
namespace Kalendar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.mcCalendarR = new System.Windows.Forms.MonthCalendar();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.mcCalendarL = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(7, 172);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(124, 21);
            this.cbMonth.TabIndex = 3;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(137, 172);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(119, 21);
            this.cbYear.TabIndex = 4;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            this.cbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbYear_KeyPress);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(4, 209);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(168, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Kalendar v0.0.1 - K.Andreev 2021";
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Yellow;
            this.btnToggle.Location = new System.Drawing.Point(239, 198);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(2);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(18, 24);
            this.btnToggle.TabIndex = 6;
            this.btnToggle.Text = ">";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // mcCalendarR
            // 
            this.mcCalendarR.Location = new System.Drawing.Point(271, 6);
            this.mcCalendarR.MaxSelectionCount = 1;
            this.mcCalendarR.Name = "mcCalendarR";
            this.mcCalendarR.ShowWeekNumbers = true;
            this.mcCalendarR.TabIndex = 7;
            this.mcCalendarR.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendarR_DateChanged);
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(268, 209);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(18, 13);
            this.lblDiff.TabIndex = 8;
            this.lblDiff.Text = "D:";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(268, 172);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(16, 13);
            this.lblLeft.TabIndex = 9;
            this.lblLeft.Text = "L:";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(268, 190);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(18, 13);
            this.lblRight.TabIndex = 10;
            this.lblRight.Text = "R:";
            // 
            // mcCalendarL
            // 
            this.mcCalendarL.Location = new System.Drawing.Point(7, 6);
            this.mcCalendarL.MaxSelectionCount = 1;
            this.mcCalendarL.Name = "mcCalendarL";
            this.mcCalendarL.ShowWeekNumbers = true;
            this.mcCalendarL.TabIndex = 11;
            this.mcCalendarL.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendarL_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 233);
            this.Controls.Add(this.mcCalendarL);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.mcCalendarR);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.MonthCalendar mcCalendarR;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.MonthCalendar mcCalendarL;
    }
}

