using AutoMapper;
using Concessionario;
using Core._02Entidades.DTO;
using Core._02Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02Entidades
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {


            CreateMap<CarroDTO, Carro>().ReverseMap();

            CreateMap<CaminhaoDTO, Caminhao>().ReverseMap();
        }
    }

}
