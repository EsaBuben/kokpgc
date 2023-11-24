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
      private string name;
      //private Status status; // int for id ?
      private int priority;
      //private string instructions;
      private User resp_user;
      //private Result result;
      public Test(){
        this.name = "No name was given";
        this.priority = -1;
      }

      public Test(string name):base(){
        this.name = name;
      }

      public Test(string name, int priority){
        this.name = name;
        this.priority = priority;
      }

      public int ID{
        get{return this.testID;}
        set{this.testID = value;}
      }

      public string Name{
        get{return this.name;}
        set{this.name = value;}
      }

      public int Priority{
        get{return this.priority;}
        set{this.priority = value;}
      }

      public User Responsible_user{
        get{return this.resp_user;}
        set{this.resp_user = value;}
      }

    }

}
