using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.CNode.IRepository
{
    using WX.CNode.Model;
    public interface ActiveIRepository
    {
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        List<Action> SelectAll();
    }
}
