namespace MusicBeePlugin
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGradientType = new System.Windows.Forms.ComboBox();
            this.checkBoxPreserveSlash = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoHide = new System.Windows.Forms.CheckBox();
            this.checkBoxNextLineWhenNoTranslation = new System.Windows.Forms.CheckBox();
            this.checkBoxHideWhenUnavailable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            resources.ApplyResources(this.btnFont, "btnFont");
            this.btnFont.Name = "btnFont";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnColor1
            // 
            resources.ApplyResources(this.btnColor1, "btnColor1");
            this.btnColor1.BackColor = System.Drawing.Color.LightCyan;
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // btnColor2
            // 
            resources.ApplyResources(this.btnColor2, "btnColor2");
            this.btnColor2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // btnBorderColor
            // 
            resources.ApplyResources(this.btnBorderColor, "btnBorderColor");
            this.btnBorderColor.BackColor = System.Drawing.Color.Gray;
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.UseVisualStyleBackColor = false;
            this.btnBorderColor.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbxGradientType
            // 
            resources.ApplyResources(this.cbxGradientType, "cbxGradientType");
            this.cbxGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGradientType.FormattingEnabled = true;
            this.cbxGradientType.Items.AddRange(new object[] {
            resources.GetString("cbxGradientType.Items"),
            resources.GetString("cbxGradientType.Items1"),
            resources.GetString("cbxGradientType.Items2")});
            this.cbxGradientType.Name = "cbxGradientType";
            // 
            // checkBoxPreserveSlash
            // 
            resources.ApplyResources(this.checkBoxPreserveSlash, "checkBoxPreserveSlash");
            this.checkBoxPreserveSlash.Name = "checkBoxPreserveSlash";
            this.checkBoxPreserveSlash.UseVisualStyleBackColor = true;
            this.checkBoxPreserveSlash.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAutoHide
            // 
            resources.ApplyResources(this.checkBoxAutoHide, "checkBoxAutoHide");
            this.checkBoxAutoHide.Checked = true;
            this.checkBoxAutoHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoHide.Name = "checkBoxAutoHide";
            this.checkBoxAutoHide.UseVisualStyleBackColor = true;
            this.checkBoxAutoHide.CheckedChanged += new System.EventHandler(this.checkBoxAutoHide_CheckedChanged);
            // 
            // checkBoxNextLineWhenNoTranslation
            // 
            this.checkBoxNextLineWhenNoTranslation.Checked = true;
            this.checkBoxNextLineWhenNoTranslation.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.checkBoxNextLineWhenNoTranslation, "checkBoxNextLineWhenNoTranslation");
            this.checkBoxNextLineWhenNoTranslation.Name = "checkBoxNextLineWhenNoTranslation";
            this.checkBoxNextLineWhenNoTranslation.UseVisualStyleBackColor = true;
            this.checkBoxNextLineWhenNoTranslation.CheckedChanged += new System.EventHandler(this.checkBoxNextLineWhenNoTranslation_CheckedChanged);
            // 
            // checkBoxHideWhenUnavailable
            // 
            resources.ApplyResources(this.checkBoxHideWhenUnavailable, "checkBoxHideWhenUnavailable");
            this.checkBoxHideWhenUnavailable.Name = "checkBoxHideWhenUnavailable";
            this.checkBoxHideWhenUnavailable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxHideWhenUnavailable);
            this.Controls.Add(this.checkBoxNextLineWhenNoTranslation);
            this.Controls.Add(this.checkBoxAutoHide);
            this.Controls.Add(this.checkBoxPreserveSlash);
            this.Controls.Add(this.cbxGradientType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFont);
            this.Name = "FrmSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGradientType;
        private System.Windows.Forms.CheckBox checkBoxPreserveSlash;
        private System.Windows.Forms.CheckBox checkBoxAutoHide;
        private System.Windows.Forms.CheckBox checkBoxNextLineWhenNoTranslation;
        private System.Windows.Forms.CheckBox checkBoxHideWhenUnavailable;
        private System.Windows.Forms.Label label4;
    }
}