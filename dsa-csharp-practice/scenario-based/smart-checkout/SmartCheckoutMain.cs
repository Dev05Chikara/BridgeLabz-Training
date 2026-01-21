using System;
class SmartCheckoutMain{
	static void Main(){
		CheckoutUtility checkout= new CheckoutUtility();
		
		Customer c1= new Customer("Dev");
		c1.Items.Add("Milk");
		c1.Items.Add("Bread");
		
		Customer c2= new Customer("Harshit");
		c2.Items.Add("Eggs");
		c2.Items.Add("Milk");
		
		checkout.AddCustomer(c1);
		checkout.AddCustomer(c2);
		
		checkout.ProcessCustomer();
		checkout.ProcessCustomer();
	}
}
