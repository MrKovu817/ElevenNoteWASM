using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevenNote.Models.NoteModels
{
    public class NoteEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }= null!;
        [Required]
        public string Title { get; set; }= null!;
        [Required]
        public int CategoryId { get; set; }
        // Make sure to assign the Modified date within the service tier/layer
    }
}