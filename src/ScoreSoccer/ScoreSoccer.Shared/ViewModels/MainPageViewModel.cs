using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScoreSoccer.ViewModels
{
    public class MainPageViewModel
    {
          public ICommand TeamsButton
        {
            get;
            private set;
        }

          public MainPageViewModel()
        {
            TeamsButton = new TeamsButtonClick();
        }
    }
}
