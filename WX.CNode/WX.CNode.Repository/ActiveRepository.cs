using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.CNode.Repository
{
    using WX.CNode.Model;
    using WX.CNode.IRepository;
    public class ActiveRepository : ActiveIRepository
    {
        public List<Action> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
