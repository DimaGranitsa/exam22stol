﻿#pragma checksum "..\..\..\Development Pages\themainwindowfortheadmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD7DE2E46CBB45B08EDA3F7374BB0FD568DF458E383E2C55B6721D8C37A0A8D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using exam22stol.Development_Pages;


namespace exam22stol.Development_Pages {
    
    
    /// <summary>
    /// themainwindowfortheadmin
    /// </summary>
    public partial class themainwindowfortheadmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame f;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button foto;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lic;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/exam22stol;component/development%20pages/themainwindowfortheadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.f = ((System.Windows.Controls.Frame)(target));
            
            #line 17 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
            this.f.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.f_Navigated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.foto = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
            this.foto.Click += new System.Windows.RoutedEventHandler(this.foto_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.kar = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
            this.kar.Click += new System.Windows.RoutedEventHandler(this.kar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lic = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Development Pages\themainwindowfortheadmin.xaml"
            this.lic.Click += new System.Windows.RoutedEventHandler(this.lic_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
