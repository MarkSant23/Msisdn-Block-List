using MsisdnBlockList.Models;
using MsisdnBlockList.Data;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MsisdnBlockList.Services
{
    public class UserService
    {
        private readonly MySqlContext _context;
        public UserService(MySqlContext context)
        {
            _context = context;
        }

        internal AppUsers GetUserByExternalProvider(string provider, string nameIdentifier)
        {
            var asd = _context.appUsers.Where(a => a.provider == provider).Where(a => a.nameIdentifier == nameIdentifier).FirstOrDefault();
            return asd;
        }

        public AppUsers GetUserById(int id)
        {
            var app = _context.appUsers.Find(id);
            return app;
        }

        public bool TryValidateUser(string username, string password, out List<Claim> claims)
        {
            claims = new List<Claim>();
            var app = _context.appUsers.Where(a => a.username == username).Where(a => a.password == password).FirstOrDefault();
            if (app is null)
            {
                return false;
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                //claims.Add(new Claim("username", username));
                claims.Add(new Claim(ClaimTypes.Name, app.username));
                claims.Add(new Claim(ClaimTypes.GivenName, app.firstname));
                claims.Add(new Claim(ClaimTypes.Surname, app.lastname));
                claims.Add(new Claim(ClaimTypes.Email, app.email));
                claims.Add(new Claim(ClaimTypes.MobilePhone, app.mobile));
                foreach (var r in app.roleList)
                {
                    claims.Add(new Claim(ClaimTypes.Role, r));
                }
                return true;
            }
        }

        public AppUsers AddNewUser(string provider, List<Claim> claims)
        {
            var a = new AppUsers();
            //var nbr = 1;
            a.provider = provider;
            a.password = claims.GetClaim(ClaimTypes.Hash);
            a.nameIdentifier = claims.GetClaim(ClaimTypes.NameIdentifier);
            a.username = claims.GetClaim("username");
            a.firstname = claims.GetClaim(ClaimTypes.GivenName);
            a.lastname = claims.GetClaim(ClaimTypes.Surname);
            var name = claims.GetClaim("name");

            // Vrlo rudimentarno rukovanje podjelom punog imena korisnika na ime i prezime. Ne baš robusno.
            if (string.IsNullOrEmpty(a.firstname))
            {
                a.firstname = name?.Split(' ').First();
            }
            if (string.IsNullOrEmpty(a.lastname))
            {
                var nameSplit = name?.Split(' ');
                if (nameSplit.Length > 1)
                {
                    a.lastname = name?.Split(' ').Last();
                }
            }
            a.email = claims.GetClaim(ClaimTypes.Email);
            a.mobile = claims.GetClaim(ClaimTypes.MobilePhone);
            a.roles = claims.GetClaim(ClaimTypes.Role);
            //a.roles = claims.GetClaim("NewUser" + nbr++);
            var entity = _context.appUsers.Add(a);
            _context.SaveChanges();
            return entity.Entity;
        }
    }

    public static class Extensions
    {
        public static string GetClaim(this List<Claim> claims, string name)
        {
            return claims.FirstOrDefault(c => c.Type == name)?.Value;
        }
    }

}
