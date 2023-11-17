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
            Application.Run(new Viewer());
            //////Project proge = new Project("Sillisalaatti");
            ////ProjectGateway progeGate = new ProjectGateway();
            ////progeGate.Insert(proge);
            //////progeGate.Delete(7);
            //////progeGate.Delete(8);
            ////List<Project> progeList = progeGate.SelectAll();
            ////for (int i = 0; i < progeList.Count; i++)
            ////{
            ////    Console.WriteLine(progeList[i]);
            ////}

            ////Console.ReadLine();
        }
    }
}
