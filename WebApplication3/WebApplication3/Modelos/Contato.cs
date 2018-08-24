using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Modelos
{
    [Serializable]
    public class Contato
    {

        public int id { get; set; }

        public String nome { get; set; }

        public String fone
        {
            get;
            set
            {
                if (value.Equals("") || value.Equals(null))
                {
                    fone = "---";
                }
                else
                {
                    fone = value;
                }
            }
        }

        public String email
        {
            get;
            set
            {
                if (value.Equals("") || value.Equals(null))
                {
                    email = "---";
                }
                else
                {
                    email = value;
                }
            }
        }



    }
}
