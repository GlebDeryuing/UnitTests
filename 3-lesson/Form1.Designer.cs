namespace _3_lesson
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
            this.A1t = new System.Windows.Forms.TextBox();
            this.B1t = new System.Windows.Forms.TextBox();
            this.A2t = new System.Windows.Forms.TextBox();
            this.B2t = new System.Windows.Forms.TextBox();
            this.A3t = new System.Windows.Forms.TextBox();
            this.B3t = new System.Windows.Forms.TextBox();
            this.Distlabel = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.rectbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1t
            // 
            this.A1t.Location = new System.Drawing.Point(14, 15);
            this.A1t.Name = "A1t";
            this.A1t.Size = new System.Drawing.Size(95, 20);
            this.A1t.TabIndex = 0;
            // 
            // B1t
            // 
            this.B1t.Location = new System.Drawing.Point(14, 41);
            this.B1t.Name = "B1t";
            this.B1t.Size = new System.Drawing.Size(95, 20);
            this.B1t.TabIndex = 1;
            // 
            // A2t
            // 
            this.A2t.Location = new System.Drawing.Point(149, 15);
            this.A2t.Name = "A2t";
            this.A2t.Size = new System.Drawing.Size(95, 20);
            this.A2t.TabIndex = 2;
            // 
            // B2t
            // 
            this.B2t.Location = new System.Drawing.Point(149, 41);
            this.B2t.Name = "B2t";
            this.B2t.Size = new System.Drawing.Size(95, 20);
            this.B2t.TabIndex = 3;
            // 
            // A3t
            // 
            this.A3t.Location = new System.Drawing.Point(280, 15);
            this.A3t.Name = "A3t";
            this.A3t.Size = new System.Drawing.Size(95, 20);
            this.A3t.TabIndex = 4;
            // 
            // B3t
            // 
            this.B3t.Location = new System.Drawing.Point(280, 41);
            this.B3t.Name = "B3t";
            this.B3t.Size = new System.Drawing.Size(95, 20);
            this.B3t.TabIndex = 5;
            // 
            // Distlabel
            // 
            this.Distlabel.AutoSize = true;
            this.Distlabel.Location = new System.Drawing.Point(12, 121);
            this.Distlabel.Name = "Distlabel";
            this.Distlabel.Size = new System.Drawing.Size(35, 13);
            this.Distlabel.TabIndex = 6;
            this.Distlabel.Text = "label1";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(15, 67);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(360, 21);
            this.button.TabIndex = 7;
            this.button.Text = "line";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // rectbutton
            // 
            this.rectbutton.Location = new System.Drawing.Point(15, 94);
            this.rectbutton.Name = "rectbutton";
            this.rectbutton.Size = new System.Drawing.Size(360, 21);
            this.rectbutton.TabIndex = 8;
            this.rectbutton.Text = "rect";
            this.rectbutton.UseVisualStyleBackColor = true;
            this.rectbutton.Click += new System.EventHandler(this.rectbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rectbutton);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Distlabel);
            this.Controls.Add(this.B3t);
            this.Controls.Add(this.A3t);
            this.Controls.Add(this.B2t);
            this.Controls.Add(this.A2t);
            this.Controls.Add(this.B1t);
            this.Controls.Add(this.A1t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A1t;
        private System.Windows.Forms.TextBox B1t;
        private System.Windows.Forms.TextBox A2t;
        private System.Windows.Forms.TextBox B2t;
        private System.Windows.Forms.TextBox A3t;
        private System.Windows.Forms.TextBox B3t;
        private System.Windows.Forms.Label Distlabel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button rectbutton;
    }
}

