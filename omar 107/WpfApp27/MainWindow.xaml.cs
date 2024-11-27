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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        project1Entities db = new project1Entities();
        login1 lo = new login1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void log_butt_Click(object sender, RoutedEventArgs e)
        {
            var start = db.login1.FirstOrDefault(z => z.log_name == name_txt.Text && z.log_pass == pass_txt.Text && z.log_role == "admin");
            var start1 = db.login1.FirstOrDefault(z => z.log_name == name_txt.Text && z.log_pass == pass_txt.Text && z.log_role == "user");
            if (start!=null)
            {
                admin_pg admin = new admin_pg();
                admin.Show();
                this.Close();
            }
            else if (start1!=null)
            {
                user_pg user = new user_pg();
                user.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
    }
}
