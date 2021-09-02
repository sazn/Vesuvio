﻿using RoasterWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoasterWebApplication.Services
{
    public interface IUserService
    {

        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();

    }
}
