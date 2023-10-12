using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models;
using ModelsDTO.DTO.MainPageControllerDTO;

namespace ModelsDTO.Profiles
{
    public class Profiles : Profile
    {
        public Profiles() 
        {
            CreateMap<Produto, ProdutoDTO>();
            CreateMap<ProdutoDTO, Produto>();



        }
    }
}
