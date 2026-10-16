namespace COMP1019_Lab08_SimplePaint
{
    partial class FrmPaint
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
            cboMode = new ComboBox();
            canvas = new Panel();
            lblMode = new Label();
            lblWidth = new Label();
            lblColor = new Label();
            btnColor = new Button();
            btnClear = new Button();
            btnSave = new Button();
            nudWidth = new NumericUpDown();
            btnUndo = new Button();
            lblStatus = new Label();
            btnOpen = new Button();
            btnBgColor = new Button();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            SuspendLayout();
            // 
            // cboMode
            // 
            cboMode.FormattingEnabled = true;
            cboMode.Location = new Point(23, 72);
            cboMode.Name = "cboMode";
            cboMode.Size = new Size(151, 33);
            cboMode.TabIndex = 0;
            cboMode.SelectedIndexChanged += cboMode_SelectedIndexChanged;
            // 
            // canvas
            // 
            canvas.BackColor = Color.White;
            canvas.Location = new Point(23, 183);
            canvas.Name = "canvas";
            canvas.Size = new Size(1104, 568);
            canvas.TabIndex = 1;
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(23, 29);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(96, 25);
            lblMode.TabIndex = 2;
            lblMode.Text = "Chế độ vẽ:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(228, 29);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(104, 25);
            lblWidth.TabIndex = 3;
            lblWidth.Text = "Độ dày nét:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(419, 29);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(74, 25);
            lblColor.TabIndex = 5;
            lblColor.Text = "Màu vẽ:";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(419, 68);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(190, 39);
            btnColor.TabIndex = 6;
            btnColor.Text = "Chọn màu...";
            btnColor.TextAlign = ContentAlignment.MiddleRight;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.Clear;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(825, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 50);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Savepng;
            btnSave.Location = new Point(992, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudWidth
            // 
            nudWidth.Location = new Point(237, 73);
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(107, 31);
            nudWidth.TabIndex = 9;
            // 
            // btnUndo
            // 
            btnUndo.Image = Properties.Resources.Undo;
            btnUndo.ImageAlign = ContentAlignment.MiddleRight;
            btnUndo.Location = new Point(652, 29);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(135, 50);
            btnUndo.TabIndex = 10;
            btnUndo.Text = "Undo";
            btnUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 754);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 25);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Tọa độ chuột:";
            // 
            // btnOpen
            // 
            btnOpen.Image = Properties.Resources.Open1;
            btnOpen.ImageAlign = ContentAlignment.MiddleRight;
            btnOpen.Location = new Point(652, 102);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(135, 50);
            btnOpen.TabIndex = 12;
            btnOpen.Text = "Mở ảnh";
            btnOpen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnBgColor
            // 
            btnBgColor.Image = Properties.Resources.BgColor;
            btnBgColor.ImageAlign = ContentAlignment.MiddleRight;
            btnBgColor.Location = new Point(825, 102);
            btnBgColor.Name = "btnBgColor";
            btnBgColor.Size = new Size(135, 50);
            btnBgColor.TabIndex = 13;
            btnBgColor.Text = "Màu nền";
            btnBgColor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBgColor.UseVisualStyleBackColor = true;
            btnBgColor.Click += btnBgColor_Click;
            // 
            // FrmPaint
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 788);
            Controls.Add(btnBgColor);
            Controls.Add(btnOpen);
            Controls.Add(lblStatus);
            Controls.Add(btnUndo);
            Controls.Add(nudWidth);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnColor);
            Controls.Add(lblColor);
            Controls.Add(lblWidth);
            Controls.Add(lblMode);
            Controls.Add(canvas);
            Controls.Add(cboMode);
            Name = "FrmPaint";
            Text = "COMP1019-Simple Paint";
            Load += FrmPaint_Load;
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMode;
        private Panel canvas;
        private Label lblMode;
        private Label lblWidth;
        private Label lblColor;
        private Button btnColor;
        private Button btnClear;
        private Button btnSave;
        private NumericUpDown nudWidth;
        private Button btnUndo;
        private Label lblStatus;
        private Button btnOpen;
        private Button btnBgColor;
    }
}