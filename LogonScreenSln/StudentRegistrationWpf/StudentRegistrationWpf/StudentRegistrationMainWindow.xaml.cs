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
  /// Interaction logic for StudentRegistrationMainWindow.xaml
  /// </summary>
  public partial class StudentRegistrationMainWindow : Window
  {
    Student objStudent = new Student();
    List<Student> students;
    public StudentRegistrationMainWindow()
    {
      InitializeComponent();
    }

    private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      foreach (DataGridViewRow row in dataGrid.SelectedRows)
      {
        txtID.Text = row.Cells[0].Value.ToString();
        txtFirstName.Text = row.Cells[1].Value.ToString();
        txtLastName.Text = row.Cells[2].Value.ToString();
        cmbDepartment.SelectedIndex = cmbDepartment.Items.IndexOf(row.Cells[3].Value.ToString());


        if (row.Cells[4].Value.ToString() == "Fulltime")
        {
          rbtnFulltime.IsChecked = true;
        }
        else
        {
          rbtnParttime.IsChecked = true;
        }

      }

    }

    private void btnNewStudent_Click(object sender, RoutedEventArgs e)
    {
      NewStudentRegistrationForm newStudRegForm = new NewStudentRegistrationForm();
      newStudRegForm.Show();
      this.Close();
    }

    private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
    {
      var remStudent = (Student)dataGrid.SelectedRows[0].DataBoundItem;
      RemoveStudentRegistrationForm remStudRegForm = new RemoveStudentRegistrationForm(remStudent);
      remStudRegForm.srm = this;
      remStudRegForm.Show(this);
    }

    private void btnEditStudent_Click(object sender, RoutedEventArgs e)
    {
      var remStudent = (Student)dataGrid.SelectedRows[0].DataBoundItem;
      EditStudentRegistrationForm editStudRegForm = new EditStudentRegistrationForm(remStudent);
      editStudRegForm.srm = this;
      editStudRegForm.Show();
      dataGrid.DataSource = Student.studentList;
    }
  }
}
