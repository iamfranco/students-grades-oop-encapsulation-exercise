using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsExercise.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public char Grade { get; private set; }

        private int _group;
        private string _secretNickName = "MySecretNickName";

        public Student(string name, char grade, int group)
        {
            Name = name;
            Grade = grade;
            _group = group;
        }

        public void Upgrade() => ChangeGrade(+1);

        public void Downgrade() => ChangeGrade(-1);

        private void ChangeGrade(int stepAmount)
        {
            const string allGrades = "FEDCBA";

            int currentGradeIndex = allGrades.IndexOf(Grade);
            int nextGradeIndex = currentGradeIndex + stepAmount;

            nextGradeIndex = BoundIndex(nextGradeIndex, allGrades.Length - 1);

            Grade = allGrades[nextGradeIndex];
        }

        private static int BoundIndex(int index, int maxIndex) => Math.Min(Math.Max(index, 0), maxIndex);
    }
}
