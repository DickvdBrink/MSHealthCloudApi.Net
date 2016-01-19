interface Swagger {
    swagger: string;
    info: SwaggerInfo;
    host: string;
    schemes: string[];
    paths: { [index: string]: SwaggerPath }; 
    definitions: { [index: string]: SwaggerSchema }; 
}

interface SwaggerInfo {
    version: string;
    title: string;
}

interface SwaggerPath {
    get: SwaggerOperation;
    put: SwaggerOperation;
    post: SwaggerOperation;
    delete: SwaggerOperation;
    options: SwaggerOperation;
    head: SwaggerOperation;
    patch: SwaggerOperation;
    parameters: any;
}

interface SwaggerOperation {
    tags: string[];
    summary: string;
    description: string;
    externalDocs: any;
    operationId: string;
    consumes: string[];
    produces: string[];
    parameters: any;
    responses: { [index: string]: SwaggerResponse };
    schemes: string[];
    deprecated: boolean;
    security: any;
}

interface SwaggerResponse {
    description: string;
    schema: SwaggerSchema;
    headers: { [index: string]: SwaggerHeaders };
    examples: any;
}

interface SwaggerSchema {
    // $ref
    format: any;
    title: string;
    description: string;
    properties: { [index: string]: SwaggerProperty };
    // TODO Lots of items here
}

interface SwaggerHeaders {
    description: string;
    type: string;
    format: string;
    items: any;
    collectionFormat: string;
    default: any;
    // TODO: Lots of items here
}

interface SwaggerProperty {
    type: string;
    format: string;
    description: string;
}