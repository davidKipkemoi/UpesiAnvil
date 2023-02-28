using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace upesi.API.Models
{
    public class User
    {
        public int UserId {get;set;}
        public int Username {get;set;}
        public int Email {get;set;}
        public int Password {get;set;}
        public int Token {get;set;}
       
    }
}