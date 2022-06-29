﻿// Copyright (c) Richasy. All rights reserved.

using System;
using Bili.App.Pages.Base;
using Windows.UI.Xaml;

namespace Bili.App.Pages.Xbox
{
    /// <summary>
    /// 动态页面.
    /// </summary>
    public sealed partial class DynamicPage : DynamicPageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPage"/> class.
        /// </summary>
        public DynamicPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
            => ViewModel.VideoModule.InitializeCommand.Execute().Subscribe();
    }
}