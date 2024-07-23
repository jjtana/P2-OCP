using Refran;

Student student = new Student { Name = "Jostin Wilmer" };

Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "C# Cursos Online" };
Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Python Offline Cursos" };
Course hybridCourse = new HybridCourse { CourseId = 3, Title = "C#,C++ Hybrid Course" };

onlineCourse.Subscribe(student);
offlineCourse.Subscribe(student);
hybridCourse.Subscribe(student);