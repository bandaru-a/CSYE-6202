using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationWpf
{
  public class Student
  {
    public string StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public string EnrollmentType { get; set; }
    public static List<string> deptList = new List<string>(new string[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" });
    public ArrayList studentIdList = new ArrayList();
    public ArrayList firstNameList = new ArrayList();
    public ArrayList lastNameList = new ArrayList();
    public ArrayList enrollmentTypeList = new ArrayList();
    public static List<Student> studentList = new List<Student>();

    public Student()
    {
      LoadFirstNameList();
      LoadLastNameList();
      LoadEnrollmentTypeList();
      LoadStudentIdList();
    }

    public void LoadFirstNameList()
    {
      firstNameList.Add("Nancy");
      firstNameList.Add("Richard");
      firstNameList.Add("Sidney");
      firstNameList.Add("Robin");
      firstNameList.Add("Danielle");
      firstNameList.Add("Jeffrey");
      firstNameList.Add("John");
      firstNameList.Add("Nora");
      firstNameList.Add("Stephen");
      firstNameList.Add("Chelsi");
    }

    public void LoadLastNameList()
    {
      lastNameList.Add("Brook");
      lastNameList.Add("Thomas");
      lastNameList.Add("Sheldon");
      lastNameList.Add("Cook");
      lastNameList.Add("White");
      lastNameList.Add("Archer");
      lastNameList.Add("Grisham");
      lastNameList.Add("Roberts");
      lastNameList.Add("King");
      lastNameList.Add("Ray");
    }

    public void LoadEnrollmentTypeList()
    {
      enrollmentTypeList.Add("Fulltime");
      enrollmentTypeList.Add("Parttime");
      enrollmentTypeList.Add("Parttime");
      enrollmentTypeList.Add("Fulltime");
      enrollmentTypeList.Add("Parttime");
      enrollmentTypeList.Add("Fulltime");
      enrollmentTypeList.Add("Fulltime");
      enrollmentTypeList.Add("Parttime");
      enrollmentTypeList.Add("Fulltime");
      enrollmentTypeList.Add("Parttime");
    }

    public void LoadStudentIdList()
    {
      studentIdList.Add("123-34-456");
      studentIdList.Add("345-56-678");
      studentIdList.Add("567-78-890");
      studentIdList.Add("121-31-141");
      studentIdList.Add("375-12-657");
      studentIdList.Add("765-76-567");
      studentIdList.Add("101-45-234");
      studentIdList.Add("234-34-987");
      studentIdList.Add("765-23-123");
      studentIdList.Add("182-11-273");
    }

    public List<Student> GenerateStudentList()
    {
      Random rand = new Random();
      int i = 1;
      while (i < 10)
      {
        studentList.Add(
            new Student
            {
              StudentID = studentIdList[rand.Next(0, 10)].ToString(),
              FirstName = firstNameList[rand.Next(0, 10)].ToString(),
              LastName = lastNameList[rand.Next(0, 10)].ToString(),
              Department = deptList[rand.Next(0, 7)].ToString(),
              EnrollmentType = enrollmentTypeList[rand.Next(0, 10)].ToString()
            }
          );
        i++;
      }

      return studentList;
    }
  }
}
