using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRepositoryPattern.DataAccessLayer
{
    // This class "FarmRepository" implements the interface "IFarmRepository"
    public class FarmRepository : IFarmRepository
    {
        // A list to store farm objects with initial data.
        List<Farm> listFarm = new List<Farm>()
        {
            new Farm(1, "Brac SEEDS", "Dhaka"),
            new Farm(2, "GLOBAL AGRO", "Dhaka"),
            new Farm(3, "ACI SEEDS", "Dhaka"),
            new Farm(4, "URO Agrovet", " Khulna"),
            new Farm(5, "Paragon Agro", "Sylhet")
        };
        // Retrieve and return a sorted list by their names.
        public List<Farm> Get()
        {
            return listFarm.OrderBy(x => x.Name).ToList();
        }
        // Retrieve and return a specific farm based on ID.
        public Farm Get(int id)
        {
            Farm oFarm = listFarm.Where(x => x.Id == id).FirstOrDefault();
            return oFarm;
        }
        // Add a new farm to the repository.
        public bool Add(Farm model)
        {
            listFarm.Add(model);
            return true;
        }
        // Update an existing farm in the repository.
        public bool Update(Farm model)
        {
            bool isExecuted = false;
            Farm oCustomer = listFarm.Where(x => x.Id == model.Id).FirstOrDefault();
            if (oCustomer != null)
            {
                listFarm.Remove(oCustomer);
                listFarm.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        // Delete a farm from the repository based on ID.
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Farm oFarm = listFarm.Where(x => x.Id == id).FirstOrDefault();
            if (oFarm != null)
            {
                listFarm.Remove(oFarm);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
