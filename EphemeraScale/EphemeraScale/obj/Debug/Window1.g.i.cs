﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D695CF79FB431E055DF0F31CE129AF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace EphemeraScale {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EphemeraScale.Window1 EventTimeManagement;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ephGridTimeManagement;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TimeManagementSubmit;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hours_begin_txtbx;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hours_end_txtbx;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minutes_begin_txtbx;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minutes_end_txtbx;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_showchng_hoursBegin;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_showchng_hoursEnd;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_showchng_minutesBegin;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_showchng_minutesEnd;
        
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
            System.Uri resourceLocater = new System.Uri("/EphemeraScale;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.EventTimeManagement = ((EphemeraScale.Window1)(target));
            return;
            case 2:
            this.ephGridTimeManagement = ((System.Windows.Controls.Grid)(target));
            
            #line 5 "..\..\Window1.xaml"
            this.ephGridTimeManagement.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.minutesend_previewtext);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TimeManagementSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Window1.xaml"
            this.TimeManagementSubmit.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.submit_IsClicked);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Window1.xaml"
            this.TimeManagementSubmit.Click += new System.Windows.RoutedEventHandler(this.submit_IsClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hours_begin_txtbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\Window1.xaml"
            this.hours_begin_txtbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.hoursbegin_previewtext);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hours_end_txtbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\Window1.xaml"
            this.hours_end_txtbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.hoursend_previewtext);
            
            #line default
            #line hidden
            return;
            case 6:
            this.minutes_begin_txtbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\Window1.xaml"
            this.minutes_begin_txtbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.minutesbegin_previewtext);
            
            #line default
            #line hidden
            return;
            case 7:
            this.minutes_end_txtbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lbl_showchng_hoursBegin = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lbl_showchng_hoursEnd = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lbl_showchng_minutesBegin = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lbl_showchng_minutesEnd = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
