﻿using TikiAPI.Data;

namespace TikiAPI.DTO
{
    public class UserCartProductDTO
    {
        public int UserCartId { get; set; }
        //public UserCart UserCart { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
