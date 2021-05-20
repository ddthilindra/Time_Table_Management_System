namespace app.Forms.Student
{
    partial class Manage_Tags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Tags));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.relatedTag = new System.Windows.Forms.ComboBox();
            this.subCode = new System.Windows.Forms.TextBox();
            this.subName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateTag = new System.Windows.Forms.GroupBox();
            this.tagGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relatedTag
            // 
            this.relatedTag.FormattingEnabled = true;
            this.relatedTag.Items.AddRange(new object[] {
            "Lecture",
            "Lab",
            "Tute",
            "Evaluation"});
            this.relatedTag.Location = new System.Drawing.Point(425, 124);
            this.relatedTag.Margin = new System.Windows.Forms.Padding(4);
            this.relatedTag.Name = "relatedTag";
            this.relatedTag.Size = new System.Drawing.Size(458, 24);
            this.relatedTag.TabIndex = 41;
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(425, 80);
            this.subCode.Margin = new System.Windows.Forms.Padding(4);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(458, 22);
            this.subCode.TabIndex = 38;
            // 
            // subName
            // 
            this.subName.Location = new System.Drawing.Point(425, 34);
            this.subName.Margin = new System.Windows.Forms.Padding(4);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(458, 22);
            this.subName.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Related Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Subject Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Subject Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Manage Tags";
            // 
            // btn_Update
            // 
            this.btn_Update.AllowToggling = false;
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.AnimationSpeed = 200;
            this.btn_Update.AutoGenerateColors = false;
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Update.BackgroundImage")));
            this.btn_Update.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.ButtonTextMarginLeft = 0;
            this.btn_Update.ColorContrastOnClick = 45;
            this.btn_Update.ColorContrastOnHover = 45;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Update.CustomizableEdges = borderEdges1;
            this.btn_Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Update.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Update.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Update.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.IconMarginLeft = 30;
            this.btn_Update.IconPadding = 10;
            this.btn_Update.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Update.IdleBorderRadius = 45;
            this.btn_Update.IdleBorderThickness = 3;
            this.btn_Update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Update.IdleIconLeftImage = null;
            this.btn_Update.IdleIconRightImage = null;
            this.btn_Update.IndicateFocus = true;
            this.btn_Update.Location = new System.Drawing.Point(632, 262);
            this.btn_Update.Name = "btn_Update";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties1.BorderRadius = 45;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 3;
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_Update.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties2.BorderRadius = 45;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 3;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_Update.OnPressedState = stateProperties2;
            this.btn_Update.Size = new System.Drawing.Size(158, 55);
            this.btn_Update.TabIndex = 95;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.TextMarginLeft = 0;
            this.btn_Update.UseDefaultRadiusAndThickness = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AllowToggling = false;
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.AnimationSpeed = 200;
            this.btn_Delete.AutoGenerateColors = false;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.ButtonTextMarginLeft = 0;
            this.btn_Delete.ColorContrastOnClick = 45;
            this.btn_Delete.ColorContrastOnHover = 45;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Delete.CustomizableEdges = borderEdges2;
            this.btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_Delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.IconMarginLeft = 30;
            this.btn_Delete.IconPadding = 10;
            this.btn_Delete.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.IdleBorderRadius = 45;
            this.btn_Delete.IdleBorderThickness = 3;
            this.btn_Delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Delete.IdleIconLeftImage = null;
            this.btn_Delete.IdleIconRightImage = null;
            this.btn_Delete.IndicateFocus = true;
            this.btn_Delete.Location = new System.Drawing.Point(829, 262);
            this.btn_Delete.Name = "btn_Delete";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties3.BorderRadius = 45;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 3;
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_Delete.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties4.BorderRadius = 45;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 3;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_Delete.OnPressedState = stateProperties4;
            this.btn_Delete.Size = new System.Drawing.Size(158, 55);
            this.btn_Delete.TabIndex = 96;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.TextMarginLeft = 0;
            this.btn_Delete.UseDefaultRadiusAndThickness = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Clear.Location = new System.Drawing.Point(528, 196);
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
            this.btn_Clear.TabIndex = 97;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.TextMarginLeft = 0;
            this.btn_Clear.UseDefaultRadiusAndThickness = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_Save.CustomizableEdges = borderEdges4;
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
            this.btn_Save.Location = new System.Drawing.Point(725, 196);
            this.btn_Save.Name = "btn_Save";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties7.BorderRadius = 45;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 3;
            stateProperties7.FillColor = System.Drawing.Color.White;
            stateProperties7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btn_Save.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties8.BorderRadius = 45;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 3;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btn_Save.OnPressedState = stateProperties8;
            this.btn_Save.Size = new System.Drawing.Size(158, 55);
            this.btn_Save.TabIndex = 98;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.TextMarginLeft = 0;
            this.btn_Save.UseDefaultRadiusAndThickness = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UpdateTag
            // 
            this.UpdateTag.Controls.Add(this.relatedTag);
            this.UpdateTag.Controls.Add(this.btn_Save);
            this.UpdateTag.Controls.Add(this.label4);
            this.UpdateTag.Controls.Add(this.btn_Clear);
            this.UpdateTag.Controls.Add(this.label2);
            this.UpdateTag.Controls.Add(this.label3);
            this.UpdateTag.Controls.Add(this.subName);
            this.UpdateTag.Controls.Add(this.subCode);
            this.UpdateTag.Location = new System.Drawing.Point(104, 333);
            this.UpdateTag.Name = "UpdateTag";
            this.UpdateTag.Size = new System.Drawing.Size(908, 279);
            this.UpdateTag.TabIndex = 99;
            this.UpdateTag.TabStop = false;
            this.UpdateTag.Text = "Update Tag";
            // 
            // tagGridView
            // 
            this.tagGridView.AllowUserToAddRows = false;
            this.tagGridView.AllowUserToDeleteRows = false;
            this.tagGridView.AllowUserToResizeColumns = false;
            this.tagGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.tagGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tagGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tagGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tagGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tagGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tagGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tagGridView.ColumnHeadersHeight = 40;
            this.tagGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tagGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tagGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tagGridView.EnableHeadersVisualStyles = false;
            this.tagGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tagGridView.Location = new System.Drawing.Point(104, 59);
            this.tagGridView.Name = "tagGridView";
            this.tagGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tagGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tagGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.tagGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tagGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tagGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.tagGridView.RowTemplate.Height = 50;
            this.tagGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tagGridView.Size = new System.Drawing.Size(908, 197);
            this.tagGridView.TabIndex = 100;
            this.tagGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tagGridView_RowHeaderMouseClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SubjectName";
            this.Column2.HeaderText = "Subject Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SubjectCode";
            this.Column3.HeaderText = "Subject Code";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RelatedTag";
            this.Column4.HeaderText = "Related Tag";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Manage_Tags
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tagGridView);
            this.Controls.Add(this.UpdateTag);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Tags";
            this.Size = new System.Drawing.Size(1127, 647);
            this.Load += new System.EventHandler(this.Manage_Tags_Load_1);
            this.UpdateTag.ResumeLayout(false);
            this.UpdateTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox relatedTag;
        private System.Windows.Forms.TextBox subCode;
        private System.Windows.Forms.TextBox subName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Update;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Delete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Clear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Save;
        private System.Windows.Forms.GroupBox UpdateTag;
        private System.Windows.Forms.DataGridView tagGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
