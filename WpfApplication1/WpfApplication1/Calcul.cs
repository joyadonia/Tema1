using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Calcul
    {
       public  float calculMedieTotala(Situatie situatie)
        {
           
            
            return 0;
        }
      public  float calculNotaFinala(Nota nota,int procent)
        {
            return ((nota.Activitate*procent)+nota.Evaluare)/2;
        }
    }
}
