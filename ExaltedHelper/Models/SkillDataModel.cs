using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ExaltedHelper.Models
{
    public class SkillDataModel
    {
        public Guid Id { get; set; }
        [Required]
        [DisplayName("Skill")]
        public string Description { get; set; }      
        [Required]
        public virtual CastesDataModel Caste { get; set; }
        public virtual CharmDataModel Charm { get; set; }

    }
}