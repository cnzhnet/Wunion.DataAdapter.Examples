/// <reference path="quill.options.d.ts" />

type Delta = any;

interface Quill {
    deleteText(index: Number, length: Number, source?: string): Delta;
    getContents(index?: Number, length?: Number): Delta;
    getLength(): Number;
    getText(index?: Number, length?: Number): string;
    insertEmbed(index: Number, type: string, value: any, source?: string): Delta;
    insertText(index: Number, text: string, source?: string): Delta;
    insertText(index: Number, text: string, format: string, value: any, source?: string): Delta;
    insertText(index: Number, text: string, formats: any , source?: String): Delta;
    setContents(delta: Delta, source?: String): Delta;
    setText(text: String, source?: String): Delta;
    updateContents(delta: Delta, source?: String): Delta;
    format(name: String, value: any, source?: String): Delta;
    formatLine(index: Number, length: Number, source?: String): Delta;
    formatLine(index: Number, length: Number, format: String, value: any, source?: String): Delta;
    formatLine(index: Number, length: Number, formats: any, source?: String): Delta;
    formatText(index: Number, length: Number, source?: String): Delta;
    formatText(index: Number, length: Number, format: String, value: any, source?: String): Delta;
    formatText(index: Number, length: Number, formats: any, source?: String): Delta;
    getFormat(range?: IRange): any;
    getFormat(index: Number, length?: Number): any;
    removeFormat(index: Number, length: Number, source?: String): Delta;
    getSelection(focus?: Boolean): IRange;
    setSelection(index: Number, length?: Number, source?: String);
    setSelection(range: IRange, source?: String);
    blur(): void;
    enable(enabled?: boolean): void;
    focus(): void;
    hasFocus(): Boolean;
    /**
     * @param source user, api, silent */
    update(source?: String);
    on(name: String, handler: Function): Quill;
}

interface IRange {
    index: Number;
    length: Number;
}

declare var Quill: {
    prototype: Quill;
    new(container: HTMLElement | string, options: IQuillOptions);
};