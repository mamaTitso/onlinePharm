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

namespace CriminalApp
{
    public partial class Form1 : Form
    {
        
        int selectedNumber;
        List<String> listOfData = new List<string>();

        public Form1()
        {

            InitializeComponent();

            symtompsList.ResetText();
            btnSubmit.Visible = true;
            selectedItem.Visible = true;
            selectedItem.Text = " ";
            medicineLabel.Visible = false;
            btnNo.Visible = false;
            btnYes.Visible = false;
            recommendDoc.Visible = false;

            //READ FROM FILE===================================================
            using (var reader = new StreamReader("MOCK_DATA.csv"))
            {
                List<string> dataList = new List<string>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    int numberOfSymptomps = 0;
                    string findAllSyptomps = findSymptomps(line, 4);

                    for(int x = 0; x < findAllSyptomps.Length; x++)
                    {
                        if(findAllSyptomps.Substring(x,1) == ".")
                        {
                            numberOfSymptomps++;
                        }
                    }
                    for(int x = 0; x < numberOfSymptomps; x++)
                    {
                        cmbSymptoms.Items.Add(findAllSyptomps.Substring(0, findAllSyptomps.IndexOf(".")));
                        findAllSyptomps = findAllSyptomps.Remove(0, findAllSyptomps.IndexOf(".") + 1);
                    }

                    if (cmbSymptoms.SelectedItem != null)
                    {
                        string selected = this.cmbSymptoms.GetItemText(this.cmbSymptoms.SelectedItem);
                        selectedItem.Text = selected;
                    }
                    //lstData.Items.Add(line+"'");
                    //symtompsList.Items.Add(findSymptomps(line, 4));

                }
            }

            //FIND IF A USER HAS CLICKED IN THE LIST BOX=======================
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String message1 = "You have syptoms of ", message2 = " Can we recommend medicine for you?";
            String disease = findSymptomps(lstData.Items[selectedNumber].ToString(),2);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message1 + disease + Environment.NewLine + message2, "OnlinePharmacy", buttons);
            if (result == DialogResult.Yes)
            {
                btnSubmit.Visible = false;
                selectedItem.Visible = false;
                medicineLabel.Visible = true;
                btnNo.Visible = true;
                btnYes.Visible = true;
                recommendDoc.Visible = true;

                string description = findSymptomps(lstData.Items[selectedNumber].ToString(), 3);
                string medicine = findSymptomps(lstData.Items[selectedNumber].ToString(), 5);
                string doctorInfo="Do you need to see or speak to a Doctor about " +disease+"?";

                medicineLabel.Text = description + Environment.NewLine + Environment.NewLine + "The medicine recommended for you will be '" +
                    medicine + "'";
                recommendDoc.Text = doctorInfo;

            }
            else
            {
                this.Refresh();
            }
        }

        string findSymptomps(string dataLine, int columnNumber)
        {
            string wholeString = dataLine+",", newWord = "";

            for (int x = 0; x < columnNumber; x++)
            {
                newWord = dataLine.Substring(0, dataLine.IndexOf(','));
                dataLine = dataLine.Remove(0, dataLine.IndexOf(',')+1);

            }
            return newWord;
        }

        private void symtompsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (symtompsList.SelectedItem != null)
            {
                selectedNumber = symtompsList.SelectedIndex;
                //selectedItem.Text = Environment.NewLine + symtompsList.SelectedItem.ToString();
               
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string DoctorName = findSymptomps(lstData.Items[selectedNumber].ToString(), 6);
            var DoctorNumber = findSymptomps(lstData.Items[selectedNumber].ToString(), 7);
            //var DoctorAdd = findSymptomps(lstData.Items[selectedNumber].ToString(), 8);
            DialogResult results= MessageBox.Show("Dr " + DoctorName + Environment.NewLine + DoctorNumber + Environment.NewLine);
            if (results == DialogResult.OK)
                this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Height = 434;
            Width = 704;
        }

        private void wellcome_Click(object sender, EventArgs e)
        {

        }
    }
}
