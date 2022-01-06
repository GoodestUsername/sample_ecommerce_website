using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// User class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class User: IdentityUser<Guid>
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public virtual UserAddress Address { get; set; }

        [PersonalData]
        public int PhoneNum { get; set; }

        // Account created date
        [PersonalData]
        public DateTime CreationDate { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
