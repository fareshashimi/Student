using System;

namespace Program
{
    class Student
    {
        private int studentNo;
        private string name;
        private string surname;
        private int vize_1;
        private int vize_2;
        private int final;
        private string schoolName;

        public Student(int studentNo, string name, string surname, int vize_1, int vize_2, int final, string schoolName)
        {
            this.studentNo = studentNo;
            this.name = name;
            this.surname = surname;
            this.vize_1 = vize_1;
            this.vize_2 = vize_2;
            this.final = final;
            this.schoolName = schoolName;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }

        public void showStudentInformation()
        {
            Console.WriteLine($"Student number: {studentNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"The first vize result: {vize_1}");
            Console.WriteLine($"The second vize result: {vize_2}");
            Console.WriteLine($"The result of final: {final}");
        }

        public double showStudentAverage()
        {
            double avg = (vize_1 * 0.2) + (vize_2 * 0.2) + (final * 0.6);
            return avg;
        }

        public string getSchoolName()
        {
            return schoolName;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Student std = new Student(2010206511, "FARES", "HACHMI", 70, 50, 60, "Karabuk University");

            

            while (true)
            {
                Console.WriteLine("1.Show the student's information.");
                Console.WriteLine("2.Show the student's average.");
                Console.WriteLine("3.Show the student's name of school.");
                Console.WriteLine("4.Log out.");
                Console.Write("\nSelect your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");

                switch (choice)
                {
                    case 1:
                        std.showStudentInformation();
                        Console.WriteLine("\n\n");
                        break;
                    case 2:
                        Console.WriteLine($"The student's name {std.Name} {std.Surname} has average {std.showStudentAverage():0.00} in this semester.\n\n");
                        break;
                    case 3:
                        Console.WriteLine($"The school's name for student {std.Name} {std.Surname} is {std.getSchoolName()}.\n\n");
                        break;
                    case 4:
                        Console.WriteLine("Logging out...\n\n");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select your choice again...\n\n");
                        break;
                }
            }
        }
    }
}
