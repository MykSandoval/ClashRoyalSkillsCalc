using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Clash
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public object TextQue { get; private set; }
        public object ComboBox1 { get; private set; }

        public string LDisc { get; set; }
        public int Level { get; set; }
        public string VDisc { get; set; }       
        public int Value { get; set; }
        
        //private void AddList(string LDisc, int Level, string VDisc, int Value)
        //{
            
        //    listBox.Items.Add(LDisc + Level + VDisc + Value);
            
        //}
        public MainPage()
        {
            this.InitializeComponent();

        }
       

        public void TextQUE_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //combo box
   
       
        
        
        public void LegendQUEButton_Click(object sender, RoutedEventArgs e)
        {
            //try catch value to display a message in case a value isnt entered!
            try
            {
                //Convert Combo box legend content to int and then * 7
                var comboBoxItem4 = comboBox4.Items[comboBox4.SelectedIndex] as ComboBoxItem;
                var Legendselect4 = comboBoxItem4.Content.ToString();
                string COMBO4 = Legendselect4;
                int.TryParse(COMBO4, out int Content4);
                int LegendInput = Content4 * 7;
                //send legend content in combo box to listboxview item
                // listBox.Items.Add("Legendary Card! Level: " + Content4 + " Value: " + LegendInput);
                listBox.Items.Add(LegendInput);
            }
            catch (ArgumentOutOfRangeException)
            {
                TextQUE.Text = "Need to select a Legendary Card!";
            }
        }

        //QUE BUTTONS*************************************************

        public void EpicQUEButton_Click(object sender, RoutedEventArgs e)
        {
            //try catch value to display a message in case a value isnt entered!
            try
            {
                //Convery epic combo box content to int and multiply by 5
                var comboBoxItem3 = comboBox3.Items[comboBox3.SelectedIndex] as ComboBoxItem;
                var Epicselect3 = comboBoxItem3.Content.ToString();
                string COMBO3 = Epicselect3;
                int.TryParse(COMBO3, out int Content3);
                int EPICInput = Content3 * 5;
                //add that to a listboxitem
                // listBox.Items.Add("Epic Card! Level: " + Content3 + " Value: " + EPICInput);
                listBox.Items.Add(EPICInput);
            }
            catch (ArgumentOutOfRangeException)
            {
                TextQUE.Text = "Need to select a Epic Card!";
            }
        }

        public void RareQUEButton_Click(object sender, RoutedEventArgs e)
        {
            //try catch value to display a message in case a value isnt entered!
            try
            {
                //convertion of rare and * 2
                var comboBoxItem2 = comboBox2.Items[comboBox2.SelectedIndex] as ComboBoxItem;
                var Rareselect2 = comboBoxItem2.Content.ToString();
                string COMBO2 = Rareselect2;
                int.TryParse(COMBO2, out int Content2);
                int RareInput = Content2 * 2;
                //add new listboxitem from the conversion

                  listBox.Items.Add(RareInput);
            }
            catch (ArgumentOutOfRangeException)
            {
                TextQUE.Text = "Need To Select a Rare Card!";
            }
        }

        public void CommonQUEButton_Click(object sender, RoutedEventArgs e)
        {
            //try catch value to display a message in case a value isnt entered!
            try
            {
                //Common conversion
                var comboBoxItem = comboBox1.Items[comboBox1.SelectedIndex] as ComboBoxItem;
                var Commonselect = comboBoxItem.Content.ToString();
                string COMBO = Commonselect;
                int.TryParse(COMBO, out int Content);


                int CommonInput = Content * 1;

                //adding common content to listboxview item

                LDisc = "Common Level: ";             
                Level = Content;
                VDisc = " Value: ";
                Value = CommonInput;
                listBox.Items.Add(LDisc + Level + VDisc + Value);

            }
            catch (ArgumentOutOfRangeException)
            {
                TextQUE.Text = "Need to Select A Common Card!";
            }
            catch (NotImplementedException)
            {
                TextQUE.Text = "stupid error";
            }
        }
        public void ENTERbutton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                
                //radiobutton select
                if (radioButton1.IsChecked == true)
                {
                    var ListBoxItem = listBox.Items[listBox.SelectedIndex] as ListBoxItem;
                    string c = ListBoxItem.Content.ToString();
                    Int32.TryParse(c, out int SelectListContent);
                    Value = SelectListContent;



                    //final Calculation***
                    int Result1 = Value;
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton2.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 2) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton3.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 3) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton4.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 4) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton5.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 5) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton6.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 6) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton7.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 7) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton8.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 8) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton9.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 9) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton10.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 10) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton11.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 11) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton12.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 12) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }
                else if (radioButton13.IsChecked == true)
                {
                    string c = listBox.Items.Last().ToString();
                    Int32.TryParse(c, out int ListCalc);
                    //final Calculation***
                    int Result1 = ((8 * 13) + ListCalc / 2);
                    TextQUE.Text = Result1.ToString();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                TextQUE.Text = "Selected The Rest of your Values!";
            }
            catch (System.NullReferenceException)
            {
                TextQUE.Text = "Value is Null!";
            }
        }
        

       


        




    public void ProgressBar_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
            int.TryParse(listBox.Items.ToString(), out int result);

            for (int i = 0; result < 8; i++)
            {
                i++;
            }
    }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton7_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton8_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton9_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton10_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton11_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton12_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton13_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

