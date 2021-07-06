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
    /// Lógica de interacción para EmpresConMasAccidentes.xaml
    /// </summary>
    public partial class EmpresConMasAccidentes : Window
    {
        public EmpresConMasAccidentes()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE=localhost:1521/xe; user id = c##BDv1; password= duoc");

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();

        }

        private void btnVentanaReportes_Click(object sender, RoutedEventArgs e)
        {
            AdministracionReportes r = new AdministracionReportes();
            this.Close();
            r.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            OracleCommand cmd = new OracleCommand("REPORTEEMPRESACONMASACCIDENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("fInicio", OracleDbType.Date).Value = dpInicio.SelectedDate;
            cmd.Parameters.Add("fTermino", OracleDbType.Date).Value = dpTermino.SelectedDate;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.Close();

            dgEmpresaConMasAccidentes.ItemsSource = dt.DefaultView;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "nma");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
