﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PecoWeb.Model.Abstract;

namespace PecoWeb.Model.Models
{
    [Table("Pages")]
    public class Page: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }
        public string Content { get; set; }
    }
}
