#region Using Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StudentRegistration.Domain;

#endregion

namespace StudentRegistration.MVP
{
	public partial class StudentRegistrationForm : Form, IStudentRegistrationForm
	{

		public event EventHandler DataChanged;

		#region Constructors

		public StudentRegistrationForm()
		{
			InitializeComponent();
			Init();
		}

		#endregion

		#region Methods

		// good software programming practice!!
		private void Init()
		{			
			LoadDepartments();
			LoadDataGridWithMockData();
			LoadDefaults();
		}

		private void LoadDepartments()
		{
			comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
				"Professional Studies", "Psychology", "Public Administration" });
		}

		// since we don't know ADO.NET and/or File I/O we will get static mock data
		private void LoadDataGridWithMockData()
		{
			var mockStudentList = new List<Student>()
			{
				new Student("111-11-1212", "Bart", "Simpson", "Information Systems", "Full Time"),
				new Student("123-12-1234", "Maggie", "Simpson", "International Affairs", "Part Time"),
			};

			// dirty workaround to make sure that we can bind to the static mock list
			var bindingList = new BindingList<Student>(mockStudentList);
			var source = new BindingSource(bindingList, null);
			dataGridViewStudents.DataSource = source;
		}

		private void LoadDefaults()
		{
			radioButtonFullTime.Select();
			comboBoxDepartment.SelectedIndex = 0;

		}

		#endregion

		private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
			{
				textBox2.Text = row.Cells[0].Value.ToString();
				textBox3.Text = row.Cells[1].Value.ToString();
				textBox4.Text = row.Cells[2].Value.ToString();

				comboBoxDepartment.SelectedIndex = comboBoxDepartment.Items.IndexOf(row.Cells[3].Value.ToString());

				// enrollment type selection driven by the grid itself
				var enrollmentType = row.Cells[4].Value.ToString();
				if (radioButtonFullTime.Text == enrollmentType)
				{
					radioButtonFullTime.Checked = true;
				}
				else if (radioButtonPartTime.Text == enrollmentType)
				{
					radioButtonPartTime.Checked = true;
				}
			}
		}

    
  }
}
