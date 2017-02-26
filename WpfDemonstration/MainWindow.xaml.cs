using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfDemonstration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
   
        public MainWindow()
        {
            ObservableCollection<string> Project1Dependencies = new ObservableCollection<string>();
            ObservableCollection<string> Project2Dependencies = new ObservableCollection<string>();
            Project1Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject1\Testingproject1");
            Project1Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject1\Testingproject2");
            Project1Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject1\Testingproject3");
            Project1Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject1\Testingproject4");
            Project2Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject2\Testingproject1");
            Project2Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject2\Testingproject2");
            Project2Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject2\Testingproject3");
            Project2Dependencies.Add(@"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\Testingproject2\Testingproject4");

            List<Project> projects = new List<Project>();
            Project project1 = new Project
            {
                Name = "project1",
                PathsOfDependencies = Project1Dependencies

            };
            Project project2 = new Project
            {
                Name = "project2",
                PathsOfDependencies = Project2Dependencies
            };

            projects.Add(project1);projects.Add(project2);
            this.DataContext = projects;

            InitializeComponent();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DependenciesListBox.DataContext = listBox.SelectedValue as Project;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddDependencyDialogWindow dialog = new AddDependencyDialogWindow();
            if (dialog.ShowDialog() == true)
            {
                (listBox.SelectedValue as Project).PathsOfDependencies.Add(dialog.path);
            }
        }
    }
}
