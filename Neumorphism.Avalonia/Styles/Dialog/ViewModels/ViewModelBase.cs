﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Neumorphism.Avalonia.Styles.Dialog.ViewModels
{
    public class DialogViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}