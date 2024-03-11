// Updated by XamlIntelliSenseFileGenerator 11.03.2024 19:24:09
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85E5BA55785386D2247CED322F7D85E1A8F47573"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using pract3;


namespace pract3
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForwardButton;

#line default
#line hidden


#line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;

#line default
#line hidden


#line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayButton;

#line default
#line hidden


#line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RandomButton;

#line default
#line hidden


#line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RepeatButton;

#line default
#line hidden


#line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VolumeSlid;

#line default
#line hidden


#line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openDir;

#line default
#line hidden


#line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowHistory;

#line default
#line hidden


#line 49 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox playlist;

#line default
#line hidden


#line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;

#line default
#line hidden


#line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider musicSlid;

#line default
#line hidden


#line 52 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentTime;

#line default
#line hidden


#line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AllTime;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/pract3;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.basa = ((pract3.MainWindow)(target));

#line 9 "..\..\..\MainWindow.xaml"
                    this.basa.Closed += new System.EventHandler(this.basa_Closed);

#line default
#line hidden
                    return;
                case 2:
                    this.ForwardButton = ((System.Windows.Controls.Button)(target));

#line 31 "..\..\..\MainWindow.xaml"
                    this.ForwardButton.Click += new System.Windows.RoutedEventHandler(this.ForwardButton_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.BackButton = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\MainWindow.xaml"
                    this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.PlayButton = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\..\MainWindow.xaml"
                    this.PlayButton.Click += new System.Windows.RoutedEventHandler(this.PlayButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.RandomButton = ((System.Windows.Controls.Button)(target));

#line 42 "..\..\..\MainWindow.xaml"
                    this.RandomButton.Click += new System.Windows.RoutedEventHandler(this.RandomButton_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.RepeatButton = ((System.Windows.Controls.Button)(target));

#line 43 "..\..\..\MainWindow.xaml"
                    this.RepeatButton.Click += new System.Windows.RoutedEventHandler(this.RepeatButton_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.VolumeSlid = ((System.Windows.Controls.Slider)(target));

#line 44 "..\..\..\MainWindow.xaml"
                    this.VolumeSlid.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSlid_ValueChanged);

#line default
#line hidden
                    return;
                case 8:
                    this.openDir = ((System.Windows.Controls.Button)(target));

#line 47 "..\..\..\MainWindow.xaml"
                    this.openDir.Click += new System.Windows.RoutedEventHandler(this.openDir_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.ShowHistory = ((System.Windows.Controls.Button)(target));

#line 48 "..\..\..\MainWindow.xaml"
                    this.ShowHistory.Click += new System.Windows.RoutedEventHandler(this.ShowHistory_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.playlist = ((System.Windows.Controls.ListBox)(target));

#line 49 "..\..\..\MainWindow.xaml"
                    this.playlist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.playlist_SelectionChanged);

#line default
#line hidden
                    return;
                case 11:
                    this.media = ((System.Windows.Controls.MediaElement)(target));

#line 50 "..\..\..\MainWindow.xaml"
                    this.media.MediaOpened += new System.Windows.RoutedEventHandler(this.media_MediaOpened);

#line default
#line hidden

#line 50 "..\..\..\MainWindow.xaml"
                    this.media.MediaEnded += new System.Windows.RoutedEventHandler(this.media_MediaEnded);

#line default
#line hidden
                    return;
                case 12:
                    this.musicSlid = ((System.Windows.Controls.Slider)(target));

#line 51 "..\..\..\MainWindow.xaml"
                    this.musicSlid.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.musicSlid_ValueChanged);

#line default
#line hidden
                    return;
                case 13:
                    this.CurrentTime = ((System.Windows.Controls.Label)(target));
                    return;
                case 14:
                    this.AllTime = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window basa;
    }
}

