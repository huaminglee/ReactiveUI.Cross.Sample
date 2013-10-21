using System.Collections.Generic;
using System.Linq;
using CrossApp.Contracts.Data.Repositories;
using CrossApp.Data.Models;

namespace CrossApp.Services.Repositories
{
    public class IdeaRepository : IIdeaRepository
    {
        // fake a database, for now
        // not thread-safe - you've been warned
        readonly static List<Idea> _ideasCreated = new List<Idea>();

        public IdeaRepository()
        {
            CreateIdea(new Idea("Idea 1") { Rejected = false });
            CreateIdea(new Idea("Idea 2") { Rejected = false });
            CreateIdea(new Idea("Idea 3") { Rejected = false });
            CreateIdea(new Idea("Idea 4") { Rejected = false });
        }

        public void CreateIdea(Idea idea)
        {
            _ideasCreated.Add(idea);
        }

        public void DeleteIdea(Idea idea)
        {
            _ideasCreated.Remove(idea);
        }

        public List<Idea> GetAllIdeas()
        {
            return _ideasCreated;
        }

        public int GetIdeaCount()
        {
            return _ideasCreated.Count();
        }

        public int GetRejectedIdeaCount()
        {
            return _ideasCreated.Count(i => i.Rejected);
        }
    }
}
