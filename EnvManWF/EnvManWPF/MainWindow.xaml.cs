using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SFC.EnvMan;

namespace EnvManWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private List<EnvVarViewItem> VarItems = new List<EnvVarViewItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            VarItems.Add(new EnvVarViewItem(EnvironmentVariableTarget.User));
            VarItems.Add(new EnvVarViewItem(EnvironmentVariableTarget.Machine));
        }

        private void MainData_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadData();
                MainData.ItemsSource = VarItems;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
