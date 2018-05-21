using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PeopleSearch.Models;
using PeopleSearch.DTOs;

namespace PeopleSearch.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Person, PersonDTO>();
            Mapper.CreateMap<PersonDTO, Person>().ForMember(p => p.Id, opt => opt.Ignore());
        }
    }
}