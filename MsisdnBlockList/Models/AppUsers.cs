using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MsisdnBlockList.Models
{
    public class AppUsers
    {
        [Key]
        public int userId { get; set; }
        
        public string provider { get; set; }
        
        public string nameIdentifier { get; set; }
        
        public string username { get; set; }
        
        public string password { get; set; }
        
        public string email { get; set; }
        
        public string firstname { get; set; }
        
        public string lastname { get; set; }
        
        public string mobile { get; set; }
        
        public string roles { get; set; }
        
        public List<string> roleList
        {
            get
            {
                return roles?.Split(',').ToList() ?? new List<string>();
            }
        }
    }
}
