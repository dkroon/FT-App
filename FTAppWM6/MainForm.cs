using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.WindowsMobile.Forms;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Globalization;

namespace FTAppWM6
{
    public partial class MainForm : Form
    {
        private IFormatProvider culture = new CultureInfo("en-US", true);
        private SortedList mySL = null;
        private EntityRecord[] erArray = null;
        private FileManager fm = null;
        private string myFilePath = null;
        private string NoDataValue = "01/01/00";
        private int StackOverflowLimit = 250;
        

        public MainForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            dtpAnthesis.CustomFormat = "MM/dd/yyyy";
            dtpAnthesis.Format = DateTimePickerFormat.Custom;
            dtpSilking.CustomFormat = "MM/dd/yyyy";
            dtpSilking.Format = DateTimePickerFormat.Custom;

            // load file and populate the data collection that will populate the combo box
            string modulePath = this.GetType().Assembly.GetModules()[0].FullyQualifiedName;
            string solutionFolder = modulePath.Substring(0, modulePath.LastIndexOf(Path.DirectorySeparatorChar));
            myFilePath = Path.Combine(solutionFolder, "MyData.txt");
            fm = new FileManager();
            try
            {
                erArray = fm.GetEntityRecords(myFilePath);
            }
            catch (Exception e)
            {
                if (e is FormatException)
                {
                    MessageBox.Show("Unable to load file.  Format problem on line " + fm.badLineCount + ":\n" + fm.badLine);
                    this.Close();
                    
                    
                }
                else
                {
                    MessageBox.Show(e.Message);
                    this.Close();
                }
                
            }
            mySL = new SortedList();

            for (int i = 1; i < erArray.Length; i++)
            {
                EntityRecord er = erArray[i];

                mySL.Add(i, er.EntityIDSuffix);

            }
            
            ICollection ic = mySL.Keys;
            IEnumerator ie = ic.GetEnumerator();

