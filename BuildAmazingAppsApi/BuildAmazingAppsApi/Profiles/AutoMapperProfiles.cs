using AutoMapper;
using BuildAmazingAppsApi.DomainModels;
using DataModels = BuildAmazingAppsApi.DataModels;


namespace BuildAmazingAppsApi.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
              .ReverseMap();

            CreateMap<DataModels.Address, Address>()
              .ReverseMap();
        }
    }
}
