using AutoMapper;

namespace EmployeeWebAPI.Models
{
    public class CustomerProfile : Profile
    {

        public CustomerProfile()
        {

            CreateMap<CustomerSource, CustomerDestination>().ForMember(dest=>dest.Id,opt=>opt.MapFrom("CustId"))
                                                            .ForMember(dest => dest.Name, opt => opt.MapFrom("CustName"));


        }
    }
}
