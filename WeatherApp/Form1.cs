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
            getWeather(); // 天気データを取得
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
                            pic_icon.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon + "@2x.png"; // URLからアイコン画像を取得
                            lab_condition.Text = Info.weather[0].main; // 天候
                            lab_detail.Text = Info.weather[0].description; // 詳細
                            lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString(); // 日の入り
                            lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString(); // 日の出
                            lab_windspeed.Text = Info.wind.speed.ToString() + "m/s"; // 風速
                            lab_pressure.Text = Info.main.pressure.ToString() + "hPa"; // 気圧
                            lab_temp.Text = Info.main.temp.ToString() + "℃"; // 気温
                            lab_humidity.Text = Info.main.humidity.ToString() + "%"; // 湿度
                        }
                        else
                        {
                            MessageBox.Show("都市名が見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (WebException ex)
                    {
                        HttpWebResponse response = (HttpWebResponse)((WebException)ex).Response;
                        if (response != null && response.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("都市名が見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("APIに接続できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("APIに接続できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // JSONデータを日時に変換
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
