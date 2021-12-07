using HRApp.Entities.LoginEntity;
using HRApp.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRApp.Pages.LoginPages
{
    /// <summary>
    /// Interaction logic for LoginEmployeePage.xaml
    /// </summary>
    public partial class LoginEmployeePage : Page
    {
        LoginView loginView;
        public LoginEmployeePage(LoginView loginView)
        {
            InitializeComponent();
            this.loginView = loginView;
        }

        private async Task Login()
        {
            var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri("https://chamcong.24hpay.vn/service/login_employee.php");

            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("email", txtEmail.Text));

            parameters.Add(new KeyValuePair<string, string>("pass", txtPassword.Text));

            // Thiết lập Content
            var content = new FormUrlEncodedContent(parameters);
            httpRequestMessage.Content = content;

            // Thực hiện Post
            var response = await httpClient.SendAsync(httpRequestMessage);

            var responseContent = await response.Content.ReadAsStringAsync();

            LoginEmployeeEntity result = JsonConvert.DeserializeObject<LoginEmployeeEntity>(responseContent);
            if (result.data != null && result.data.result)
            {
                HomeView homeView = new HomeView();
                homeView.Show();
                loginView.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private async void Login(object sender, MouseButtonEventArgs e)
        {
            await Login();
        }

        class Account
        {
            public string email { get; set; }

            public string pass { get; set; }

            public Account(string email, string pass)
            {
                this.email = email;
                this.pass = pass;
            }
        }
    }
}
