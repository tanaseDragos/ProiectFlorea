using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFloreaLicenta
{
    public partial class Form1 : Form
    {
        Object[] fetchArray = { 4, 8, 16 };
        Object[] instructionBufferArray = { 4, 8, 16, 32 };
        Object[] issueRateArray = { 2,4, 8, 16};
        Object[] nPenArray = { 10, 15, 20 };
        Object[] nrSetRegistriiArray = { 2 };
        Object[] blockSizeArray = { 4, 8, 16 };
        Object[] sizeBlockArray = { 64, 128, 256, 512, 1024, 2048, 4096, 8192 };
        public Form1()
        {
            InitializeComponent();
            fetchRate.Items.AddRange(fetchArray);
            instructionBufferSize.Items.AddRange(instructionBufferArray);
            irMax.Items.AddRange(issueRateArray);
            nPen.Items.AddRange(nPenArray);
            nrSetRegistrii.Items.AddRange(nrSetRegistriiArray);
            blockSize.Items.AddRange(blockSizeArray);
            blockSizeDC.Items.AddRange(blockSizeArray);
            sizeDC.Items.AddRange(sizeBlockArray);
            sizeIC.Items.AddRange(sizeBlockArray);

            setFirstIndexes();

        }

        public void setFirstIndexes()
        {
            fetchRate.SelectedIndex = 0;
            instructionBufferSize.SelectedIndex = 0;
            irMax.SelectedIndex = 0;
            nPen.SelectedIndex = 0;
            nrSetRegistrii.SelectedIndex = 0;
            blockSize.SelectedIndex = 0;
            blockSizeDC.SelectedIndex = 0;
            sizeDC.SelectedIndex = 0;
            sizeIC.SelectedIndex = 0;
        }

        private void fetchRate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void irMax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void instructionBufferSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nPen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alegeFisier_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
             
                openFileDialog.Filter = "All files (*.*)|*.*"; // You can change this to filter specific file types

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    pathFisier.Text = filePath;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blockSizeDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            blockSize.Text = blockSizeDC.SelectedItem.ToString();
        }
    }
}
