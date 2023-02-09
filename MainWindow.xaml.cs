using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace JSON_P_JoshuaHooper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string json = File.ReadAllText("C:\\Users\\joshu\\source\\repos\\JSON_P_JoshuaHooper\\Mock_Data_Car_Owners.json");

        private List<CarOwner> _carOwners = new List<CarOwner>();

        public MainWindow()
        {
            InitializeComponent();

            _carOwners = JsonConvert.DeserializeObject<List<CarOwner>>(json);


            foreach (CarOwner carOwner in _carOwners)
            {
                if (!cboColors.Items.Contains(carOwner.Color))
                {
                    cboColors.Items.Add(carOwner.Color);
                }
            }
        }

        private void cboColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedColor = (string)cboColors.SelectedItem;

            listBoxData.Items.Clear();

            foreach (CarOwner carOwner in _carOwners)
            {
                if (selectedColor == carOwner.Color)
                {
                    listBoxData.Items.Add(carOwner);
                }
            }
        }
    }
}
