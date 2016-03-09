using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExaltedHelper.Models;

namespace ExaltedHelper.DAL
{
    public class CharmInitialiser : System.Data.Entity.DropCreateDatabaseAlways<CharmContext>
    {

        protected override void Seed(CharmContext context)
        {

            var ExaltedTypes = new List<ExaltedTypeDataModel>
            {
                new ExaltedTypeDataModel { Description = "Solar"},
                new ExaltedTypeDataModel { Description = "Abysal"},
                new ExaltedTypeDataModel { Description = "DragonBlooded"},
                new ExaltedTypeDataModel { Description = "Siderial"},
                new ExaltedTypeDataModel { Description = "Alchemical"},
                new ExaltedTypeDataModel { Description = "Infernal"},
                new ExaltedTypeDataModel { Description = "None"},
            };

            ExaltedTypes.ForEach(e => context.ExaltedTypeModel.Add(e));
            context.SaveChanges();

            ExaltedTypeDataModel solar = context.ExaltedTypeModel.SingleOrDefault(e => e.Description.ToLower() == "solar");
            ExaltedTypeDataModel abysal = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "abysal");
            ExaltedTypeDataModel dragonBlooded = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "dragonblooded");
            ExaltedTypeDataModel siderial = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "siderial");
            ExaltedTypeDataModel alchemical = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "alchemical");
            ExaltedTypeDataModel infernal = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "infernal");
            ExaltedTypeDataModel noExaltedType = ExaltedTypes.SingleOrDefault(e => e.Description.ToLower() == "none");


            var AttributeCategories = new List<AttributeCategoryDataModel>
           {
               new AttributeCategoryDataModel { Description = "Social", Id = Guid.NewGuid() },
               new AttributeCategoryDataModel { Description = "Mental", Id = Guid.NewGuid() },
               new AttributeCategoryDataModel { Description = "Physical", Id = Guid.NewGuid() },
               new AttributeCategoryDataModel { Description = "None", Id = Guid.NewGuid() }
           };

            AttributeCategories.ForEach(a => context.AttributeCategoryModel.Add(a));
            context.SaveChanges();

            AttributeCategoryDataModel social = AttributeCategories.SingleOrDefault(a => a.Description.ToLower() == "social");
            AttributeCategoryDataModel physical = AttributeCategories.SingleOrDefault(a => a.Description.ToLower() == "physical");
            AttributeCategoryDataModel mental = AttributeCategories.SingleOrDefault(a => a.Description.ToLower() == "mental");
            AttributeCategoryDataModel noAttributeCategory = AttributeCategories.SingleOrDefault(a => a.Description.ToLower() == "none");

            var Attributes = new List<AttributeDataModel>
           {
               new AttributeDataModel { Category = social, Description = "Charisma", Id = Guid.NewGuid()},
               new AttributeDataModel { Category = social, Description = "Manipulation", Id = Guid.NewGuid()},
               new AttributeDataModel { Category = social, Description = "Appearance", Id = Guid.NewGuid() },
               new AttributeDataModel { Category = mental, Description = "Intelligence", Id = Guid.NewGuid() },
               new AttributeDataModel { Category = mental, Description = "Wits", Id = Guid.NewGuid() },
               new AttributeDataModel { Category = mental, Description = "Perception", Id = Guid.NewGuid() },
               new AttributeDataModel { Category = physical, Description = "Strength", Id = Guid.NewGuid()},
               new AttributeDataModel { Category = physical, Description = "Dexterity", Id = Guid.NewGuid()},
               new AttributeDataModel { Category = physical, Description = "Stamina", Id = Guid.NewGuid() },
               new AttributeDataModel { Category = noAttributeCategory, Description = "None", Id = Guid.NewGuid()}          
           };

            AttributeDataModel charisma = Attributes.SingleOrDefault(a => a.Description.ToLower() == "charisma");
            AttributeDataModel manipulation = Attributes.SingleOrDefault(a => a.Description.ToLower() == "manipulation");

            AttributeDataModel appearance = Attributes.SingleOrDefault(a => a.Description.ToLower() == "appearance");

            AttributeDataModel intelligence = Attributes.SingleOrDefault(a => a.Description.ToLower() == "intelligence");

            AttributeDataModel wits = Attributes.SingleOrDefault(a => a.Description.ToLower() == "wits");

            AttributeDataModel perception = Attributes.SingleOrDefault(a => a.Description.ToLower() == "perception");

            AttributeDataModel strength = Attributes.SingleOrDefault(a => a.Description.ToLower() == "strength");

            AttributeDataModel dexterity = Attributes.SingleOrDefault(a => a.Description.ToLower() == "dexterity");

            AttributeDataModel stamina = Attributes.SingleOrDefault(a => a.Description.ToLower() == "stamina");

            AttributeDataModel noAttributes = Attributes.SingleOrDefault(a => a.Description.ToLower() == "none");


            Attributes.ForEach(a => context.AttributeModel.Add(a));
            context.SaveChanges();
         
            var castes = new List<CastesDataModel>
            {
                new CastesDataModel { Id = Guid.NewGuid(), Description = "Dawn" },
                new CastesDataModel { Id = Guid.NewGuid(), Description = "Twilight" },
                new CastesDataModel { Id = Guid.NewGuid(), Description = "Eclipse"},
                new CastesDataModel { Id = Guid.NewGuid(), Description = "Zenith" },
                new CastesDataModel { Id = Guid.NewGuid(), Description = "Night"  },
                new CastesDataModel {Id = Guid.NewGuid(), Description = "none"}
            };

            CastesDataModel dawn = castes.SingleOrDefault(c => c.Description.ToLower() == "dawn");
            CastesDataModel twilight = castes.SingleOrDefault(c => c.Description.ToLower() == "twilight");
            CastesDataModel eclipse = castes.SingleOrDefault(c => c.Description.ToLower() == "eclipse");
            CastesDataModel zenith = castes.SingleOrDefault(c => c.Description.ToLower() == "zenith");
            CastesDataModel night = castes.SingleOrDefault(c => c.Description.ToLower() == "night");
            CastesDataModel noCaste = castes.SingleOrDefault(c => c.Description.ToLower() == "none");

            castes.ForEach(c => context.CastesModel.Add(c));
            context.SaveChanges();

            var skills = new List<SkillDataModel>
            {
                new SkillDataModel { Description = "Archery", Id = Guid.NewGuid(), Caste = dawn},
                new SkillDataModel { Description = "Martial Arts", Id = Guid.NewGuid(), Caste = dawn},
                new SkillDataModel { Description = "Melee", Id = Guid.NewGuid(), Caste = dawn},
                new SkillDataModel { Description = "Thrown", Id = Guid.NewGuid(), Caste = dawn},
                new SkillDataModel { Description = "War", Id = Guid.NewGuid(), Caste = dawn},
                new SkillDataModel { Description = "Craft(Air)", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Craft(Earth)", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Craft(Fire)", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Craft(Water)", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Craft(Wood)", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Investigation", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Lore", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Medicine", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Occult", Id = Guid.NewGuid(), Caste = twilight},
                new SkillDataModel { Description = "Bureacracy", Id = Guid.NewGuid(), Caste = eclipse},
                new SkillDataModel { Description = "Linguistics", Id = Guid.NewGuid(), Caste = eclipse},
                new SkillDataModel { Description = "Ride", Id = Guid.NewGuid(), Caste = eclipse},
                new SkillDataModel { Description = "Sail", Id = Guid.NewGuid(), Caste = eclipse},
                new SkillDataModel { Description = "Socialize", Id = Guid.NewGuid(), Caste = eclipse},
                new SkillDataModel { Description = "Integrity", Id = Guid.NewGuid(), Caste = zenith},
                new SkillDataModel { Description = "Performance", Id = Guid.NewGuid(), Caste = zenith},
                new SkillDataModel { Description = "Presence", Id = Guid.NewGuid(), Caste = zenith},
                new SkillDataModel { Description = "Resistence", Id = Guid.NewGuid(), Caste = zenith},
                new SkillDataModel { Description = "Survival", Id = Guid.NewGuid(), Caste = zenith},
                new SkillDataModel { Description = "Athletics", Id = Guid.NewGuid(), Caste = night},
                new SkillDataModel { Description = "Awareness", Id = Guid.NewGuid(), Caste = night},
                new SkillDataModel { Description = "Dodge", Id = Guid.NewGuid(), Caste = night},
                new SkillDataModel { Description = "Larceny", Id = Guid.NewGuid(), Caste = night},
                new SkillDataModel { Description = "Stealth", Id = Guid.NewGuid(), Caste = night},
                new SkillDataModel { Description = "None", Id = Guid.NewGuid(), Caste = night},
            };

            SkillDataModel war = skills.SingleOrDefault(s => s.Description.ToLower() == "war");

            skills.ForEach(s => context.SkillModel.Add(s));

            context.SaveChanges();

            var charms = new List<CharmDataModel>
            {
                new CharmDataModel 
                {
                    Id = new Random().Next(200), 
                    ComboOk = true,
                    Description = "Add up to your ability + attribute to a war roll",
                    EssanceCost = 1, 
                    ExaltedType = solar,                    
                    HealthCost = 0,
                    MinimumAbility = 1,
                    MinimumEssance = 1,
                    Name = "First War Excellancy",                                   
                    WillPowerCost = 0,
                }
            };

            charms.ForEach(c => context.CharmModel.Add(c));
            context.SaveChanges();
        }

    }
}