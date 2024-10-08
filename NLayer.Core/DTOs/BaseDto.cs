﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{   
    //Dto'lar Cliente tüm modeli göstermek yerine gerekli olan propertyleri göstermemiz demektir. Update,create gibi metotların kendine ait dtoları olmalıdır.
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
