using System;
using System.Collections.Generic;
using Wunion.DataAdapter.Kernel.CommandBuilders;
using Wunion.DataAdapter.Kernel.CodeFirst;
using Wunion.DataAdapter.Kernel.Querying;


namespace Wunion.DataAdapter.CodeFirstDemo.Data.Domain
{
    public class UserAccountDao : QueryDao
    {
        public UserAccountDao(DbContext dbc = null) : base(dbc)
        { }

        public UserAccountDao() : base(null)
        { }

        public override Type EntityType => typeof(UserAccount);

        public FieldDescription UID => GetField("UID");

        public FieldDescription Name => GetField("Name");

        public FieldDescription Password => GetField("Password");

        public FieldDescription Status => GetField("Status");

        public FieldDescription Groups => GetField("Groups");

        public FieldDescription User => GetField("User");

        public FieldDescription PhoneNumber => GetField("PhoneNumber");

        public FieldDescription Email => GetField("Email");

        public FieldDescription Creation => GetField("Creation");

        public FieldDescription LastModified => GetField("LastModified");

        protected override IDbTableContext GetTableContext(string name)
        {
            if (string.IsNullOrEmpty(name))
                return db?.TableDeclaration<UserAccount>("UserAccounts");
            return db?.TableDeclaration<UserAccount>(name);
        }

        protected override IDescription[] GetAllFields()
        {
            return new IDescription[] {
                UID,
                Name,
                Password,
                Status,
                Groups,
                User,
                PhoneNumber,
                Email,
                Creation,
                LastModified
            };
        }
    }
}
