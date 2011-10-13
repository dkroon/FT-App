namespace FTAppWM6
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbRowPlant = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dtpAnthesis = new System.Windows.Forms.DateTimePicker();
            this.dtpSilking = new System.Windows.Forms.DateTimePicker();
            this.lblAnthesis = new System.Windows.Forms.Label();
            this.lblSilking = new System.Windows.Forms.Label();
            this.btnAnthesisAccept = new System.Windows.Forms.Button();
            this.btnSilkingAccept = new System.Windows.Forms.Button();
            this.btnAnthesisNext = new System.Windows.Forms.Button();
            this.btnAnthesisLast = new System.Windows.Forms.Button();
            this.btnSilkingNext = new System.Windows.Forms.Button();
            this.btnSilkingLast = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnAntNoData = new System.Windows.Forms.Button();
            this.btnSilkingNoData = new System.Windows.Forms.Button();
            this.cbxPlusMinusHundred = new System.Windows.Forms.CheckBox();
            this.cbxPlusMinusTen = new System.Windows.Forms.CheckBox();
            this.cbxPlusMinusThousand = new System.Windows.Forms.CheckBox();
            this.lblAddSub = new System.Windows.Forms.Label();
            this.cbxPlusMinusOne = new System.Windows.Forms.CheckBox();
            this.btnAntRemoveData = new System.Windows.Forms.Button();
            this.btnSilkRemoveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRowPlant
            // 
            this.cmbRowPlant.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.cmbRowPlant.Location = new System.Drawing.Point(32, 6);
            this.cmbRowPlant.Name = "cmbRowPlant";
            this.cmbRowPlant.Size = new System.Drawing.Size(160, 49);
            this.cmbRowPlant.TabIndex = 0;
            this.cmbRowPlant.SelectedIndexChanged += new System.EventHandler(this.cmbRowPlant_SelectedIndexChanged);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnLast.Location = new System.Drawing.Point(0, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 49);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "<";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(198, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 49);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dtpAnthesis
            // 
            this.dtpAnthesis.CalendarFont = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.dtpAnthesis.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.dtpAnthesis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnthesis.Location = new System.Drawing.Point(32, 97);
            this.dtpAnthesis.Name = "dtpAnthesis";
            this.dtpAnthesis.Size = new System.Drawing.Size(171, 36);
            this.dtpAnthesis.TabIndex = 3;
            this.dtpAnthesis.ValueChanged += new System.EventHandler(this.dtpAnthesis_ValueChanged);
            // 
            // dtpSilking
            // 
            this.dtpSilking.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.dtpSilking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSilking.Location = new System.Drawing.Point(32, 189);
            this.dtpSilking.Name = "dtpSilking";
            this.dtpSilking.Size = new System.Drawing.Size(171, 36);
            this.dtpSilking.TabIndex = 4;
            this.dtpSilking.ValueChanged += new System.EventHandler(this.dtpSilking_ValueChanged);
            // 
            // lblAnthesis
            // 
            this.lblAnthesis.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblAnthesis.Location = new System.Drawing.Point(3, 73);
            this.lblAnthesis.Name = "lblAnthesis";
            this.lblAnthesis.Size = new System.Drawing.Size(119, 24);
            this.lblAnthesis.Text = "Anthesis";
            // 
            // lblSilking
            // 
            this.lblSilking.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblSilking.Location = new System.Drawing.Point(3, 163);
            this.lblSilking.Name = "lblSilking";
            this.lblSilking.Size = new System.Drawing.Size(102, 30);
            this.lblSilking.Text = "Silking";
            // 
            // btnAnthesisAccept
            // 
            this.btnAnthesisAccept.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnthesisAccept.Location = new System.Drawing.Point(126, 139);
            this.btnAnthesisAccept.Name = "btnAnthesisAccept";
            this.btnAnthesisAccept.Size = new System.Drawing.Size(77, 36);
            this.btnAnthesisAccept.TabIndex = 7;
            this.btnAnthesisAccept.Text = "Save";
            this.btnAnthesisAccept.Click += new System.EventHandler(this.btnAnthesisAccept_Click);
            // 
            // btnSilkingAccept
            // 
            this.btnSilkingAccept.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnSilkingAccept.Location = new System.Drawing.Point(126, 228);
            this.btnSilkingAccept.Name = "btnSilkingAccept";
            this.btnSilkingAccept.Size = new System.Drawing.Size(77, 37);
            this.btnSilkingAccept.TabIndex = 8;
            this.btnSilkingAccept.Text = "Save";
            this.btnSilkingAccept.Click += new System.EventHandler(this.btnSilkingAccept_Click);
            // 
            // btnAnthesisNext
            // 
            this.btnAnthesisNext.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnthesisNext.Location = new System.Drawing.Point(209, 97);
            this.btnAnthesisNext.Name = "btnAnthesisNext";
            this.btnAnthesisNext.Size = new System.Drawing.Size(31, 68);
            this.btnAnthesisNext.TabIndex = 9;
            this.btnAnthesisNext.Text = ">";
            this.btnAnthesisNext.Click += new System.EventHandler(this.btnAnthesisNext_Click);
            // 
            // btnAnthesisLast
            // 
            this.btnAnthesisLast.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnthesisLast.Location = new System.Drawing.Point(0, 97);
            this.btnAnthesisLast.Name = "btnAnthesisLast";
            this.btnAnthesisLast.Size = new System.Drawing.Size(35, 68);
            this.btnAnthesisLast.TabIndex = 10;
            this.btnAnthesisLast.Text = "<";
            this.btnAnthesisLast.Click += new System.EventHandler(this.btnAnthesisLast_Click);
            // 
            // btnSilkingNext
            // 
            this.btnSilkingNext.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnSilkingNext.Location = new System.Drawing.Point(209, 190);
            this.btnSilkingNext.Name = "btnSilkingNext";
            this.btnSilkingNext.Size = new System.Drawing.Size(31, 69);
            this.btnSilkingNext.TabIndex = 11;
            this.btnSilkingNext.Text = ">";
            this.btnSilkingNext.Click += new System.EventHandler(this.btnSilkingNext_Click);
            // 
            // btnSilkingLast
            // 
            this.btnSilkingLast.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnSilkingLast.Location = new System.Drawing.Point(0, 189);
            this.btnSilkingLast.Name = "btnSilkingLast";
            this.btnSilkingLast.Size = new System.Drawing.Size(33, 70);
            this.btnSilkingLast.TabIndex = 12;
            this.btnSilkingLast.Text = "<";
            this.btnSilkingLast.Click += new System.EventHandler(this.btnSilkingLast_Click);
            // 
            // btnAntNoData
            // 
            this.btnAntNoData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAntNoData.Location = new System.Drawing.Point(39, 139);
            this.btnAntNoData.Name = "btnAntNoData";
            this.btnAntNoData.Size = new System.Drawing.Size(36, 26);
            this.btnAntNoData.TabIndex = 15;
            this.btnAntNoData.Text = "ND";
            this.btnAntNoData.Click += new System.EventHandler(this.btnAntNoData_Click);
            // 
            // btnSilkingNoData
            // 
            this.btnSilkingNoData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSilkingNoData.Location = new System.Drawing.Point(39, 231);
            this.btnSilkingNoData.Name = "btnSilkingNoData";
            this.btnSilkingNoData.Size = new System.Drawing.Size(36, 28);
            this.btnSilkingNoData.TabIndex = 16;
            this.btnSilkingNoData.Text = "ND";
            this.btnSilkingNoData.Click += new System.EventHandler(this.btnSilkingNoData_Click);
            // 
            // cbxPlusMinusHundred
            // 
            this.cbxPlusMinusHundred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPlusMinusHundred.Location = new System.Drawing.Point(91, 55);
            this.cbxPlusMinusHundred.Name = "cbxPlusMinusHundred";
            this.cbxPlusMinusHundred.Size = new System.Drawing.Size(73, 20);
            this.cbxPlusMinusHundred.TabIndex = 19;
            this.cbxPlusMinusHundred.Text = "100";
            // 
            // cbxPlusMinusTen
            // 
            this.cbxPlusMinusTen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPlusMinusTen.Location = new System.Drawing.Point(148, 55);
            this.cbxPlusMinusTen.Name = "cbxPlusMinusTen";
            this.cbxPlusMinusTen.Size = new System.Drawing.Size(55, 20);
            this.cbxPlusMinusTen.TabIndex = 20;
            this.cbxPlusMinusTen.Text = "10";
            // 
            // cbxPlusMinusThousand
            // 
            this.cbxPlusMinusThousand.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPlusMinusThousand.Location = new System.Drawing.Point(32, 55);
            this.cbxPlusMinusThousand.Name = "cbxPlusMinusThousand";
            this.cbxPlusMinusThousand.Size = new System.Drawing.Size(73, 20);
            this.cbxPlusMinusThousand.TabIndex = 21;
            this.cbxPlusMinusThousand.Text = "1000";
            // 
            // lblAddSub
            // 
            this.lblAddSub.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblAddSub.Location = new System.Drawing.Point(3, 56);
            this.lblAddSub.Name = "lblAddSub";
            this.lblAddSub.Size = new System.Drawing.Size(41, 20);
            this.lblAddSub.Text = "+/-";
            // 
            // cbxPlusMinusOne
            // 
            this.cbxPlusMinusOne.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPlusMinusOne.Location = new System.Drawing.Point(192, 55);
            this.cbxPlusMinusOne.Name = "cbxPlusMinusOne";
            this.cbxPlusMinusOne.Size = new System.Drawing.Size(45, 20);
            this.cbxPlusMinusOne.TabIndex = 23;
            this.cbxPlusMinusOne.Text = "1";
            // 
            // btnAntRemoveData
            // 
            this.btnAntRemoveData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAntRemoveData.Location = new System.Drawing.Point(78, 139);
            this.btnAntRemoveData.Name = "btnAntRemoveData";
            this.btnAntRemoveData.Size = new System.Drawing.Size(44, 26);
            this.btnAntRemoveData.TabIndex = 27;
            this.btnAntRemoveData.Text = "REM";
            this.btnAntRemoveData.Click += new System.EventHandler(this.btnAntRemoveData_Click);
            // 
            // btnSilkRemoveData
            // 
            this.btnSilkRemoveData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSilkRemoveData.Location = new System.Drawing.Point(78, 231);
            this.btnSilkRemoveData.Name = "btnSilkRemoveData";
            this.btnSilkRemoveData.Size = new System.Drawing.Size(44, 28);
            this.btnSilkRemoveData.TabIndex = 28;
            this.btnSilkRemoveData.Text = "REM";
            this.btnSilkRemoveData.Click += new System.EventHandler(this.btnSilkRemoveData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnSilkRemoveData);
            this.Controls.Add(this.btnAntRemoveData);
            this.Controls.Add(this.cbxPlusMinusOne);
            this.Controls.Add(this.btnSilkingNoData);
            this.Controls.Add(this.btnAntNoData);
            this.Controls.Add(this.btnSilkingLast);
            this.Controls.Add(this.btnSilkingNext);
            this.Controls.Add(this.btnAnthesisLast);
            this.Controls.Add(this.btnAnthesisNext);
            this.Controls.Add(this.dtpSilking);
            this.Controls.Add(this.btnSilkingAccept);
            this.Controls.Add(this.btnAnthesisAccept);
            this.Controls.Add(this.lblSilking);
            this.Controls.Add(this.lblAnthesis);
            this.Controls.Add(this.dtpAnthesis);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.cmbRowPlant);
            this.Controls.Add(this.cbxPlusMinusTen);
            this.Controls.Add(this.cbxPlusMinusHundred);
            this.Controls.Add(this.cbxPlusMinusThousand);
            this.Controls.Add(this.lblAddSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flowering Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRowPlant;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dtpAnthesis;
        private System.Windows.Forms.DateTimePicker dtpSilking;
        private System.Windows.Forms.Label lblAnthesis;
        private System.Windows.Forms.Label lblSilking;
        private System.Windows.Forms.Button btnAnthesisAccept;
        private System.Windows.Forms.Button btnSilkingAccept;
        private System.Windows.Forms.Button btnAnthesisNext;
        private System.Windows.Forms.Button btnAnthesisLast;
        private System.Windows.Forms.Button btnSilkingNext;
        private System.Windows.Forms.Button btnSilkingLast;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Button btnAntNoData;
        private System.Windows.Forms.Button btnSilkingNoData;
        private System.Windows.Forms.CheckBox cbxPlusMinusHundred;
        private System.Windows.Forms.CheckBox cbxPlusMinusTen;
        private System.Windows.Forms.CheckBox cbxPlusMinusThousand;
        private System.Windows.Forms.Label lblAddSub;
        private System.Windows.Forms.CheckBox cbxPlusMinusOne;
        private System.Windows.Forms.Button btnAntRemoveData;
        private System.Windows.Forms.Button btnSilkRemoveData;
    }
}

