using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    public class Test
    {
      private int testID;
      private int refFunctionalityID;
      private string name;
      //private Status status;
      private int priority;
      //private string instructions;
      private int resp_user_id;
      //private Result result;
      public Test(){
        this.name = "No name was given";
        this.priority = -1;
      }

      public Test(string name, int refFunctionalityID):base(){
        this.name = name;
        this.refFunctionalityID = refFunctionalityID;
      }

      public Test(string name, int priority,  int refFunctionalityID){
        this.name = name;
        this.priority = priority;
        this.refFunctionalityID = refFunctionalityID;
      }

      public Test(int testid, string name, int priority,  int refFunctionalityID){
        this.testID = testid;
        this.name = name;
        this.priority = priority;
        this.refFunctionalityID = refFunctionalityID;
      }

      public int Id{
        get{return this.testID;}
        set{this.testID = value;}
      }

      public int ref_func_id{
        get{return this.refFunctionalityID;}
        set{this.refFunctionalityID = value;}
      }


      public string Name{
        get{return this.name;}
        set{this.name = value;}
      }

      public int Priority{
        get{return this.priority;}
        set{this.priority = value;}
      }

      public int Responsible_user_id{
        get{return this.resp_user_id;}
        set{this.resp_user_id = value;}
      }

      public override string ToString(){
        return $"{this.testID}: {this.name}";
      }

    }

}
