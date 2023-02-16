using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;
using ElevenNote.Models.CategoryModels;

namespace ElevenNote.Models.NoteModels
{
    public class NoteDetail
    {
        public int Id { get; set; }
        public string Content { get; set; }= null!;
        public string Title { get; set; }= null!;
        public virtual CategoryListItem Category { get; set; }= null!;
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}