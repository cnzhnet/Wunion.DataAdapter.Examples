using System;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.CommandBuilders;

namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    /// <summary>
    /// 通用分类实体.
    /// </summary>
    public class GeneralCategory : WriteDateTime
    {
        /// <summary>
        /// 创建一个 <see cref="GeneralCategory"/> 的对象实例.
        /// </summary>
        public GeneralCategory()
        { }

        /// <summary>
        /// 分类的ID.
        /// </summary>
        [Identity(0, 1)]
        [TableField(DbType = GenericDbType.Int, NotNull = true, PrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// 分类的名称.
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 255, NotNull = true, Unique = true)]
        public string Name { get; set; }

        /// <summary>
        /// 分类的说明.
        /// </summary>
        [TableField(DbType = GenericDbType.VarChar, Size = 400)]
        public string Description { get; set; }
    }
}
