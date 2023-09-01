using FarmRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRepositoryPattern.BusinessLayer
{
    public class FarmBusiness
    {
        IFarmRepository _repository;
        // Constructor that takes an IFarmRepository instance as a parameter.
        public FarmBusiness(IFarmRepository repository)
        {
            _repository = repository;
        }

        // Retrieve and return a list of farms by Get method
        public List<Farm> Get()
        {
            return _repository.Get();
        }

        // Retrieve and return a specific farm based ID using Get method
        public Farm Get(int id)
        {
            return _repository.Get(id);
        }

        // Add a new farm using the Add method
        public bool Add(Farm model)
        {
            return _repository.Add(model);
        }

        // Update an existing farm using the Update method
        public bool Update(Farm model)
        {
            return _repository.Update(model);
        }

        // Delete a farm based on ID using the Delete method
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
