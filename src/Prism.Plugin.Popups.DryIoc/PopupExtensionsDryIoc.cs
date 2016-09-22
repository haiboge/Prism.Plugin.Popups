﻿using DryIoc;
using Prism.DryIoc;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace Prism.Navigation
{
    public static partial class PopupExtensions
    {
        static IContainer s_container
        {
            get { return ( Application.Current as PrismApplication ).Container; }
        }

        private static PopupPage CreatePopupPageByName( string name )
        {
            return s_container.Resolve<object>( name ) as PopupPage;
        }
    }
}