﻿#pragma checksum "..\..\user_pg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FD95D4953BA6B72E7FE3E57C3CDACEE1191DC7DAB74991BF6493A943A33A523"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp27;


namespace WpfApp27 {
    
    
    /// <summary>
    /// user_pg
    /// </summary>
    public partial class user_pg : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\user_pg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Completed;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\user_pg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid pend;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\user_pg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_txt;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\user_pg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_butt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\user_pg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp27;component/user_pg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\user_pg.xaml"
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
            this.Completed = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\user_pg.xaml"
            this.Completed.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Completed_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pend = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\user_pg.xaml"
            this.pend.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pend_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.id_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.save_butt = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\user_pg.xaml"
            this.save_butt.Click += new System.Windows.RoutedEventHandler(this.save_butt_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\user_pg.xaml"
            this.cb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

