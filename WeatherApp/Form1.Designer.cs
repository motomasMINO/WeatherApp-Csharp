namespace WeatherApp
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
            TbCity = new TextBox();
            label1 = new Label();
            Btn_search = new Button();
            lab_condition = new Label();
            lab_detail = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lab_sunrise = new Label();
            lab_sunset = new Label();
            lab_windspeed = new Label();
            lab_pressure = new Label();
            pic_icon = new PictureBox();
            label2 = new Label();
            lab_humidity = new Label();
            lab_temp = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_icon).BeginInit();
            SuspendLayout();
            // 
            // TbCity
            // 
            TbCity.Location = new Point(107, 36);
            TbCity.Name = "TbCity";
            TbCity.Size = new Size(311, 27);
            TbCity.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 1;
            label1.Text = "都市名:";
            // 
            // Btn_search
            // 
            Btn_search.BackColor = Color.Transparent;
            Btn_search.BackgroundImage = (Image)resources.GetObject("Btn_search.BackgroundImage");
            Btn_search.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_search.FlatStyle = FlatStyle.Flat;
            Btn_search.Location = new Point(424, 27);
            Btn_search.Name = "Btn_search";
            Btn_search.Size = new Size(48, 50);
            Btn_search.TabIndex = 2;
            Btn_search.UseVisualStyleBackColor = false;
            Btn_search.Click += Btn_search_Click;
            // 
            // lab_condition
            // 
            lab_condition.AutoSize = true;
            lab_condition.BackColor = Color.Transparent;
            lab_condition.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_condition.ForeColor = Color.White;
            lab_condition.Location = new Point(196, 300);
            lab_condition.Name = "lab_condition";
            lab_condition.Size = new Size(99, 40);
            lab_condition.TabIndex = 3;
            lab_condition.Text = "天候";
            // 
            // lab_detail
            // 
            lab_detail.AutoSize = true;
            lab_detail.BackColor = Color.Transparent;
            lab_detail.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_detail.ForeColor = Color.White;
            lab_detail.Location = new Point(216, 372);
            lab_detail.Name = "lab_detail";
            lab_detail.Size = new Size(58, 23);
            lab_detail.TabIndex = 4;
            lab_detail.Text = "詳細";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 5;
            label4.Text = "風速:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 314);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 6;
            label5.Text = "気圧:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 528);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 7;
            label6.Text = "日の出:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 565);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 8;
            label7.Text = "日の入り:";
            // 
            // lab_sunrise
            // 
            lab_sunrise.AutoSize = true;
            lab_sunrise.BackColor = Color.Transparent;
            lab_sunrise.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_sunrise.ForeColor = Color.White;
            lab_sunrise.Location = new Point(136, 528);
            lab_sunrise.Name = "lab_sunrise";
            lab_sunrise.Size = new Size(55, 23);
            lab_sunrise.TabIndex = 9;
            lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            lab_sunset.AutoSize = true;
            lab_sunset.BackColor = Color.Transparent;
            lab_sunset.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_sunset.ForeColor = Color.White;
            lab_sunset.Location = new Point(136, 565);
            lab_sunset.Name = "lab_sunset";
            lab_sunset.Size = new Size(55, 23);
            lab_sunset.TabIndex = 10;
            lab_sunset.Text = "N/A";
            // 
            // lab_windspeed
            // 
            lab_windspeed.AutoSize = true;
            lab_windspeed.BackColor = Color.Transparent;
            lab_windspeed.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_windspeed.ForeColor = Color.White;
            lab_windspeed.Location = new Point(82, 260);
            lab_windspeed.Name = "lab_windspeed";
            lab_windspeed.Size = new Size(55, 23);
            lab_windspeed.TabIndex = 11;
            lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            lab_pressure.AutoSize = true;
            lab_pressure.BackColor = Color.Transparent;
            lab_pressure.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_pressure.ForeColor = Color.White;
            lab_pressure.Location = new Point(82, 314);
            lab_pressure.Name = "lab_pressure";
            lab_pressure.Size = new Size(55, 23);
            lab_pressure.TabIndex = 12;
            lab_pressure.Text = "N/A";
            // 
            // pic_icon
            // 
            pic_icon.BackColor = Color.Transparent;
            pic_icon.Location = new Point(196, 179);
            pic_icon.Name = "pic_icon";
            pic_icon.Size = new Size(129, 104);
            pic_icon.TabIndex = 13;
            pic_icon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 372);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 14;
            label2.Text = "湿度:";
            // 
            // lab_humidity
            // 
            lab_humidity.AutoSize = true;
            lab_humidity.BackColor = Color.Transparent;
            lab_humidity.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_humidity.ForeColor = Color.White;
            lab_humidity.Location = new Point(82, 372);
            lab_humidity.Name = "lab_humidity";
            lab_humidity.Size = new Size(55, 23);
            lab_humidity.TabIndex = 15;
            lab_humidity.Text = "N/A";
            // 
            // lab_temp
            // 
            lab_temp.AutoSize = true;
            lab_temp.BackColor = Color.Transparent;
            lab_temp.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lab_temp.ForeColor = Color.White;
            lab_temp.Location = new Point(216, 413);
            lab_temp.Name = "lab_temp";
            lab_temp.Size = new Size(58, 23);
            lab_temp.TabIndex = 16;
            lab_temp.Text = "気温";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 597);
            Controls.Add(lab_temp);
            Controls.Add(lab_humidity);
            Controls.Add(label2);
            Controls.Add(pic_icon);
            Controls.Add(lab_pressure);
            Controls.Add(lab_windspeed);
            Controls.Add(lab_sunset);
            Controls.Add(lab_sunrise);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lab_detail);
            Controls.Add(lab_condition);
            Controls.Add(Btn_search);
            Controls.Add(label1);
            Controls.Add(TbCity);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "お天気アプリ";
            ((System.ComponentModel.ISupportInitialize)pic_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbCity;
        private Label label1;
        private Button Btn_search;
        private Label lab_condition;
        private Label lab_detail;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lab_sunrise;
        private Label lab_sunset;
        private Label lab_windspeed;
        private Label lab_pressure;
        private PictureBox pic_icon;
        private Label label2;
        private Label lab_humidity;
        private Label lab_temp;
    }
}
