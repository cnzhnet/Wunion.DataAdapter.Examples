using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class DocumentCatalogDao : QueryDao
    {
        public DocumentCatalogDao(DbContext dbc = null) : base(dbc)
        { }

        public DocumentCatalogDao() : base(null)
        { }

        public override Type EntityType => typeof(DocumentCatalog);

        public FieldDescription Id => GetField("Id");

        public FieldDescription Name => GetField("Name");

        public FieldDescription Locale => GetField("Locale");

        public FieldDescription Category => GetField("Category");

        public FieldDescription Parent => GetField("Parent");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<DocumentCatalog>("DocumentCatalogs");
            return db?.TableDeclaration<DocumentCatalog>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                Id,
                Name,
                Locale,
                Category,
                Parent,
                Creation,
                LastModified
            };
        }
    }
}
