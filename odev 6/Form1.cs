using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Hedaf Miktar"].Points.Clear();
            chart1.Series["Uretilen Miktar"].Points.Clear();
            dataGridView1.Rows.Clear();
            var list = new Liste();
            int lenght=list.MakineAdi.Count;
            DateTime gun,basalngic,bitis;

            for (int i = 0; i <lenght ; i++) {
                gun = DateTime.ParseExact(list.Tarih[i], " dd.MM.yyyy",null);
                
                basalngic= DateTime.Parse(dateTimePicker1.Text);
                bitis = DateTime.Parse(dateTimePicker2.Text);

                if (comboBox1.Text== list.MakineAdi[i])
                {
                    if ((basalngic <= gun && bitis >= gun))
                    {
                        dataGridView1.Rows.Add(list.MakineAdi[i], list.Tarih[i],
                            list.HedafMiktar[i], list.UretilenMiktar[i]);

                        chart1.Series["Hedaf Miktar"].Points.AddXY(list.Tarih[i], Convert.ToDouble(list.HedafMiktar[i]));
                        chart1.Series["Uretilen Miktar"].Points.AddXY(list.Tarih[i], Convert.ToDouble(list.UretilenMiktar[i]));
                    }


                }

            }
        }
    }
}
