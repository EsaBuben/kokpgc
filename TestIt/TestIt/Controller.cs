using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    class Controller
    {
        public static Project Kutsu(string text)
        {
            //Projektin lisäys tietokantaan
            Project proge = new Project(text);
            ProjectGateway progeWay = new ProjectGateway();
            progeWay.Insert(proge);
            return proge;
        }
        //public static Functionality funkyKutsu(Project proge, string nimi, string given, string when, string then)
        //{
            
        //}
        public static List<Project> Listaa()
        {
            //Projektien listaus
            ProjectGateway progeWay = new ProjectGateway();
            List<Project> allTheStuff = progeWay.SelectAll();
            return allTheStuff;
        }
    }
}
