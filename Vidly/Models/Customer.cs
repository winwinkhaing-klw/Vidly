﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Date of Birth")]
        public DateTime? Birthday { get; set; }
        public bool IsSubscribedToCustomer { get; set; }
        [Display(Name="MembershipType")]
        public MembershipType MembershipType { get; set; }
       
    }
}