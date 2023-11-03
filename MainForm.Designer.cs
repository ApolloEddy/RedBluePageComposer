namespace RedBluePageComposer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_OriginWord = new System.Windows.Forms.Label();
            this.textBox_OriginWord = new System.Windows.Forms.TextBox();
            this.button_OriginWord = new System.Windows.Forms.Button();
            this.label_OutputPath = new System.Windows.Forms.Label();
            this.textBox_OutputPath = new System.Windows.Forms.TextBox();
            this.button_OutputPath = new System.Windows.Forms.Button();
            this.label_Extension = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radioButton_html = new System.Windows.Forms.RadioButton();
            this.radioButton_word = new System.Windows.Forms.RadioButton();
            this.button_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_OriginWord
            // 
            this.label_OriginWord.AutoSize = true;
            this.label_OriginWord.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OriginWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_OriginWord.Location = new System.Drawing.Point(21, 38);
            this.label_OriginWord.Name = "label_OriginWord";
            this.label_OriginWord.Size = new System.Drawing.Size(145, 35);
            this.label_OriginWord.TabIndex = 0;
            this.label_OriginWord.Text = "文案路径：";
            // 
            // textBox_OriginWord
            // 
            this.textBox_OriginWord.AllowDrop = true;
            this.textBox_OriginWord.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_OriginWord.Location = new System.Drawing.Point(184, 35);
            this.textBox_OriginWord.Name = "textBox_OriginWord";
            this.textBox_OriginWord.Size = new System.Drawing.Size(490, 42);
            this.textBox_OriginWord.TabIndex = 1;
            // 
            // button_OriginWord
            // 
            this.button_OriginWord.Font = new System.Drawing.Font("宋体", 9F);
            this.button_OriginWord.Location = new System.Drawing.Point(691, 35);
            this.button_OriginWord.Name = "button_OriginWord";
            this.button_OriginWord.Size = new System.Drawing.Size(75, 37);
            this.button_OriginWord.TabIndex = 2;
            this.button_OriginWord.Text = "···";
            this.button_OriginWord.UseVisualStyleBackColor = true;
            this.button_OriginWord.Click += new System.EventHandler(this.button_OriginWord_Click);
            // 
            // label_OutputPath
            // 
            this.label_OutputPath.AutoSize = true;
            this.label_OutputPath.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OutputPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_OutputPath.Location = new System.Drawing.Point(21, 102);
            this.label_OutputPath.Name = "label_OutputPath";
            this.label_OutputPath.Size = new System.Drawing.Size(145, 35);
            this.label_OutputPath.TabIndex = 0;
            this.label_OutputPath.Text = "输出路径：";
            // 
            // textBox_OutputPath
            // 
            this.textBox_OutputPath.AllowDrop = true;
            this.textBox_OutputPath.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_OutputPath.Location = new System.Drawing.Point(184, 99);
            this.textBox_OutputPath.Name = "textBox_OutputPath";
            this.textBox_OutputPath.Size = new System.Drawing.Size(490, 42);
            this.textBox_OutputPath.TabIndex = 1;
            // 
            // button_OutputPath
            // 
            this.button_OutputPath.Font = new System.Drawing.Font("宋体", 9F);
            this.button_OutputPath.Location = new System.Drawing.Point(691, 99);
            this.button_OutputPath.Name = "button_OutputPath";
            this.button_OutputPath.Size = new System.Drawing.Size(75, 37);
            this.button_OutputPath.TabIndex = 2;
            this.button_OutputPath.Text = "···";
            this.button_OutputPath.UseVisualStyleBackColor = true;
            this.button_OutputPath.Click += new System.EventHandler(this.button_OutputPath_Click);
            // 
            // label_Extension
            // 
            this.label_Extension.AutoSize = true;
            this.label_Extension.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Extension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Extension.Location = new System.Drawing.Point(21, 165);
            this.label_Extension.Name = "label_Extension";
            this.label_Extension.Size = new System.Drawing.Size(145, 35);
            this.label_Extension.TabIndex = 0;
            this.label_Extension.Text = "保存格式：";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // radioButton_html
            // 
            this.radioButton_html.AutoSize = true;
            this.radioButton_html.Checked = true;
            this.radioButton_html.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_html.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_html.Location = new System.Drawing.Point(241, 165);
            this.radioButton_html.Name = "radioButton_html";
            this.radioButton_html.Size = new System.Drawing.Size(103, 39);
            this.radioButton_html.TabIndex = 3;
            this.radioButton_html.TabStop = true;
            this.radioButton_html.Text = ".html";
            this.radioButton_html.UseVisualStyleBackColor = true;
            // 
            // radioButton_word
            // 
            this.radioButton_word.AutoSize = true;
            this.radioButton_word.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_word.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_word.Location = new System.Drawing.Point(504, 163);
            this.radioButton_word.Name = "radioButton_word";
            this.radioButton_word.Size = new System.Drawing.Size(106, 39);
            this.radioButton_word.TabIndex = 3;
            this.radioButton_word.TabStop = true;
            this.radioButton_word.Text = ".docx";
            this.radioButton_word.UseVisualStyleBackColor = true;
            // 
            // button_Generate
            // 
            this.button_Generate.Font = new System.Drawing.Font("宋体", 13F);
            this.button_Generate.Location = new System.Drawing.Point(656, 223);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(107, 37);
            this.button_Generate.TabIndex = 2;
            this.button_Generate.Text = "生成";
            this.button_Generate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(778, 274);
            this.Controls.Add(this.radioButton_word);
            this.Controls.Add(this.radioButton_html);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.button_OutputPath);
            this.Controls.Add(this.button_OriginWord);
            this.Controls.Add(this.textBox_OutputPath);
            this.Controls.Add(this.textBox_OriginWord);
            this.Controls.Add(this.label_Extension);
            this.Controls.Add(this.label_OutputPath);
            this.Controls.Add(this.label_OriginWord);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "红蓝在线公众号模板生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_OriginWord;
        private System.Windows.Forms.TextBox textBox_OriginWord;
        private System.Windows.Forms.Button button_OriginWord;
        private System.Windows.Forms.Label label_OutputPath;
        private System.Windows.Forms.TextBox textBox_OutputPath;
        private System.Windows.Forms.Button button_OutputPath;
        private System.Windows.Forms.Label label_Extension;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton radioButton_html;
        private System.Windows.Forms.RadioButton radioButton_word;
        private System.Windows.Forms.Button button_Generate;
    }
}

