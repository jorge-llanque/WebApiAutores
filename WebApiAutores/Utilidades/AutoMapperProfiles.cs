using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.DTOs;
using WebApiAutores.Entidades;

namespace WebApiAutores.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorCreacionDTO, Autor>();
            CreateMap<Autor, AutorDTO>();

            CreateMap<LibroCreactionDTO, Libro>()
                .ForMember(libro => libro.AutoresLibros, opciones => opciones.MapFrom(MapAutoresLibros));
            CreateMap<Libro, LibroDTO>();

            CreateMap<ComentarioCreacionDTO, Comentario>();
            CreateMap<Comentario, ComentarioDTO>();
        }

        private List<AutorLibro> MapAutoresLibros(LibroCreactionDTO libroCreactionDTO, Libro libro)
        {
            var resultado = new List<AutorLibro>();
            if(libroCreactionDTO.AutoresIds == null)
            {
                return resultado;
            }

            foreach (var autorId in libroCreactionDTO.AutoresIds)
            {
                resultado.Add(new AutorLibro()
                {
                    AutorId = autorId
                });
            }
            return resultado;
        }
    }
}
