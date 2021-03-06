﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SimpleMVVMAttempt.Models;


namespace SimpleMVVMAttempt.ViewModels
{
    public class Presenter : ObservableObject
    {
        private readonly TextConverter _textConverter = new TextConverter(s => s.ToUpper());
        private string _someText;
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();
      

        public string SomeText
        {
            get { return _someText; }

            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }

        }

        public IEnumerable History
        {
            get { return _history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            if (!string.IsNullOrWhiteSpace(SomeText))
            {
                AddToHistory(_textConverter.ConvertText(SomeText));
                SomeText = string.Empty;
            }
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
            {
                _history.Add(item);
            }
        }
    }
}
