﻿using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<Recipe, int, Recipe> RecipeData()
        {
            return new RecipeRepo();
        }

        public static IRepo<Rating, int, Rating> RatingData()
        {
            return new RatingRepo();
        }

        public static IAuth Auth()
        {
            return new UserRepo();
        }
    }
}
