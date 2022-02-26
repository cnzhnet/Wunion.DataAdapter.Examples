using System;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.CommandBuilders;

namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    /// <summary>
    /// 表示资源的语言环境实体.
    /// </summary>
    public class ResourceLocale : WriteDateTime
    {
        /// <summary>
        /// 创建一个 <see cref="ResourceLocale"/> 的实体对象.
        /// </summary>
        public ResourceLocale()
        { }

        /// <summary>
        /// 表示区域语言的名称（例如：zh-CN 或 en-US）
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 10, NotNull = true, PrimaryKey = true)]
        public string Name { get; set; }

        /// <summary>
        /// 表示语言环境的显示名称.
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 32, NotNull = true)]
        public string DisplayName { get; set; }
    }
}
