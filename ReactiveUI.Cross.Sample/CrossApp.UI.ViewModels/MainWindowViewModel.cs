using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using CrossApp.Contracts.Data.Repositories;
using CrossApp.Data.Models;
using ReactiveUI;

namespace CrossApp.UI.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private readonly IIdeaRepository _ideaRepository;

        public ReactiveList<Idea> Ideas { get; set; }

        public ReactiveCommand CreateIdeaCommand { get; set; }

        public string NewIdeaDescription { get; set; }

        public MainWindowViewModel()
        {
            _ideaRepository = RxApp.MutableResolver.GetService<IIdeaRepository>();

            UpdateAllIdeas();

            CreateIdeaCommand = new ReactiveCommand();
            CreateIdeaCommand.Subscribe((o) => CreateNewIdea());
        }

        private void UpdateAllIdeas()
        {
            var allIdeas = _ideaRepository.GetAllIdeas();

            Ideas = new ReactiveList<Idea>(allIdeas);
        }

        public void CreateNewIdea()
        {
            var newIdea = new Idea(NewIdeaDescription);
            _ideaRepository.CreateIdea(newIdea);
            Ideas.Add(newIdea);
        }
    }
}
