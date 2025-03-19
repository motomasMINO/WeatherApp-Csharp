using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String APIKey = "6146e78137b3768e2aa4fb9ad8f58e48";

        private void Btn_search_Click(object sender, EventArgs e)
        {
            getWeather(); // �V�C�f�[�^���擾
        }

        private void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&lang=ja&appid={1}", TbCity.Text, APIKey);

                    try
                    {
                        var json = web.DownloadString(url);
                        WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                        if (Info != null && Info.weather != null && Info.weather.Count > 0)
                        {
                            pic_icon.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon + "@2x.png"; // URL����A�C�R���摜���擾
                            lab_condition.Text = Info.weather[0].main; // �V��
                            lab_detail.Text = Info.weather[0].description; // �ڍ�
                            lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString(); // ���̓���
                            lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString(); // ���̏o
                            lab_windspeed.Text = Info.wind.speed.ToString() + "m/s"; // ����
                            lab_pressure.Text = Info.main.pressure.ToString() + "hPa"; // �C��
                            lab_temp.Text = Info.main.temp.ToString() + "��"; // �C��
                            lab_humidity.Text = Info.main.humidity.ToString() + "%"; // ���x
                        }
                        else
                        {
                            MessageBox.Show("�s�s����������܂���ł����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (WebException ex)
                    {
                        HttpWebResponse response = (HttpWebResponse)((WebException)ex).Response;
                        if (response != null && response.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("�s�s����������܂���ł����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("API�ɐڑ��ł��܂���ł����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("API�ɐڑ��ł��܂���ł����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // JSON�f�[�^������ɕϊ�
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
