using System;
using Microsoft.AspNetCore.Mvc;
using entityProject.data;
using entityProject.entities;
using Microsoft.EntityFrameworkCore;
using entityProject.DTOs;

namespace entityProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
	{

		private readonly DataContext context;

		public UsersController(DataContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
		{
			var users = await context.Users.ToListAsync();
			return users;
		}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await context.Users.FindAsync(id);
        }
		[HttpPost("register")]
		public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
		{
			var user = new AppUser { UserName = registerDto.Username };
			context.Users.Add(user);
			await context.SaveChangesAsync();
			return user;
		}
    }
}

