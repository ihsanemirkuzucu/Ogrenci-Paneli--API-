using AutoMapper;
using DataModels = StudentManagement.DataModels;
using StudentManagement.DomainModels;
using StudentManagement.Profiles.AfterMaps;

namespace StudentManagement.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>().ReverseMap();
            CreateMap<DataModels.Gender, Gender>().ReverseMap();
            CreateMap<DataModels.Address, Address>().ReverseMap();
            CreateMap<UpdateStudentRequest,DataModels.Student>().AfterMap<UpdateStudentRequestAfterMap>();
            CreateMap<AddStudentRequest,DataModels.Student>().AfterMap<AddStudentRequestAfterMap>();
        }
    }
}
