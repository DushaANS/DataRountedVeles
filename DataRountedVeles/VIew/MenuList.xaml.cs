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

namespace DataRountedVeles.VIew
{
    /// <summary>
    /// Логика взаимодействия для MenuList.xaml
    /// </summary>
    public partial class MenuList : Window
    {
        public MenuList()
        {
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None;
            InitializeComponent();
        }
        private void panelHeaderMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WoodListEnter(object sender, RoutedEventArgs e)
        {
            WoodenLogHouse woodenLogHouse = new WoodenLogHouse();
            woodenLogHouse.Show();
            this.Close();
        }

        private void SawedEnter(object sender, RoutedEventArgs e)
        {
            Sawed sawed = new Sawed();
            sawed.Show();
            this.Close();   
        }

        private void DryingEnter(object sender, RoutedEventArgs e)
        {
            Drying drying = new Drying();
            drying.Show();
            this.Close();
        }

        private void WarehouseEnter(object sender, RoutedEventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Show();
            this.Close();
        }

        private void ReportingEnter(object sender, RoutedEventArgs e)
        {
            Reporting reporting = new Reporting();
            reporting.Show();
            this.Close();
        }
    }
}
