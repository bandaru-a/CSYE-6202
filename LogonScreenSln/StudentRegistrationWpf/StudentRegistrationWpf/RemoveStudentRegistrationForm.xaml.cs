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

namespace StudentRegistrationWpf
{
  /// <summary>
  /// Interaction logic for RemoveStudentRegistrationForm.xaml
  /// </summary>
  public partial class RemoveStudentRegistrationForm : Window
  {
    Student studenttoRemove;
    internal StudentRegistrationMainWindow srm;
    public RemoveStudentRegistrationForm(Student remStudent)
    {
      InitializeComponent();
      studenttoRemove = remStudent;
    }

    private void btnRemove_Click(object sender, RoutedEventArgs e)
    {
      MessageBoxResult result = MessageBox.Show("Are you sure you want to remove this student?", "Remove Student Registration confirmation", MessageBoxButton.YesNo);
      if (result == MessageBoxResult.Yes)
      {
        Student.studentList.Remove(studenttoRemove);
        ((StudentRegistrationMainWindow)this.Owner).dataGrid.DataContext = null;
        ((StudentRegistrationMainWindow)this.Owner).dataGrid.DataContext = Student.studentList;
        this.Hide();
      }
      else
      {
        this.Hide();
        srm.Hide();
      }
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
