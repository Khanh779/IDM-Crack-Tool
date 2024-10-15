namespace IDM_Crack_Tool
{
    partial class Form1
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
            this.PN_Title = new System.Windows.Forms.Panel();
            this.cButton2 = new IDM_Crack_Tool.Custom_Controls.CButton();
            this.cButton1 = new IDM_Crack_Tool.Custom_Controls.CButton();
            this.LB_Form_Text = new System.Windows.Forms.Label();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cButton4 = new IDM_Crack_Tool.Custom_Controls.CButton();
            this.cButton3 = new IDM_Crack_Tool.Custom_Controls.CButton();
            this.cDragForm1 = new IDM_Crack_Tool.Custom_Controls.CDragForm();
            this.cDragForm2 = new IDM_Crack_Tool.Custom_Controls.CDragForm();
            this.cDragForm3 = new IDM_Crack_Tool.Custom_Controls.CDragForm();
            this.PN_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Title
            // 
            this.PN_Title.BackColor = System.Drawing.Color.Transparent;
            this.PN_Title.Controls.Add(this.cButton2);
            this.PN_Title.Controls.Add(this.cButton1);
            this.PN_Title.Controls.Add(this.LB_Form_Text);
            this.PN_Title.Controls.Add(this.PB_Icon);
            this.PN_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Title.Location = new System.Drawing.Point(1, 1);
            this.PN_Title.Name = "PN_Title";
            this.PN_Title.Size = new System.Drawing.Size(430, 35);
            this.PN_Title.TabIndex = 0;
            // 
            // cButton2
            // 
            this.cButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton2.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton2.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton2.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton2.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton2.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cButton2.Location = new System.Drawing.Point(369, 2);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(30, 30);
            this.cButton2.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton2.TabIndex = 3;
            this.cButton2.Text = "0";
            this.cButton2.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton2.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton2.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton2_MouseClick);
            // 
            // cButton1
            // 
            this.cButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton1.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton1.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton1.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.cButton1.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cButton1.Location = new System.Drawing.Point(403, 2);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(30, 30);
            this.cButton1.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton1.TabIndex = 1;
            this.cButton1.Text = "r";
            this.cButton1.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton1.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton1.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton1_MouseClick);
            // 
            // LB_Form_Text
            // 
            this.LB_Form_Text.AutoSize = true;
            this.LB_Form_Text.BackColor = System.Drawing.Color.Transparent;
            this.LB_Form_Text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Form_Text.ForeColor = System.Drawing.Color.LightGray;
            this.LB_Form_Text.Location = new System.Drawing.Point(34, 10);
            this.LB_Form_Text.Name = "LB_Form_Text";
            this.LB_Form_Text.Size = new System.Drawing.Size(84, 17);
            this.LB_Form_Text.TabIndex = 1;
            this.LB_Form_Text.Text = "LB_Form_Text";
            // 
            // PB_Icon
            // 
            this.PB_Icon.Location = new System.Drawing.Point(8, 8);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Size = new System.Drawing.Size(20, 20);
            this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Icon.TabIndex = 2;
            this.PB_Icon.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(1, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 8);
            this.progressBar1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(24, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(380, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "   --- Internet Download Manager (IDM) ---\n- IDM Status: Installed\n- Version: ..." +
    "\n- Activation Status: N/A\n";
            this.richTextBox1.WordWrap = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // cButton4
            // 
            this.cButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton4.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton4.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton4.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton4.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton4.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton4.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton4.Location = new System.Drawing.Point(312, 230);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(92, 30);
            this.cButton4.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton4.TabIndex = 4;
            this.cButton4.Text = "Crack now";
            this.cButton4.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton4.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton4.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton4_MouseClick);
            // 
            // cButton3
            // 
            this.cButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton3.ButtonHoveredColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton3.ButtonHoveredColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cButton3.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton3.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.cButton3.ButtonPressedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton3.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.cButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton3.Location = new System.Drawing.Point(174, 230);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(132, 30);
            this.cButton3.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.cButton3.TabIndex = 4;
            this.cButton3.Text = "Reset activation";
            this.cButton3.TextHoveredColor = System.Drawing.Color.Gainsboro;
            this.cButton3.TextNormalColor = System.Drawing.Color.LightGray;
            this.cButton3.TextPressedColor = System.Drawing.Color.Silver;
            this.cButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cButton3_MouseClick);
            // 
            // cDragForm1
            // 
            this.cDragForm1.Form = this;
            this.cDragForm1.MaximizeFullScreen = false;
            this.cDragForm1.SupportMaximize = false;
            this.cDragForm1.TargetControl = this.PN_Title;
            // 
            // cDragForm2
            // 
            this.cDragForm2.Form = this;
            this.cDragForm2.MaximizeFullScreen = false;
            this.cDragForm2.SupportMaximize = false;
            this.cDragForm2.TargetControl = this.LB_Form_Text;
            // 
            // cDragForm3
            // 
            this.cDragForm3.Form = this;
            this.cDragForm3.MaximizeFullScreen = false;
            this.cDragForm3.SupportMaximize = false;
            this.cDragForm3.TargetControl = this.PB_Icon;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(432, 288);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cButton4);
            this.Controls.Add(this.cButton3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PN_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM Crack Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PN_Title.ResumeLayout(false);
            this.PN_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Title;
        private System.Windows.Forms.Label LB_Form_Text;
        private System.Windows.Forms.PictureBox PB_Icon;
        private Custom_Controls.CButton cButton1;
        private Custom_Controls.CDragForm cDragForm1;
        private Custom_Controls.CDragForm cDragForm2;
        private Custom_Controls.CDragForm cDragForm3;
        private Custom_Controls.CButton cButton2;
        private Custom_Controls.CButton cButton3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Custom_Controls.CButton cButton4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

