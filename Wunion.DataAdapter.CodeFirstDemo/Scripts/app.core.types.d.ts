/** 模块视图接口. */
interface IModuleView {
    init(): void;
}

/** 应用程序接口. */
interface IApplication {
    setActiveModuleView(module: IModuleView): void;
    getActiveModuleView(): IModuleView;
}

//declare global {
//    interface Window {
//        mainApp: IApplication;
//    }
//}

interface Window {
        mainApp: IApplication;
}