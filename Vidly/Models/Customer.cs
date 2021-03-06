﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedTodNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}