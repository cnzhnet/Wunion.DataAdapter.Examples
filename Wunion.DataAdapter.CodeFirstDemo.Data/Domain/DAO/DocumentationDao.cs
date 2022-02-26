using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class DocumentationDao : QueryDao
    {
        public DocumentationDao(DbContext dbc = null) : base(dbc)
        { }

        public DocumentationDao() : base(null)
        { }

        public override Type EntityType => typeof(Documentation);

        public FieldDescription Id => GetField("Id");

        public FieldDescription Catalog => GetField("Catalog");

        public FieldDescription Locale => GetField("Locale");

        public FieldDescription Tags => GetField("Tags");

        public FieldDescription Content => GetField("Content");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<Documentation>("Documentation");
            return db?.TableDeclaration<Documentation>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                Id,
                Catalog,
                Locale,
                Tags,
                Content,
                Creation,
                LastModified
            };
        }
    }
}
