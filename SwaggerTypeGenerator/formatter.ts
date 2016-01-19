export default class Formatter {
    private buffer: string[] = [];
    private level: number = 0;
    private newline: string;

    constructor() {
        this.newline = "\r\n";
    }

    public indent() {
        this.level++;
    }

    public unindent() {
        this.level--;
    }

    public writeIndent() {
        this.buffer.push(this.createIndentString());
    }

    public writeNewline() {
        this.buffer.push(this.newline);
    }

    public write(str: string) {
        this.buffer.push(str);
    }

    public writeline(str: string) {
        this.buffer.push(`${this.createIndentString()}${str}${this.newline}`);
    }

    private createIndentString(level?: number) {
        level = typeof level === "undefined" ? this.level : level;
        return Array((level * 4) + 1).join(" ")
    }

    public toString() {
        return this.buffer.join("");
    }
}
