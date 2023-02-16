using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;
using ElevenNote.Models.NoteModels;

namespace ElevenNote.Models.CategoryModels
{
    public class CategoryDetail
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public List<NoteListItem> Notes { get; set; }= new List<NoteListItem>();
    }
}