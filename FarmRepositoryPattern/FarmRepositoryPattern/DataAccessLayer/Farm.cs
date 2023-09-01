using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRepositoryPattern.DataAccessLayer
{
    public class Farm
    {
        // Public fields to store farm information.
        public int Id;
        public string Name;
        public string Address;
        // Default constructor.
        public Farm()
        {
        }
        // Parameterized constructor.
        public Farm(int id, string name, string address)
        {
            // This constructor takes three parameters to initialize the fields
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
