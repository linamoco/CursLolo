using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templates;
using System.IO;

namespace table
{
    public partial class SaveBox : BorderLessForm
    {
        private Form1 form { get; }
        public SaveBox(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void SaveBox_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = new Size(338,175);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            form.saveButtonCl();
            this.Close();
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
