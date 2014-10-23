using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            string textCurrentStudentBirth = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            DateTime currentStudentBirthday = DateTime.Parse(textCurrentStudentBirth);

            string textOtherStudentBirth = otherStudent.OtherInfo.Substring(otherStudent.OtherInfo.Length - 10);
            DateTime otherStudentBirthday = DateTime.Parse(textOtherStudentBirth);

            bool isCurrentStudentOlderThanOther = 
                currentStudentBirthday.CompareTo(otherStudentBirthday) < 0;

            return isCurrentStudentOlderThanOther;
        }
    }
}
