using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transcripter.BuisnessLogic
{
    public class Buisness
    {
        private string Fname;
        private string SecondName;

        public string fname
        {

            set { Fname = value; }
            get { return Fname; }


        }

        public string secondName
        { set { SecondName = value; }
            get { return SecondName; }

        }
    }
  }
