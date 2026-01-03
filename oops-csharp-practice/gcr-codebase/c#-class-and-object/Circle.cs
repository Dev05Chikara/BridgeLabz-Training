using System;
class Circle{
	private double radius;
	
	public Circle(double radius){
		this.radius= radius;
	}
	public void AreaAndCircumference(){
		double area= Math.PI * radius * radius;
		double circumference = 2 * Math.PI * radius;
		Console.WriteLine("\nArea of Circle(r= "+radius+"): "+area);
		Console.WriteLine("Circumference of Circle(r= "+radius+"): "+circumference);
	} 
}
class Program{
	static void Main(){
		Circle circle1= new Circle(2.5);
		Circle circle2= new Circle(6.8);
		Circle circle3= new Circle(3.3);
		
		circle1.AreaAndCircumference();
		circle2.AreaAndCircumference();
		circle3.AreaAndCircumference();
	}
}