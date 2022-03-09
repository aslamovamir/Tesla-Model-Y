using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_Programming_Challenge
{
    class Model_Y: Model_E
    {
        //attribute of a range of 350 miles
        protected string range_350;

        //Get method
        public string Get_Range()
        {
            return this.range_350;
        }

        //Set method
        public void Set_Range(string range)
        {
            this.range_350 = range;
        }
    }
}
