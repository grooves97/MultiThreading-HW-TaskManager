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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TasksProcess tasksProcess = new TasksProcess();
            taskDataGrid.ItemsSource = tasksProcess.GetProcessesByName();
        }

        private void KillProcess(object sender, RoutedEventArgs e)
        {
            var selectedProcess = taskDataGrid.SelectedItem as Process;
            if (selectedProcess != null)
                selectedProcess.Kill();
            taskDataGrid.Items.Refresh();
        }
    }
}
