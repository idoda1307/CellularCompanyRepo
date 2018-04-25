using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DAL.Models;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace DAL
{
    public class Initializer
    {


        public static List<PackageIncludesEntity> InitializePackageIncludes()
        {
            using (var db = new CellularCompanyContext())
            {
               db.PackageIncludes.AddOrUpdate(p => p.PackageId,
                    new PackageIncludesEntity()
                    {
                        FixedPrice = 100,
                        MaxMinute = 200
                    },
                    new PackageIncludesEntity()
                    {
                        FixedPrice = 160,
                        MaxMinute = 400
                    },
                    new PackageIncludesEntity()
                    {
                        DiscountPrecentage = 50,
                        FixedPrice = 9.9
                    },
                    new PackageIncludesEntity()
                    {
                        InsideFamilyCalls = true
                    });
                db.SaveChanges();
                return db.PackageIncludes.ToList();
            }
        }
    }
}
