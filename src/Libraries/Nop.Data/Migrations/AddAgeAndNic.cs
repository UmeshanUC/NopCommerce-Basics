using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;

namespace Nop.Data.Migrations
{
    [NopMigration("2022/01/01 12:00:00:0000000", "Customer.Add Age and NIC", UpdateMigrationType.Data,
        MigrationProcessType.Update)]
    public class AddAgeAndNic : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Column(nameof(Customer.Age))
                .OnTable(nameof(Customer))
                .AsInt16()
                .Nullable();
            
            Create.Column(nameof(Customer.Nic))
                .OnTable(nameof(Customer))
                .AsString(255)
                .Nullable();
        }
    }
}
