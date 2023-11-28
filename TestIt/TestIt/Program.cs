using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIt
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Viewer viewer = new Viewer();
            Application.Run(viewer);
            //Project proge = new Project("Testi");
            //Controller.AddNew(proge, DataObjectType.Project);
            //Functionality funktio = new Functionality(proge, "Testi");
            //Controller.AddNew(funktio, DataObjectType.Functionality);

        }
    }
}
