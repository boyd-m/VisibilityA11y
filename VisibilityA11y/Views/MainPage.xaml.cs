using System;
using System.ComponentModel;
using VisibilityA11y.ViewModels;
using Xamarin.Forms;

namespace VisibilityA11y.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainViewModel viewModel;
        
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainViewModel
            {
                IsVisible = false
            };
            BindingContext = viewModel;
        }

        public void Button_Pressed(object sender, EventArgs e)
        {
            viewModel.IsVisible = !viewModel.IsVisible;
        }
    }
}