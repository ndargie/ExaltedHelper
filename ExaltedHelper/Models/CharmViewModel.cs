﻿using ExaltedHelper.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExaltedHelper.Models
{
    public class CharmViewModel
    {

        [Key]
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
        [Range(0, 10)]
        [DisplayName("Essance")]
        public int EssanceRequirement { get; set; }

        [Required]
        [Range(0, 10)]
        [DisplayName("Ability requirement")]
        public int AbilityRequirement { get; set; }

        [Required]
        public int SelectedExaltedType { get; set; }

     
        [DisplayName("Exalted Type")]
        public IEnumerable<ExaltedTypeViewModel> ExaltedTypes { get; set; }

        [Required]
        [Range(0, 10)]
        [DisplayName("Health cost")]
        public int HealthCost { get; set; }
        
        [Required]
        [Range(0, 10)]
        [DisplayName("Willpower cost")]
        public int WillpowerCost { get; set; }

        [Required]
        [Range(0, 10)]
        [DisplayName("Essance cost")]
        public int EssanceCost { get; set; }

    }
}