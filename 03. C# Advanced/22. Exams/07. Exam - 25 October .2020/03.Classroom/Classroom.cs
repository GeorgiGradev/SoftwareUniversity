using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => students.Count; 


        public string RegisterStudent(Student student)
        {
            if (Capacity > students.Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            bool isRemoved = students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));

            if (isRemoved)
            {
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            List<Student> list = students.FindAll(x => x.Subject == subject);
            if (list.Count > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in list)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }
            return sb.ToString().TrimEnd();
        }
        public int GetStudentsCount()
        {
            return students.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
