using System;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Badupload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Badly Written App Files (*.argh)|*.argh";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter fmt = new BinaryFormatter();
                    MemoryStream stm = new MemoryStream(File.ReadAllBytes(dlg.FileName));
                    var run = fmt.Deserialize(stm);

                    run.Run();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
