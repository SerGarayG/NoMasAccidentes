﻿#pragma checksum "..\..\AdministracionReportes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D6FD2425DB1BB0CC6E644D7E4D60004333C9A4AC6FA08BBDB430DA5D4ED8E12"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using NoMasAccidentesv2;
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


namespace NoMasAccidentesv2 {
    
    
    /// <summary>
    /// AdministracionReportes
    /// </summary>
    public partial class AdministracionReportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AdministracionReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentanaReportes;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdministracionReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PlanMasContratado;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AdministracionReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_EmpresaMasAccidentes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AdministracionReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ExtraMasSolicitado;
        
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
            System.Uri resourceLocater = new System.Uri("/NoMasAccidentesv2;component/administracionreportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdministracionReportes.xaml"
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
            this.btnVentanaReportes = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AdministracionReportes.xaml"
            this.btnVentanaReportes.Click += new System.Windows.RoutedEventHandler(this.btnVentanaReportes_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_PlanMasContratado = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AdministracionReportes.xaml"
            this.btn_PlanMasContratado.Click += new System.Windows.RoutedEventHandler(this.btn_PlanMasContratado_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_EmpresaMasAccidentes = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AdministracionReportes.xaml"
            this.btn_EmpresaMasAccidentes.Click += new System.Windows.RoutedEventHandler(this.btn_EmpresaMasAccidentes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_ExtraMasSolicitado = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AdministracionReportes.xaml"
            this.btn_ExtraMasSolicitado.Click += new System.Windows.RoutedEventHandler(this.btn_ExtraMasSolicitado_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
