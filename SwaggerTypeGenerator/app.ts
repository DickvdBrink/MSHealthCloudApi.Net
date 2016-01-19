﻿import * as fs from "fs";
import Formatter from "./formatter";

const cloudApiContent = fs.readFileSync("api/cloudapi.json", "utf-8");
const cloudApi: Swagger = JSON.parse(cloudApiContent);

const namespace = "MSHealthCloudApi.Net.Model";

console.log("Generating types for: " + cloudApi.info.title);

const keys = Object.keys(cloudApi.definitions);
for (const key of keys) {
    if (key == "Object") continue;

    const definition = cloudApi.definitions[key];
    const classTemlate = `using System;

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
    fs.writeFileSync(`../MSHealthCloudApi.Net/Model/${key}.cs`, classTemlate);
}

function createProperties(definition: SwaggerSchema) {
    const keys = Object.keys(definition.properties);
    let result = "";
    for (const key of keys) {
        const property = definition.properties[key];
        if (property.description) {
            result += `/// <summary>
        /// ${formatDescription(property.description, Array(8 + 1).join(" "))}
        /// </summary>
        `;
        }
        result += `public ${dataTypeToCSharp(property)} ${key} { get; set; }\n`;
        result += "        ";
    }
    return result;
}

function dataTypeToCSharp(property: SwaggerProperty) {
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
    if (property.type == "array") {
        const ref = <string>property["items"]["$ref"];
        return ref.substring(ref.lastIndexOf('/') + 1);
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