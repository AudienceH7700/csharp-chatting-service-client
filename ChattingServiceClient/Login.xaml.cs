using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChattingServiceClient
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(IpTextBox.Text))
            {
                MessageBox.Show("닉네임과 IP를 입력해주세요.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string nameCheck = string.Format("{0} 님으로 로그인 하시겠습니까?", NameTextBox.Text);
            MessageBoxResult nameMessageBoxResult = MessageBox.Show(nameCheck, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(nameMessageBoxResult == MessageBoxResult.No)
            {
                return;
            }

            string ipCheck = string.Format("서버 IP는 {0} 이 맞습니까?", IpTextBox.Text);
            MessageBoxResult ipMessageBoxResult = MessageBox.Show(ipCheck, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(ipMessageBoxResult == MessageBoxResult.No) 
            {
                return;
            }

            this.DialogResult = true;
        }
    }
}
