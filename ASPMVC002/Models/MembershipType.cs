﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVC002.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}