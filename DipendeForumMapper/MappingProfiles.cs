using AutoMapper;
using DipendeForum.Context.Entities;
using DipendeForumDomain.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DipendeForumDomain.Enum;

namespace DipendeForumMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDomain>().ReverseMap();
            CreateMap<Message, MessageDomain>().ReverseMap();

            CreateMap<Post, PostDomain>()
                .ForMember(destination => destination.Category,
                    options => options.MapFrom(source => ToCategoryEnum(source.Category)));


            CreateMap<PostDomain, Post>()
                .ForMember(destination => destination.Category,
                    options => options.MapFrom(source => (byte) source.Category));

        }

        private static CategoryEnum ToCategoryEnum(byte categoryByte)
        {
            return Enum
                .GetValues(typeof(CategoryEnum))
                .Cast<byte>()
                .Contains(categoryByte) ? (CategoryEnum)categoryByte : CategoryEnum.None;
        }

    }
}
