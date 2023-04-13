using HandyControl.Tools.Extension;
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

namespace IdiNahui
{
    /// <summary>
    /// Логика взаимодействия для ChoosePage.xaml
    /// </summary>
    public partial class ChoosePage : Page
    {
        public ChoosePage()
        {
            InitializeComponent();
            UserToDo toDo = new UserToDo();
            UserToDo toDo1 = new UserToDo();
            toDo1.NameDo.Text = "жоско слушать музыку";
            toDo1.ImfDo.Source = new BitmapImage(new Uri("music.png", UriKind.Relative));
            UserToDo toDo2 = new UserToDo();
            toDo2.NameDo.Text = "выспався";
            toDo2.ImfDo.Source = new BitmapImage(new Uri("hachis drawing of nana lmao.jpg", UriKind.Relative));
            UserToDo toDo3 = new UserToDo();
            toDo3.NameDo.Text = "ecgtd gjgkfrfnm";
            toDo3.ImfDo.Source = new BitmapImage(new Uri("cry.jpg", UriKind.Relative));

            List<UserToDo> userToDos = new List<UserToDo>() { toDo, toDo1, toDo2, toDo3 };
            ToDoLit.ItemsSource = userToDos;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
             
        }

       
    }
}
