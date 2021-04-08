using AutoMapper;
using DipendeForum.Context.Entities;
using DipendeForumDomain.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForumMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDomain>().ReverseMap();
        }
    }
}
