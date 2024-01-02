﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System;

namespace MerchantManagementApp.Entities
{
    public class Merchant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MerchantId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
