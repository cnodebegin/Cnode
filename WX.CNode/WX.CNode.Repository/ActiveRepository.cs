using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.CNode.Repository
{
    using WX.CNode.Model;
    using WX.CNode.IRepository;
    public class ActiveRepository : IActiveRepository
    {
        public List<Active> GetActiveList()
        {
            string sql = "select active.* from active join author on author.id=PublisherID join dataresource on dataresource.id=author.DataID";
            List<Active> activelist = MySqlDapper.Query<Active>(sql);
            return activelist;
        }
    }
}
