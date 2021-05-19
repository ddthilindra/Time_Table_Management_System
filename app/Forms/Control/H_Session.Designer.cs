namespace app.Forms.Control
{
    partial class H_Session
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tab1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.tab2);
            this.panelContainer.Controls.Add(this.tab1);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1136, 658);
            this.panelContainer.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(68, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(697, 49);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time Table Management System";
            // 
            // tab1
            // 
            this.tab1.BorderColor = System.Drawing.Color.Gainsboro;
            this.tab1.Controls.Add(this.label1);
            this.tab1.Location = new System.Drawing.Point(95, 99);
            this.tab1.Name = "tab1";
            this.tab1.PanelColor = System.Drawing.Color.Empty;
            this.tab1.ShadowDept = 2;
            this.tab1.ShadowTopLeftVisible = false;
            this.tab1.Size = new System.Drawing.Size(342, 199);
            this.tab1.TabIndex = 12;
            this.tab1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuShadowPanel1_MouseClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(87, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Session ";
            // 
            // tab2
            // 
            this.tab2.BorderColor = System.Drawing.Color.Gainsboro;
            this.tab2.Controls.Add(this.label2);
            this.tab2.Location = new System.Drawing.Point(593, 99);
            this.tab2.Name = "tab2";
            this.tab2.PanelColor = System.Drawing.Color.Empty;
            this.tab2.ShadowDept = 2;
            this.tab2.ShadowTopLeftVisible = false;
            this.tab2.Size = new System.Drawing.Size(342, 199);
            this.tab2.TabIndex = 13;
            this.tab2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Session";
            // 
            // H_Session
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelContainer);
            this.Name = "H_Session";
            this.Size = new System.Drawing.Size(1136, 658);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel tab1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel tab2;
        private System.Windows.Forms.Label label1;
    }
}
