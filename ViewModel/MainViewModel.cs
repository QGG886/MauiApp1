using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            TodoItems = new ObservableCollection<string>();
        }
        [ObservableProperty]
        string text;

        [ObservableProperty]
        ObservableCollection<string> todoItems;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            TodoItems.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove(string s)
        {
            if(TodoItems.Contains(s))
                TodoItems.Remove(s);
        }
    }
}
