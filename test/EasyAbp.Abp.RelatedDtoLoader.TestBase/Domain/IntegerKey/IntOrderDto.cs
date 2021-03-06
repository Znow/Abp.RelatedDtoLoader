﻿using Volo.Abp.Application.Dtos;

namespace EasyAbp.Abp.RelatedDtoLoader.TestBase.Domain.IntegerKey
{
    public class IntOrderDto : EntityDto<int>
    {
        public int ProductId { get; set; }

        [RelatedDto] public IntProductDto Product { get; set; }

        public IntOrderDto Clone()
        {
            return (IntOrderDto) MemberwiseClone();
        }
    }
}