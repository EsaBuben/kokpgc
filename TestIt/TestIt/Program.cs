using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Project proge = new Project("Sillisalaatti");
            ProjectGateway progeGate = new ProjectGateway();
            //progeGate.Insert(proge);
            progeGate.Delete(1);
            progeGate.Delete(2);
            List<Project> progeList = progeGate.ShowAll();
            for (int i = 0; i < progeList.Count; i++)
            {
                Console.WriteLine(progeList[i]);
            }

            Console.ReadLine();
        }
    }
}
