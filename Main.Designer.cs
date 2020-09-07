namespace PingPongEvent
{
    partial class Main
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
            this.cmd = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.BackColor = System.Drawing.Color.Black;
            this.cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd.ForeColor = System.Drawing.Color.Lime;
            this.cmd.Location = new System.Drawing.Point(0, 0);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(800, 450);
            this.cmd.TabIndex = 0;
            this.cmd.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cmd;
    }
}

