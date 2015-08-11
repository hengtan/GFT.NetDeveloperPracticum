﻿using System.Collections.Generic;
using GFT.NetDeveloperPracticum.Model.Entities;
using GFT.NetDeveloperPracticum.Model.Entities.Contracts;
using GFT.NetDeveloperPracticum.Model.Entities.Enums;

namespace GFT.NetDeveloperPracticum.Model
{
    public class MorningMeal : IScheduleStrategy
    {
        public MealPlan Meal(EnumDishesTime time, List<int> numbersOfMeal)
        {           
            var mealPlan = new MealFactory(time, numbersOfMeal).Create();

            return mealPlan;
        }
    }
}
