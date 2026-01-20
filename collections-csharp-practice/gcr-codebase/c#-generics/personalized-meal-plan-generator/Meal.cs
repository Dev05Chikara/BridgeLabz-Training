using System;
class Meal<T> where T : IMealPlan{
	T meal;
	
	public Meal(T meal){
		this.meal= meal;
	}
	
	public void Generate(){
		ValidateMeal(meal);
		
		Console.WriteLine("Meal Type: "+meal.GetMealType());
		Console.WriteLine("Calories: "+meal.GetCalories());
		Console.WriteLine("--------------------------------");
	}
	
	static void ValidateMeal<U>(U mealPlan) where U : IMealPlan{
		if(mealPlan.GetCalories()<=0){
			Console.WriteLine("Invalid Meal Plan");
		}
	}
}
