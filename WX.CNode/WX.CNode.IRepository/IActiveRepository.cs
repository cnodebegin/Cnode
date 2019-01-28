using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.CNode.IRepository
{
    using WX.CNode.Model;
    public interface IActiveRepository
    {
        List<Active> GetActiveList();
    }
}
