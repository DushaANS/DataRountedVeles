﻿using System;
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
using System.Windows.Threading;

namespace DataRountedVeles.VIew
{
    /// <summary>
    /// Логика взаимодействия для WoodenLogHouse.xaml
    /// </summary>
    public partial class WoodenLogHouse : Window
    {
        public WoodenLogHouse()
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

        private void ExitList(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList();
            menuList.Show();
            this.Close();
        }
    }
}