            // show a blank field as the first record in the comboBox
            cmbRowPlant.Items.Add("");
            for(int i = 0; i< mySL.Count; i++)
            {
                cmbRowPlant.Items.Add((String)mySL.GetByIndex(i));
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int index = 0;
            // if the +/-1000,+/-100, +/-10 or +/- 1  checkboxes are checked, move to 
            // the appropriate row regardless of whether it has been scored or not
            if (cbxPlusMinusThousand.Checked ||
                cbxPlusMinusHundred.Checked ||
                cbxPlusMinusTen.Checked ||
                cbxPlusMinusOne.Checked)
            {
                index = cmbRowPlant.SelectedIndex - GetStepSize();
                SetUpNextEntityForScoring(index);
            }
            else // if none of +/-1000,+/-100, +/-10 or +/- 1 checkboxes are checked, then getNextEntityNeedingData
            {
                index = getNextEntityNeedingData(cmbRowPlant.SelectedIndex, false, 0);
                if (index <= 0)
                {
                    cmbRowPlant.SelectedIndex = 1;
                }
                else
                {
                    SetUpNextEntityForScoring(index);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = 0;
            // if the +/-1000,+/-100, +/-10 or +/- 1  checkboxes are checked, move to the appropriate
            // row regardless of whether it has been scored or not
            if (cbxPlusMinusThousand.Checked ||
                cbxPlusMinusHundred.Checked ||
                cbxPlusMinusTen.Checked ||
                cbxPlusMinusOne.Checked)
            {
                index = cmbRowPlant.SelectedIndex + GetStepSize();
                SetUpNextEntityForScoring(index);
            }
            else // if none of +/-1000,+/-100, +/-10 or +/- 1 checkboxes are checked, then getNextEntityNeedingData
            {
                index = getNextEntityNeedingData(cmbRowPlant.SelectedIndex, true, 0);

                if (index <= 0)
                {
                    cmbRowPlant.SelectedIndex = 1;
                }
                else
                {
                    SetUpNextEntityForScoring(index);
                }
            }
        }



        //private int getNextEntityNeedingData(int currentEntityIndex, Boolean forward)
        //{
        //    int nextRecordIndex = currentEntityIndex;
        //    Boolean stillLooking =true;
        //    if (currentEntityIndex < 1) { nextRecordIndex = 1; stillLooking = false; }
        //    while (stillLooking && currentEntityIndex < erArray.Length )
        //    {
        //        if (forward)
        //        {
        //            if (nextRecordIndex < erArray.Length - 1) { nextRecordIndex++; }
        //        }
        //        else
        //        {
        //            if (nextRecordIndex > 1) { nextRecordIndex--; }
        //        }
        //        //QQQQ handle array boundaries
        //        EntityRecord nextER = (EntityRecord)erArray[nextRecordIndex];
        //        if (nextER != null && nextRecordIndex >= 1)
        //        {
        //            if (nextER.AnthesisDate == DateTime.MinValue || nextER.SilkingDate == DateTime.MinValue)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    return nextRecordIndex;
        //}

        private int getNextEntityNeedingData(int currentEntityIndex, Boolean forward, int recursionCount)
        {
            int nextRecordIndex = currentEntityIndex;
            if (currentEntityIndex < 1) { return 1; }
            if (currentEntityIndex >= erArray.Length - 1 && forward) { return erArray.Length - 1; }
            if (currentEntityIndex < erArray.Length)
            {
                if (forward)
                {
                    if (nextRecordIndex < erArray.Length ) { nextRecordIndex = nextRecordIndex + GetStepSize(); }
                }else
                {
                    if (nextRecordIndex > 1 ) { nextRecordIndex = nextRecordIndex - GetStepSize(); }
                }
                EntityRecord nextER = (EntityRecord)erArray[nextRecordIndex];
                if (nextER != null && nextRecordIndex > 1)
                {
                    if (nextER.AnthesisDate != DateTime.MinValue && 
                        nextER.SilkingDate != DateTime.MinValue && 
                        recursionCount < erArray.Length &&
                        recursionCount < StackOverflowLimit)
                    {
                        nextRecordIndex = getNextEntityNeedingData(nextRecordIndex, forward, ++recursionCount);
                    }
                }
            }
            return nextRecordIndex;
        }
        private void SetUpNextEntityForScoring(int index)
        {
            int maxIndex = cmbRowPlant.Items.Count - 1 ;
            if (index > maxIndex) { index = maxIndex; }
            if (index < 1) { index = 1; }
            cmbRowPlant.SelectedIndex = index;
            DateTime dtAnthesis = erArray[index].AnthesisDate;
            if (dtAnthesis != DateTime.MinValue)
            {
                dtpAnthesis.Value = dtAnthesis;
                disableButton(btnAnthesisAccept, 12.0F);
                disableButton(btnAntNoData, 10.0F);
                enableButton(btnAntRemoveData, 12.0F);
            }
            else
            {
                dtpAnthesis.Value = DateTime.Now;
                enableButton(btnAnthesisAccept, 20.0F);
                enableButton(btnAntNoData, 12.0F);
                disableButton(btnAntRemoveData, 10.0F);
            }
            DateTime dtSilking = erArray[index].SilkingDate;
            if (dtSilking != DateTime.MinValue)
            {
                dtpSilking.Value = dtSilking;
                disableButton(btnSilkingAccept, 12.0F);
                disableButton(btnSilkingNoData, 10.0F);
                enableButton(btnSilkRemoveData, 12.0F);
            }
            else
            {
                dtpSilking.Value = DateTime.Now;
                enableButton(btnSilkingAccept, 20.0F);
                enableButton(btnSilkingNoData, 12.0F);
                disableButton(btnSilkRemoveData, 10.0F);
            }
        }

        private int GetStepSize()
        {
            int MinimumStepSize = 1;
            int StepSize = 0;
            if (cbxPlusMinusThousand.Checked)   { StepSize = StepSize + 1000; }
            if (cbxPlusMinusHundred.Checked)    { StepSize = StepSize + 100; }
            if (cbxPlusMinusTen.Checked)        { StepSize = StepSize + 10; }
            if (cbxPlusMinusOne.Checked)        { StepSize = StepSize + 1; }
            if (StepSize < MinimumStepSize) { StepSize = MinimumStepSize; }
            return StepSize;
        }
        private void enableButton(Button btn, float fontSize)
        {
            btn.Enabled = true;
            btn.ForeColor = Color.Red;
            btn.Font = new Font("Tahoma", fontSize, FontStyle.Bold);
            this.cmbRowPlant.Focus();
        }

        private void disableButton(Button btn, float fontSize)
        {
            btn.Enabled = false;
            btn.ForeColor = Color.Gray;
            btn.Font = new Font("Tahoma", fontSize, FontStyle.Regular);
            this.cmbRowPlant.Focus();
        }

        private void btnAnthesisAccept_Click(object sender, EventArgs e)
        {
            int selectedIndex =  cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[selectedIndex].AnthesisDate = dtpAnthesis.Value;

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                disableButton(btnAnthesisAccept, 12.0F);
                disableButton(btnAntNoData, 10.0F);
                enableButton(btnAntRemoveData, 12.0F);
            }
        }

        private void btnSilkingAccept_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[cmbRowPlant.SelectedIndex].SilkingDate = dtpSilking.Value;

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                disableButton(btnSilkingAccept, 12.0F);
                disableButton(btnSilkingNoData, 10.0F);
                enableButton(btnSilkRemoveData, 12.0F);
            }
        }

