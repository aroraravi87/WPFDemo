using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WpfAppDemo_Library.Model;
using WPFAppDemo_DTO.Customer;
using WPFAppDemo_DTO.Account;
namespace WPFDemo_AutoMapper
{
    public class ObjectMapper : IObjectMapper
    {
        public void CreateMap()
        {
            MapObjectOfAdministration();
        }

        private void MapObjectOfAdministration()
        {
            Mapper.CreateMap<AccountDTO, User>();
            Mapper.CreateMap<User, AccountDTO>();
            Mapper.CreateMap<CustomerDTO,Customer>();
            Mapper.CreateMap<Customer, CustomerDTO>();

        }
    }
}
