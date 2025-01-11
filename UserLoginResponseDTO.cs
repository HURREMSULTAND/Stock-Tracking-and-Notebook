using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformfs2
{
    public class UserLoginResponseDTO
    {

        public int Id { get; set; } 
        public string Fullname { get; set; }    
        public string PasswordH { get; set; }  
        public string PasswordHS { get; set; }  
    }
}
