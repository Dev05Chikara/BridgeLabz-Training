using System;
class VehicleNode
{
    public string vehicleNumber;
    public VehicleNode next;

    public VehicleNode(string vehicleNumber)
    {
        this.vehicleNumber= vehicleNumber;
        next=null;
    }
}