using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ConfirmedPassword { get; set; }
        public string Token { get; set; }
    }
}
