namespace CalendarBuilder.Controls
{
    partial class DayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDay = new Label();
            SuspendLayout();
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDay.AutoSize = true;
            lblDay.Location = new Point(68, 10);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(38, 15);
            lblDay.TabIndex = 0;
            lblDay.Text = "label1";
            // 
            // DayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDay);
            Name = "DayControl";
            Size = new Size(175, 182);
            Load += DayControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDay;
    }
}
