using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MsisdnBlockList.Models
{
    public enum Status
    {
        Blocked = 1,
        NotBlocked = 0
    }
   
    public partial class MSISDN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int msisdn_id { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Kreirano")]
        public DateTime created { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Zadnja promjena")]
        public DateTime? modified { get; set; }
                
        [DisplayName("Obrisano")]
        public DateTime? deleted { get; set; }

        [Required(ErrorMessage = "Potrebno je navesti MSISDN")]
        [RegularExpression(@"^(((00|\+)?385)|0)?(9[125789][1-9][0-9]{5,6})", ErrorMessage = "Nije valjani broj mobilnog telefona")]
        [MaxLength(13, ErrorMessage = "Maksimalno 13 znakova")]
        [MinLength(6, ErrorMessage = "Minimalno 6 znakova")]
        [Display(Name = "Broj telefona")]
        public string msisdn { get; set; }

        [EnumDataType(typeof(Status))]
        [DisplayName("Status")]
        [DisplayFormat(NullDisplayText = "Bez statusa")]
        [DefaultValue(1)]
        public int status { get; set; }

        [DisplayName("User Name")]
        [Column("user_id")]
        [ForeignKey("user")]
        public int user_id { get; set; }
        
        public virtual User user { get; set; }
       

        public string GetFormatedPhoneNumber()
        {
            return GetFormatedPhoneNumber(msisdn);
        }

        public static string GetFormatedPhoneNumber(string msisdn)
        {
            if (string.IsNullOrEmpty(msisdn))
                return string.Empty;

            if (msisdn.StartsWith("+385"))
                return msisdn.Substring(4);

            if (msisdn.StartsWith("00"))
                return msisdn.Substring(6);

            if (msisdn.StartsWith("09"))
                return msisdn.Substring(1);

            if (msisdn.StartsWith("385"))
                return msisdn.Substring(3);

            return msisdn;

        }
    }

}
