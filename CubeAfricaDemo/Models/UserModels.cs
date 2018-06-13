using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CubeAfricaDemo.Models
{
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class User
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cellNo { get; set; }
        public string workNo { get; set; }
    }
}
