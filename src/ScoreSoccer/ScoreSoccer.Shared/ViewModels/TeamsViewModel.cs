using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScoreSoccer.ViewModels
{
    public class TeamsViewModel
    {

        public ICommand AddTeamButton
        {
            get;
            private set;
        }

        public ICommand EditTeamButton
        {
            get;
            private set;
        }

        public ICommand StatsButton
        {
            get;
            private set;
        }
        public TeamsViewModel()
        {
            AddTeamButton = new AddTeamButtonClick();
            EditTeamButton = new EditTeamButtonClick();
        }
    }
}
