using ApiFipe.Domain.Model;
using ApiFipe.Infra.Repository;
using ApiFipe.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFipe.Service.Service
{
    public class FipeService : IFipeService
    {
        FipeRepository rep = new FipeRepository();

        public void Add(Fipe Entity)
        {
            try
            {
               rep.Add(Entity);
            }
            catch (Exception)
            {
                throw new ArgumentException("Ocorreu um erro!");
          
            }
           
        }

        public void Delete(int Id)
        {
            try
            {
                rep.Delete(Id);
            }
            catch (Exception)
            {
                throw new ArgumentException("Ocorreu um erro!");
            }
           
        }

        public Fipe Get(int Id)
        {
            try
            {
                return rep.Get(Id);
            }
            catch (Exception)
            {

                throw new ArgumentException("Ocorreu um erro!");
            }
          
        }

        public List<Fipe> List()
        {
            try
            {
                return rep.GetAll();
            }
            catch (Exception)
            {
                throw new ArgumentException("Ocorreu um erro!");
            }
           
        }

        public void Update(Fipe Entity)
        {
            try
            {
                rep.Edit(Entity);
            }
            catch (Exception)
            {
                throw new ArgumentException("Ocorreu um erro!");
            }
           
        }

        public List<Fipe> BuscarPorAno(string Ano)
        {
            try
            {
                return rep.GetPorAno(Ano);
            }
            catch (Exception)
            {

                throw new ArgumentException("Ocorreu um erro!");
            }

        }
    }
}
