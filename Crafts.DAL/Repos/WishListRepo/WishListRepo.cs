﻿using Crafts.DAL.Context;
using Crafts.DAL.Models;
using Crafts.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafts.DAL.Repos.WishListRepo
{
    public class WishListRepo:GenericRepo<Wishlist>,IWishListRepo
    {
        private readonly CraftsContext _context;

        public WishListRepo(CraftsContext context):base(context) 
        {
            _context = context;
        }

        public Wishlist? GetUserWishList(string userId)
        {
            return _context.Set<Wishlist>()
                .Include(w=>w.Products)
                .FirstOrDefault(c => c.UserId == userId);
        }
    }
}
