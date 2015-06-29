using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaltedHelper.Models
{
    public class SkillDataModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }      
        [Required]
        public virtual CastesDataModel Caste { get; set; }
        public virtual CharmDataModel Charm { get; set; }

    }
}