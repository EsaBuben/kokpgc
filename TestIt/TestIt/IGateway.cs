using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    public interface IGateway 
    {
        void Insert(Object obj);
        List<Object> SelectAll();
        List<Object> SelectAll(int id);
        void Delete(int id);
        Object Find(string t);
    }
}
