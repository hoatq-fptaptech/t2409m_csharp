// See https://aka.ms/new-console-template for more information
using T2409M_CSharp.session1;

Console.WriteLine("Hello, World!");
Student s = new Student();

s.learn();
s.learn("T2409M");
s.name = "Đinh Lực";

Teacher h = new Teacher();
h.Name = "QUang Hoa";
h.Address = "13 Trịnh Văn Bô";

Subject csharp = new Subject { Name = "C Sharp", Hours = 32, Cost=4.5 };
