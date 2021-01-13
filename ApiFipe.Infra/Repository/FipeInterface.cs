using ApiFipe.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFipe.Infra.Repository
{
    public interface FipeInterface
    {
        bool Add(Fipe fipe);
        List<Fipe> GetAll();
        Fipe Get(int id);
        bool Edit(Fipe fipe);
        bool Delete(int id);
    }
}
