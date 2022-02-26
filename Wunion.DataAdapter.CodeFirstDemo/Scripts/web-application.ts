/// <reference path="app.core.types.d.ts" />
/// <reference path="types/layui/index.d.ts" />


class WebApplication implements IApplication {
    private moduleView: IModuleView;

    constructor() {
        $(document).ready(() => this.init());
    }

    private init(): void {
        layer.alert("弹出来了！");
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