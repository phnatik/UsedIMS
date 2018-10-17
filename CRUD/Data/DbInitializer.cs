using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class DbInitializer
    {
        public static void Initialize(CrudContext context)
        {
            // Creates the database if it doesnt exist
            context.Database.EnsureCreated();

            if (context.UsedInv.Any())
            {
                return;
            }

            // if it doesnt exist populate it
            var inventory = new AddUsedInventory[]
            {
                new AddUsedInventory { Year = 2015, Make="Ford", Model = "F-150", Trim = "Lariat", VIN = 12345678901234543 },
                new AddUsedInventory { Year =2012, Make="Toyota", Model = "Camry", Trim = "LS", VIN = 12345678901234543 },
                new AddUsedInventory { Year =2012, Make="BMW", Model = "i3", Trim = "3 Series", VIN = 12345678901234543 },
                new AddUsedInventory { Year =2011, Make="Volkswagen", Model = "Pasat", Trim = "P", VIN = 12345678901234543 }
            };

            foreach (AddUsedInventory i in inventory)
            {
                context.UsedInv.Add(i);
            }
            context.SaveChanges();
        }
    }
}
