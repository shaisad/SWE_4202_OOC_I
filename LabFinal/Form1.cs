using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabFinal
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\sadia\Downloads\SWE4201MarkSheet.csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();




                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();
                    dummy.id = values[0];
                    dummy.name = values[1];
                    dummy.attendance = values[2];
                    dummy.quiz1 = values[3];
                    dummy.quiz2 = values[4];
                    dummy.quiz3 = values[5];
                    dummy.quiz4 = values[6];
                    dummy.mid = values[7];
                    dummy.final = values[8];
                    dummy.viva = values[9];

                    students.Add(dummy);

                    student_listbox.Items.Clear();

                    foreach (Student student in students)
                    {
                       student_listbox.Items.Add(student.getInfo());
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public class Student

        {
            public string id;
            public string name;
            public string attendance;
            public string quiz1;
            public string quiz2;
            public string quiz3;
            public string quiz4;
            public string mid;
            public string final;
            public string viva;
            public double quiztotal;
            public double percentage;
            public double total;
            public string grade;


            public double getQuizTotal()
            {
                int lowest = 0;

                if ((Convert.ToInt32(quiz1) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz1) < Convert.ToInt32(quiz3)) && (Convert.ToInt32(quiz1) < Convert.ToInt32(quiz4)))
                    lowest = Convert.ToInt32(quiz1);

                if ((Convert.ToInt32(quiz2) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz2) < Convert.ToInt32(quiz3)) && (Convert.ToInt32(quiz2) < Convert.ToInt32(quiz4)))
                    lowest = Convert.ToInt32(quiz2);

                if ((Convert.ToInt32(quiz3) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz3) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz3) < Convert.ToInt32(quiz4)))
                    lowest = Convert.ToInt32(quiz3);

                if ((Convert.ToInt32(quiz4) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz4) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz4) < Convert.ToInt32(quiz3)))
                    lowest = Convert.ToInt32(quiz4);

                quiztotal = Convert.ToInt32(quiz1) + Convert.ToInt32(quiz2) + Convert.ToInt32(quiz3) + Convert.ToInt32(quiz4) - lowest;

                return quiztotal;
            }
           
            public double getTotal()
            {
                total = (Convert.ToDouble(attendance) + Convert.ToDouble(mid) + Convert.ToDouble(final) + Convert.ToDouble(viva) + getQuizTotal());
                return total;
            }

            public double getPercentage()
            {
                percentage = getTotal() / 3;
                percentage = Math.Round(percentage, 2);
                return percentage;
            }

            public string getGrade()
            {
                if (percentage < 40)
                    grade = "F";

                else if (percentage < 45 && percentage >= 40)
                    grade = "D";

                else if (percentage < 50 && percentage >= 45)
                    grade = "C";

                else if (percentage < 55 && percentage >= 50)
                    grade = "C+";

                else if (percentage < 60 && percentage >= 55)
                    grade = "B-";

                else if (percentage < 65 && percentage >= 60)
                    grade = "B";

                else if (percentage < 70 && percentage >= 65)
                    grade = "B+";

                else if (percentage < 75 && percentage >= 70)
                    grade = "A-";

                else if (percentage < 80 && percentage >= 75)
                    grade = "A";

                else
                    grade = "A+";

                return grade;
            }
           
            public string getInfo()
            {
                return (id + "\t" + name + "\t\t" + getPercentage() + "%" + "\t\t" + getGrade());
            }
           
        }



        private void search_id_on_click(object sender, EventArgs e)
        {
            string inputid = SearchIDTextbox.Text;


            foreach (Student student in students)
            {
                if (inputid == student.id)

                {
                    AttendanceLabel.Text = student.attendance;
                    Quiz1Label.Text = student.quiz1;
                    Quiz2Label.Text = student.quiz2;
                    Quiz3Label.Text = student.quiz3;
                    Quiz4Label.Text = student.quiz4;
                    QuizTotalLabel.Text = Convert.ToString(student.getQuizTotal());
                    FinalLabel.Text = student.final;
                    VivaLabel.Text = student.viva;
                    TotalLabel.Text = Convert.ToString(student.getTotal());
                    PercentageLabel.Text = Convert.ToString(student.getPercentage()) + "%";
                    GradeLabel.Text = student.getGrade();
                }


            }
        }
    }
}
