/// <reference path="app.core.types.d.ts" />
/// <reference path="types/layui/index.d.ts" />
/// <reference path="types/quill/index.d.ts" />


class WebApplication implements IApplication {
    private moduleView: IModuleView;
    private editor: Quill;

    constructor() {
        $(document).ready(() => this.init());
    }

    private init(): void {
        layer.alert("弹出来了！");
        this.editor = new Quill("#my-editor", {
            modules: {
                toolbar: [
                    ['bold', 'italic', 'underline', 'strike'],        // toggled buttons
                    ['blockquote', 'code-block'],
                    [{ 'header': 1 }, { 'header': 2 }],               // custom button values
                    [{ 'list': 'ordered' }, { 'list': 'bullet' }],
                    [{ 'script': 'sub' }, { 'script': 'super' }],      // superscript/subscript
                    [{ 'indent': '-1' }, { 'indent': '+1' }],          // outdent/indent
                    [{ 'direction': 'rtl' }],                         // text direction
                    [{ 'size': ['small', false, 'large', 'huge'] }],  // custom dropdown
                    [{ 'header': [1, 2, 3, 4, 5, 6, false] }],
                    [{ 'color': [] }, { 'background': [] }],          // dropdown with defaults from theme
                    [{ 'font': ['Serif', 'Monospace', 'SimSun', 'SimHei', 'Microsoft-YaHei', 'Microsoft-JhengHei', 'NSimSun', 'LiSu', 'YouYuan'] }],
                    [{ 'align': [] }],
                    ['clean'],                                         // remove formatting button
                    ['image', 'video']
                ]
            },
            placeholder: "请输入内容.",
            theme: "snow"
        });
    }

    setActiveModuleView(module: IModuleView): void {
        this.moduleView = module;
    }
    getActiveModuleView(): IModuleView {
        return this.moduleView;
    }
}

if (!window.mainApp)
    window.mainApp = new WebApplication();