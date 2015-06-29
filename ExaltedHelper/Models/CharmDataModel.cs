using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedHelper.Models
{
    public class CharmDataModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int ExaltedTypeDataModelId { get; set; }
        public virtual ExaltedTypeDataModel ExaltedType { get; set; }
        
        [Required]
        public int MinimumEssance { get; set; }
        [Required]
        public int MinimumAbility { get; set; }
        [Required]
        public int WillPowerCost { get; set; }
        [Required]
        public int EssanceCost { get; set; }
        [Required]
        public int HealthCost { get; set; }
    }
}