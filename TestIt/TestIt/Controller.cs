using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
// using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    public enum DataObjectType
    {
        Project,
        Functionality,
        Test,
        Result,
        User,
        UserStory,
        ProjectRole
    }
    public class Controller
    {
        public static Object AddNew(Object obj, DataObjectType type)
        {
            GatewayConstructor gateway = new GatewayConstructor(type);
            if (type == DataObjectType.UserStory)
            {
                string a = Convert.ToString(((UserStory)obj).FunctionalityID);
                if (gateway.Find(a) != null)
                {
                    return null;
                }
                else gateway.Insert(obj);
                return obj;
            }
            else
            {
                gateway.Insert(obj);

                return obj;
            }

        }
        public static List<Object> Listaa(DataObjectType type)
        {
            GatewayConstructor gateway = new GatewayConstructor(type);
            return gateway.SelectAll();

        }
        public static List<Object> Listaa(int id, DataObjectType type)
        {
          GatewayConstructor gateway = new GatewayConstructor(type);
          return gateway.SelectAll(id);

        }
        public static void RemoveItem(int id, DataObjectType typpi)
        {
            GatewayConstructor gateway = new GatewayConstructor(typpi);
            gateway.Delete(id);
        }

        public static void Update(Object obj, DataObjectType tyyppi)
        {
            GatewayConstructor gateway = new GatewayConstructor(tyyppi);
            gateway.Update(obj);
        }

        public static List<Object> getProjectUsers(int project_id)
        {
          GatewayConstructor gateway = new GatewayConstructor(DataObjectType.ProjectRole);
          List<Object> proj_role_list = gateway.SelectAll(project_id);
          UserGateway usergateway = new UserGateway();
          List<Object> project_users = new List<Object>();
          foreach(Object obj in proj_role_list){
            ProjectRole pr = (ProjectRole)obj;

            User user =(User)(usergateway.FindById(pr.Ref_user_id));
            project_users.Add(user);
          }
          return project_users;
        }
        public static void SetResponsibleUser(User user, int id)
        {
            TestGateway gateway = new TestGateway();
            gateway.UpdateResponsibleUser(user, id);

        }
    }
}
