using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevenNote.Models.NoteModels
{
    public class NoteListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }= null!;
        public string CategoryName { get; set; }= null!;
    }
}