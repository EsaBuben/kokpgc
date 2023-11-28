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
            //Application.Run(new Viewer());

            //Functionality funkka = new Functionality("Sallasilaatti", proge.ProjectID);
            //////progeGate.Delete(7);
            //////progeGate.Delete(8);
            Project proge = new Project("Sillisalaatti");
            //Project proge2 = new Project("Sillisalaatti2");  
            Controller.AddNew(proge, DataObjectType.Project);
            //progeGate.Insert(proge2);
            //List<Project> progeList = Controller.SelectAll();
            //for (int i = 0; i < progeList.Count; i++)
            //{
            //    Console.WriteLine(progeList[i]);
            //}

            ////Test test = new Test(10, "testi", 0, 1);
            ////TestGateway testgateway = new TestGateway();
            ////testgateway.Insert(test);
            ////List<Test> testlist = testgateway.SelectAll();
            ////foreach (Test t in testlist )
            ////{
            ////    Console.WriteLine(t.ToString());
            ////}

            Console.ReadLine();
        }
    }
}
