using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRepositoryPattern.DataAccessLayer
{
    // Class that implement this interface
    public interface IFarmRepository
    {
        List<Farm> Get();
        Farm Get(int id);
        bool Add(Farm model);
        bool Update(Farm model);
        bool Delete(int id);
    }
}
