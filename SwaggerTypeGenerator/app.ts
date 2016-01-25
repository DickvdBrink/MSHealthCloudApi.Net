﻿import * as fs from "fs";
import Formatter from "./formatter";

const config = JSON.parse(fs.readFileSync("config.json", "utf-8"));
const content = fs.readFileSync(config.input, "utf-8");
const api: Swagger = JSON.parse(content);

const namespace = config.namespace;
const enumTypes: { [index: string]: { items: string[] } } = {};

console.log("Generating types for: " + api.info.title);

const keys = Object.keys(api.definitions);
for (const key of keys) {
    if (key == "Object") continue;

    const definition = api.definitions[key];
    const classTemlate = `// This file is automatically generated
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ${namespace}
{
    /// <summary>
    /// ${formatDescription(definition.description, Array(4 + 1).join(" "))}
    /// </summary>
    public class ${key}
    {
${createProperties(definition)}
    }
}`;
    fs.writeFileSync(`${config.outputFolder}/${key}.cs`, classTemlate);
}

const enumkeys = Object.keys(enumTypes);
for (const key of enumkeys) {
    const definition = enumTypes[key];
    const classTemlate = `// This file is automatically generated
using System;

namespace ${namespace}
{
    public enum ${FormatName(key)}
    {
        ${definition.items.join(",\n        ")}
    }
}`;
    fs.writeFileSync(`${config.outputFolder}/${FormatName(key)}.cs`, classTemlate);
}

function createProperties(definition: SwaggerSchema) {
    const keys = Object.keys(definition.properties);
    let result = "";
    for (const key of keys) {
        const property = definition.properties[key];
        if (property.description) {
            result += `        /// <summary>
        /// ${formatDescription(property.description, Array(8 + 1).join(" "))}
        /// </summary>\n`;
        }

        result += `        [JsonPropertyAttribute("${key}")]\n`;
        result += `        public ${dataTypeToCSharp(property, key)} ${FormatName(key)} { get; set; }\n`;
    }
    return result;
}

function dataTypeToCSharp(property: SwaggerProperty, key: string) {
    const map: { [index: string]: string | { [index: string]: string } } = {
        'integer': {
            'int32': 'int',
            'int64': 'long'
        },
        'number': {
            'float': 'float',
            'double': 'double'
        },
        'string': {
            'byte': 'byte[]',
            'binary': 'byte[]',
            'date': 'DateTime',
            'date-time': 'DateTime',
            'password': 'string',
        },
        'boolean': 'bool'
    };
    if ((<any>property).enum) {
        enumTypes[key] = { items: (<any>property).enum };
        return FormatName(key);
    }
    if (property.type == "array") {
        const ref = <string>property["items"]["$ref"];
        const name = ref.substring(ref.lastIndexOf('/') + 1)
        return `List<${name}>`;
    }
    const result = map[property.type];
    if (typeof result === "string") {
        return result;
    } else if (result && property.format && result[property.format]) {
        return result[property.format];
    } else {
        return 'string';
    }
}

function formatDescription(description: string, indent: string) {
    if (description) {
        return description.replace(/(\r\n|\n|\r)[ ]*/g, "$1" + indent + "/// ");
    }
    return "";
}

function FormatName(name: string) {
    return name.replace(/^./, (str) => str.toUpperCase());
}