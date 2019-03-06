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

namespace pstgresdbapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            pstgresdbapp.postgresDataSet postgresDataSet = ((pstgresdbapp.postgresDataSet)(this.FindResource("postgresDataSet")));
            // Load data into the table throwers. You can modify this code as needed.
            pstgresdbapp.postgresDataSetTableAdapters.throwersTableAdapter postgresDataSetthrowersTableAdapter = new pstgresdbapp.postgresDataSetTableAdapters.throwersTableAdapter();
            postgresDataSetthrowersTableAdapter.Fill(postgresDataSet.throwers);
            System.Windows.Data.CollectionViewSource throwersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("throwersViewSource")));
            throwersViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            postgresDataSetTableAdapters.throwersTableAdapter throwers1 = new postgresDataSetTableAdapters.throwersTableAdapter();
            throwers1.Insert("Tom Shields", 2017);

            


        }
    }
}
