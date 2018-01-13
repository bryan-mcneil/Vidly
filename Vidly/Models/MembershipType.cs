using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public String Name { get; set; }
        public short SignUpFee { get; set; }
        public byte Duration { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}