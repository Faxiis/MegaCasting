﻿#pragma checksum "..\..\..\..\Views\ClientView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AFF57B5BDC863491F4043BA8CB5D6A6D2939FF7"
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
    /// ClientView
    /// </summary>
    public partial class ClientView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatagridClient;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveClient;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteClient;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Prenom;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nom;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telephone;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Adresse;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodePostal;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ville;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\ClientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClient;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPFClient;component/views/clientview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ClientView.xaml"
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
            this.DatagridClient = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.SaveClient = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Views\ClientView.xaml"
            this.SaveClient.Click += new System.Windows.RoutedEventHandler(this.SaveClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteClient = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Views\ClientView.xaml"
            this.DeleteClient.Click += new System.Windows.RoutedEventHandler(this.DeleteClient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Prenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\..\Views\ClientView.xaml"
            this.Prenom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Prenom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Nom = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\Views\ClientView.xaml"
            this.Nom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Nom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.telephone = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\..\Views\ClientView.xaml"
            this.telephone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.telephone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\ClientView.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Adresse = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\Views\ClientView.xaml"
            this.Adresse.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Adresse_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CodePostal = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\..\Views\ClientView.xaml"
            this.CodePostal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CodePostal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Ville = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\..\Views\ClientView.xaml"
            this.Ville.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ville_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AddClient = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\Views\ClientView.xaml"
            this.AddClient.Click += new System.Windows.RoutedEventHandler(this.AddClient_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

