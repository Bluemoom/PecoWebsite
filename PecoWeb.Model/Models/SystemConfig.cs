﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PecoWeb.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName="varchar")]
        public string Code { get; set; }
        [MaxLength(50)]
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
    }
}
