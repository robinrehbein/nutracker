using nutracker.Dto.FoodDto;
using nutracker.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Mapper.FoodMapper
{
    public class FoodInfoMapper
    {
        public FoodInfoDto ToDto(FoodInfo foodInfo)
        {
            FoodInfoDto foodInfoDto = new FoodInfoDto();
            foodInfoDto.FoodCalories = foodInfo.FoodCalories;
            foodInfoDto.Carbohydrates = foodInfo.Carbohydrates;
            foodInfoDto.Fat = foodInfo.Fat;
            foodInfoDto.Protein = foodInfo.Protein;
            foodInfoDto.Salt = foodInfo.Salt;
            return foodInfoDto;
        }

        public FoodInfo ToEntity(FoodInfoDto foodInfoDto)
        {
            FoodInfo foodInfo = new FoodInfo();
            return foodInfo;
        }
    }
}