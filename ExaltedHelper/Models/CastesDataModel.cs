using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Models
{
    public class CastesDataModel
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Description { get; set; }

        public virtual ExaltedTypeDataModel ExaltedType { get; set; }
        public virtual CharmDataModel Charm { get; set; }
        public virtual ICollection<SkillDataModel> Skills { get; set; }
    }
}