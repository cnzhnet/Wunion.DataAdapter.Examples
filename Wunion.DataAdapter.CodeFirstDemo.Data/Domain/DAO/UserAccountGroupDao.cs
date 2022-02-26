using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class UserAccountGroupDao : QueryDao
    {
        public UserAccountGroupDao(DbContext dbc = null) : base(dbc)
        { }

        public UserAccountGroupDao() : base(null)
        { }

        public override Type EntityType => typeof(UserAccountGroup);

        public FieldDescription Id => GetField("Id");

        public FieldDescription Name => GetField("Name");

        public FieldDescription Description => GetField("Description");

        public FieldDescription Permissions => GetField("Permissions");

        public FieldDescription IsDeleted => GetField("IsDeleted");

        public FieldDescription DeletionDate => GetField("DeletionDate");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<UserAccountGroup>("UserAccountGroups");
            return db?.TableDeclaration<UserAccountGroup>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                Id,
                Name,
                Description,
                Permissions,
                IsDeleted,
                DeletionDate,
                Creation,
                LastModified
            };
        }
    }
}
