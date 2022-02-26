using System;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.CommandBuilders;

namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    /// <summary>
    /// 文档内容实体.
    /// </summary>
    public class Documentation : WriteDateTime
    {
        /// <summary>
        /// 创建一个 <see cref="Documentation"/> 的对象实例.
        /// </summary>
        public Documentation()
        { }

        /// <summary>
        /// 表示文档 ID.
        /// </summary>
        [Identity(0, 1)]
        [TableField(DbType = GenericDbType.Int, NotNull = true, PrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// 所属目录.
        /// </summary>
        [ForeignKey(TableName = "DocumentCatalogs", Field = "Id")]
        [TableField(DbType = GenericDbType.Int, NotNull = true)]
        public int Catalog { get; set; }

        /// <summary>
        /// 该文章的语言环境.
        /// </summary>
        [ForeignKey(TableName = "ResourceLocales", Field = "Name")]
        [TableField(DbType = GenericDbType.VarChar, Size = 10, NotNull = true)]
        public string Locale { get; set; }

        /// <summary>
        /// 该文章的搜索标签.
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 255)]
        public string Tags { get; set; }

        /// <summary>
        /// 文章内容.
        /// </summary>
        [TableField(DbType = GenericDbType.Text)]
        public string Content { get; set; }
    }
}
