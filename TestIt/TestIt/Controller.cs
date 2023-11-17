using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace TestIt
{
    class Controller
    {
        public static void Kutsu(string text)
        {
            //Projektin lisäys tietokantaan
            Project proge = new Project(text);
            ProjectGateway progeWay = new ProjectGateway();
            progeWay.Insert(proge);
        }
    }
}
