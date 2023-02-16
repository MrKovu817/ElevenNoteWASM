using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElevenNote.Data.DatabaseContext;
using ElevenNote.Data.Entities;
using ElevenNote.Models.NoteModels;
using ElevenNote.Services.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Services.Services
{
    public class NoteService : INoteService
    {
        private readonly AppDbContext _dbContext;
        private IMapper _mapper;

        public NoteService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreateNote(NoteCreate model)
        {
            var note = _mapper.Map<Note>(model);
            await _dbContext.Notes.AddAsync(note);
            return await _dbContext.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteNote(int id)
        {
            var note = await _dbContext.Notes.FindAsync(id);
            if(note is null) return false;
            _dbContext.Notes.Remove(note);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<NoteDetail> GetNote(int id)
        {
            return _mapper.Map<NoteDetail>(await _dbContext.Notes.FindAsync(id));
        }

        public async Task<List<NoteListItem>> GetNotes()
        {
            return _mapper.Map<List<NoteListItem>>(await _dbContext.Notes.ToListAsync());
        }

        public async Task<bool> UpdateNote(NoteEdit model)
        {
            var noteInDb = await _dbContext.Notes.FindAsync(model.Id);
            if(noteInDb is null) return false;
            
            var note = _mapper.Map<Note>(model);
            _dbContext.Notes.Update(note);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}