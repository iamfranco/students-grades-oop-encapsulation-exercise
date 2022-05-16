using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsExercise.Models
{
    public class Student
    {
        private const string ALL_GRADES = "FEDCBA";

        public string Name { get; private set; }
        public char Grade { get; private set; }

        private int _group;
        private string _secretNickName = "MySecretNickName";

        public Student(string name, char grade, int group)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Name cannot be null, empty, or only consist of whitespaces");

            if (!ALL_GRADES.Contains(grade))
                throw new ArgumentException("Grade must be one of the following: 'A', 'B', 'C', 'D', 'E', 'F'", nameof(grade));

            if (group < 1 || group > 5)
                throw new ArgumentException("Group must be one of the following: 1, 2, 3, 4, 5", nameof(group));

            Name = name;
            Grade = grade;
            _group = group;
        }

        public void Upgrade() => ChangeGrade(+1);

        public void Downgrade() => ChangeGrade(-1);

        private void ChangeGrade(int stepAmount)
        {
            int currentGradeIndex = ALL_GRADES.IndexOf(Grade);
            int nextGradeIndex = currentGradeIndex + stepAmount;

            nextGradeIndex = BoundIndex(nextGradeIndex, ALL_GRADES.Length - 1);

            Grade = ALL_GRADES[nextGradeIndex];
        }

        private static int BoundIndex(int index, int maxIndex) => Math.Min(Math.Max(index, 0), maxIndex);
    }
}
