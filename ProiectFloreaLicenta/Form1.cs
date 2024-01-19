using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFloreaLicenta
{
    public partial class Form1 : Form
    {
        double TICKS = 0;
        int nrInstrProcesate = 0;
        int nrBranchProcesate = 0;
        int nrStoreProcesate = 0;
        int nrLoadProcesate = 0;
        int nrArithProcesate = 0;
        int acceseDisponibileLaMemoriePerCiclu;
        int PCnormal = 0;
        double missCache = 0.1;
        Instructiune[,] instructiuniAduseDinMemorie;
        List<Instructiune> instructiuniCititeDinBenchmark;
        int numberOfInstructions = 0;
        int deCateOriAFostAccesataMemoria = 0;
        public Form1()
        {
            InitializeComponent();
            
            addRanges();
            setFirstIndexes();
            verificareAcceseDisponibileLaMemorie();

        }

        public void setareUniportSauBiport()
        {
            if (Settings.uniport == 1)
            {
                acceseDisponibileLaMemoriePerCiclu = 1;
            }
            else if (Settings.biport == 1)
            {
                acceseDisponibileLaMemoriePerCiclu = 2;
            }

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

      
        public void uniportSelectat(object sender, EventArgs e)
        {
            if (uniport.Checked)
                Settings.uniport = 1;
            else
                Settings.uniport = 0;
        }
        public void biportSelectat(object sender, EventArgs e)
        {

            if (biport.Checked)
                Settings.biport = 1;
            else
                Settings.biport = 0;
        }

        public void verificareAcceseDisponibileLaMemorie()
        {
            this.uniport.CheckedChanged += new System.EventHandler(this.uniportSelectat);
            this.biport.CheckedChanged += new System.EventHandler(this.biportSelectat);
        }

        public void addRanges()
        {
            fetchRate.Items.AddRange(ConvertToIntArray(Settings.FetchArray));
            instructionBufferSize.Items.AddRange(ConvertToIntArray(Settings.InstructionBufferArray));
            irMax.Items.AddRange(ConvertToIntArray(Settings.IssueRateArray));
            nPen.Items.AddRange(ConvertToIntArray(Settings.NPenArray));
            nrSetRegistrii.Items.AddRange(ConvertToIntArray(Settings.NrSetRegistriiArray));
            blockSize.Items.AddRange(ConvertToIntArray(Settings.BlockSizeArray));
            blockSizeDC.Items.AddRange(ConvertToIntArray(Settings.BlockSizeArray));
            sizeDC.Items.AddRange(ConvertToIntArray(Settings.SizeBlockArray));
            sizeIC.Items.AddRange(ConvertToIntArray(Settings.SizeBlockArray));
            
            traceFilesListBox.Items.Add("FBUBBLE.TRC");
            traceFilesListBox.Items.Add("FMATRIX.TRC");
            traceFilesListBox.Items.Add("FPERM.TRC");
            traceFilesListBox.Items.Add("FPUZZLE.TRC");
            traceFilesListBox.Items.Add("FQUEENS.TRC");
            traceFilesListBox.Items.Add("FSORT.TRC");
            traceFilesListBox.Items.Add("FTOWER.TRC");
            traceFilesListBox.Items.Add("FTREE.TRC");

        }



        private object[] ConvertToIntArray(int[] intArray)
        {
            return intArray.Cast<object>().ToArray();
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


        private void blockSizeDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            blockSize.Text = blockSizeDC.SelectedItem.ToString();
        }

        private void parsareFisier_Click(object sender, EventArgs e)
        {
            if (traceFilesListBox.SelectedItem != null)
            {
                string selectedTraceFile = traceFilesListBox.SelectedItem.ToString();
                string filePath = Path.Combine("C:\\Users\\drago\\source\\repos\\proiectFlorea\\ProiectFloreaLicenta\\BenchmarkTraces", selectedTraceFile);

                try
                {
                    int selectedIRMaxDePeInterfata = Convert.ToInt32(irMax.SelectedItem.ToString());
                    var citireBenchmark = new CitireBenchmark();
                    instructiuniCititeDinBenchmark = citireBenchmark.parsareFisierTrc(filePath);
                    instructiuniAduseDinMemorie = citireBenchmark.ProcessInstructionsIntoMatrix(instructiuniCititeDinBenchmark, selectedIRMaxDePeInterfata);
                    
                    MessageBox.Show("Fisierul a fost parsat cu succes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show($"O eroare s-a intamplat cand s-a parsat fisierul: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un fisier pentru parsare.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ProcessInstructions(List<Instructiune> instructiuniCititeDinBenchmark)
        {
            
            foreach (Instructiune instructiune in instructiuniCititeDinBenchmark)
            {   
                numberOfInstructions = instructiuniCititeDinBenchmark.Count;
                while (instructiune.pcCurent != PCnormal)
                {
                    PCnormal++;
                    nrArithProcesate++;
                }

                if (instructiune.tipInstructine == "B")
                {
                    PCnormal = instructiune.target;
                    nrBranchProcesate++;
                }
                else if (instructiune.tipInstructine == "S")
                {
                    PCnormal++;
                    nrStoreProcesate++;
                }
                else if (instructiune.tipInstructine == "L")
                {
                    PCnormal++;
                    nrLoadProcesate++;
                }
            }
        }

        
        public double calculateLatency(int numberOfInstructions, int irMax)
        {
            
            int latency = (int)latenta.Value;
            int rowsWith2Instructions = 0;

            if (irMax >= 2)
            {
                
                if (irMax == 2)
                {
                    rowsWith2Instructions = numberOfInstructions / irMax;
                }
                if (numberOfInstructions % irMax == 2)
                {
                    rowsWith2Instructions++;
                }
            }

            
            TICKS = rowsWith2Instructions * latency;
            return TICKS;
        }
       

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startSimulare_Click(object sender, EventArgs e)
        {
            int latency = (int)latenta.Value;
            int selectedIRMaxDePeInterfata = Convert.ToInt32(irMax.SelectedItem.ToString());
            int numarPen = Convert.ToInt32(nPen.SelectedItem.ToString());
            ProcessInstructions(instructiuniCititeDinBenchmark);
            calculateLatency(numberOfInstructions, selectedIRMaxDePeInterfata);
 

            foreach (Instructiune instructiune in instructiuniAduseDinMemorie)
            {   
                if (instructiune == null)
                {
                    break;
                }
                if (deCateOriAFostAccesataMemoria < acceseDisponibileLaMemoriePerCiclu)
                {
                    if (instructiune.tipInstructine == "L" || instructiune.tipInstructine == "S" )
                    {
                        deCateOriAFostAccesataMemoria++;
                    }
                    
                }
                else
                {
                    if (instructiune.tipInstructine == "L" || instructiune.tipInstructine == "S")
                    {
                        deCateOriAFostAccesataMemoria = 0;
                        TICKS += latency;
                    }
                }
            }

            double penalizareMissCache = nrLoadProcesate * missCache * numarPen;
            TICKS += penalizareMissCache;

            ticksTextBox.Text = TICKS.ToString();
            loadTextBox.Text = nrLoadProcesate.ToString();
            storeTextBox.Text = nrStoreProcesate.ToString();
            branchTextBox.Text = nrBranchProcesate.ToString();
            int total = nrLoadProcesate + nrStoreProcesate + nrBranchProcesate;
            totalTextBox.Text = total.ToString();
            double IR = (double)total / TICKS;
            issueRateTextBox.Text = IR.ToString();
            double irSIMULTAN = total/(TICKS+penalizareMissCache);
            influentaIrTextBox.Text = irSIMULTAN.ToString(); // 2.1 
            double oneCycle = TICKS;
            oneCycleTextBox.Text = oneCycle.ToString();
        }
    }
}
