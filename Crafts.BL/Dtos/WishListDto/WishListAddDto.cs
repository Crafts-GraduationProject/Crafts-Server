﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafts.BL.Dtos.WishListDto
{
    public class WishListAddDto
    {
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}
