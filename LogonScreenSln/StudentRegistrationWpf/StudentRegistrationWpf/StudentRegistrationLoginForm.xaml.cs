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

namespace StudentRegistrationWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    int counter = 0;
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnSignIn_Click(object sender, RoutedEventArgs e)
    {
      string usrName = "demouser";
      string pwd = "demo";
      if ((txtUsername.Text.ToUpper() == usrName.ToUpper()) && (txtPassword.Text == pwd))
      {
        this.Hide();
        StudentRegistrationMainWindow srmw = new StudentRegistrationMainWindow();
        srmw.Show();
      }
      else
      {
        txtUsername.Clear();
        txtPassword.Clear();
        counter++;
        if (counter == 3)
          this.Close();
      }
    }
  }
}
