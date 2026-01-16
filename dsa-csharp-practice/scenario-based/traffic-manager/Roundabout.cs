using System;
class Roundabout{
	private VehicleNode head= null;
	
	public void AddVehicle(string vehicle){
		VehicleNode newVehicle= new VehicleNode(vehicle);
		if(head==null){
			head= newVehicle;
			newVehicle.next= head;
		}else{
			VehicleNode temp= head;
			while(temp.next!=head){
				temp= temp.next;
			}
			temp.next= newVehicle;
			newVehicle.next= head;
		}
		Console.WriteLine("---Vehicle "+vehicle+" entered roundabout---");
	}
	
	public void RemoveVehicle(string vehicle){
		if(head==null){
			Console.WriteLine("---Roundabout is empty---");
			return;
		}
		if(head.vehicleNumber.Equals(vehicle) && head.next==head){
			head= null;
			Console.WriteLine("---Vehicle "+vehicle+" exited roundabout---");
			return;
		}
		VehicleNode curr= head;
		VehicleNode prev= null;
		do{
			if(curr.vehicleNumber.Equals(vehicle)){
				if(curr==head){
					VehicleNode temp= head;
					while(temp.next!=head){
						temp= temp.next;
					}
					head= head.next;
					temp.next= head;
				}else{
					prev.next= curr.next;
				}
				Console.WriteLine("---Vehicle "+vehicle+" exited roundabout---");
				return;
			}
			prev= curr;
			curr= curr.next;
		}while(curr!=head);
		Console.WriteLine("---Vehicle not found in roundabout---");
	}
	
	public void DisplayRoundabout(){
		if(head==null){
			Console.WriteLine("---Roundabout is empty---");
			return;
		}
		Console.WriteLine("\nVehicles in Roundabout:");
		VehicleNode temp= head;
		do{
			Console.WriteLine("- "+temp.vehicleNumber);
			temp= temp.next;
		}while(temp!=head);
	}
}
