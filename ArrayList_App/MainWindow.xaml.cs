using System;
using System.Collections;
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

namespace ArrayList_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Showall(object sender, RoutedEventArgs e)
        {
            
            /*  //Add data
            arrayList.Add(10);
            arrayList.Add(99);
            arrayList.Add(120);
            arrayList.Add(15);
            arrayList.Add(18);
            arrayList.Add(11);
            //show Data
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            //MessageBox.Show(arrayList[0].ToString());

            //count
            MessageBox.Show("Count : " + arrayList.Count.ToString());

            //remove data ลบ ตัวแรกที่เจอ
            arrayList.Remove(10);//ลบข้อมูลที่เท่ากับ10 ตัวแรก

            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            //remove ตามตำแหน่งที่ใส่
            arrayList.RemoveAt(2);//ลบข้อมูลที่ตำแหน่งที่สอง

            //sort data
            arrayList.Sort();

            //clear data
            arrayList.Clear();*/

            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            int add_Data = int.Parse(txtBox.Text); 
            arrayList.Add(add_Data);
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            int remove_Data = int.Parse(txtBox.Text);
            arrayList.Remove(remove_Data);
        }

    }
}
