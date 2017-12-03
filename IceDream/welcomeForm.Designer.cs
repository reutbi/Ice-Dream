namespace IceDream
{
    partial class welcomeForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_welcomeForm = new System.Windows.Forms.PictureBox();
            this.timer_welcomeForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_welcomeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_welcomeForm
            // 
            this.pictureBox_welcomeForm.Location = new System.Drawing.Point(0, -2);
            this.pictureBox_welcomeForm.Name = "pictureBox_welcomeForm";
            this.pictureBox_welcomeForm.Size = new System.Drawing.Size(984, 261);
            this.pictureBox_welcomeForm.TabIndex = 0;
            this.pictureBox_welcomeForm.TabStop = false;
            // 
            // timer_welcomeForm
            // 
            this.timer_welcomeForm.Interval = 5000;
            this.timer_welcomeForm.Tick += new System.EventHandler(this.timer_welcomeForm_Tick);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.pictureBox_welcomeForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice-Dream";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_welcomeForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_welcomeForm;
        private System.Windows.Forms.Timer timer_welcomeForm;
    }
}