using System;
using System.Collections.Generic;
namespace TestIt
{
    public class GatewayConstructor:IGateway
    {
        private IGateway gateway;
        public GatewayConstructor(DataObjectType dtype)
        {
        switch(dtype)
          {
          case DataObjectType.Project:
            this.gateway = new ProjectGateway();
            break;
          case DataObjectType.Functionality:
            this.gateway = new FunctionalityGateway();
            break;
          case DataObjectType.Test:
            this.gateway = new TestGateway();
            break;
          case DataObjectType.Result:
            break;
          case DataObjectType.User:
            break;
          default:
            this.gateway = null;
            break;
          }
        }

        public void Insert(Object obj){
          this.gateway.Insert(obj);
        }

        public List<Object> SelectAll(){
          return gateway.SelectAll();
        }

        public List<Object> SelectAll(int id){
          return gateway.SelectAll(id);
        }
        public void Delete(int id)
        {
            this.gateway.Delete(id);
        }
    }
}
