using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorEase.Core.DTO.Request
{
    public class RegisterRequest
    {
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public string Bvn { get; set; }
       
        [EmailAddress]
        public string Email { get; set; }
       
        [Phone]
        public string PhoneNumber { get; set; }
       
        public string Nin { get; set; }
        
        public string Role { get; set; }
       
        public string HouseNumber { get; set; }
       
        public string StreetName { get; set; }
       
        public string Landmark { get; set; }
       
        public string CityOrTown { get; set; }
       
        public string Lga { get; set; }
       
        public string State { get; set; }

        public IFormFile Image { get; set; }


    }
    public class UpdateUserRequest
    {
        public IFormFile Image
        {
            get; set;
        }

    }
}
