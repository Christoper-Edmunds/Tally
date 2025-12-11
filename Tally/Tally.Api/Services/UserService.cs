using Microsoft.AspNetCore.Identity;
using System;
using Tally.Api.DTO;
using Tally.Api.Interfaces;
using Tally.Data;
using Tally.Data.Entities;

namespace Tally.Api.Services
{
    public class UserService : IUserService
    {
        private readonly TallyDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(TallyDbContext dbContext, IPasswordHasher<User> passwordHasher)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
        }

        public User? ValidateUser(string Email, string Password)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Email == Email);
            if (user == null || user.PasswordHash == null) return null;
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, Password);
            return result == PasswordVerificationResult.Success ? user : null;
        }

        public User? ValidateRefreshToken(string refreshToken)
        {
            return _dbContext.Users.SingleOrDefault(u => u.RefreshToken == refreshToken && u.RefreshTokenExpiry > DateTime.UtcNow);
        }

        public void UpdateRefreshToken(int userId, string newRefreshToken)
        {
            var user = _dbContext.Users.Find(userId);
            if (user == null) return;
            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiry = DateTime.UtcNow.AddMonths(6);
            _dbContext.SaveChanges();
        }

        public bool UserExists(string email)
        {
            return _dbContext.Users.Any(u => u.Email == email);
        }

        public User? CreateUser(RegisterRequest request)
        {
            var user = new User
            {
                Email = request.Email,
                UserName = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                // ... other properties
            };
            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
    }
}
