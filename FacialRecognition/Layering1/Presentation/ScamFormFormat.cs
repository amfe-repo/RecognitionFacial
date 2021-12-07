using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layering1.Domain;

namespace Layering1.Presentation
{
    public class ScamFormFormat
    {
        private static DataHelpers dh = new DataHelpers();

        //This operation can stay in the Domain

        public static List<string> infoFormat(string enrollment) 
        {
            var list = from p in dh.ShowData() where p.Enrollment == enrollment select p;

            List<string> formats = new List<string>();

            foreach (var format in list) 
            {
                formats.Add(format.NameUser.ToString());
                formats.Add(format.Age.ToString());
                formats.Add(format.Enrollment.ToString());
                formats.Add(format.FirstDose.ToString());
                formats.Add(format.SecondDose.ToString());
                formats.Add(format.Vaccinated.ToString());
            }

            return formats;
            
        }

    }
}
