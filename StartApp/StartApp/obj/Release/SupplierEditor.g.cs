﻿#pragma checksum "..\..\SupplierEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "598C5449F7AFBB8D4B1AF2F8F6B968672A22733962F1E2D396FBBDA5E1003C02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StartApp;
using StartApp.ValidationRules;
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


namespace StartApp {
    
    
    /// <summary>
    /// SupplierEditor
    /// </summary>
    public partial class SupplierEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal StartApp.SupplierEditor supplierEditorWindow;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SupplierEditorMainGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTitle;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCompanyName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContactName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContactTitle;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCity;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRegion;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPostalCode;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCountry;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFax;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHomePage;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\SupplierEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/StartApp;component/suppliereditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SupplierEditor.xaml"
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
            this.supplierEditorWindow = ((StartApp.SupplierEditor)(target));
            
            #line 10 "..\..\SupplierEditor.xaml"
            this.supplierEditorWindow.Closing += new System.ComponentModel.CancelEventHandler(this.supplierEditorWindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SupplierEditorMainGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 12 "..\..\SupplierEditor.xaml"
            this.SupplierEditorMainGrid.KeyDown += new System.Windows.Input.KeyEventHandler(this.SaveOrCancelKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtCompanyName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtContactName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtContactTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtRegion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtPostalCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtCountry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtFax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.txtHomePage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
