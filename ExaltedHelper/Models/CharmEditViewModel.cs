using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Models
{
    public class CharmEditViewModel
    {

        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Combo ok")]
        public bool ComboOk { get; set; }

        [Required]
        [DisplayName("Essance")]
        public int EssanceRequirement { get; set; }

        [Required]
        [DisplayName("Ability requirement")]
        public int AbilityRequirement { get; set; }

        [Required]
        [DisplayName("Exalted Type")]
        public string ExaltedType { get; set; }

        [Required]
        [DisplayName("Health cost")]
        public int HealthCost { get; set; }

        [Required]
        [DisplayName("Willpower cost")]
        public int WillpowerCost { get; set; }

        [Required]
        [DisplayName("Essance cost")]
        public int EssanceCost { get; set; }

    }
}