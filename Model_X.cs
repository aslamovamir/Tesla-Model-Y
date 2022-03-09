using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_Programming_Challenge
{
    class Model_X : Model_S
    {
        //attribute of two spare tires
        protected string two_spare_tires;

        //set method
        public void Set_Tires(string tires)
        {
            this.two_spare_tires = tires;
        }

        //get method
        public string Get_Tires()
        {
            return this.two_spare_tires;
        }
    }
}
