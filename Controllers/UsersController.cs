﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using store.Data;
using store.Models;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly storeContext _context;


        public UsersController(storeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _context.User.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet("checkEmailExists/{email}")]
        public bool CheckEmailExists(string email)
        {
            return _context.User.Any(u => u.Email == email);
        }

        [HttpGet("utilisateur")]
        public async Task<ActionResult<IEnumerable<User>>> Getutilisateur()
        {
            return await _context.User.Where(u => u.type == 1).ToListAsync();
        }


        [HttpGet("client")]
        public async Task<ActionResult<IEnumerable<User>>> Getclient()
        {
            return await _context.User.Where(u => u.type == 0).ToListAsync();
        }

        [HttpGet("checkUserType/{id}")]
        public async Task<ActionResult<string>> CheckUserType(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            if (user.type == 1)
            {
                return Ok("Admin");
            }
            else if (user.type == 0)
            {
                return Ok("Client");
            }
            else
            {
                return BadRequest("Invalid user type");
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update(int id, UserDto obj)
        {
            try
            {
                var dbobj = _context.User.Single(p => p.Id == id);

                dbobj.FullName = obj.FullName;
                dbobj.Email = obj.Email;
                dbobj.Password = obj.Password;
                dbobj.PhoneNumber = obj.PhoneNumber;
                dbobj.type = obj.type;
                dbobj.token = obj.token;
                dbobj.Adresse = obj.Adresse;
                dbobj.MFcin = obj.MFcin;
                dbobj.Gouvernorat = obj.Gouvernorat;
                dbobj.CodePostal = obj.CodePostal;
                dbobj.NomRaisonSocial = obj.NomRaisonSocial;
                _context.SaveChanges();
                return Ok(dbobj);
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("updateAdress/{id:int}")]
        public IActionResult Updateaddres(int id, UserDto obj)
        {
            try
            {
                var dbobj = _context.User.Single(p => p.Id == id);


                dbobj.Adresse = obj.Adresse;
                dbobj.MFcin = obj.MFcin;
                dbobj.Gouvernorat = obj.Gouvernorat;
                dbobj.CodePostal = obj.CodePostal;
                dbobj.NomRaisonSocial = obj.NomRaisonSocial;
                _context.SaveChanges();
                return Ok(dbobj);
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var useri = new User()
            { FullName =user.FullName,
            Email = user.Email,
            Password = user.Password,
            PhoneNumber = user.PhoneNumber,
            type = user.type,

            };
            
            _context.User.Add(useri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = useri.Id }, useri);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }



    }
}
