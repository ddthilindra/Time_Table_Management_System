namespace app.Forms.Student
{
    partial class Add_Student_Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student_Groups));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.prog_drop = new System.Windows.Forms.ComboBox();
            this.Ac_Year_Sem_Drop = new System.Windows.Forms.ComboBox();
            this.Sub_Group_Id = new System.Windows.Forms.TextBox();
            this.subGroupIdLbl = new System.Windows.Forms.Label();
            this.Group_Id = new System.Windows.Forms.TextBox();
            this.GroupIdLbl = new System.Windows.Forms.Label();
            this.Sub_Group_no = new System.Windows.Forms.NumericUpDown();
            this.SubGroupNoLbl = new System.Windows.Forms.Label();
            this.Group_No = new System.Windows.Forms.NumericUpDown();
            this.GroupNoLbl = new System.Windows.Forms.Label();
            this.progLbl = new System.Windows.Forms.Label();
            this.AcYrSemLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Generate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.Sub_Group_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_No)).BeginInit();
            this.SuspendLayout();
            // 
            // prog_drop
            // 
            this.prog_drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prog_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prog_drop.FormattingEnabled = true;
            this.prog_drop.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "CSNE",
            "IM",
            "ISE"});
            this.prog_drop.Location = new System.Drawing.Point(382, 230);
            this.prog_drop.Margin = new System.Windows.Forms.Padding(4);
            this.prog_drop.Name = "prog_drop";
            this.prog_drop.Size = new System.Drawing.Size(160, 28);
            this.prog_drop.TabIndex = 35;
            // 
            // Ac_Year_Sem_Drop
            // 
            this.Ac_Year_Sem_Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ac_Year_Sem_Drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ac_Year_Sem_Drop.FormattingEnabled = true;
            this.Ac_Year_Sem_Drop.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.Ac_Year_Sem_Drop.Location = new System.Drawing.Point(382, 137);
            this.Ac_Year_Sem_Drop.Margin = new System.Windows.Forms.Padding(4);
            this.Ac_Year_Sem_Drop.Name = "Ac_Year_Sem_Drop";
            this.Ac_Year_Sem_Drop.Size = new System.Drawing.Size(160, 28);
            this.Ac_Year_Sem_Drop.TabIndex = 34;
            // 
            // Sub_Group_Id
            // 
            this.Sub_Group_Id.Location = new System.Drawing.Point(795, 424);
            this.Sub_Group_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Sub_Group_Id.Name = "Sub_Group_Id";
            this.Sub_Group_Id.ReadOnly = true;
            this.Sub_Group_Id.Size = new System.Drawing.Size(132, 22);
            this.Sub_Group_Id.TabIndex = 30;
            // 
            // subGroupIdLbl
            // 
            this.subGroupIdLbl.AutoSize = true;
            this.subGroupIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupIdLbl.Location = new System.Drawing.Point(661, 424);
            this.subGroupIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subGroupIdLbl.Name = "subGroupIdLbl";
            this.subGroupIdLbl.Size = new System.Drawing.Size(124, 24);
            this.subGroupIdLbl.TabIndex = 29;
            this.subGroupIdLbl.Text = "Sub Group ID";
            // 
            // Group_Id
            // 
            this.Group_Id.Location = new System.Drawing.Point(795, 334);
            this.Group_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Id.Name = "Group_Id";
            this.Group_Id.ReadOnly = true;
            this.Group_Id.Size = new System.Drawing.Size(132, 22);
            this.Group_Id.TabIndex = 28;
            // 
            // GroupIdLbl
            // 
            this.GroupIdLbl.AutoSize = true;
            this.GroupIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupIdLbl.Location = new System.Drawing.Point(661, 331);
            this.GroupIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GroupIdLbl.Name = "GroupIdLbl";
            this.GroupIdLbl.Size = new System.Drawing.Size(85, 24);
            this.GroupIdLbl.TabIndex = 27;
            this.GroupIdLbl.Text = "Group ID";
            // 
            // Sub_Group_no
            // 
            this.Sub_Group_no.Location = new System.Drawing.Point(383, 427);
            this.Sub_Group_no.Margin = new System.Windows.Forms.Padding(4);
            this.Sub_Group_no.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Sub_Group_no.Name = "Sub_Group_no";
            this.Sub_Group_no.Size = new System.Drawing.Size(160, 22);
            this.Sub_Group_no.TabIndex = 26;
            // 
            // SubGroupNoLbl
            // 
            this.SubGroupNoLbl.AutoSize = true;
            this.SubGroupNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubGroupNoLbl.Location = new System.Drawing.Point(142, 424);
            this.SubGroupNoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubGroupNoLbl.Name = "SubGroupNoLbl";
            this.SubGroupNoLbl.Size = new System.Drawing.Size(176, 24);
            this.SubGroupNoLbl.TabIndex = 25;
            this.SubGroupNoLbl.Text = "Sub Group Number";
            // 
            // Group_No
            // 
            this.Group_No.Location = new System.Drawing.Point(383, 331);
            this.Group_No.Margin = new System.Windows.Forms.Padding(4);
            this.Group_No.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Group_No.Name = "Group_No";
            this.Group_No.Size = new System.Drawing.Size(160, 22);
            this.Group_No.TabIndex = 24;
            // 
            // GroupNoLbl
            // 
            this.GroupNoLbl.AutoSize = true;
            this.GroupNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNoLbl.Location = new System.Drawing.Point(142, 331);
            this.GroupNoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GroupNoLbl.Name = "GroupNoLbl";
            this.GroupNoLbl.Size = new System.Drawing.Size(137, 24);
            this.GroupNoLbl.TabIndex = 23;
            this.GroupNoLbl.Text = "Group Number";
            // 
            // progLbl
            // 
            this.progLbl.AutoSize = true;
            this.progLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progLbl.Location = new System.Drawing.Point(142, 228);
            this.progLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progLbl.Name = "progLbl";
            this.progLbl.Size = new System.Drawing.Size(109, 24);
            this.progLbl.TabIndex = 22;
            this.progLbl.Text = "Programme";
            // 
            // AcYrSemLbl
            // 
            this.AcYrSemLbl.AutoSize = true;
            this.AcYrSemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcYrSemLbl.Location = new System.Drawing.Point(142, 136);
            this.AcYrSemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcYrSemLbl.Name = "AcYrSemLbl";
            this.AcYrSemLbl.Size = new System.Drawing.Size(224, 24);
            this.AcYrSemLbl.TabIndex = 21;
            this.AcYrSemLbl.Text = "Academic Year Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Student Groups";
            // 
            // btn_Generate
            // 
            this.btn_Generate.AllowToggling = false;
            this.btn_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Generate.AnimationSpeed = 200;
            this.btn_Generate.AutoGenerateColors = false;
            this.btn_Generate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Generate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Generate.BackgroundImage")));
            this.btn_Generate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Generate.ButtonText = "Generate ID";
            this.btn_Generate.ButtonTextMarginLeft = 0;
            this.btn_Generate.ColorContrastOnClick = 45;
            this.btn_Generate.ColorContrastOnHover = 45;
            this.btn_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Generate.CustomizableEdges = borderEdges1;
            this.btn_Generate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Generate.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Generate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Generate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Generate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Generate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.ForeColor = System.Drawing.Color.White;
            this.btn_Generate.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generate.IconMarginLeft = 30;
            this.btn_Generate.IconPadding = 10;
            this.btn_Generate.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generate.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Generate.IdleBorderRadius = 15;
            this.btn_Generate.IdleBorderThickness = 3;
            this.btn_Generate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Generate.IdleIconLeftImage = null;
            this.btn_Generate.IdleIconRightImage = null;
            this.btn_Generate.IndicateFocus = true;
            this.btn_Generate.Location = new System.Drawing.Point(665, 545);
            this.btn_Generate.Name = "btn_Generate";
            stateProperties1.BorderColor = System.Drawing.Color.Teal;
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 3;
            stateProperties1.FillColor = System.Drawing.Color.LightSeaGreen;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_Generate.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties2.BorderRadius = 15;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 3;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_Generate.OnPressedState = stateProperties2;
            this.btn_Generate.Size = new System.Drawing.Size(172, 55);
            this.btn_Generate.TabIndex = 99;
            this.btn_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Generate.TextMarginLeft = 0;
            this.btn_Generate.UseDefaultRadiusAndThickness = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.AllowToggling = false;
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AnimationSpeed = 200;
            this.btn_Save.AutoGenerateColors = false;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ButtonTextMarginLeft = 0;
            this.btn_Save.ColorContrastOnClick = 45;
            this.btn_Save.ColorContrastOnHover = 45;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Save.CustomizableEdges = borderEdges2;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.IconMarginLeft = 30;
            this.btn_Save.IconPadding = 10;
            this.btn_Save.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Save.IdleBorderRadius = 45;
            this.btn_Save.IdleBorderThickness = 3;
            this.btn_Save.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Save.IdleIconLeftImage = null;
            this.btn_Save.IdleIconRightImage = null;
            this.btn_Save.IndicateFocus = true;
            this.btn_Save.Location = new System.Drawing.Point(814, 606);
            this.btn_Save.Name = "btn_Save";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties3.BorderRadius = 45;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 3;
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_Save.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties4.BorderRadius = 45;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 3;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_Save.OnPressedState = stateProperties4;
            this.btn_Save.Size = new System.Drawing.Size(158, 55);
            this.btn_Save.TabIndex = 102;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.TextMarginLeft = 0;
            this.btn_Save.UseDefaultRadiusAndThickness = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AllowToggling = false;
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.AnimationSpeed = 200;
            this.btn_Clear.AutoGenerateColors = false;
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.ButtonText = "Clear";
            this.btn_Clear.ButtonTextMarginLeft = 0;
            this.btn_Clear.ColorContrastOnClick = 45;
            this.btn_Clear.ColorContrastOnHover = 45;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Clear.CustomizableEdges = borderEdges3;
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Clear.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Clear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Clear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Clear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.IconMarginLeft = 30;
            this.btn_Clear.IconPadding = 10;
            this.btn_Clear.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Clear.IdleBorderRadius = 45;
            this.btn_Clear.IdleBorderThickness = 3;
            this.btn_Clear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Clear.IdleIconLeftImage = null;
            this.btn_Clear.IdleIconRightImage = null;
            this.btn_Clear.IndicateFocus = true;
            this.btn_Clear.Location = new System.Drawing.Point(151, 606);
            this.btn_Clear.Name = "btn_Clear";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties5.BorderRadius = 45;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 3;
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_Clear.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties6.BorderRadius = 45;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 3;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_Clear.OnPressedState = stateProperties6;
            this.btn_Clear.Size = new System.Drawing.Size(158, 55);
            this.btn_Clear.TabIndex = 101;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.TextMarginLeft = 0;
            this.btn_Clear.UseDefaultRadiusAndThickness = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // Add_Student_Groups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.prog_drop);
            this.Controls.Add(this.Ac_Year_Sem_Drop);
            this.Controls.Add(this.Sub_Group_Id);
            this.Controls.Add(this.subGroupIdLbl);
            this.Controls.Add(this.Group_Id);
            this.Controls.Add(this.GroupIdLbl);
            this.Controls.Add(this.Sub_Group_no);
            this.Controls.Add(this.SubGroupNoLbl);
            this.Controls.Add(this.Group_No);
            this.Controls.Add(this.GroupNoLbl);
            this.Controls.Add(this.progLbl);
            this.Controls.Add(this.AcYrSemLbl);
            this.Controls.Add(this.label1);
            this.Name = "Add_Student_Groups";
            this.Size = new System.Drawing.Size(1127, 710);
            ((System.ComponentModel.ISupportInitialize)(this.Sub_Group_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_No)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prog_drop;
        private System.Windows.Forms.ComboBox Ac_Year_Sem_Drop;
        private System.Windows.Forms.TextBox Sub_Group_Id;
        private System.Windows.Forms.Label subGroupIdLbl;
        private System.Windows.Forms.TextBox Group_Id;
        private System.Windows.Forms.Label GroupIdLbl;
        private System.Windows.Forms.NumericUpDown Sub_Group_no;
        private System.Windows.Forms.Label SubGroupNoLbl;
        private System.Windows.Forms.NumericUpDown Group_No;
        private System.Windows.Forms.Label GroupNoLbl;
        private System.Windows.Forms.Label progLbl;
        private System.Windows.Forms.Label AcYrSemLbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Generate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Save;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Clear;
    }
}
