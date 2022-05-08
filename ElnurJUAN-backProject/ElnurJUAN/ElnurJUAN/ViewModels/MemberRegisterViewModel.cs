﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.ViewModels
{
    public class MemberRegisterViewModel
    {
        [Required]
        [StringLength(maximumLength:30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 60)]
        public string FullName { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        [DataType(DataType.Password)]
        public string   Password { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
