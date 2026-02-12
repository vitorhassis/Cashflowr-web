using AutoMapper;
using Cashflow.Models;
using Cashflowr.Data.Dtos;


namespace Cashflowr.Profiles
{
    public class EntradaProfile : Profile
    {
        public EntradaProfile()
        {
            // ENTRADA
            CreateMap<Entradas, ReadEntradaDto>()
                .ForMember(dest => dest.Nome,
                           opt => opt.MapFrom(src => src.Nome.ToString()));

            CreateMap<CreateEntradaDto, Entradas>();
            CreateMap<UpdateEntradaDto, Entradas>();


            // RESERVA
            CreateMap<Reserva, ReadReservaDto>()
                .ForMember(dest => dest.Tipo,
                           opt => opt.MapFrom(src => src.Tipo.ToString()));

            CreateMap<CreateReservaDto, Reserva>();
            CreateMap<UpdateReservaDto, Reserva>();

            //SAIDA CATEGORIA
            CreateMap<Saida, ReadSaidaDto>()
                .ForMember(dest => dest.Categoria,
                           opt => opt.MapFrom(src => src.Categoria.ToString()));

            CreateMap<CreateSaidaDto, Saida>();
            CreateMap<UpdateSaidaDto, Saida>();

            //SAIDA FORMA DE PAGAMENTO
            CreateMap<Saida, ReadSaidaDto>()
                .ForMember(dest => dest.FormaDePagamento,
                          opt => opt.MapFrom(src => src.FormaDePagamento.ToString()));




        }
    }

}
