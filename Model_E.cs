using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_Programming_Challenge
{
    class Model_E: Model_X
    {
        //attribute for five seetings for air system
        protected string five_settings_air_system;

        //get method
        public string Get_Settings()
        {
            return this.five_settings_air_system;
        }

        //set method
        public void Set_Settings(string settings)
        {
            this.five_settings_air_system = settings;
        }
    }
}
