using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiteApp
{
    class loginJSON
    {

        private static loginJSON instance = null;
        private loginJSON()
        {

        }
        public static loginJSON Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new loginJSON();
                }
                return instance;
            }
        }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Surname { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
    }
}
