using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRestaurant.Elements
{
    public class Waiter
    {
        public void TakeComand(IComand command)
        {
            command.Execute();
        }
    }
}
