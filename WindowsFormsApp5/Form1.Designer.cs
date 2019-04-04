namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestFile = new System.Windows.Forms.TextBox();
            this.btnDestFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbFileCopy = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(130, 86);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(382, 20);
            this.txtSourceFile.TabIndex = 6;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(531, 86);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(75, 23);
            this.btnSourceFile.TabIndex = 7;
            this.btnSourceFile.Text = "Browse";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination";
            // 
            // txtDestFile
            // 
            this.txtDestFile.Location = new System.Drawing.Point(130, 158);
            this.txtDestFile.Name = "txtDestFile";
            this.txtDestFile.Size = new System.Drawing.Size(382, 20);
            this.txtDestFile.TabIndex = 9;
            // 
            // btnDestFile
            // 
            this.btnDestFile.Location = new System.Drawing.Point(531, 158);
            this.btnDestFile.Name = "btnDestFile";
            this.btnDestFile.Size = new System.Drawing.Size(75, 23);
            this.btnDestFile.TabIndex = 10;
            this.btnDestFile.Text = "Browse";
            this.btnDestFile.UseVisualStyleBackColor = true;
            this.btnDestFile.Click += new System.EventHandler(this.btnDestFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Working";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbFileCopy
            // 
            this.pbFileCopy.Location = new System.Drawing.Point(46, 294);
            this.pbFileCopy.Name = "pbFileCopy";
            this.pbFileCopy.Size = new System.Drawing.Size(531, 23);
            this.pbFileCopy.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(46, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "&Start copy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbFileCopy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestFile);
            this.Controls.Add(this.txtDestFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestFile;
        private System.Windows.Forms.Button btnDestFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbFileCopy;
        private System.Windows.Forms.Button btnStart;
    }
}

