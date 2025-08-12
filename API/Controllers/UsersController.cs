using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseAPIController
    {
        private readonly AppDbContext _dataContxt;

        public UsersController(AppDbContext dataContxt)
        {
            _dataContxt = dataContxt;
        }
        [AllowAnonymous]
        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _dataContxt.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("user/{id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var users = await _dataContxt.Users.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(users);
        }
    }
}
