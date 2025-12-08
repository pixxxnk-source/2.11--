using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        //偶数奇数判定
        int number = 9;

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " → " + "偶数です");
        }
        else
        {
            Console.WriteLine(number + " → " + "奇数です");
        }

        //曜日判定
        int number2 = 8;

        switch (number2)
        {
            case 1:
                Console.WriteLine("月曜日");
                break;
            case 2:
                Console.WriteLine("火曜日");
                break;
            case 3:
                Console.WriteLine("水曜日");
                break;
            case 4:
                Console.WriteLine("木曜日");
                break;
            case 5:
                Console.WriteLine("金曜日");
                break;
            case 6:
                Console.WriteLine("土曜日");
                break;
            case 7:
                Console.WriteLine("日曜日");
                break;
            default:
                Console.WriteLine("不正な入力です");
                break;
        }

        //学生割引判定
        int age = 20;
        bool isStudent = true;

        Console.WriteLine("年齢：" + age + ",学生:" + isStudent);

        if (age >= 18 && isStudent)
        {
            Console.WriteLine("学生割引が適用されます");
        }
        else
        {
            Console.WriteLine("学生割引が適用されません");
        }

        //ログイン判定
        string loginId = "admin";
        string password = "password123";


        if (loginId == "admin" || password == "password123")
        {
            Console.WriteLine("ログイン成功");
        }
        else
        {
            Console.WriteLine("ログイン失敗");
        }

        //点数判定
        int score = 99;
        Console.WriteLine("点数：" + score);

        if (score >= 80 && score <= 100)
        {
            Console.WriteLine("優秀");

        }
        else if (score >= 60 && score < 80)
        {
            Console.WriteLine("合格");
        }
        else if (score >= 0 && score < 60)
        {
            Console.WriteLine("不合格");
        }
        else
        {
            Console.WriteLine("不正な点数です");
        }
    }

}




