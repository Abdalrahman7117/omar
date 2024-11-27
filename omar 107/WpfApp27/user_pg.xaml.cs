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
    /// Interaction logic for user_pg.xaml
    /// </summary>
    public partial class user_pg : Window
    {
        project1Entities db = new project1Entities();
        task ts = new task();
        public user_pg()
        {
            InitializeComponent();
            Load();
            Load1();
            
           
        }
        public void Load()
        {
            cb.ItemsSource = db.tasks.ToList();
            
        }
        public void Load1()
        {
            var gridpend = db.tasks.Where(x => x.task_id == int.Parse(id_txt.Text) && x.task_Status == "Completed");
            var gridcomb = db.tasks.Where(q => q.task_id == int.Parse(id_txt.Text) && q.task_Status == "Pending" || q.task_Status == "In Progress");          
        }

        //private void save_butt_Click(object sender, RoutedEventArgs e)
        //{
          
        //    if (pend.SelectedItem is task select)
        //    {              
        //        select.task_id = int.Parse(id_txt.Text);
        //        select.task_Status = cb.Text;
        //        db.SaveChanges();
        //        Load();
        //        Load1();
               
        //    }
            //else if (Completed.SelectedItem is task select1)
            //{               
            //    select1.task_id = int.Parse(id_txt.Text);
            //    select1.task_Status = cb.Text;
            //    db.SaveChanges();
            //    Load();
            //    Load1();
            //    Load2();
            //}
            //var op = new task()
            //{
            //    task_id = int.Parse(id_txt.Text),
            //    task_Status = cb.Text,
            //};
            //db.tasks.Add(op);
            //db.SaveChanges();
            //Load();
            //Load1();
     //   }

        private void pend_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (pend.SelectedItem is task select)
            {
                ts = select;
                id_txt.Text = select.task_id.ToString();
                cb.Text = select.task_Status;

            }
        }

  
        

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void save_butt_Click_1(object sender, RoutedEventArgs e)
        {
            var op = new task()
            {
                task_id = int.Parse(id_txt.Text),
                task_Status = cb.Text,
            };
            db.tasks.Add(op);
            db.SaveChanges();
            Load();
            Load1();
        }
        private void Completed_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Completed.SelectedItem is task select)
            {
                ts = select;
                id_txt.Text = select.task_id.ToString();
                cb.Text = select.task_Status;
            }

        }
    }
}
