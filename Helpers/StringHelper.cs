using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        //Gereksinimler
        //1. Girilen ifadenin başındaki ve sonundaki fazla boşluklar silinmelidir.
        //2. Girilen ifadenin içindeki fazla boşluklar silinmelidir.
        public static  string FazlaBosluklariSil(string ifade)
        {
            ifade = ifade.Trim();

            string yeniIfade = string.Empty;

            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ' && ifade[i+1] == ' ')
                {
                    continue;
                }

                yeniIfade += ifade[i];
            }

            return yeniIfade;
        }
    }
}
