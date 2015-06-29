using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Models
{
    public class AttributeCategoryDataModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual AttributeDataModel Attribute { get; set; }
    }
}