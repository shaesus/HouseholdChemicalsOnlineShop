﻿using Application.Helpers;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IUsersService
    {
        Task<AuthorizationResult> Login(string email, string password);
        Task<User?> Register(string userName, string email, string password);
    }
}