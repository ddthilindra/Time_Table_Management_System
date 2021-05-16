namespace app.Forms.Student
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.lable1 = new System.Windows.Forms.Label();
            this.lbl_AYS = new System.Windows.Forms.Label();
            this.Text_AYS = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Programme = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbl_prg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(61, 33);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(309, 37);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Add Student Groups";
            this.lable1.Click += new System.EventHandler(this.lable1_Click);
            // 
            // lbl_AYS
            // 
            this.lbl_AYS.AutoSize = true;
            this.lbl_AYS.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AYS.Location = new System.Drawing.Point(63, 126);
            this.lbl_AYS.Name = "lbl_AYS";
            this.lbl_AYS.Size = new System.Drawing.Size(242, 22);
            this.lbl_AYS.TabIndex = 7;
            this.lbl_AYS.Text = "Acadamic Year Semester";
            // 
            // Text_AYS
            // 
            this.Text_AYS.AcceptsReturn = false;
            this.Text_AYS.AcceptsTab = false;
            this.Text_AYS.AnimationSpeed = 200;
            this.Text_AYS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Text_AYS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Text_AYS.BackColor = System.Drawing.Color.Transparent;
            this.Text_AYS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Text_AYS.BackgroundImage")));
            this.Text_AYS.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Text_AYS.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Text_AYS.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Text_AYS.BorderColorIdle = System.Drawing.Color.Silver;
            this.Text_AYS.BorderRadius = 1;
            this.Text_AYS.BorderThickness = 1;
            this.Text_AYS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Text_AYS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_AYS.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Text_AYS.DefaultText = "";
            this.Text_AYS.FillColor = System.Drawing.Color.White;
            this.Text_AYS.HideSelection = true;
            this.Text_AYS.IconLeft = null;
            this.Text_AYS.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_AYS.IconPadding = 10;
            this.Text_AYS.IconRight = null;
            this.Text_AYS.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_AYS.Lines = new string[0];
            this.Text_AYS.Location = new System.Drawing.Point(311, 113);
            this.Text_AYS.MaxLength = 32767;
            this.Text_AYS.MinimumSize = new System.Drawing.Size(100, 35);
            this.Text_AYS.Modified = false;
            this.Text_AYS.Multiline = false;
            this.Text_AYS.Name = "Text_AYS";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Text_AYS.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Text_AYS.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Text_AYS.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Text_AYS.OnIdleState = stateProperties4;
            this.Text_AYS.PasswordChar = '\0';
            this.Text_AYS.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Text_AYS.PlaceholderText = "Enter text";
            this.Text_AYS.ReadOnly = false;
            this.Text_AYS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Text_AYS.SelectedText = "";
            this.Text_AYS.SelectionLength = 0;
            this.Text_AYS.SelectionStart = 0;
            this.Text_AYS.ShortcutsEnabled = true;
            this.Text_AYS.Size = new System.Drawing.Size(248, 35);
            this.Text_AYS.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.Text_AYS.TabIndex = 8;
            this.Text_AYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Text_AYS.TextMarginBottom = 0;
            this.Text_AYS.TextMarginLeft = 5;
            this.Text_AYS.TextMarginTop = 0;
            this.Text_AYS.TextPlaceholder = "Enter text";
            this.Text_AYS.UseSystemPasswordChar = false;
            this.Text_AYS.WordWrap = true;
            // 
            // Programme
            // 
            this.Programme.AutoSize = true;
            this.Programme.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programme.Location = new System.Drawing.Point(64, 189);
            this.Programme.Name = "Programme";
            this.Programme.Size = new System.Drawing.Size(117, 22);
            this.Programme.TabIndex = 7;
            this.Programme.Text = "Programme";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(311, 189);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(248, 37);
            this.bunifuDropdown1.TabIndex = 9;
            // 
            // lbl_prg
            // 
            this.lbl_prg.AutoSize = true;
            this.lbl_prg.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prg.Location = new System.Drawing.Point(64, 256);
            this.lbl_prg.Name = "lbl_prg";
            this.lbl_prg.Size = new System.Drawing.Size(117, 22);
            this.lbl_prg.TabIndex = 7;
            this.lbl_prg.Text = "Programme";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.Text_AYS);
            this.Controls.Add(this.lbl_prg);
            this.Controls.Add(this.Programme);
            this.Controls.Add(this.lbl_AYS);
            this.Controls.Add(this.lable1);
            this.Name = "Add_Student";
            this.Size = new System.Drawing.Size(1127, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lbl_AYS;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Text_AYS;
        private System.Windows.Forms.Label Programme;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label lbl_prg;
    }
}
