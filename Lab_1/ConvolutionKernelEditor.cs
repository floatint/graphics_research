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
    public partial class ConvolutionKernelEditor : Form
    {
        public ConvolutionKernelEditor()
        {
            InitializeComponent();
            FillFromMatrix(_kernel);

            // redraw
            // TODO: fix
            ValidateItems();
        }

        private void FillFromMatrix(double[][] matrix)
        {
            kernelItemsTableLayout.SuspendLayout();
            kernelItemsTableLayout.Controls.Clear();
            kernelItemsTableLayout.RowCount = 0;
            kernelItemsTableLayout.ColumnCount = 0;
            kernelItemsTableLayout.ColumnStyles.Clear();
            kernelItemsTableLayout.RowStyles.Clear();


            
            kernelItemsTableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            for (int y = 0; y < matrix.Length; y++)
            {
                kernelItemsTableLayout.RowCount += 1;
                kernelItemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f / matrix.Length));
            }
            kernelItemsTableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            for (int x = 0; x < matrix[0].Length; x++)
            {
                kernelItemsTableLayout.ColumnCount += 1;
                kernelItemsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / matrix[0].Length));
            }
            for (int y = 0; y < matrix.Length; y++)
            {
                for (int x = 0; x < matrix[0].Length; x++)
                {
                    var tb = new TextBox()
                    {
                        Text = matrix[y][x].ToString(),
                        AutoSize = true,
                        Multiline = true,
                        Dock = DockStyle.Fill,
                        Font = new Font(Font.FontFamily, 16),
                        TextAlign = HorizontalAlignment.Center,

                    };
                    tb.KeyDown += textBox_KeyDown;
                    kernelItemsTableLayout.Controls.Add(tb, x, y);

                }
            }
            kernelItemsTableLayout.ResumeLayout();
        }

        private bool ValidateItems()
        {
            for (int y = 0; y < kernelItemsTableLayout.RowCount; y++)
            {
                for (int x = 0; x < kernelItemsTableLayout.ColumnCount; x++)
                {
                    int itemId = y * kernelItemsTableLayout.ColumnCount + x;

                    if (!double.TryParse(kernelItemsTableLayout.Controls[itemId].Text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out double itemValue))
                    {
                        kernelItemsTableLayout.Controls[itemId].BackColor = Color.Red;
                        MessageBox.Show($"Cell ({y}, {x}) contains invalid data");
                        return false;
                    } else
                    {
                        RedrawCell(y, x);
                    }
                }
            }

            // check anchor
            if (kernelItemsTableLayout.RowCount <= KernelAnchor.Y || kernelItemsTableLayout.ColumnCount <= KernelAnchor.X)
            {
                MessageBox.Show("Please, select new kernel anchor");
                return false;
            }

            return true;
        }

        private void RedrawCell(int y, int x)
        {
            int itemId = y * kernelItemsTableLayout.ColumnCount + x;
            if (y == KernelAnchor.Y && x == KernelAnchor.X)
            {
                kernelItemsTableLayout.Controls[itemId].BackColor = Color.Blue;
            }
            else
            {
                kernelItemsTableLayout.Controls[itemId].BackColor = SystemColors.Window;
            }
        }

        public double[][] Kernel
        {
            get
            {
                double[][] kernel = new double[kernelItemsTableLayout.RowCount][];
                for (int y = 0; y < kernel.Length; y++)
                {
                    kernel[y] = new double[kernelItemsTableLayout.ColumnCount];
                }

                for (int y = 0; y < kernel.Length; y++)
                {
                    for (int x = 0; x < kernel[0].Length; x++)
                    {
                        int itemId = y * kernelItemsTableLayout.ColumnCount + x;
                        //int itemId = y == 0 ? x : (y - 1) * kernel[0].Length + x;
                        kernel[y][x] = double.Parse(kernelItemsTableLayout.Controls[itemId].Text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture);
                    }
                }

                return kernel;
            }
        }

        // default kernel anchor
        public Point KernelAnchor { set; get; } = new Point(1, 1);

        // default kernel (edge detection)
        private double[][] _kernel = new double[3][] {
                new double[] { -1, -1, -1},
                new double[] { -1, 8, -1},
                new double[] { -1, -1, -1 }
        };

        private void ConvolutionKernelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidateItems())
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                e.Cancel = true;
                return;
            }
        }


        private void okMainMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateItems())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void addRowMenuItem_Click(object sender, EventArgs e)
        {
            kernelItemsTableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            kernelItemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f / kernelItemsTableLayout.RowCount + 1));
            kernelItemsTableLayout.SuspendLayout();
            kernelItemsTableLayout.RowCount += 1;
            for (int x = 0; x < kernelItemsTableLayout.ColumnCount; x++)
            {
                var tb = new TextBox()
                {
                    Text = "0",
                    AutoSize = true,
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    Font = new Font(Font.FontFamily, 16),
                    TextAlign = HorizontalAlignment.Center,

                };
                tb.KeyDown += textBox_KeyDown;
                
                kernelItemsTableLayout.Controls.Add(tb, x, kernelItemsTableLayout.RowCount - 1);
            }
            foreach (var i in kernelItemsTableLayout.RowStyles)
            {
                var rs = i as RowStyle;
                rs.Height = 100.0f / kernelItemsTableLayout.RowCount;
            }
            kernelItemsTableLayout.ResumeLayout();
        }

        private void addColumnMenuItem_Click(object sender, EventArgs e)
        {
            kernelItemsTableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            kernelItemsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / kernelItemsTableLayout.ColumnCount + 1));
            kernelItemsTableLayout.SuspendLayout();
            kernelItemsTableLayout.ColumnCount += 1;
            for (int y = 0; y < kernelItemsTableLayout.RowCount; y++)
            {
                var tb = new TextBox()
                {
                    Text = "0",
                    AutoSize = true,
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    Font = new Font(Font.FontFamily, 16),
                    TextAlign = HorizontalAlignment.Center,

                };
                tb.KeyDown += textBox_KeyDown;
                kernelItemsTableLayout.Controls.Add(tb, kernelItemsTableLayout.ColumnCount - 1, y);
            }
            foreach (var i in kernelItemsTableLayout.ColumnStyles)
            {
                var rs = i as ColumnStyle;
                rs.Width = 100.0f / kernelItemsTableLayout.ColumnCount;
            }
            kernelItemsTableLayout.ResumeLayout();
        }

        private void toFileProviderMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(sfd.FileName) || string.IsNullOrWhiteSpace(sfd.FileName)))
                {
                    try
                    {
                        Graphics.Core.MatrixFileProvider.SaveToFile(sfd.FileName, Kernel);
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"Kernel save to file fail. Exception:\n {ex.ToString()}");
                    }
                }
            }
        }

        private void fromFileProviderMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(ofd.FileName) || string.IsNullOrWhiteSpace(ofd.FileName)))
                {
                    try
                    {
                        var newKernel = Graphics.Core.MatrixFileProvider.LoadFromFile(ofd.FileName);
                        KernelAnchor = new Point(newKernel.Length / 2, newKernel[0].Length / 2);
                        FillFromMatrix(newKernel);
                        // redraw
                        ValidateItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kernel load from file fail. Exception:\n {ex.ToString()}");
                    }
                }
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var prevAnchor = KernelAnchor;

                var pos = kernelItemsTableLayout.GetCellPosition((Control)sender);

                KernelAnchor = new Point(pos.Column, pos.Row);
                // redraw
                RedrawCell(prevAnchor.Y, prevAnchor.X);
                RedrawCell(pos.Row, pos.Column);
            }
        }
    }
}
