using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    public enum DataObjectType
    {
        Test,
        Project,
        Functionality
    }
    class Controller
    {
        public static Object AddNew(Object obj, DataObjectType type)
        {
            IGateway gateway;
            switch(type)
            {
                case DataObjectType.Project:
                    gateway = new ProjectGateway();
                    gateway.Insert(obj);
                    break;
                case DataObjectType.Test:
                    gateway = new TestGateway();
                    gateway.Insert(obj);
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
