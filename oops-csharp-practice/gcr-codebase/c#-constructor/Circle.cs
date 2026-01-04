using System;
class Circle{
	private double radius;
	
	public Circle(): this(1.0){
	}
	
	public Circle(double radius){
		this.radius= radius;
	}
	
	public void AreaAndCircumference(){
		double area= Math.PI * radius * radius;
		double circumference= 2 * Math.PI * radius;
		Console.WriteLine("\nCircle Radius: "+radius);
		Console.WriteLine("Area: "+area);
		Console.WriteLine("Circumference: "+circumference);
	}
}
class Program{
	static void Main(){
		Circle circle1= new Circle();
		Circle circle2= new Circle(5.5);
		
		circle1.AreaAndCircumference();
		circle2.AreaAndCircumference();
	}
}
