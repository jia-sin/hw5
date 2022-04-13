using System;

string name = "";
string gender_in = "";
string gender_out = "";
string birth = "";
string id = "";

bool is_right = false;

while (is_right != true)
{
    Console.WriteLine("姓名:");
    name = Console.ReadLine();

    Console.WriteLine("性別:1.男生  2.女生");
    gender_in = Console.ReadLine();
    switch (gender_in)
    {
        case "1":
            gender_out = "男";
            break;
        case "2":
            gender_out = "女";
            break;
    }

    Console.WriteLine("出生年月日:");
    birth = Console.ReadLine();

    Console.WriteLine("學號:");
    id = Console.ReadLine();

    Console.WriteLine(name);
    Console.WriteLine(gender_out);
    Console.WriteLine(birth);
    Console.WriteLine(id);

    Console.WriteLine("請問內容正確嗎?");
    Console.WriteLine("1.正確 2.再輸入一次");
    if (Console.ReadLine() == "1")
    {
        is_right = true;
    }
    else
    {
        is_right = false;
    }
}
Console.WriteLine("已完成資料建置");