using Database.Step4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database.Step4.Winform
{
    public partial class Scenario3 : Form
    {
        public Scenario3()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            List<Track> values = DataRepository.Playlist.GetGenre(txtKeyword.Text);
            listView.DataSource = values.ToList();
            

            double Sum = DataRepository.Playlist.GetCount(txtKeyword.Text);
            Sum = Sum * 0.99;
            PriceSum.Text = Sum.ToString();
        }

        private void ListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Scenario3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chinookDataSet1.Track' table. You can move, or remove it, as needed.
            this.trackTableAdapter.Fill(this.chinookDataSet1.Track);

        }
    }
}
