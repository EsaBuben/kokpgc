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
          case DataObjectType.UserStory:
            this.gateway = new UserStoryGateway();
            break;
          case DataObjectType.Test:
            this.gateway = new TestGateway();
            break;
          case DataObjectType.Result:
            this.gateway = new ResultGateway();
            break;
          case DataObjectType.User:
            this.gateway = new UserGateway();
            break;
          case DataObjectType.ProjectRole:
            this.gateway = new ProjectRoleGateway();
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
        public Object Find(string t)
        {
            return this.gateway.Find(t);
        }
        public void Update(Object obj)
        {
            this.gateway.Update(obj);
        }
    }
}
