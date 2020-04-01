using nutracker.Dto.FoodDto;
using nutracker.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Mapper.FoodMapper
{
    public class FoodCategoryMapper
    {
        public FoodCategoryDto ToDto(FoodCategory foodCategory)
        {
            FoodCategoryDto foodCategoryDto = new FoodCategoryDto();
            //foodCategoryDto.drink = foodCategory.drink;
            //foodCategoryDto.food = foodCategory.food;
            return foodCategoryDto;
        }

        public FoodCategory ToEntity(FoodCategoryDto foodCategoryDto)
        {
            FoodCategory foodCategory = new FoodCategory();
            return foodCategory;
        }
    }
}