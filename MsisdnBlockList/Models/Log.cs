using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MsisdnBlockList.Models
{
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int history_id { get; set; }

        [ForeignKey("user")]
        [Display(Name = "User Name")]
        public int user_id { get; set; }
        
        [Display(Name = "Msisdn ID")]
        public int msisdn_id { get; set; }

        [Display(Name = "Status")]
        public int status { get; set; }

        [Display(Name = "Kreirano")]
        public DateTime created { get; set; }

        public virtual User user { get; set; }

        
    }

}
