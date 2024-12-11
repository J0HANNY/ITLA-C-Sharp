using Shop.DAL.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.DAL.Entities
{
    public class Category : BaseEntity
    {

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

    }
}