using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Exalted Type")]
        public int ExaltedTypeDataModelId { get; set; }
        [DisplayName("Exalted Type")]
        public virtual ExaltedTypeDataModel ExaltedType { get; set; }
        
        [Required]
        [DisplayName("Minimum Essance")]
        public int MinimumEssance { get; set; }
        [Required]
        [DisplayName("Minimum Ability")]
        public int MinimumAbility { get; set; }
        [Required]
        [DisplayName("Willpower Cost")]
        public int WillPowerCost { get; set; }
        [Required]
        [DisplayName("Essance Cost")]
        public int EssanceCost { get; set; }
        [Required]
        [DisplayName("Health Cost")]
        public int HealthCost { get; set; }
    }
}