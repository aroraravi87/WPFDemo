using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WPFAppDemo_DTO.Customer;
using WPFAppDemo_DTO.Account;
using WPFAppDemo_Library.Model;

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
