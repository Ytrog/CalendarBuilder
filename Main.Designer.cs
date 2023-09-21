namespace CalendarBuilder
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            tsYears = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            tsMonth = new ToolStripComboBox();
            btnCreate = new ToolStripButton();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(1047, 660);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1047, 685);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, tsYears, toolStripLabel2, tsMonth, btnCreate });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(417, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(27, 22);
            toolStripLabel1.Text = "Jaar";
            // 
            // tsYears
            // 
            tsYears.Name = "tsYears";
            tsYears.Size = new Size(121, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(44, 22);
            toolStripLabel2.Text = "Maand";
            // 
            // tsMonth
            // 
            tsMonth.Name = "tsMonth";
            tsMonth.Size = new Size(121, 25);
            // 
            // btnCreate
            // 
            btnCreate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCreate.Image = (Image)resources.GetObject("btnCreate.Image");
            btnCreate.ImageTransparentColor = Color.Magenta;
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(88, 22);
            btnCreate.Text = "Maak kalender";
            btnCreate.Click += btnCreate_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 685);
            Controls.Add(toolStripContainer1);
            Name = "Main";
            Text = "Calendar Builder";
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripComboBox tsMonth;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btnCreate;
        private ToolStripTextBox tsYears;
    }
}