using Kanban_WPF.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kanban_WPF.View
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private RegisterViewModel viewModel;

        public RegisterWindow(KanbanController controller)
        {
            InitializeComponent();
            this.viewModel = new RegisterViewModel(controller);
            this.DataContext = viewModel;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Register();
        }

    }
}
