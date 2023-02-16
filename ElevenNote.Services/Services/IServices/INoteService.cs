using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Models.NoteModels;

namespace ElevenNote.Services.Services.IServices
{
    public interface INoteService
    {
        Task<bool> CreateNote(NoteCreate model);
        Task<bool> UpdateNote(NoteEdit model);
        Task<bool> DeleteNote(int id);
        Task<List<NoteListItem>> GetNotes();
        Task<NoteDetail> GetNote(int id);
    }
}