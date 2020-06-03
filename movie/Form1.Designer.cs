namespace Task_6__Animation_
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.MercuryTimer = new System.Windows.Forms.Timer(this.components);
            this.AnimationCheckBox = new System.Windows.Forms.CheckBox();
            this.EarthTimer = new System.Windows.Forms.Timer(this.components);
            this.MarsTimer = new System.Windows.Forms.Timer(this.components);
            this.JupiterTimer = new System.Windows.Forms.Timer(this.components);
            this.SaturnTimer = new System.Windows.Forms.Timer(this.components);
            this.UranusTimer = new System.Windows.Forms.Timer(this.components);
            this.NeptuneTimer = new System.Windows.Forms.Timer(this.components);
            this.PlutoTimer = new System.Windows.Forms.Timer(this.components);
            this.VenusTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPictureBox.BackColor = System.Drawing.Color.Black;
            this.MainPictureBox.Location = new System.Drawing.Point(9, 67);
            this.MainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(986, 564);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // MercuryTimer
            // 
            this.MercuryTimer.Interval = 1;
            this.MercuryTimer.Tick += new System.EventHandler(this.MercuryTimer_Tick);
            // 
            // AnimationCheckBox
            // 
            this.AnimationCheckBox.AutoSize = true;
            this.AnimationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimationCheckBox.Location = new System.Drawing.Point(455, 23);
            this.AnimationCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.AnimationCheckBox.Name = "AnimationCheckBox";
            this.AnimationCheckBox.Size = new System.Drawing.Size(98, 28);
            this.AnimationCheckBox.TabIndex = 0;
            this.AnimationCheckBox.Text = "Animate";
            this.AnimationCheckBox.UseVisualStyleBackColor = true;
            this.AnimationCheckBox.CheckedChanged += new System.EventHandler(this.AnimationCheckBox_CheckedChanged);
            // 
            // EarthTimer
            // 
            this.EarthTimer.Interval = 20;
            this.EarthTimer.Tick += new System.EventHandler(this.EarthTimer_Tick);
            // 
            // MarsTimer
            // 
            this.MarsTimer.Interval = 35;
            this.MarsTimer.Tick += new System.EventHandler(this.MarsTimer_Tick);
            // 
            // JupiterTimer
            // 
            this.JupiterTimer.Interval = 60;
            this.JupiterTimer.Tick += new System.EventHandler(this.JupiterTimer_Tick);
            // 
            // SaturnTimer
            // 
            this.SaturnTimer.Interval = 150;
            this.SaturnTimer.Tick += new System.EventHandler(this.SaturnTimer_Tick);
            // 
            // UranusTimer
            // 
            this.UranusTimer.Interval = 420;
            this.UranusTimer.Tick += new System.EventHandler(this.UranusTimer_Tick);
            // 
            // NeptuneTimer
            // 
            this.NeptuneTimer.Interval = 825;
            this.NeptuneTimer.Tick += new System.EventHandler(this.NeptuneTimer_Tick);
            // 
            // PlutoTimer
            // 
            this.PlutoTimer.Interval = 1240;
            this.PlutoTimer.Tick += new System.EventHandler(this.PlutoTimer_Tick);
            // 
            // VenusTimer
            // 
            this.VenusTimer.Interval = 18;
            this.VenusTimer.Tick += new System.EventHandler(this.VenusTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.AnimationCheckBox);
            this.Controls.Add(this.MainPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.CheckBox AnimationCheckBox;
        private System.Windows.Forms.Timer MercuryTimer;
        private System.Windows.Forms.Timer EarthTimer;
        private System.Windows.Forms.Timer MarsTimer;
        private System.Windows.Forms.Timer JupiterTimer;
        private System.Windows.Forms.Timer SaturnTimer;
        private System.Windows.Forms.Timer UranusTimer;
        private System.Windows.Forms.Timer NeptuneTimer;
        private System.Windows.Forms.Timer PlutoTimer;
        private System.Windows.Forms.Timer VenusTimer;
    }
}

