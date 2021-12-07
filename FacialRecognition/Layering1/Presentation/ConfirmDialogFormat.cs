using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layering1.Presentation
{
    public class ConfirmDialogFormat
    {
        public static string textDialog(string state) 
        {
            if(state == "error") 
            {
                return "Ha ocurrido un error\ninesperado";
            }
            else if (state == "delete") 
            {
                return "Se ha eliminado\nsatisfactoriamente";
            }
            else 
            {
                return "Se ha registrado\nsatisfactoriamente";
            }
        }
        public static string imgDialog(string state) 
        {
            if (state == "error")
            {
                return "src\\ErrorLogo.png";
            }
            else if (state == "delete")
            {
                return "src\\deleteLogo4.png";
            }
            else
            {
                return "src\\confirmLogo.png";
            }
        }
    }
}
