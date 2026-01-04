using System;
class Order{
    protected int orderId;
    protected string orderDate;

    public Order(int id, string date){
        orderId = id;
        orderDate = date;
    }
}

class ShippedOrder : Order{
    protected string trackingNumber;

    public ShippedOrder(int id, string date, string tracking)
        : base(id, date){
        trackingNumber = tracking;
    }
}

class DeliveredOrder : ShippedOrder{
    private string deliveryDate;

    public DeliveredOrder(int id, string date, string tracking, string delivery)
        : base(id, date, tracking){
        deliveryDate = delivery;
    }

    public void GetOrderStatus(){
        Console.WriteLine("Order Delivered on: " + deliveryDate);
    }
}

class Program{
    static void Main(){
        DeliveredOrder d = new DeliveredOrder(101, "1-Jan-2026", "TRK123", "5-Jan-2026");
        d.GetOrderStatus();
    }
}
