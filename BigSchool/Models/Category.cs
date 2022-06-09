﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Category
    {
        public byte Id { set; get; }
        [Required]
        [StringLength(255)]
        public string Name { set; get; }
    }
}