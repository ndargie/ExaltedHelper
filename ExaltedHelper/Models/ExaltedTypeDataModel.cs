using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Models
{
    public class ExaltedTypeDataModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Exalted Type")]
        public string Description { get; set; }
    }
}