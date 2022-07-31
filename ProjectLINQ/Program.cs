using System;
using System.Collections.Generic;
using System.Text;



namespace ProjectLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> lstStudent = new List<Student>();
            Student student1 = new Student()
            {
                StudentID = 1,
                StudentName = "John Nigel",
                Mark = 73,
                City = "NYC"

            };
            Student student2 = new Student()
            {
                StudentID = 2,
                StudentName = "Alex Roma",
                Mark = 51,
                City = "CA"

            };
            Student student3 = new Student()
            {
                StudentID = 3,
                StudentName = "Noha Shamil",
                Mark = 88,
                City = "CA"


            };
            Student student4 = new Student()
            {
                StudentID = 4,
                StudentName = "James Palatte",
                Mark = 60,
                City = "NYC"

            };
            Student student5 = new Student()
            {
                StudentID = 5,
                StudentName = "Ron Jenova",
                Mark = 85,
                City = "NYC"

            };
            lstStudent.Add(student1); //studentList or students
            lstStudent.Add(student2);
            lstStudent.Add(student3);
            lstStudent.Add(student4);
            lstStudent.Add(student5);
            //1.Lấy ra học sinh có id = 4
            Console.WriteLine("1.Lấy ra học sinh có id = 4");
            var student = lstStudent.SingleOrDefault(m => m.StudentID == 4);
            Console.WriteLine(student?.StudentName + "," + student?.Mark + "," + student?.City);
            Console.WriteLine("=============================================");
            //2. Lấy ra danh sách học sinh có tên chứa ‘am’ và sống ở thành phố ‘CA’
            Console.WriteLine("2. Lấy ra danh sách học sinh có tên chứa ‘am’ và sống ở thành phố ‘CA’");
            var getListStudent = from listStudent in lstStudent where listStudent.StudentName.Contains("am") && listStudent.City.Contains("CA") select listStudent.StudentName;
            foreach (var item in getListStudent.ToList())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================================");
            //3. Lấy ra tên học sinh có điểm cao nhất
            Console.WriteLine("3. Lấy ra tên học sinh có điểm cao nhất");
            //highestMarkStudent => camel case lạc đà 
            //Rule variable, const => kibap A_B
            var MarkStudent = lstStudent.SingleOrDefault(m => m.Mark == lstStudent.Max(m => m.Mark));
            Console.WriteLine(MarkStudent.StudentName);

            Console.WriteLine("=============================================");

            //4.Kiểm tra tất cả học sinh có điểm > 50 không.Nếu lớn hơn thì in ra dòng chữ “Pass”. Không thì in ra dòng chữ “Fail”
            Console.WriteLine("4.Kiểm tra tất cả học sinh có điểm > 50 không.Nếu lớn hơn thì in ra dòng chữ “Pass”. Không thì in ra dòng chữ “Fail”");
            var checkPointStudent = lstStudent.All(m => m.Mark > 50);
            if (checkPointStudent)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();
        }
    }
}