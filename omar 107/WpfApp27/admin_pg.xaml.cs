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

namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for admin_pg.xaml
    /// </summary>
    public partial class admin_pg : Window
    {
        project1Entities db = new project1Entities();
        task ts = new task();
        public admin_pg()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            grid.ItemsSource = db.tasks.ToList();
        }

        private void add_butt_Click(object sender, RoutedEventArgs e)
        {
            var pp = new task()
            {
                task_id = int.Parse(id1_txt.Text),
                task_name = name1_txt.Text,
                task_title = title1_txt.Text,
                task_des = des1_txt.Text,
                task_Status = cb.Text,
            };
            db.tasks.Add(pp);
            db.SaveChanges();
            Load();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem is task select)
            {
                select.task_id = int.Parse(id1_txt.Text);
                select.task_name = name1_txt.Text;
                select.task_title = title1_txt.Text;
                select.task_des = des1_txt.Text;
                select.task_Status = cb.Text;
                db.SaveChanges();
                Load();
            }

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            db.tasks.Remove(ts);
            db.SaveChanges();
            Load();
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem is task select)
            {
                ts = select;
                id1_txt.Text = select.task_id.ToString();
                name1_txt.Text = select.task_name.ToString();
                title1_txt.Text = select.task_title.ToString();
                des1_txt.Text = select.task_des.ToString();
                cb.Text = select.task_Status;
            }
        }
    }
}
