using AutoMapper;
using ProjectMiniShop.Models;
using ProjectMiniShop.Models.DTO;

namespace ProjectMiniShop
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product,ProductDTO>().ReverseMap();
        }
    }
}
