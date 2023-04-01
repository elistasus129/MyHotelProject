using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ServiceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            //CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            //CreateMap<LoginUserDto, AppUser>().ReverseMap();

            //CreateMap<ResultAboutDto, About>().ReverseMap();
            //CreateMap<UpdateAboutDto, About>().ReverseMap();

            //CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            //CreateMap<ResultStaffDto, Staff>().ReverseMap();

            //CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            //CreateMap<CreateBookingDto, Booking>().ReverseMap();
            //CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            //CreateMap<CreateGuestDto, Guest>().ReverseMap();
            //CreateMap<UpdateGuestDto, Guest>().ReverseMap();
        }
    }
}
