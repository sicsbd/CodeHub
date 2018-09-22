﻿using CodeHub.ViewModels.Settings;
using Windows.UI.Xaml;

namespace CodeHub.Views.Settings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NotificationSettings : SettingsDetailPageBase
    {
        private NofiticationSettingsViewModel ViewModel;

        public NotificationSettings()
        {
            InitializeComponent();

            ViewModel = new NofiticationSettingsViewModel();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            
            DataContext = ViewModel;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            => Bindings.Update();

        private void OnCurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            if (e.NewState != null)
            {
                TryNavigateBackForDesktopState(e.NewState.Name);
            }
        }
    }
}
