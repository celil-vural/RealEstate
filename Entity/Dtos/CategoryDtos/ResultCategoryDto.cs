﻿namespace Entity.Dtos.CategoryDtos
{
    public record ResultCategoryDto(int CategoryId, string CategoryName, bool CategoryStatus)
    {
        private ResultCategoryDto() : this(0, string.Empty, false)
        {
        }
    }
}
