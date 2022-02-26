/** layui 标准模块接口成员声明. */
export interface IModuleBase {
    /** 全局项. */
    config: any;
    /** 索引. */
    index: number;
    /** 设置全局项.
     * @param options 全局项. */
    set(options: Object): any;
    /** 事件监听.
     * @param events 事件描述信息.
     * @param callback 回调函数. */
    on(events: string, callback: Function): any;
}
/** layui 配置数据接口声明. */
export interface LayuiConfiguration {
    /** 记录模块物理路径. */
    modules: any;
    /** 记录模块加载状态. */
    status: any;
    /** 符合规范的模块请求最长等待秒数. */
    timeout: number;
    /** 记录模块自定义事件 */
    event: any;
}