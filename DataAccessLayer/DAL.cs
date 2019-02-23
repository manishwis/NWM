using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DAL
    {
        protected MISContext _misContext;
        public DAL()
        {
            _misContext = new MISContext();
        }

    }
}
