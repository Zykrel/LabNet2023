using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext _northwindcontext;

        public BaseLogic() 
        {
            _northwindcontext = new NorthWindContext();
        }
    }
}
