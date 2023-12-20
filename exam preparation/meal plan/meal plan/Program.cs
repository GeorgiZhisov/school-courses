class Program
{
    static void Main()
    {
        List<string> meals = Console.ReadLine().Split().ToList();
        List<int> dailyCalories = Console.ReadLine().Split().Select(int.Parse).ToList();

        int mealsCount = 0;

        for (int dayIndex = 0; dayIndex < dailyCalories.Count && meals.Count > 0; dayIndex++)
        {
            int remainingDailyCalories = dailyCalories[dayIndex];

            while (meals.Count > 0)
            {
                int currentMealCalories = GetCalories(meals[0]);

                if (currentMealCalories <= remainingDailyCalories)
                {
                    remainingDailyCalories -= currentMealCalories;
                    meals.RemoveAt(0);
                    mealsCount++;
                }
                else
                {
                    meals[0] = SubtractCalories(meals[0], remainingDailyCalories);
                    break;
                }
            }

            if (remainingDailyCalories == 0)
            {
                dailyCalories.RemoveAt(dayIndex);
                dayIndex--;
            }
        }

        if (meals.Count == 0)
        {
            Console.WriteLine($"John had {mealsCount} meals.");
            Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCalories)} calories.");
        }
        else
        {
            Console.WriteLine($"John ate enough, he had {mealsCount} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
        }
    }

    static int GetCalories(string meal)
    {
        switch (meal)
        {
            case "salad": return 350;
            case "soup": return 490;
            case "pasta": return 680;
            case "steak": return 790;
            default: return 0;
        }
    }

    static string SubtractCalories(string meal, int calories)
    {
        int mealCalories = GetCalories(meal);
        int remainingCalories = mealCalories - calories;

        if (remainingCalories <= 0)
        {
            return "none";
        }

        return $"{meal.Substring(0, meal.Length - 1)} {remainingCalories}";
    }
}