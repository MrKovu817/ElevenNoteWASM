using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevenNote.Models.NoteModels
{
    public class NoteCreate
    {
        [Required]
        public string Content { get; set; }= null!;
        [Required]
        public string Title { get; set; }= null!;
        [Required]
        public int CategoryId { get; set; }
        // Make sure to assign the current date within the service tier/layer
    }
}