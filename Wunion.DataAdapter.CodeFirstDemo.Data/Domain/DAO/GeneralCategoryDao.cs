using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class GeneralCategoryDao : QueryDao
    {
        public GeneralCategoryDao(DbContext dbc = null) : base(dbc)
        { }

        public GeneralCategoryDao() : base(null)
        { }

        public override Type EntityType => typeof(GeneralCategory);

        public FieldDescription Id => GetField("Id");

        public FieldDescription Name => GetField("Name");

        public FieldDescription Description => GetField("Description");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<GeneralCategory>("GeneralCategories");
            return db?.TableDeclaration<GeneralCategory>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                Id,
                Name,
                Description,
                Creation,
                LastModified
            };
        }
    }
}
