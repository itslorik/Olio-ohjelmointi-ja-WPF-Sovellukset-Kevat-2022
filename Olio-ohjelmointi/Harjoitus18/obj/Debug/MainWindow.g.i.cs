// Updated by XamlIntelliSenseFileGenerator 18.1.2022 13.54.32
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1DDEB9C45EFE1E4E422CB63BDAD8ECA986A98F0CBB5C522B3E5C9F83899A69A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Harjoitus18;
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


namespace Harjoitus18
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_KertoLasku;

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Erotus;

#line default
#line hidden


#line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_JakoLasku;

#line default
#line hidden


#line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Summa;

#line default
#line hidden


#line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Numero;

#line default
#line hidden


#line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Numero2;

#line default
#line hidden


#line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Vastaus;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Harjoitus18;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btn_KertoLasku = ((System.Windows.Controls.Button)(target));

#line 10 "..\..\MainWindow.xaml"
                    this.btn_KertoLasku.Click += new System.Windows.RoutedEventHandler(this.btn_KertoLasku_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.btn_Erotus = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\MainWindow.xaml"
                    this.btn_Erotus.Click += new System.Windows.RoutedEventHandler(this.btn_Erotus_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_JakoLasku = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\MainWindow.xaml"
                    this.btn_JakoLasku.Click += new System.Windows.RoutedEventHandler(this.btn_JakoLasku_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btn_Summa = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\MainWindow.xaml"
                    this.btn_Summa.Click += new System.Windows.RoutedEventHandler(this.btn_Summa_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.txt_Numero = ((System.Windows.Controls.TextBox)(target));

#line 32 "..\..\MainWindow.xaml"
                    this.txt_Numero.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Numero_TextChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.txt_Numero2 = ((System.Windows.Controls.TextBox)(target));

#line 33 "..\..\MainWindow.xaml"
                    this.txt_Numero2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Numero2_TextChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.txt_Vastaus = ((System.Windows.Controls.TextBox)(target));

#line 34 "..\..\MainWindow.xaml"
                    this.txt_Vastaus.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Vastaus_TextChanged);

#line default
#line hidden
                    return;
                case 8:
                    this.btn_Numero1 = ((System.Windows.Controls.Button)(target));
                    return;
                case 9:
                    this.btn_Numero3 = ((System.Windows.Controls.Button)(target));
                    return;
                case 10:
                    this.btn_Numero2 = ((System.Windows.Controls.Button)(target));
                    return;
                case 11:
                    this.btn_Numero5 = ((System.Windows.Controls.Button)(target));
                    return;
                case 12:
                    this.btn_Numero4 = ((System.Windows.Controls.Button)(target));

#line 39 "..\..\MainWindow.xaml"
                    this.btn_Numero4.Click += new System.Windows.RoutedEventHandler(this.btn_Numero1_Copy3_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.btn_Numero6 = ((System.Windows.Controls.Button)(target));
                    return;
                case 14:
                    this.btn_Numero7 = ((System.Windows.Controls.Button)(target));
                    return;
                case 15:
                    this.btn_Numero8 = ((System.Windows.Controls.Button)(target));
                    return;
                case 16:
                    this.btn_Numero9 = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

