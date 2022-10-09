using AutoMapper;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.Mappers
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            /*
                This is where we are mapping from 
                entity to view model and vice versa.
            */
            CreateMap<Users, DTOUser>().ReverseMap();
            CreateMap<Advertise, DTOAdvertise>()
                .ForMember(dest => dest.AdvertiseID,opt=>opt.MapFrom(src=>src.Id))
                .ForMember(dest => dest.Caption,opt=>opt.MapFrom(src=>src.Caption))
                .ForMember(dest => dest.Name,opt=>opt.MapFrom(src=>src.Name))
                .ForMember(dest => dest.MediaSourceURL, opt=>opt.MapFrom(src=>src.MediaSourceURL))
                .ForMember(dest => dest.IsVideo, opt=>opt.MapFrom(src=>src.IsVideo))
                .ForMember(dest => dest.CreationDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Likers, opt => opt.Ignore())
                .ForMember(dest => dest.Owner, opt => opt.Ignore())
                .ForMember(dest => dest.Viewers, opt => opt.Ignore())
                .ForMember(dest => dest.LikerCount, opt => opt.Ignore())
                .ForMember(dest => dest.ViewerCount, opt => opt.Ignore())
                .ForMember(dest => dest.LikeReward, opt => opt.Ignore())
                .ForMember(dest => dest.ViewReward, opt => opt.Ignore())
                .ForMember(dest => dest.YouLiked, opt => opt.Ignore())
                .ForMember(dest => dest.IsAvtivated, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<Draws, DTODraws>().ReverseMap();
        }
    }
}
