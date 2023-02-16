using AutoMapper;
using ElevenNote.Data.Entities;
using ElevenNote.Models.CategoryModels;
using ElevenNote.Models.NoteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevenNote.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Category,CategoryCreate>().ReverseMap();
            CreateMap<Category,CategoryDetail>().ReverseMap();
            CreateMap<Category,CategoryListItem>().ReverseMap();

            CreateMap<Note,NoteCreate>().ReverseMap();
            CreateMap<Note,NoteListItem>().ReverseMap();
            CreateMap<Note,NoteDetail>().ReverseMap();
            CreateMap<Note,NoteEdit>().ReverseMap();
        }
    }
}