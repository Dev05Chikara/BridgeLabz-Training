using System;
class MealMain{
	static void Main(){
		VegetarianMeal veg= new VegetarianMeal();
		Meal<VegetarianMeal> m1= new Meal<VegetarianMeal>(veg);
		m1.Generate();
		
		VeganMeal vegan= new VeganMeal();
		Meal<VeganMeal> m2= new Meal<VeganMeal>(vegan);
		m2.Generate();
		
		KetoMeal keto= new KetoMeal();
		Meal<KetoMeal> m3= new Meal<KetoMeal>(keto);
		m3.Generate();
		
		HighProteinMeal hp= new HighProteinMeal();
		Meal<HighProteinMeal> m4= new Meal<HighProteinMeal>(hp);
		m4.Generate();
	}
}
