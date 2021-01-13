using ApiFipe.Domain.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFipe.Infra.Repository
{
    public class FipeRepository : FipeInterface
    {

        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public bool Add(Fipe fipe)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int rowsAffected = db.Execute(@"INSERT Fipe([Marca],[Modelo],[Ano],[Preco],[Codigo]) values (@Marca, @Modelo, @Ano, @Preco,@Codigo)",
                new
                {
                    Marca = fipe.Marca,
                    Modelo = fipe.Modelo,
                    Ano = fipe.Ano,
                    Preco = fipe.Preco,            
                    Codigo = fipe.Codigo
                });
                if (rowsAffected > 0)
                {
                    return true;
                }

                return false;
            }

        }

        public bool Delete(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int rowsAffected = db.Execute(@"DELETE FROM [Fipe] WHERE Id = @Id",
                new { Id = Id });

                if (rowsAffected > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public bool Edit(Fipe fipe)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int rowsAffected = db.Execute(
                     "UPDATE [Fipe] SET [Marca] = @Marca ,[Modelo] = @Modelo, [Ano] = @Ano,[Preco] = @Preco,[PrecoVenda] = @PrecoVenda,[Codigo]=Codigo WHERE Id = " +
                     fipe.Id, fipe);

                if (rowsAffected > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public Fipe Get(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                return db.Query<Fipe>("SELECT * FROM [FIPE] WHERE Id = @id", new { Id = Id }).SingleOrDefault();
            }
        }

        public List<Fipe> GetPorAno(string Ano)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string term = "%" + Ano + "%";
                var query = $@"SELECT * FROM FIPE WHERE Ano LIKE '{term}'";
                var a = db.Query<Fipe>(query).ToList();
                return a;
            }
        }

        public List<Fipe> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Fipe>(@"SELECT * FROM FIPE").ToList();
            }
        }
    }
}
