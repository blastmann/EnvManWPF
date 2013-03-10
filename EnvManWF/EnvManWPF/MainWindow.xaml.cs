using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        private EnvVarManager variableManger = new EnvVarManager();        

        public MainWindow()
        {
            InitializeComponent();
            LoadEnvironmentVars();
        }

        private void LoadEnvironmentVars()
        {
            LoadEnvironmentVariables(this.dgv, EnvironmentVariableTarget.User);
        }

        /// <summary>
        /// Loads the environment variables.
        /// </summary>
        /// <param name="dgv">The Data Grid View.</param>
        /// <param name="target">The target.</param>
        private void LoadEnvironmentVariables(
            DataGrid dgv, EnvironmentVariableTarget target)
        {
            EnvVarValueValidator validator = new EnvVarValueValidator();

            IDictionary environmentVariables
                = this.variableManger.GetEnvVariables(target);

            dgv.ItemsSource = environmentVariables;
        }
    }
}
