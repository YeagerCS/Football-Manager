﻿#pragma checksum "..\..\..\TeamManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FDD5FD7C8466F511A3072C496BA28BF143A4F5C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Football_Manager;
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


namespace Football_Manager {
    
    
    /// <summary>
    /// TeamManagement
    /// </summary>
    public partial class TeamManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label benchlbl;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox startingLbx;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox benchLbx;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button substituteBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label benchlbl_Copy;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ratingLbl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sellBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\TeamManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sellPrice;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Football Manager;V1.0.0.0;component/teammanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TeamManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.benchlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.startingLbx = ((System.Windows.Controls.ListBox)(target));
            
            #line 13 "..\..\..\TeamManagement.xaml"
            this.startingLbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.startingLbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.benchLbx = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\..\TeamManagement.xaml"
            this.benchLbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.benchLbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.substituteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\TeamManagement.xaml"
            this.substituteBtn.Click += new System.Windows.RoutedEventHandler(this.substituteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\TeamManagement.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.benchlbl_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ratingLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.sellBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\TeamManagement.xaml"
            this.sellBtn.Click += new System.Windows.RoutedEventHandler(this.sellBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.sellPrice = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
