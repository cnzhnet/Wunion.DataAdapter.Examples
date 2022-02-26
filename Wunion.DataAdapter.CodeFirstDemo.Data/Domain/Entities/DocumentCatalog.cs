using System;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.CommandBuilders;

namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    /// <summary>
    /// 文档目录实体.
    /// </summary>
    public class DocumentCatalog : WriteDateTime
    {
        /// <summary>
        /// 创建一个 <see cref="DocumentCatalog"/> 的对象实例.
        /// </summary>
        public DocumentCatalog()
        { }
        
        /// <summary>
        /// 目标 ID.
        /// </summary>
        [Identity(0, 1)]
        [TableField(DbType = GenericDbType.Int, NotNull = true, PrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// 目录名称.
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 255, NotNull = true)]
        public string Name { get; set; }

        /// <summary>
        /// 语言环境
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 10, NotNull = true)]
        public string Locale { get; set; }

        /// <summary>
        /// 所属类型.
        /// </summary>
        [ForeignKey(TableName = "GeneralCategories", Field = "Id")]
        [TableField(DbType = GenericDbType.Int, NotNull = true)]
        public int Category { get; set; }

        /// <summary>
        /// 父级目录.
        /// </summary>
        [TableField(DbType = GenericDbType.Int)]
        public int? Parent { get; set; }
    }
}
