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
            CreateMap<Users, DTOUser>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Family, opt => opt.MapFrom(src => src.Family))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.IsActivated, opt => opt.MapFrom(src => src.IsActivated))
                .ForMember(dest => dest.ProfileMediaURL, opt => opt.MapFrom(src => src.ProfileMediaURL))
                .ReverseMap();
            CreateMap<Advertise, DTOAdvertise>()
                .ForMember(dest => dest.AdvertiseID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Caption, opt => opt.MapFrom(src => src.Caption))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.MediaSourceURL, opt => opt.MapFrom(src => src.MediaSourceURL))
                .ForMember(dest => dest.IsVideo, opt => opt.MapFrom(src => src.IsVideo))
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
            CreateMap<Draws, DTODraws>()
                .ForMember(dest => dest.DrawId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.OwnerId, opt => opt.MapFrom(src => src.Owner))
                .ForMember(dest => dest.Prizes, opt => opt.Ignore())
                .ForMember(dest => dest.Owner, opt => opt.Ignore())
                .ForMember(dest => dest.PrizeWinners, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<Prizes, DTOPrize>()
                .ForMember(dest => dest.PrizeId, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}
