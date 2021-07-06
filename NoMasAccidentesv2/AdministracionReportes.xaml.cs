using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para AdministracionReportes.xaml
    /// </summary>
    public partial class AdministracionReportes : Window
    {
        public AdministracionReportes()
        {
            InitializeComponent();
        }
      
        private void btnVentanaReportes_Click(object sender, RoutedEventArgs e)
        {
            AdministracionReportes r = new AdministracionReportes();
            this.Close();
            r.ShowDialog();
        }

        private void btn_PlanMasContratado_Click(object sender, RoutedEventArgs e)
        {
            PlanMasContratado p = new PlanMasContratado();
            this.Close();
            p.ShowDialog();
        }

        private void btn_EmpresaMasAccidentes_Click(object sender, RoutedEventArgs e)
        {
            EmpresConMasAccidentes p = new EmpresConMasAccidentes();
            this.Close();
            p.ShowDialog();
        }

        private void btn_ExtraMasSolicitado_Click(object sender, RoutedEventArgs e)
        {
            AsesoriaMasRealizada p = new AsesoriaMasRealizada();
            this.Close();
            p.ShowDialog();

        }
    }
}
