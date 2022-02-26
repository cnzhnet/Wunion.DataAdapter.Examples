using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class ResourceLocaleDao : QueryDao
    {
        public ResourceLocaleDao(DbContext dbc = null) : base(dbc)
        { }

        public ResourceLocaleDao() : base(null)
        { }

        public override Type EntityType => typeof(ResourceLocale);

        public FieldDescription Name => GetField("Name");

        public FieldDescription DisplayName => GetField("DisplayName");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<ResourceLocale>("ResourceLocales");
            return db?.TableDeclaration<ResourceLocale>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                Name,
                DisplayName,
                Creation,
                LastModified
            };
        }
    }
}
