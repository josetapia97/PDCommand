using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRestaurant.Elements
{
    public class PlaceOrderCommand : IComand
    {
        private Order _order;
        public PlaceOrderCommand(Order order)
        {
            _order = order;
        }
        public void Execute()
        {
            _order.Place();
        }
    }
}
