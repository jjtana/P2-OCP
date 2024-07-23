using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refran
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student {std.Name} subscribed to online course: {Title}");
        }
    }

    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student {std.Name} subscribed to offline course: {Title}");
        }
    }

    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student {std.Name} subscribed to hybrid course: {Title}");
        }
    }

    public class Student
    {
        public string Name { get; set; }
    }
}
