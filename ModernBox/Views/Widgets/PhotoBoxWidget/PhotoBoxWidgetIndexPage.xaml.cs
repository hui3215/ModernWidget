// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using ModernBox.Helpers;
using ModernBox.Models;
using ModernBox.ViewModels.Widgets.PhotoBoxWidget;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ModernBox.Views.Widgets.PhotoBoxWidget;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class PhotoBoxWidgetIndexPage : Page
{
    public PhotoBoxWidgetViewModel viewModel
    {
        get; set;
    }
    public PhotoBoxWidgetIndexPage()
    {
        this.InitializeComponent();
        viewModel = App.GetService<PhotoBoxWidgetViewModel>();
        this.DataContext= viewModel;
    }



    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        var parameter = (WidgetSize)e.Parameter  ;
        this.Width = WidgetSizeHelper.getWidth(parameter);
        this.Height = WidgetSizeHelper.getHeight(parameter);
        
    }


}
