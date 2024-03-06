using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineKraft.DbLib.Models
{
    internal class User : IdentityUser
    {
        public string Pseudo { get; set; }

        public User(string pseudo) : base()
        {
            Pseudo = pseudo;
        }
    }
}
