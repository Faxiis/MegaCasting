﻿#pragma checksum "..\..\..\..\Views\PartnerView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4D0FB1B8CEAB5750D4E48E06E47A28CD28D61363"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MegaCasting.WPFClient.Views;
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


namespace MegaCasting.WPFClient.Views {
    
    
    /// <summary>
    /// PartnerView
    /// </summary>
    public partial class PartnerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatagridDiffusionPartner;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveDiffusionPartner;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteDiffusionPartner;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Phone;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\PartnerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDiffusionPartner;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPFClient;V1.0.0.0;component/views/partnerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PartnerView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DatagridDiffusionPartner = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.SaveDiffusionPartner = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Views\PartnerView.xaml"
            this.SaveDiffusionPartner.Click += new System.Windows.RoutedEventHandler(this.SaveDiffusionPartner_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteDiffusionPartner = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\PartnerView.xaml"
            this.DeleteDiffusionPartner.Click += new System.Windows.RoutedEventHandler(this.DeleteDiffusionPartner_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\..\Views\PartnerView.xaml"
            this.Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\..\Views\PartnerView.xaml"
            this.Phone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Phone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\..\Views\PartnerView.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddDiffusionPartner = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Views\PartnerView.xaml"
            this.AddDiffusionPartner.Click += new System.Windows.RoutedEventHandler(this.AddDiffusionPartner_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

