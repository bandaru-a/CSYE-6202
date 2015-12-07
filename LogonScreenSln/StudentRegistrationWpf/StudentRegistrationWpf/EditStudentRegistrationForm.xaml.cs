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
  /// Interaction logic for EditStudentRegistrationForm.xaml
  /// </summary>
  public partial class EditStudentRegistrationForm : Window
  {
    Student studenttoEdit;
    internal StudentRegistrationMainWindow srm;
    public EditStudentRegistrationForm(Student st)
    {
      InitializeComponent();
      studenttoEdit = st;
    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {

      if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
     || cmbDepartment.SelectedIndex == -1)
      {
        MessageBox.Show("Please fill in all the fields", "Edit Student Registration warning", MessageBoxButton.OK);
      }
      else
      {

        MessageBoxResult result = MessageBox.Show("Are you sure you want to update this student?", "Edit Student Registration confirmation", MessageBoxButton.YesNo);
        if (result == MessageBoxResult.Yes)
        {
          Student UpdatedStudent = new Student
          {
            StudentID = txtID.Text,
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            Department = cmbDepartment.SelectedItem.ToString(),
            EnrollmentType = rbtnFulltime.IsPressed ? "Fulltime" : "Parttime"
          };
          Student.studentList.Remove(studenttoEdit);
          Student.studentList.Add(UpdatedStudent);
          this.Hide();
          srm.Refresh();
        }

        else
        {
          this.Hide();
          srm.Hide();
        }
      }
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
// private void Window_Loaded(object sender, RoutedEventArgs e)