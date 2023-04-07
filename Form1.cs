using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace port_serial
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF,indexOfG, indexOfH, indexOfI, indexOfJ;
        sbyte indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP, indexOfQ, indexOfR, indexOfS, indexOfT;
        int IDataA;
        int limDA, limUA;

        private void btnSet_Click(object sender, EventArgs e)
        {
            limDA = Convert.ToInt32(tbox_D_A.Text);
            limUA = Convert.ToInt32(tbox_U_A.Text);

        }

        private void lblDataConn_Click(object sender, EventArgs e)
        {

        }

        string dataA, dataB, dataC, dataD, dataE, dataF, dataG, dataH, dataI, dataJ;
        string dataK, dataL, dataM, dataN, dataO, dataP, dataQ, dataR, dataS, dataT;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
        }

        private void cBoxBAUDRATE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                //serialPort1.DataBits = Convert.ToInt32(cBoxDATABIT.Text);
                //serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBIT.Text);
                //serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBIT.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                lblDataConn.Text = "Connected";
                btn_Open.Enabled = false;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                lblDataConn.Text = "Disconnected";
                btn_Open.Enabled = true;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {}

        private void cBoxCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void label15_Click(object sender, EventArgs e)
        {}

        private void label19_Click(object sender, EventArgs e)
        {}

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != ""|tBoxdataA.Text != "");
            {
                tBoxDataOut.Text = "";
                tBoxdataA.Text = "";
                tBoxdataB.Text = "";
                tBoxdataC.Text = "";
                tBoxdataD.Text = "";
                tBoxdataE.Text = "";
                tBoxdataF.Text = "";
                tBoxdataG.Text = "";
                tBoxdataH.Text = "";
                tBoxdataI.Text = "";
                tBoxdataJ.Text = "";
                tBoxdataK.Text = "";
                tBoxdataL.Text = "";
                tBoxdataM.Text = "";
                tBoxdataN.Text = "";
                tBoxdataO.Text = "";
                tBoxdataP.Text = "";
                tBoxdataQ.Text = "";
                tBoxdataR.Text = "";
                tBoxdataS.Text = "";
                tBoxdataT.Text = "";

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(dataIN.IndexOf("A"));
                indexOfB = Convert.ToSByte(dataIN.IndexOf("B"));
                indexOfC = Convert.ToSByte(dataIN.IndexOf("C"));
                indexOfD = Convert.ToSByte(dataIN.IndexOf("D"));
                indexOfE = Convert.ToSByte(dataIN.IndexOf("E"));
                indexOfF = Convert.ToSByte(dataIN.IndexOf("F"));
                indexOfG = Convert.ToSByte(dataIN.IndexOf("G"));
                indexOfH = Convert.ToSByte(dataIN.IndexOf("H"));
                indexOfI = Convert.ToSByte(dataIN.IndexOf("I"));
                indexOfJ = Convert.ToSByte(dataIN.IndexOf("J"));
                indexOfK = Convert.ToSByte(dataIN.IndexOf("K"));
                indexOfL = Convert.ToSByte(dataIN.IndexOf("L"));
                indexOfM = Convert.ToSByte(dataIN.IndexOf("M"));
                indexOfN = Convert.ToSByte(dataIN.IndexOf("N"));
                indexOfO = Convert.ToSByte(dataIN.IndexOf("O"));
                indexOfP = Convert.ToSByte(dataIN.IndexOf("P"));
                indexOfQ = Convert.ToSByte(dataIN.IndexOf("Q"));
                indexOfR = Convert.ToSByte(dataIN.IndexOf("R"));
                indexOfS = Convert.ToSByte(dataIN.IndexOf("S"));
                indexOfT = Convert.ToSByte(dataIN.IndexOf("T"));

                dataA = dataIN.Substring(0, indexOfA);
                dataB = dataIN.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                dataC = dataIN.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                dataD = dataIN.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                dataE = dataIN.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                dataF = dataIN.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                dataG = dataIN.Substring(indexOfF + 1, (indexOfG - indexOfF) - 1);
                dataH = dataIN.Substring(indexOfG + 1, (indexOfH - indexOfG) - 1);
                dataI = dataIN.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);
                dataJ = dataIN.Substring(indexOfI + 1, (indexOfJ - indexOfI) - 1);
                dataK = dataIN.Substring(indexOfJ + 1, (indexOfK - indexOfJ) - 1);
                dataL = dataIN.Substring(indexOfK + 1, (indexOfL - indexOfK) - 1);
                dataM = dataIN.Substring(indexOfL + 1, (indexOfM - indexOfL) - 1);
                dataN = dataIN.Substring(indexOfM + 1, (indexOfN - indexOfM) - 1);
                dataO = dataIN.Substring(indexOfN + 1, (indexOfO - indexOfN) - 1);
                dataP = dataIN.Substring(indexOfO + 1, (indexOfP - indexOfO) - 1);
                dataQ = dataIN.Substring(indexOfP + 1, (indexOfQ - indexOfP) - 1);
                dataR = dataIN.Substring(indexOfQ + 1, (indexOfR - indexOfQ) - 1);
                dataS = dataIN.Substring(indexOfR + 1, (indexOfS - indexOfR) - 1);
                dataT = dataIN.Substring(indexOfS + 1, (indexOfT - indexOfS) - 1);


                tBoxdataA.Text = dataA;
                tBoxdataB.Text = dataB;
                tBoxdataC.Text = dataC;
                tBoxdataD.Text = dataD;
                tBoxdataE.Text = dataE;
                tBoxdataF.Text = dataF;
                tBoxdataG.Text = dataG;
                tBoxdataH.Text = dataH;
                tBoxdataI.Text = dataI;
                tBoxdataJ.Text = dataJ;
                tBoxdataK.Text = dataK;
                tBoxdataL.Text = dataL;
                tBoxdataM.Text = dataM;
                tBoxdataN.Text = dataN;
                tBoxdataO.Text = dataO;
                tBoxdataP.Text = dataP;
                tBoxdataQ.Text = dataQ;
                tBoxdataR.Text = dataR;
                tBoxdataS.Text = dataS;
                tBoxdataT.Text = dataT;

                IDataA = Convert.ToInt32(dataA);

                if (IDataA >= limDA && IDataA <= limUA) 
                {
                    lblDataA.Text = "Pass";
                }
                else
                {
                    lblDataA.Text = "Fail";
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
