using nutracker.Dto.FoodDto;
using nutracker.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Mapper.FoodMapper
{
    public class FoodMapper
    {
        public FoodDto ToDto(Food food)
        {
            FoodDto foodDto = new FoodDto();
            FoodCategoryMapper foodCategroyMapper = new FoodCategoryMapper();
            FoodInfoMapper foodInfoMapper = new FoodInfoMapper();
            foodDto.validated = food.Validated;
            foodDto.name = food.Name;
            foodDto.foodCategoryDto = foodCategroyMapper.ToDto(food.FoodCategory);
            foodDto.foodInfoDto = foodInfoMapper.ToDto(food.FoodInfo);
            foodDto.barcode = food.Barcode;
            foodDto.portion = food.Portion;
            return foodDto;
        }
    }

    public Food ToEntity(FoodDto foodDto)
    {
        Food food = new Food();
        FoodCategoryMapper foodCategoryMapper = new FoodCategoryMapper();
        FoodInfoMapper foodInfoMapper = new FoodInfoMapper();
        food.Validated = foodDto.validated;
        food.Name = foodDto.name;
        food.FoodCategory = foodCategoryMapper.ToEntity(foodDto.foodCategoryDto);
        food.FoodInfo = foodInfoMapper.ToEntity(foodDto.foodInfoDto);
        food.Barcode = foodDto.barcode;
        food.Portion = foodDto.portion;
        return food;
    }
}