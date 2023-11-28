using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    enum DataObjectType{
      Project,
      Funktionality,
      Test
    }
    class Controller
    {
        public static Object Kutsu(Object obj,DataObjectType type)
        {
            //Projektin lisäys tietokantaan
            // Project proge = new Project(text);
            // ProjectGateway progeWay = new ProjectGateway();
            // progeWay.Insert(proge);
            // return proge;
            IGateway igate;
            switch(type)
            {
              case DataObjectType.Test:
                igate = new TestGateway();
                igate.Insert(obj);
              break;
              default:
              break;
            }

            return obj;


        }
        public static List<Project> Listaa()
        {
            //Projektien listaus
            ProjectGateway progeWay = new ProjectGateway();
            List<Project> allTheStuff = progeWay.SelectAll();
            return allTheStuff;
        }

    }
}
