using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_Programming_Challenge
{
    class Model_S
    {
        // protected attribute of wiper container
        protected string two_gallon_windshield_container;

        //get method
        public string Get_Container()
        {
            return this.two_gallon_windshield_container;
        }

        //set method
        public void Set_Container(string container)
        {
            this.two_gallon_windshield_container = container;
        }
    }
}
