using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobamenu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet1.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.mahasiswa);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            menu.Show();
            this.Hide();
        }
    }
}
