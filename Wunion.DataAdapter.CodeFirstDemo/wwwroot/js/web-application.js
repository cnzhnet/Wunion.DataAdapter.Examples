class WebApplication {
    constructor() {
        $(document).ready(() => this.init());
    }
    init() {
        layer.alert("弹出来了！");
        this.editor = new Quill("#my-editor", {
            modules: {
                toolbar: [
                    ['bold', 'italic', 'underline', 'strike'],
                    ['blockquote', 'code-block'],
                    [{ 'header': 1 }, { 'header': 2 }],
                    [{ 'list': 'ordered' }, { 'list': 'bullet' }],
                    [{ 'script': 'sub' }, { 'script': 'super' }],
                    [{ 'indent': '-1' }, { 'indent': '+1' }],
                    [{ 'direction': 'rtl' }],
                    [{ 'size': ['small', false, 'large', 'huge'] }],
                    [{ 'header': [1, 2, 3, 4, 5, 6, false] }],
                    [{ 'color': [] }, { 'background': [] }],
                    [{ 'font': ['Serif', 'Monospace', 'SimSun', 'SimHei', 'Microsoft-YaHei', 'Microsoft-JhengHei', 'NSimSun', 'LiSu', 'YouYuan'] }],
                    [{ 'align': [] }],
                    ['clean'],
                    ['image', 'video']
                ]
            },
            placeholder: "请输入内容.",
            theme: "snow"
        });
    }
    setActiveModuleView(module) {
        this.moduleView = module;
    }
    getActiveModuleView() {
        return this.moduleView;
    }
}
if (!window.mainApp)
    window.mainApp = new WebApplication();
//# sourceMappingURL=web-application.js.map