﻿using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace inlämning1Tomasso.Data.Repos
{
    public class DishRepository : IDishRepository
    {
        private readonly TomassoDbContext _context;

        public DishRepository(TomassoDbContext context)
        {
            _context = context;
        }

        public void AddDish(Dish dish)
        {
            _context.Dishes.Add(dish);
            _context.SaveChanges();
        }

        public void DeleteDish(int dishId)
        {
            var dish = _context.Dishes.SingleOrDefault(d => d.DishID == dishId);
            if (dish != null)
            {
                _context.Dishes.Remove(dish);
                _context.SaveChanges();
            }
        }

        public void UpdateDish(Dish dish)
        {
            var existingDish = _context.Dishes.SingleOrDefault(d => d.DishID == dish.DishID);
            if (existingDish != null)
            {
                _context.Entry(existingDish).CurrentValues.SetValues(dish);
                _context.SaveChanges();
            }
        }

        public List<Dish> GetAllDishes()
        {
            return _context.Dishes.ToList();
        }

        public Dish GetDishById(int dishID)
        {
            return _context.Dishes.FirstOrDefault(d => d.DishID == dishID);
        }
    }
}
