namespace DigitalSignature
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
            this.txtbxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonCalcParameters = new System.Windows.Forms.Button();
            this.txtbxQ = new System.Windows.Forms.TextBox();
            this.LabelQ = new System.Windows.Forms.Label();
            this.txtbxP = new System.Windows.Forms.TextBox();
            this.LabelP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxHash = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RadioButtonCheck = new System.Windows.Forms.RadioButton();
            this.RadioButtonMakeSign = new System.Windows.Forms.RadioButton();
            this.txtbxSign = new System.Windows.Forms.TextBox();
            this.LabelCipher = new System.Windows.Forms.Label();
            this.txtbxK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxX
            // 
            this.txtbxX.Location = new System.Drawing.Point(581, 35);
            this.txtbxX.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxX.Name = "txtbxX";
            this.txtbxX.Size = new System.Drawing.Size(183, 34);
            this.txtbxX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(541, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 34);
            this.label4.TabIndex = 68;
            this.label4.Text = "X:";
            // 
            // txtbxH
            // 
            this.txtbxH.Location = new System.Drawing.Point(320, 35);
            this.txtbxH.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxH.Name = "txtbxH";
            this.txtbxH.Size = new System.Drawing.Size(183, 34);
            this.txtbxH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(279, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 34);
            this.label3.TabIndex = 64;
            this.label3.Text = "H:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonClear.Enabled = false;
            this.ButtonClear.Location = new System.Drawing.Point(817, 122);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(212, 38);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "Очистить поля";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonCalcParameters
            // 
            this.ButtonCalcParameters.Location = new System.Drawing.Point(817, 35);
            this.ButtonCalcParameters.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCalcParameters.Name = "ButtonCalcParameters";
            this.ButtonCalcParameters.Size = new System.Drawing.Size(212, 76);
            this.ButtonCalcParameters.TabIndex = 6;
            this.ButtonCalcParameters.Text = "Рассчитать параметры";
            this.ButtonCalcParameters.UseVisualStyleBackColor = true;
            this.ButtonCalcParameters.Click += new System.EventHandler(this.ButtonCalcParameters_Click);
            // 
            // txtbxQ
            // 
            this.txtbxQ.Location = new System.Drawing.Point(46, 35);
            this.txtbxQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxQ.Name = "txtbxQ";
            this.txtbxQ.Size = new System.Drawing.Size(183, 34);
            this.txtbxQ.TabIndex = 1;
            // 
            // LabelQ
            // 
            this.LabelQ.Location = new System.Drawing.Point(6, 38);
            this.LabelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(40, 34);
            this.LabelQ.TabIndex = 60;
            this.LabelQ.Text = "Q:";
            // 
            // txtbxP
            // 
            this.txtbxP.Location = new System.Drawing.Point(46, 77);
            this.txtbxP.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxP.Name = "txtbxP";
            this.txtbxP.Size = new System.Drawing.Size(183, 34);
            this.txtbxP.TabIndex = 2;
            // 
            // LabelP
            // 
            this.LabelP.Location = new System.Drawing.Point(8, 80);
            this.LabelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(40, 34);
            this.LabelP.TabIndex = 58;
            this.LabelP.Text = "P:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(247, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "Хэш:";
            // 
            // txtbxHash
            // 
            this.txtbxHash.Location = new System.Drawing.Point(320, 122);
            this.txtbxHash.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxHash.Name = "txtbxHash";
            this.txtbxHash.ReadOnly = true;
            this.txtbxHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxHash.Size = new System.Drawing.Size(444, 34);
            this.txtbxHash.TabIndex = 54;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1042, 39);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(244, 30);
            this.OpenFile.Text = "Открыть файл";
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(244, 30);
            this.SaveFile.Text = "Сохранить в файл";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ClearStrip
            // 
            this.ClearStrip.Name = "ClearStrip";
            this.ClearStrip.Size = new System.Drawing.Size(14, 29);
            // 
            // RadioButtonCheck
            // 
            this.RadioButtonCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonCheck.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonCheck.Location = new System.Drawing.Point(817, 199);
            this.RadioButtonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonCheck.Name = "RadioButtonCheck";
            this.RadioButtonCheck.Size = new System.Drawing.Size(209, 35);
            this.RadioButtonCheck.TabIndex = 8;
            this.RadioButtonCheck.Text = "Проверка";
            this.RadioButtonCheck.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMakeSign
            // 
            this.RadioButtonMakeSign.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonMakeSign.Checked = true;
            this.RadioButtonMakeSign.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonMakeSign.Location = new System.Drawing.Point(817, 171);
            this.RadioButtonMakeSign.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonMakeSign.Name = "RadioButtonMakeSign";
            this.RadioButtonMakeSign.Size = new System.Drawing.Size(209, 35);
            this.RadioButtonMakeSign.TabIndex = 7;
            this.RadioButtonMakeSign.TabStop = true;
            this.RadioButtonMakeSign.Text = "Создание подписи";
            this.RadioButtonMakeSign.UseVisualStyleBackColor = true;
            // 
            // txtbxSign
            // 
            this.txtbxSign.Location = new System.Drawing.Point(320, 169);
            this.txtbxSign.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSign.Name = "txtbxSign";
            this.txtbxSign.ReadOnly = true;
            this.txtbxSign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSign.Size = new System.Drawing.Size(444, 34);
            this.txtbxSign.TabIndex = 74;
            // 
            // LabelCipher
            // 
            this.LabelCipher.Location = new System.Drawing.Point(247, 169);
            this.LabelCipher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCipher.Name = "LabelCipher";
            this.LabelCipher.Size = new System.Drawing.Size(80, 34);
            this.LabelCipher.TabIndex = 73;
            this.LabelCipher.Text = "ЭЦП:";
            // 
            // txtbxK
            // 
            this.txtbxK.Location = new System.Drawing.Point(46, 122);
            this.txtbxK.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxK.Name = "txtbxK";
            this.txtbxK.Size = new System.Drawing.Size(183, 34);
            this.txtbxK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 34);
            this.label2.TabIndex = 75;
            this.label2.Text = "K:";
            // 
            // txtbxG
            // 
            this.txtbxG.Location = new System.Drawing.Point(320, 77);
            this.txtbxG.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxG.Name = "txtbxG";
            this.txtbxG.ReadOnly = true;
            this.txtbxG.Size = new System.Drawing.Size(183, 34);
            this.txtbxG.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(280, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 34);
            this.label5.TabIndex = 77;
            this.label5.Text = "G:";
            // 
            // txtbxY
            // 
            this.txtbxY.Location = new System.Drawing.Point(581, 77);
            this.txtbxY.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxY.Name = "txtbxY";
            this.txtbxY.ReadOnly = true;
            this.txtbxY.Size = new System.Drawing.Size(183, 34);
            this.txtbxY.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(541, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 34);
            this.label6.TabIndex = 79;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 33);
            this.label7.TabIndex = 82;
            this.label7.Text = "Текст:";
            // 
            // txtbxMessage
            // 
            this.txtbxMessage.Location = new System.Drawing.Point(11, 242);
            this.txtbxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxMessage.Multiline = true;
            this.txtbxMessage.Name = "txtbxMessage";
            this.txtbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxMessage.Size = new System.Drawing.Size(1018, 132);
            this.txtbxMessage.TabIndex = 10;
            this.txtbxMessage.TextChanged += new System.EventHandler(this.txtbxMessage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxMessage);
            this.Controls.Add(this.txtbxY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxSign);
            this.Controls.Add(this.LabelCipher);
            this.Controls.Add(this.RadioButtonCheck);
            this.Controls.Add(this.RadioButtonMakeSign);
            this.Controls.Add(this.txtbxX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonCalcParameters);
            this.Controls.Add(this.txtbxQ);
            this.Controls.Add(this.LabelQ);
            this.Controls.Add(this.txtbxP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxHash);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цифровая подпись";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonCalcParameters;
        private System.Windows.Forms.TextBox txtbxQ;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.TextBox txtbxP;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxHash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem ClearStrip;
        private System.Windows.Forms.RadioButton RadioButtonCheck;
        private System.Windows.Forms.RadioButton RadioButtonMakeSign;
        private System.Windows.Forms.TextBox txtbxSign;
        private System.Windows.Forms.Label LabelCipher;
        private System.Windows.Forms.TextBox txtbxK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxMessage;

    }
}

