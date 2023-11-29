using CommandRestaurant;
using CommandRestaurant.Elements;


Order order = new Order();
IComand placeorder = new PlaceOrderCommand(order);
IComand cancelOrder = new CancelOrderCommand(order);

Waiter mesero = new Waiter();
mesero.TakeComand(placeorder);
mesero.TakeComand(cancelOrder);