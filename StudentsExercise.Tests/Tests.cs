using FluentAssertions;
using StudentsExercise.Models;

namespace StudentsExercise.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Instantiate_Student_With_Null_As_Name_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student(null, 'B', 1);
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Instantiate_Student_With_EmptyString_As_Name_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("", 'B', 1);
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Instantiate_Student_With_WhiteSpace_As_Name_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("   ", 'B', 1);
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Instantiate_Student_With_Grade_Z_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("Peter", 'Z', 1);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Instantiate_Student_With_Grade_Underscore_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("Peter", '_', 1);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Instantiate_Student_With_Group_Zero_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("Peter", 'B', 0);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Instantiate_Student_With_Group_6_Should_Throw_Exception()
        {
            Student student;
            Action act = () => student = new Student("Peter", 'B', 6);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Student_Name_Should_Return_Name()
        {
            string studentName = "Peter";
            Student student = new Student(studentName, 'B', 1);
            student.Name.Should().Be(studentName);
        }

        [Test]
        public void Student_Grade_Should_Return_Grade()
        {
            char studentGrade = 'B';
            Student student = new Student("Peter", studentGrade, 1);
            student.Grade.Should().Be(studentGrade);
        }

        [Test]
        public void Student_Upgrade_With_Grade_B_Should_Update_Grade_To_A()
        {
            Student student = new Student("Peter", 'B', 1);
            student.Upgrade();
            student.Grade.Should().Be('A');
        }

        [Test]
        public void Student_Upgrade_With_Grade_A_Should_Update_Grade_To_A()
        {
            Student student = new Student("Peter", 'A', 1);
            student.Upgrade();
            student.Grade.Should().Be('A');
        }

        [Test]
        public void Student_Downgrade_With_Grade_C_Should_Update_Grade_To_D()
        {
            Student student = new Student("Peter", 'C', 1);
            student.Downgrade();
            student.Grade.Should().Be('D');
        }

        [Test]
        public void Student_Downgrade_With_Grade_F_Should_Update_Grade_To_F()
        {
            Student student = new Student("Peter", 'F', 1);
            student.Downgrade();
            student.Grade.Should().Be('F');
        }
    }
}