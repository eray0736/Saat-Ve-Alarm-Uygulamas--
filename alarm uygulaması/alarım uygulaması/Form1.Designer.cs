
namespace alarm_uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNalarımKur = new System.Windows.Forms.Button();
            this.BTNalarmErteleme = new System.Windows.Forms.Button();
            this.BtnAlarmSustur = new System.Windows.Forms.Button();
            this.IBIgüncel_zaman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlarmZamanı = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTARİH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNalarımKur
            // 
            this.BTNalarımKur.BackColor = System.Drawing.Color.Turquoise;
            this.BTNalarımKur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNalarımKur.BackgroundImage")));
            this.BTNalarımKur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNalarımKur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNalarımKur.FlatAppearance.BorderSize = 0;
            this.BTNalarımKur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNalarımKur.ForeColor = System.Drawing.Color.Black;
            this.BTNalarımKur.Location = new System.Drawing.Point(161, 171);
            this.BTNalarımKur.Name = "BTNalarımKur";
            this.BTNalarımKur.Size = new System.Drawing.Size(90, 42);
            this.BTNalarımKur.TabIndex = 0;
            this.BTNalarımKur.Text = "KUR";
            this.BTNalarımKur.UseVisualStyleBackColor = false;
            this.BTNalarımKur.Click += new System.EventHandler(this.BTNalarmKur_Click);
            // 
            // BTNalarmErteleme
            // 
            this.BTNalarmErteleme.BackColor = System.Drawing.Color.Turquoise;
            this.BTNalarmErteleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNalarmErteleme.BackgroundImage")));
            this.BTNalarmErteleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNalarmErteleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNalarmErteleme.FlatAppearance.BorderSize = 0;
            this.BTNalarmErteleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNalarmErteleme.ForeColor = System.Drawing.Color.Black;
            this.BTNalarmErteleme.Location = new System.Drawing.Point(278, 171);
            this.BTNalarmErteleme.Name = "BTNalarmErteleme";
            this.BTNalarmErteleme.Size = new System.Drawing.Size(90, 42);
            this.BTNalarmErteleme.TabIndex = 1;
            this.BTNalarmErteleme.Text = "ERTELE";
            this.BTNalarmErteleme.UseVisualStyleBackColor = false;
            this.BTNalarmErteleme.Click += new System.EventHandler(this.BTNalarmErteleme_Click);
            // 
            // BtnAlarmSustur
            // 
            this.BtnAlarmSustur.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnAlarmSustur.BackColor = System.Drawing.Color.Turquoise;
            this.BtnAlarmSustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAlarmSustur.BackgroundImage")));
            this.BtnAlarmSustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlarmSustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlarmSustur.FlatAppearance.BorderSize = 0;
            this.BtnAlarmSustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlarmSustur.ForeColor = System.Drawing.Color.Black;
            this.BtnAlarmSustur.Location = new System.Drawing.Point(390, 171);
            this.BtnAlarmSustur.Name = "BtnAlarmSustur";
            this.BtnAlarmSustur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlarmSustur.Size = new System.Drawing.Size(90, 42);
            this.BtnAlarmSustur.TabIndex = 2;
            this.BtnAlarmSustur.Text = "DURDUR";
            this.BtnAlarmSustur.UseVisualStyleBackColor = false;
            this.BtnAlarmSustur.Click += new System.EventHandler(this.BtnAlarmSustur_Click);
            // 
            // IBIgüncel_zaman
            // 
            this.IBIgüncel_zaman.BackColor = System.Drawing.Color.Transparent;
            this.IBIgüncel_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IBIgüncel_zaman.ForeColor = System.Drawing.Color.White;
            this.IBIgüncel_zaman.Location = new System.Drawing.Point(224, 6);
            this.IBIgüncel_zaman.Name = "IBIgüncel_zaman";
            this.IBIgüncel_zaman.Size = new System.Drawing.Size(195, 60);
            this.IBIgüncel_zaman.TabIndex = 3;
            this.IBIgüncel_zaman.Text = "00:00:00";
            this.IBIgüncel_zaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IBIgüncel_zaman.Click += new System.EventHandler(this.IBIgüncel_zaman_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 63);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlarmZamanı
            // 
            this.txtAlarmZamanı.BackColor = System.Drawing.Color.DarkGray;
            this.txtAlarmZamanı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlarmZamanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlarmZamanı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAlarmZamanı.Location = new System.Drawing.Point(242, 129);
            this.txtAlarmZamanı.Name = "txtAlarmZamanı";
            this.txtAlarmZamanı.Size = new System.Drawing.Size(156, 23);
            this.txtAlarmZamanı.TabIndex = 5;
            this.txtAlarmZamanı.TextChanged += new System.EventHandler(this.txtAlarmZamanı_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "alarm saatini giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTARİH
            // 
            this.labelTARİH.AutoSize = true;
            this.labelTARİH.BackColor = System.Drawing.Color.Transparent;
            this.labelTARİH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTARİH.Location = new System.Drawing.Point(12, 9);
            this.labelTARİH.Name = "labelTARİH";
            this.labelTARİH.Size = new System.Drawing.Size(130, 25);
            this.labelTARİH.TabIndex = 7;
            this.labelTARİH.Text = "00:00:0000";
            this.labelTARİH.Click += new System.EventHandler(this.labelTARİH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(622, 295);
            this.Controls.Add(this.labelTARİH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlarmZamanı);
            this.Controls.Add(this.BTNalarmErteleme);
            this.Controls.Add(this.BTNalarımKur);
            this.Controls.Add(this.IBIgüncel_zaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAlarmSustur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNalarımKur;
        private System.Windows.Forms.Button BTNalarmErteleme;
        private System.Windows.Forms.Button BtnAlarmSustur;
        private System.Windows.Forms.Label IBIgüncel_zaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlarmZamanı;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTARİH;
    }
}

