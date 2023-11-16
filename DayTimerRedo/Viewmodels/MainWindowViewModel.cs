﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTimerRedo.Viewmodels
{
    public class MainWindowViewModel : BaseViewmodel
    {
        private string _timeRemainingFormatted = "00:00.00";
        public string TimeRemainingFormatted
        {
            get => _timeRemainingFormatted;
            set
            {
                _timeRemainingFormatted = value;
                NotifyPropertyChanged(nameof(TimeRemainingFormatted));
            }
        }

        public void FormatTimeRemaining(TimeSpan duration)
        {
            string hours = duration.Hours > 9 ? $"{duration.Hours}" : $"0{duration.Hours}";
            string minutes = duration.Minutes > 9 ? $"{duration.Minutes}" : $"0{duration.Minutes}";
            string seconds = duration.Seconds > 9 ? $"{duration.Seconds}" : $"0{duration.Seconds}";
            TimeRemainingFormatted = $"{hours}:{minutes}.{seconds}";
        }
    }
}