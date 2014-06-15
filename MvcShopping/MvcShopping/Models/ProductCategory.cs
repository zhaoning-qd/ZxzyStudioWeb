﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShopping.Models
{
    [DisplayName("商品类别")]
    [DisplayColumn("Name")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("商品类别名称")]
        [Required(ErrorMessage="请输入商品类别名称")]
        [MaxLength(20,ErrorMessage="类别名称不能超过20个字")]
        public string Name { get; set; }
    }
}