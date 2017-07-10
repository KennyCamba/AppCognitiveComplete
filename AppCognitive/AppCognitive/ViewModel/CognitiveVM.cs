﻿using System.Collections.ObjectModel;

namespace AppCognitive.ViewModel
{
    public class CognitiveVM
    {
        public CognitiveVM()
        {
            LoadMenu();
        }
        public ObservableCollection<MenuItemVM> Menu { get; set; }

        #region Commands
       /* public ICommand GoCommand {
            get { return new RelayCommand<String>(Go); }
        }

        private void Go(string pageName)
        {
            switch (pageName)
            {
                case "UsPage":
                    App.Navigator.PushAsync(new UsPage());
                    break;
                default:
                    break;
            }
        }*/
        #endregion

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemVM>
            {
                new MenuItemVM()
                {
                    Icon = "ic_add_photo",
                    Title = "Capturar",
                    PageName = "NewCapturePage"
                },

                new MenuItemVM()
                {
                    Icon = "ic_select",
                    Title = "Seleccionar",
                    PageName = "SelectPage"
                },

                new MenuItemVM()
                {
                    Icon = "ic_resultCS",
                    Title = "Resultado",
                    PageName = "ResultPage"
                },

                new MenuItemVM()
                {
                    Icon = "ic_share",
                    Title = "Compartir",
                    PageName = "SharePage"
                },

                new MenuItemVM()
                {
                    Icon = "ic_us",
                    Title = "Nosotros",
                    PageName = "UsPage"
                }
            };
        }
    }
}
