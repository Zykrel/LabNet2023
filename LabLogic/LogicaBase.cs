using Lab.EF.Data2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLogic
{
    public class LogicaBase
    {
        protected readonly NorthwindData _northwindcontext;
        public LogicaBase()
            {
                _northwindcontext = new NorthwindData();
            }
        }
    }