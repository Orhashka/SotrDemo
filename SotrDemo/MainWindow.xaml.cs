using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace SotrDemo
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<SotrAlgItem> SortAlgList { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            SortAlgList = new ObservableCollection<SotrAlgItem>();

            SortAlgList.Add(new SotrAlgItem() { Name = "Please, select algorithm" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Bubble sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Coctail sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Gnome sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Insertion sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Merge sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Selection sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Comb sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Shell sort" });
            SortAlgList.Add(new SotrAlgItem() { Name = "Quick sort" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });
            //SortAlgList.Add(new SotrAlgItem() { Name = "-----------" });

            DataContext = this;
            this.selectSortAlgComboBox.SelectedIndex = 0;
        }

        private void tempButton_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show(SortAlgList.Count.ToString());
        }

        private void selectSortAlgComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Global.NumOfAlg = this.selectSortAlgComboBox.SelectedIndex;
        }

        private void generateArrayButton_Click(object sender, RoutedEventArgs e)
        {
            Global.leftBorder = (double)this.leftBoder.Value;
            Global.rightBorder = (double)this.rightBorder.Value;
            Global.numOfElements = (int)this.NumOfElements.Value;

            Global.array = new double[Global.numOfElements];
            for (int i = 0; i < Global.numOfElements; i++)
                Global.array[i] = Global.random.NextDouble() + Global.random.Next((int)Global.leftBorder, (int)Global.rightBorder);
            PrintArray();
        }



        #region TextBox

        private void printArrayButton_Click(object sender, RoutedEventArgs e)
        {
            PrintArray();
        }

        public void PrintArray()
        {
            mainTextBox.Text += "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                mainTextBox.Text += Math.Round(Global.array[i], 2) + "\t";
        }

        private void fontSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            this.mainTextBox.FontSize = (int)this.fontSize.Value;
        }

        private void saveAsButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            //saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.FileName = SortAlgList[this.selectSortAlgComboBox.SelectedIndex].Name + " " + Global.numOfElements.ToString() + " " + DateTime.Today.ToString().Substring(0, 10);
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Clear();
        }






        #endregion

        private void sotrButton_Click(object sender, RoutedEventArgs e)
        {

            switch (Global.NumOfAlg)
            {
                case 0:
                    MessageBox.Show("Please, select algorithm");
                    break;
                case 1:

                    string[] s = SortingAlgorithms.BubbleSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 2:

                    s = SortingAlgorithms.CoctailSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 3:

                    s = SortingAlgorithms.GnomeSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 4:

                    s = SortingAlgorithms.InsertionSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 5:

                    s = SortingAlgorithms.MergeSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 6:

                    s = SortingAlgorithms.SelectionSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 7:

                    s = SortingAlgorithms.CombSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 8:

                    s = SortingAlgorithms.ShellSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
                case 9:

                    s = SortingAlgorithms.QuickSort(Global.array);
                    for (int i = 0; i < s.Length; i++)
                        mainTextBox.Text += s[i];
                    break;
            }
        }
    }
}
