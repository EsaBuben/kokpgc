﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    public class Result
    {
      private int result_id;
      private int ref_user_id;
      private int ref_test_id;

      // private string acceptance;// result class overlaps with status
      private string comment;

      private DateTime time;

      public Result(){
        this.result_id = -1;
        this.comment = "No comment";

      }

      public Result(int ref_user_id, int ref_test_id, string comment):this(){
        this.ref_user_id = ref_user_id;
        this.ref_test_id = ref_test_id;
        this.comment = comment;
      }

      public int ID{
        get{return this.result_id;}
        set{this.result_id = value;}
      }

      public int Ref_test_id{
        get{return this.Ref_test_id;}
        set{this.Ref_test_id = value;}
      }

      public int Ref_user_id{
        get{return this.Ref_user_id;}
        set{this.Ref_user_id = value;}
      }

      public string Comment{
        get{return this.comment;}
        set{this.comment = value;}
      }

      public DateTime Time{
        get{return this.time;}
        set{this.time = value;}
      }

    }
}
