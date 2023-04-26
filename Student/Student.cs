using System;
namespace StudentASM
{
	public class Student
	{
		private int id { get; set; }
        private string nameSV { get; set; }
        private string gioiTinh { get; set; }
        private int age { get; set; }
        private int diemToan { get; set; }
        private int diemLy { get; set; }
        private int diemHoa { get; set; }
        private float GPA { get; set; }
        private string hocLuc { get; set; }

        private static List<Student> students = new List<Student>();


        public Student(int id, string nameSV, string gioiTinh, int age, int diemToan, int diemLy, int diemHoa, float GPA, string hocLuc)
		{
            this.id = id;
            this.nameSV = nameSV;
            this.gioiTinh = gioiTinh;
            this.age = age;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
            this.GPA = GPA;
            this.hocLuc = hocLuc;
        }

        public Student()
        {

        }

        public float tinhGPA(int diemToan, int diemLy, int diemHoa)
        {
            return (diemToan + diemHoa + diemLy) / 3;
        }

        public string xetHocLuc(double tinhGPA)
        {
            if (tinhGPA >= 8)
            {
                return "Gioi";
            }else if (tinhGPA >=6.5)
            {
                return "Kha";
            }else if (tinhGPA >= 5)
            {
                return "Trung Binh";
            }
            else
            {
                return "Yeu";
            }
        }

        public void addSV()
        {
            Console.WriteLine("Nhap ID sinh vien: ");
            string nhapID = Console.ReadLine();
            id = Convert.ToInt32(nhapID);

            Console.WriteLine("Nhap ten sinh vien: ");
            string nhapName = Console.ReadLine();
            this.nameSV = nhapName;

            Console.WriteLine("Nhap gioi tinh sinh vien: ");
            string nhapGT = Console.ReadLine();
            this.gioiTinh = nhapGT;

            Console.WriteLine("Nhap tuoi sinh vien: ");
            string tuoi = Console.ReadLine();
            age = Convert.ToInt32(tuoi);

            Console.WriteLine("Nhap diem Toan cua sinh vien: ");
            string toan = Console.ReadLine();
            diemToan = Convert.ToInt32(toan);

            Console.WriteLine("Nhap diem LY cua sinh vien: ");
            string ly = Console.ReadLine();
            diemLy = Convert.ToInt32(toan);

            Console.WriteLine("Nhap diem Hoa cua sinh vien: ");
            string hoa = Console.ReadLine();
            diemHoa = Convert.ToInt32(toan);

            Console.WriteLine("Them sinh vien thanh cong!");
        }

        public void updateSVbyID(int newID, string newName, string newGT, int newAge, int newDT, int newDL, int newDH)
        {
            Student studentToUpdate = null;
            foreach (Student student in students)
            {
                if (student.id == newID)
                {
                    studentToUpdate = student;
                    break;
                } 
            }

            if (studentToUpdate == null)
            {
                Console.WriteLine("Khong tim thay sinh vien voi id " +id);
                return;
            }

            studentToUpdate.nameSV = newName;
            studentToUpdate.gioiTinh = newGT;
            studentToUpdate.age = newAge;
            studentToUpdate.diemToan = newDT;
            studentToUpdate.diemLy = newDL;
            studentToUpdate.diemHoa = newDH;
            studentToUpdate.GPA = tinhGPA(newDT, newDL, newDH);
            studentToUpdate.hocLuc = xetHocLuc(studentToUpdate.GPA);
        }

        public void removeSV(int idDelete)
        {
            Student studentToDelete = null;
            foreach (Student student in students)
            {
                if (student.id == idDelete)
                {
                    studentToDelete = student;
                    break;
                }
            }

            if (studentToDelete == null)
            {
                Console.WriteLine("Khong tim thay sinh vien co id" + idDelete);
                return;
            }

            students.Remove(studentToDelete);
            Console.WriteLine("Xoa sinh vien thanh cong!");
        }

        public List<Student> timkiemByName(string name)
        {
            List<Student> result = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].nameSV == name)
                {
                    result.Add(students[i]);
                }
            }
            return result;
        }

        public void sapxepSVtheoGPA()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].GPA < students[j + 1].GPA)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp; 
                    }
                }
            }
        }

        public void sapxepSVtheoTen()
        {
            int n = students.Count;
            for (int i = 0;i < n -1; i++)
            {
                for (int j = 0; j < n; i++)
                {
                    if (string.Compare(students[i].nameSV, students[j].nameSV) > 0)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        public void sapxepSVtheoID()
        {
            int n = students.Count;
            for (int i = 0;i < n -1; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (students[i].id > students[j].id)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        public void hienthiDsSV()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID sinh vien : " + students[i].id);
                Console.WriteLine("Ten sinh vien : " + students[i].nameSV);
                Console.WriteLine("Tuoi sinh vien : " + students[i].age);
                Console.WriteLine("Gioi Tinh sinh vien : " + students[i].gioiTinh);
                Console.WriteLine("Diem trung binh sinh vien : " + students[i].GPA);
                Console.WriteLine("Hoc luc sinh vien : " + students[i].hocLuc);
            }
        }
	}
}

