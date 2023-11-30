﻿using System;
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
        Project,
        Functionality,
        Test,
        Result,
        User
    }
    class Controller
    {
        public static Object AddNew(Object obj, DataObjectType type)
        {
            GatewayConstructor gateway = new GatewayConstructor(type);

            gateway.Insert(obj);

            return obj;

        }
        public static List<Object> Listaa(DataObjectType type)
        {
            GatewayConstructor gateway = new GatewayConstructor(type);
            return gateway.SelectAll();

        }
        public static Object Listaa(int id, DataObjectType type)
        {
          GatewayConstructor gateway = new GatewayConstructor(type);
          return gateway.SelectAll(id);

        }

        //public static List<Project> Listaa()
        //{
        //    //Projektien listaus
        //    ProjectGateway progeWay = new ProjectGateway();
        //    List<Project> allTheStuff = progeWay.SelectAll();
        //    return allTheStuff;
        //}

    }
}
