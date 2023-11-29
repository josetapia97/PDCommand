using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRestaurant.Elements
{
    public class Order 
    {
        public void Place() 
        {
            Console.WriteLine("Order has been placed");
        }
        public void Cancel()
        {
            Console.WriteLine("Order has been canceled");
        }
    }
}
