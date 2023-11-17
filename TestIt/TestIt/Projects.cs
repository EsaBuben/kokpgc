using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    class Projects
    {
        private string projectName;
        Functionality[] funk;

        public Projects(string projectName)
        {
            this.projectName = projectName;
            funk = new Functionality[10];
        }


    }
}
