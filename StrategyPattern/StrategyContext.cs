using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyContext
    {
        public Order Order { get; set; }

        public IOrderFileSavingStrategy OrderToFile { get; set; }

        public void SaveFile()
        {
            OrderToFile.SaveOrderToFile(Order);
        }
    }
}
