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
      private string[] status_list = {"to be tested","currently under testing","results reported","accepted"};
      private ResultStatus status;
      private int priority;
      //private string instructions;
      private int resp_user_id;
      private string resp_user_name;
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

      public Test( string name, int priority,  int refFunctionalityID, int testid)
        {
        this.testID = testid;
        this.name = name;
        this.priority = priority;
        this.refFunctionalityID = refFunctionalityID;
      }

      public int getStatus(){
        return (int)this.status;
      }

      public void setStatus(int status){
        this.status = (ResultStatus)status;
      }
      public int getResponsibleUserId()
      {
        return this.resp_user_id;
      }
      public void setResponsibleUserId(int value)
      {
         this.resp_user_id = value;

      }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int ID
        {
            get{return this.testID;}
            set{this.testID = value;}
        }
        public int Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public string Responsible{
          get{return this.resp_user_name;}
          set{this.resp_user_name = value;}
        }

        public string Status{
          get{return this.status_list[((int)this.status)];}

        }

        public int ref_func_id{
        get{return this.refFunctionalityID;}
        set{this.refFunctionalityID = value;}
      }








      public override string ToString(){
        return $"{this.testID}: {this.name}";
      }

    }

}
