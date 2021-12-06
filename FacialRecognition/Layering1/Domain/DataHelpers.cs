using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layering1.Integration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Layering1.Domain
{
    public class DataHelpers
    {
        public List<MostrarDatos_Result> ShowData() 
        {
            using (UserEntities dbContext = new UserEntities()) 
            {
                var dh = dbContext.MostrarDatos().ToList();

                return dh;
            }
        }

        public void InsertData(string fullName, int age, string enrollment, string firstDose, string secondDose, bool vaccinated, bool roleUser)
        {
            using (UserEntities dbContext = new UserEntities())
            {
                try 
                {
                    dbContext.InsertarDatos(fullName, age, enrollment, firstDose, secondDose, vaccinated, roleUser);
                    dbContext.SaveChanges();
                }
                catch (Exception e) 
                {
                    throw new Exception("Ha ocurrido un error "+ e.Message);
                }
                
            }
        }

        public void UpdateData(string fullName, int age, string enrollment, string firstDose, string secondDose, bool vaccinated, bool roleUser, int idUser)
        {
            using (UserEntities dbContext = new UserEntities())
            {
                try
                {
                    dbContext.EditarDatos(fullName, age, enrollment, firstDose, secondDose, vaccinated, roleUser, idUser);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Ha ocurrido un error " + e.Message);
                }

            }
        }

        public void DeleteData(int idUser)
        {
            using (UserEntities dbContext = new UserEntities())
            {
                try
                {
                    dbContext.EliminarDatos(idUser);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Ha ocurrido un error " + e.Message);
                }

            }
        }
    }
}
