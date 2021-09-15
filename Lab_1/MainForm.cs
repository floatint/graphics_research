using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetTransformationsEnabled();
        }

        private void openImageMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK || (string.IsNullOrWhiteSpace(ofd.FileName) || string.IsNullOrEmpty(ofd.FileName)))
            {
                MessageBox.Show("Please, select image file");
                return;
            } else
            {
                if (!File.Exists(ofd.FileName))
                {
                    MessageBox.Show("Selected image doesn't exist");
                    return;
                }
                else
                {
                    // try to load bitmap
                    try
                    {
                        sourceImage = (Bitmap)Image.FromFile(ofd.FileName);
                        sourceImagePictureBox.Image = sourceImage;
                        sourceImageFileName = ofd.FileName;
                        SetFormText(ofd.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Image loading fail. Exception:\n {ex.ToString()}");
                        return;
                    }
                }
            }
            SetTransformationsEnabled();
        }

        private void closeImageMenuItem_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                return;
            }
            SetFormText(null);
            sourceImagePictureBox.Image = null;
            sourceImage = null;
            sourceImageFileName = null;
            SetTransformationsEnabled();
        }

        private Bitmap sourceImage;
        private string sourceImageFileName;

        private void convolutionTranformationMenuItem_Click(object sender, EventArgs e)
        {
            Form convolutionForm = new ConvolutionForm(sourceImageFileName, sourceImage);
            convolutionForm.Show();
        }

        // UI routines
        private void SetFormText(string fileName)
        {
            // set form text to default
            if (string.IsNullOrEmpty(fileName))
            {
                Text = new string(Text.TakeWhile(x => x != ':').ToArray());
            } else
            {
                // append file name to form text
                Text += $": {fileName}";
            }
        }

        private void SetTransformationsEnabled()
        {
            if (sourceImage == null)
            {
                convolutionTranformationMenuItem.Enabled = false;
            } else
            {
                convolutionTranformationMenuItem.Enabled = true;
            }
        }
    }
}
