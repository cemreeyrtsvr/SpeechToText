namespace SpeechToText
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            btnStop = new Button();
            txtTranscript = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(157, 312);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "\"Başlat\"";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(770, 312);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "\"Bitir\"\r\n";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtTranscript
            // 
            txtTranscript.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTranscript.Location = new Point(157, 511);
            txtTranscript.Multiline = true;
            txtTranscript.Name = "txtTranscript";
            txtTranscript.ScrollBars = ScrollBars.Vertical;
            txtTranscript.Size = new Size(707, 166);
            txtTranscript.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(171, 202);
            label1.Name = "label1";
            label1.Size = new Size(693, 26);
            label1.TabIndex = 3;
            label1.Text = "---Lütfen Başlat Tuşuna Basarak Çevirmek İstediğiniz Metni Söyleyiniz---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1007, 748);
            Controls.Add(label1);
            Controls.Add(txtTranscript);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.RosyBrown;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Çevirici";
            Click += btnStop_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox txtTranscript;
        private Label label1;
    }
}
