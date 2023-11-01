﻿namespace RestrictedTextboxSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.restrictedTextbox6 = new RestrictedTextbox.RestrictedTextbox();
            this.restrictedTextboxText = new RestrictedTextbox.RestrictedTextbox();
            this.restrictedTextboxV = new RestrictedTextbox.RestrictedTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restrictedTextbox1 = new RestrictedTextbox.RestrictedTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.restrictedTextboxC = new RestrictedTextbox.RestrictedTextbox();
            this.restrictedTextboxA = new RestrictedTextbox.RestrictedTextbox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restrictedTextbox6
            // 
            this.restrictedTextbox6.CapableRegexPattern = ".*";
            this.restrictedTextbox6.Location = new System.Drawing.Point(262, 65);
            this.restrictedTextbox6.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextbox6.Name = "restrictedTextbox6";
            this.restrictedTextbox6.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.NoRestriction;
            this.restrictedTextbox6.Size = new System.Drawing.Size(227, 22);
            this.restrictedTextbox6.TabIndex = 4;
            this.restrictedTextbox6.Text = "^([0-9]{0,3})(-[0-9]{0,4})?";
            this.restrictedTextbox6.TrimEndChars = null;
            this.restrictedTextbox6.TextChanged += new System.EventHandler(this.restrictedTextbox6_TextChanged);
            // 
            // restrictedTextboxText
            // 
            this.restrictedTextboxText.CapableRegexPattern = "^([0-9]{0,3})(-[0-9]{0,4})?";
            this.restrictedTextboxText.Location = new System.Drawing.Point(36, 65);
            this.restrictedTextboxText.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextboxText.Name = "restrictedTextboxText";
            this.restrictedTextboxText.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.Custom;
            this.restrictedTextboxText.Size = new System.Drawing.Size(218, 22);
            this.restrictedTextboxText.TabIndex = 3;
            this.restrictedTextboxText.TrimEndChars = null;
            // 
            // restrictedTextboxV
            // 
            this.restrictedTextboxV.CapableRegexPattern = "([0-9]+\\.?)*[0-9]*";
            this.restrictedTextboxV.Location = new System.Drawing.Point(36, 169);
            this.restrictedTextboxV.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextboxV.Name = "restrictedTextboxV";
            this.restrictedTextboxV.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.Version;
            this.restrictedTextboxV.Size = new System.Drawing.Size(218, 22);
            this.restrictedTextboxV.TabIndex = 6;
            this.restrictedTextboxV.TrimEndChars = new char[] {
        '.'};
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // restrictedTextbox1
            // 
            this.restrictedTextbox1.CapableRegexPattern = "[0-9]";
            this.restrictedTextbox1.Location = new System.Drawing.Point(36, 13);
            this.restrictedTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextbox1.Name = "restrictedTextbox1";
            this.restrictedTextbox1.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.IntType;
            this.restrictedTextbox1.Size = new System.Drawing.Size(218, 22);
            this.restrictedTextbox1.TabIndex = 0;
            this.restrictedTextbox1.TrimEndChars = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Version ([0-9]+\\.?)*[0-9]*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Custom ^[0-9]{0,4}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "AlphabetType [a-zA-z]";
            // 
            // restrictedTextboxC
            // 
            this.restrictedTextboxC.CapableRegexPattern = "^[0-9]{0,4}";
            this.restrictedTextboxC.Location = new System.Drawing.Point(36, 221);
            this.restrictedTextboxC.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextboxC.Name = "restrictedTextboxC";
            this.restrictedTextboxC.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.Custom;
            this.restrictedTextboxC.Size = new System.Drawing.Size(218, 22);
            this.restrictedTextboxC.TabIndex = 7;
            this.restrictedTextboxC.TrimEndChars = null;
            // 
            // restrictedTextboxA
            // 
            this.restrictedTextboxA.CapableRegexPattern = "[A-Za-z]";
            this.restrictedTextboxA.Location = new System.Drawing.Point(36, 114);
            this.restrictedTextboxA.Margin = new System.Windows.Forms.Padding(4);
            this.restrictedTextboxA.Name = "restrictedTextboxA";
            this.restrictedTextboxA.Restrict = RestrictedTextbox.RestrictedTextbox.RestrictType.AlphabetType;
            this.restrictedTextboxA.Size = new System.Drawing.Size(218, 22);
            this.restrictedTextboxA.TabIndex = 5;
            this.restrictedTextboxA.TrimEndChars = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.restrictedTextbox6);
            this.Controls.Add(this.restrictedTextboxText);
            this.Controls.Add(this.restrictedTextboxV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.restrictedTextbox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restrictedTextboxC);
            this.Controls.Add(this.restrictedTextboxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestrictedTextbox.RestrictedTextbox restrictedTextbox6;
        private RestrictedTextbox.RestrictedTextbox restrictedTextboxText;
        private RestrictedTextbox.RestrictedTextbox restrictedTextboxV;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestrictedTextbox.RestrictedTextbox restrictedTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RestrictedTextbox.RestrictedTextbox restrictedTextboxC;
        private RestrictedTextbox.RestrictedTextbox restrictedTextboxA;
        private System.Windows.Forms.TextBox textBox1;
    }
}

