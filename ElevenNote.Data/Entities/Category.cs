using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevenNote.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; } = null!;
        public List<Note> Notes { get; set; }= new List<Note>();
    }
}