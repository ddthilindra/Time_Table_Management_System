namespace app.Forms.Control
{
    partial class H_lecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H_lecture));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLecturer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSubject = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(14, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 54);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1136, 658);
            this.panelContainer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnLecturer);
            this.groupBox1.Controls.Add(this.bunifuButton1);
            this.groupBox1.Controls.Add(this.btnSubject);
            this.groupBox1.Location = new System.Drawing.Point(32, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 592);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lecturer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLecturer
            // 
            this.btnLecturer.AllowToggling = false;
            this.btnLecturer.AnimationSpeed = 200;
            this.btnLecturer.AutoGenerateColors = false;
            this.btnLecturer.BackColor = System.Drawing.Color.Transparent;
            this.btnLecturer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLecturer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLecturer.BackgroundImage")));
            this.btnLecturer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLecturer.ButtonText = "Lecturer";
            this.btnLecturer.ButtonTextMarginLeft = 0;
            this.btnLecturer.ColorContrastOnClick = 45;
            this.btnLecturer.ColorContrastOnHover = 45;
            this.btnLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLecturer.CustomizableEdges = borderEdges1;
            this.btnLecturer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLecturer.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnLecturer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLecturer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLecturer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLecturer.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.btnLecturer.ForeColor = System.Drawing.Color.White;
            this.btnLecturer.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLecturer.IconMarginLeft = 30;
            this.btnLecturer.IconPadding = 10;
            this.btnLecturer.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLecturer.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLecturer.IdleBorderRadius = 45;
            this.btnLecturer.IdleBorderThickness = 3;
            this.btnLecturer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLecturer.IdleIconLeftImage = null;
            this.btnLecturer.IdleIconRightImage = null;
            this.btnLecturer.IndicateFocus = true;
            this.btnLecturer.Location = new System.Drawing.Point(93, 67);
            this.btnLecturer.Name = "btnLecturer";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties1.BorderRadius = 45;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 3;
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLecturer.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.BorderRadius = 45;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 3;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLecturer.OnPressedState = stateProperties2;
            this.btnLecturer.Size = new System.Drawing.Size(325, 192);
            this.btnLecturer.TabIndex = 4;
            this.btnLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLecturer.TextMarginLeft = 0;
            this.btnLecturer.UseDefaultRadiusAndThickness = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.AllowToggling = false;
            this.btnSubject.AnimationSpeed = 200;
            this.btnSubject.AutoGenerateColors = false;
            this.btnSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnSubject.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            this.btnSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubject.BackgroundImage")));
            this.btnSubject.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubject.ButtonText = "Subject";
            this.btnSubject.ButtonTextMarginLeft = 0;
            this.btnSubject.ColorContrastOnClick = 45;
            this.btnSubject.ColorContrastOnHover = 45;
            this.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSubject.CustomizableEdges = borderEdges3;
            this.btnSubject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubject.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSubject.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSubject.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSubject.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSubject.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.IconMarginLeft = 30;
            this.btnSubject.IconPadding = 10;
            this.btnSubject.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSubject.IdleBorderRadius = 45;
            this.btnSubject.IdleBorderThickness = 3;
            this.btnSubject.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            this.btnSubject.IdleIconLeftImage = null;
            this.btnSubject.IdleIconRightImage = null;
            this.btnSubject.IndicateFocus = true;
            this.btnSubject.Location = new System.Drawing.Point(448, 67);
            this.btnSubject.Name = "btnSubject";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            stateProperties5.BorderRadius = 45;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 3;
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnSubject.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.White;
            stateProperties6.BorderRadius = 45;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 3;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnSubject.OnPressedState = stateProperties6;
            this.btnSubject.Size = new System.Drawing.Size(325, 192);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubject.TextMarginLeft = 0;
            this.btnSubject.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DarkSlateBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Session";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 30;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 45;
            this.bunifuButton1.IdleBorderThickness = 3;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = true;
            this.bunifuButton1.Location = new System.Drawing.Point(93, 285);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            stateProperties3.BorderRadius = 45;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 3;
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(69)))), ((int)(((byte)(153)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.BorderRadius = 45;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 3;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties4;
            this.bunifuButton1.Size = new System.Drawing.Size(325, 192);
            this.bunifuButton1.TabIndex = 5;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // H_lecture
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "H_lecture";
            this.Size = new System.Drawing.Size(1136, 658);
            this.Load += new System.EventHandler(this.H_lecture_Load);
            this.panel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSubject;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLecturer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}
