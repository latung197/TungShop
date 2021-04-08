﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TungShop.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//ID tự động tăng
        public int ID { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }// 1 MenuGroup chưa nhiều Menus
    }
}
