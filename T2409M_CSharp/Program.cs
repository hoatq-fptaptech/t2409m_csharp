// See https://aka.ms/new-console-template for more information
using T2409M_CSharp.session1;
using T2409M_CSharp.session2;
using T2409M_CSharp.session3;

//Console.WriteLine("Hello, World!");
//Student s = new Student();

//s.learn();
//s.learn("T2409M");
//s.name = "Đinh Lực";

//Teacher h = new Teacher();
//h.Name = "QUang Hoa";
//h.Address = "13 Trịnh Văn Bô";

//Subject csharp = new Subject { Name = "C Sharp", Hours = 32, Cost=4.5 };

//Car c = new Car { Brand = "Toyota", Maintains = new List<string>() };
//c.Maintains.Add("30/07/2025");
//c.Maintains.Add("15/09/2025");

//Console.WriteLine(c.Maintains[0]);
//Console.WriteLine(c[0]);

// demo delegate
ShowString ss = new ShowString(Demo.PrintMsg);

//Demo.PrintMsg("Hello");
//ss("Hello");
ss += Box.BoxOpen;
ss += new Demo().Alert;

ss("Hello");

//Box.SMS("098765456", "Xin chao, cho lam quen nhe");
//Box.Email("098765456", "Xin chao, cho lam quen nhe");
//Box.Zalo("098765456", "Xin chao, cho lam quen nhe");
//Box.Telegram("098765456", "Xin chao, cho lam quen nhe");

//SendNotify sn = new SendNotify(Box.SMS);
//sn += Box.Email;
//sn += Box.Zalo;
//sn += Box.Telegram;

//sn("0987654321", "Xin chao, cho lam quen nhe");

ChamSocKhachHang cskh = new ChamSocKhachHang();
cskh.GuiThongBao("09876543","Hello");
