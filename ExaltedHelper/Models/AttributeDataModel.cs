using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedHelper.Models
{
    public class AttributeDataModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }       
        [Required]
        public virtual AttributeCategoryDataModel Category { get; set; }
        public virtual CharmDataModel Charm { get; set; }
    }
}