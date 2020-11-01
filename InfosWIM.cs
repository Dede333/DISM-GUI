using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISM_GUI
{
    class InfosWIM
    {
        int Index_Wim;                          // mémorise l'index du WIM
        string Nom_Wim;                         // mémorise le nom du WIM
        string Description_Wim;                 // mémorise la description du WIM  
        ulong Taille_Wim;                       // mémorise la taille du WIM

        public int Index                        
        {
            get { return Index_Wim; }
            set { Index_Wim = value; }
        }

        public string Nom
        {
            get { return Nom_Wim; }
            set { Nom_Wim = value; }
        }

        public string Description
        {
            get { return Description_Wim; }
            set { Description_Wim = value; }
        }

        public ulong Taille
        {
            get { return (ulong)Taille_Wim; }
            set { Taille_Wim = (ulong)value; }
        }
    }
}
