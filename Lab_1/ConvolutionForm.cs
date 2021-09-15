using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class ConvolutionForm : Form
    {
        public ConvolutionForm(string fileName, Bitmap sourceImage)
        {
            InitializeComponent();
            Text += $": {fileName}";
            // get default convolution kernel with central anchor
            _originalImage = sourceImage;
            convolutedImagePictureBox.Image = Graphics.Core.GraphicsMath.Convolution(sourceImage, kernelEditor.Kernel, kernelEditor.KernelAnchor);
        }

        // default kernel
        private Bitmap _originalImage;
        private ConvolutionKernelEditor kernelEditor = new ConvolutionKernelEditor();

        private void editKernelMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == kernelEditor.ShowDialog())
            {
                double[][] convolutionKernel = kernelEditor.Kernel;
                convolutedImagePictureBox.Image = Graphics.Core.GraphicsMath.Convolution(_originalImage, convolutionKernel, kernelEditor.KernelAnchor);
            }
        }
    }
}