        private void btnAnthesisNext_Click(object sender, EventArgs e)
        {
            dtpAnthesis.Value = dtpAnthesis.Value.AddDays(1);
        }

        private void btnAnthesisLast_Click(object sender, EventArgs e)
        {
            dtpAnthesis.Value = dtpAnthesis.Value.AddDays(-1);
        }

        private void btnSilkingNext_Click(object sender, EventArgs e)
        {
            dtpSilking.Value = dtpSilking.Value.AddDays(1);
        }

        private void btnSilkingLast_Click(object sender, EventArgs e)
        {
            dtpSilking.Value = dtpSilking.Value.AddDays(-1);
        }

        private void cmbRowPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            if (selectedIndex > 0)
            {
                SetUpNextEntityForScoring(selectedIndex);
            }
        }

        private void dtpAnthesis_ValueChanged(object sender, EventArgs e)
        {

            // QQQQ compare if date is the same as the EntityRecord 
            dtpAnthesis.Value.ToShortDateString();
            enableButton(btnAnthesisAccept, 20.0F);
            enableButton(btnAntNoData, 12.0F);
        }

        private void dtpSilking_ValueChanged(object sender, EventArgs e)
        {
            // QQQQ compare if date is the same as the EntityRecord 
            dtpSilking.Value.ToShortDateString();
            enableButton(btnSilkingAccept, 20.0F);
            enableButton(btnSilkingNoData, 12.0F);
        }


        private void btnAntNoData_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[cmbRowPlant.SelectedIndex].AnthesisDate = DateTime.Parse(NoDataValue);

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                dtpAnthesis.Value = DateTime.Parse(NoDataValue);
                disableButton(btnAnthesisAccept, 12.0F);
                disableButton(btnAntNoData, 10.0F);
                enableButton(btnAntRemoveData, 12.0F);
                
            }
        }

        private void btnSilkingNoData_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[cmbRowPlant.SelectedIndex].SilkingDate = DateTime.Parse(NoDataValue);

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                dtpSilking.Value = DateTime.Parse(NoDataValue);
                disableButton(btnSilkingAccept, 12.0F);
                disableButton(btnSilkingNoData, 10.0F);
                enableButton(btnSilkRemoveData, 12.0F);
                
            }
        }

        private void btnAntRemoveData_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[selectedIndex].AnthesisDate = DateTime.MinValue;

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                enableButton(btnAnthesisAccept, 20.0F);
                enableButton(btnAntNoData, 12.0F);
                disableButton(btnAntRemoveData, 10.0F);
                dtpAnthesis.Value = DateTime.Now;
            }
        }

        private void btnSilkRemoveData_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbRowPlant.SelectedIndex;
            // update the EntityRecord[] with new data
            if (selectedIndex > 0)
            {
                erArray[cmbRowPlant.SelectedIndex].SilkingDate = DateTime.MinValue;

                // write it to file
                fm.SaveEntityRecords(myFilePath, erArray);
                enableButton(btnSilkingAccept, 20.0F);
                enableButton(btnSilkingNoData, 12.0F);
                disableButton(btnSilkRemoveData, 10.0F);
                dtpSilking.Value = DateTime.Now;
            }
        }
    }
}