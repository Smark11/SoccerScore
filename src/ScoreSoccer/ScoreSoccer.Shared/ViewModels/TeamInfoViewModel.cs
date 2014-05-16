using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScoreSoccer.ViewModels
{
    public class TeamInfoViewModel
    {

          public ICommand SaveTeamButton
        {
            get;
            private set;
        }

          public TeamInfoViewModel()
        {           
            SaveTeamButton = new SaveTeamButtonClick();
        }

    }
}
