using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossApp.Data.Models;

namespace CrossApp.Contracts.Data.Repositories
{
    public interface IIdeaRepository
    {
        void CreateIdea(Idea idea);
        void DeleteIdea(Idea idea);
        List<Idea> GetAllIdeas();
        int GetIdeaCount();
        int GetRejectedIdeaCount();
    }
}
