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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt___biblioteki_graficzne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorSet.Items.Add("Niebieski");
            colorSet.Items.Add("Czerwony");
            colorSet.Items.Add("Różowy");
            colorSet.Items.Add("Żółty");
            colorSet.Items.Add("Zielony");
            colorSet.Items.Add("Fioletowy");
            rbx.IsChecked = true;
        }


        private void colorSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorSet.SelectedIndex == 0) matDiffuseMain.Color = Colors.Blue;
            else if (colorSet.SelectedIndex == 1) matDiffuseMain.Color = Colors.Red;
            else if (colorSet.SelectedIndex == 2) matDiffuseMain.Color = Colors.DeepPink;
            else if (colorSet.SelectedIndex == 3) matDiffuseMain.Color = Colors.Yellow;
            else if (colorSet.SelectedIndex == 4) matDiffuseMain.Color = Colors.ForestGreen;
            else if (colorSet.SelectedIndex == 5) matDiffuseMain.Color = Colors.Violet;
        }

        private void rbx_Checked(object sender, RoutedEventArgs e)
        {
            var vecx = new Vector3D(1, 0, 0);
            rotate.Axis = vecx;
            slider1.Value = 0;
        }

        private void rby_Checked(object sender, RoutedEventArgs e)
        {
            var vecx = new Vector3D(0, 1, 0);
            rotate.Axis = vecx;
            slider1.Value = 0;
        }

        private void rbz_Checked(object sender, RoutedEventArgs e)
        {
            var vecx = new Vector3D(0, 0, 1);
            rotate.Axis = vecx;
            slider1.Value = 0;
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (sizeInfo.WidthChanged) this.Width = sizeInfo.NewSize.Height;
            else this.Height = sizeInfo.NewSize.Width;
        }
    }


}
