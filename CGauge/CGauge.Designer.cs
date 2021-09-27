namespace CGauge
{
    partial class CGauge
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
            this.components = new System.ComponentModel.Container();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightClickMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMinimumTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.rightClickMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMaximumTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.rightClickWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickWarningTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.rightClickAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickAlarmTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.btMinimumApply = new System.Windows.Forms.ToolStripMenuItem();
            this.btMaximumApply = new System.Windows.Forms.ToolStripMenuItem();
            this.btWarningApply = new System.Windows.Forms.ToolStripMenuItem();
            this.btAlarmApply = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickMinimum,
            this.rightClickMaximum,
            this.rightClickWarning,
            this.rightClickAlarm});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // rightClickMinimum
            // 
            this.rightClickMinimum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickMinimumTextbox,
            this.btMinimumApply});
            this.rightClickMinimum.Name = "rightClickMinimum";
            this.rightClickMinimum.Size = new System.Drawing.Size(180, 22);
            this.rightClickMinimum.Text = "Minimum";
            // 
            // rightClickMinimumTextbox
            // 
            this.rightClickMinimumTextbox.Name = "rightClickMinimumTextbox";
            this.rightClickMinimumTextbox.Size = new System.Drawing.Size(100, 23);
            // 
            // rightClickMaximum
            // 
            this.rightClickMaximum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickMaximumTextbox,
            this.btMaximumApply});
            this.rightClickMaximum.Name = "rightClickMaximum";
            this.rightClickMaximum.Size = new System.Drawing.Size(180, 22);
            this.rightClickMaximum.Text = "Maximum";
            // 
            // rightClickMaximumTextbox
            // 
            this.rightClickMaximumTextbox.Name = "rightClickMaximumTextbox";
            this.rightClickMaximumTextbox.Size = new System.Drawing.Size(100, 23);
            // 
            // rightClickWarning
            // 
            this.rightClickWarning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickWarningTextbox,
            this.btWarningApply});
            this.rightClickWarning.Name = "rightClickWarning";
            this.rightClickWarning.Size = new System.Drawing.Size(180, 22);
            this.rightClickWarning.Text = "Warning Threshold";
            // 
            // rightClickWarningTextbox
            // 
            this.rightClickWarningTextbox.Name = "rightClickWarningTextbox";
            this.rightClickWarningTextbox.Size = new System.Drawing.Size(100, 23);
            // 
            // rightClickAlarm
            // 
            this.rightClickAlarm.AccessibleName = "";
            this.rightClickAlarm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickAlarmTextbox,
            this.btAlarmApply});
            this.rightClickAlarm.Name = "rightClickAlarm";
            this.rightClickAlarm.Size = new System.Drawing.Size(180, 22);
            this.rightClickAlarm.Text = "Alarm Threshold";
            // 
            // rightClickAlarmTextbox
            // 
            this.rightClickAlarmTextbox.Name = "rightClickAlarmTextbox";
            this.rightClickAlarmTextbox.Size = new System.Drawing.Size(100, 23);
            // 
            // btMinimumApply
            // 
            this.btMinimumApply.Name = "btMinimumApply";
            this.btMinimumApply.Size = new System.Drawing.Size(180, 22);
            this.btMinimumApply.Text = "Apply";
            this.btMinimumApply.Click += new System.EventHandler(this.btMinimumApply_Click);
            // 
            // btMaximumApply
            // 
            this.btMaximumApply.Name = "btMaximumApply";
            this.btMaximumApply.Size = new System.Drawing.Size(180, 22);
            this.btMaximumApply.Text = "Apply";
            this.btMaximumApply.Click += new System.EventHandler(this.btMaximumApply_Click);
            // 
            // btWarningApply
            // 
            this.btWarningApply.Name = "btWarningApply";
            this.btWarningApply.Size = new System.Drawing.Size(180, 22);
            this.btWarningApply.Text = "Apply";
            this.btWarningApply.Click += new System.EventHandler(this.btWarningApply_Click);
            // 
            // btAlarmApply
            // 
            this.btAlarmApply.Name = "btAlarmApply";
            this.btAlarmApply.Size = new System.Drawing.Size(180, 22);
            this.btAlarmApply.Text = "Apply";
            this.btAlarmApply.Click += new System.EventHandler(this.btAlarmApply_Click);
            // 
            // CGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CGauge";
            this.Size = new System.Drawing.Size(192, 208);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CGauge_MouseDown);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem rightClickMinimum;
        private System.Windows.Forms.ToolStripMenuItem rightClickMaximum;
        private System.Windows.Forms.ToolStripMenuItem rightClickWarning;
        private System.Windows.Forms.ToolStripMenuItem rightClickAlarm;
        private System.Windows.Forms.ToolStripTextBox rightClickMinimumTextbox;
        private System.Windows.Forms.ToolStripTextBox rightClickMaximumTextbox;
        private System.Windows.Forms.ToolStripTextBox rightClickWarningTextbox;
        private System.Windows.Forms.ToolStripTextBox rightClickAlarmTextbox;
        private System.Windows.Forms.ToolStripMenuItem btMinimumApply;
        private System.Windows.Forms.ToolStripMenuItem btMaximumApply;
        private System.Windows.Forms.ToolStripMenuItem btWarningApply;
        private System.Windows.Forms.ToolStripMenuItem btAlarmApply;
    }
}
