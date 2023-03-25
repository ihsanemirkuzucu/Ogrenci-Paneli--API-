using AutoMapper;
using StudentManagement.DomainModels;
using System;
using DataModels = StudentManagement.DataModels;
namespace StudentManagement.Profiles.AfterMaps
{
    public class AddStudentRequestAfterMap : IMappingAction<AddStudentRequest, DataModels.Student>
    {
        public void Process(AddStudentRequest source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Address = new DataModels.Address()
            {
                Id = Guid.NewGuid(),
                PhysicalAdress = source.PhysicalAdress,
                PostalAdress = source.PostalAdress
            };
        }
    }
}
