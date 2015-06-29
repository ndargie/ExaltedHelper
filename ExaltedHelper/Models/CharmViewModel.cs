using ExaltedHelper.Infrastructure.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExaltedHelper.Models
{
    public class CharmViewModel
    {

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Combo ok")]
        public bool ComboOk { get; set; }

        [DisplayName("Willpower")]
        public int WillPowerCost { get; set; }

        [DisplayName("Essance")]
        public int EssanceCost { get; set; }

        [DisplayName("Health")]
        public int HealthCost { get; set; }
    }
}