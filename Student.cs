using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            while (lineWithAllData.Contains("  "))
            {
                lineWithAllData = lineWithAllData.Replace("  ", " ");
            }
            string[] arr = lineWithAllData.Split(' ').ToArray();
            surName = arr[0];
            firstName = arr[1];
            patronymic = arr[2];
            sex = Convert.ToChar(arr[3]);
            dateOfBirth = arr[4];
            mathematicsMark = Convert.ToChar(arr[5]);
            if (mathematicsMark == '-')
            {
                mathematicsMark = '2';
            }
            physicsMark = Convert.ToChar(arr[6]);
            if (physicsMark == '-')
            {
                physicsMark = '2';
            }
            informaticsMark = Convert.ToChar(arr[7]);
            if (informaticsMark == '-')
            {
                informaticsMark = '2';
            }
            scholarship = Convert.ToInt32(arr[8]);
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
        }
    }
}
