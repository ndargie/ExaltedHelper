using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ExaltedHelper.Models;
using ExaltedHelper.DAL;

namespace ExaltedHelper.Mappers
{
    public static class InitialiseMappers 
    {
        public static void RegisterMappings()
        {
            CharmContext db = new CharmContext();
            Mapper.CreateMap<CharmDataModel, CharmEditViewModel>()
                .ForMember(dest => dest.ExaltedType, opt => opt.MapFrom(src => src.ExaltedType.Description))
                .ForMember(dest => dest.EssanceRequirement, opt => opt.MapFrom(src => src.MinimumEssance))
                .ForMember(dest => dest.AbilityRequirement, opt => opt.MapFrom(src => src.MinimumAbility));
            Mapper.CreateMap<CharmEditViewModel, CharmDataModel>()
                .ForMember(dest => dest.MinimumEssance, opt => opt.MapFrom(src => src.EssanceRequirement))
             
                   .ForMember(dest => dest.MinimumAbility, opt => opt.MapFrom(src => src.AbilityRequirement))
                .ForMember(dest => dest.ExaltedType, opt => opt.MapFrom(src => db.ExaltedTypeModel.Single(x => x.Description == src.ExaltedType)))
                .ForMember(dest => dest.ExaltedTypeDataModelId, opt => opt.MapFrom(src => db.ExaltedTypeModel.Single(x => x.Description == src.ExaltedType).Id));
            Mapper.CreateMap<CharmViewModel, CharmDataModel>()
                .ForMember(dest => dest.ComboOk, opt => opt.MapFrom(src => src.ComboOk))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.EssanceCost, opt => opt.MapFrom(src => src.EssanceCost))
                .ForMember(dest => dest.ExaltedType, opt => opt.MapFrom(src => db.ExaltedTypeModel.Single(x => x.Id == src.SelectedExaltedType)))
                .ForMember(dest => dest.ExaltedTypeDataModelId, opt => opt.MapFrom(src => src.SelectedExaltedType))
                .ForMember(dest => dest.HealthCost, opt => opt.MapFrom(src => src.HealthCost))
                .ForMember(dest => dest.MinimumAbility, opt => opt.MapFrom(src => src.AbilityRequirement))
                .ForMember(dest => dest.MinimumEssance, opt => opt.MapFrom(src => src.EssanceRequirement));
               Mapper.CreateMap<ExaltedTypeDataModel, ExaltedTypeViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Description));
            Mapper.CreateMap<ExaltedTypeViewModel, ExaltedTypeDataModel>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Name));
            Mapper.AssertConfigurationIsValid();
        }
    }
}