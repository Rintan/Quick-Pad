﻿using Windows.ApplicationModel.Resources;
using QuickPad.Mvvm.ViewModels;

namespace QuickPad.UI.Helpers
{
    public class DisplayMode : IDisplayMode
    {
        private ResourceLoader _resourceLoader;
        private string _text = null;
            
        public string Uid { get; }
        public string Text 
        { 
            get 
            {
                if (_text == null)
                {
                    if (_resourceLoader == null) _resourceLoader = ResourceLoader.GetForCurrentView();

                    _text = _resourceLoader.GetString($"{Uid}");
                }

                return _text;
            } 
        }

        public DisplayMode(string uid)
        {
            Uid = uid;
        }
    }
}
