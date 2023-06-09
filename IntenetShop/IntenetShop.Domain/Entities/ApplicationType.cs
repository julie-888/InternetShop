﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntenetShop.Domain.Entities
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Range(0, int.MaxValue)]
        public int DisplayOrder { get; set; }
    }
}
