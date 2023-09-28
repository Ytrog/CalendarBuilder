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
            lblDay.AutoSize = true;
            lblDay.Dock = DockStyle.Left;
            lblDay.Location = new Point(0, 0);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(0, 15);
            lblDay.TabIndex = 0;
            // 
            // DayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDay);
            Name = "DayControl";
            Size = new Size(173, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDay;
    }
}
