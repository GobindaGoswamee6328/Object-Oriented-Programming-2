using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;

            do
            {
                Console.WriteLine("1. Bike");
                Console.WriteLine("2. Car");
                Console.WriteLine("3. Airplane");
                Console.WriteLine("4. Exit");
                Console.WriteLine("-------------------------");

                Console.Write("Enter The Option : ");
                int option1 = Convert.ToInt32(Console.ReadLine());

                if (option1 == 1)
                {
                    Console.Write("Bike Info");
                    Console.Write(" Enter Company Name : ");
                    string companyname = Console.ReadLine();
                    Console.Write(" Enter Model Name : ");
                    string modelname = Console.ReadLine();
                    Console.Write(" Enter Engine Serial : ");
                    int engineserial = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter User Name: ");
                    string username = Console.ReadLine();
                    Console.Write(" Enter User Gender : ");
                    string usergender = Console.ReadLine();
                    Console.Write(" Enter Contract Number : ");
                    string contractnumber = Console.ReadLine();


                    Transport s1 = new Transport();
                    s1.setuserinfo(new userinfo(username, usergender, contractnumber));
                    s1.setcompanyname(companyname);
                    s1.setmodelname(modelname);
                    s1.setengineserial(engineserial);
                    s1.showinfo();

                }
                else if (option1 == 2)
                {
                    Console.Write("Car Info");
                    Console.Write(" Enter Company Name : ");
                    string companyname = Console.ReadLine();
                    Console.Write(" Enter Model Name : ");
                    string modelname = Console.ReadLine();
                    Console.Write(" Enter Engine Serial : ");
                    int engineserial = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter User Name: ");
                    string username = Console.ReadLine();
                    Console.Write(" Enter User Gender : ");
                    string usergender = Console.ReadLine();
                    Console.Write(" Enter Contract Number : ");
                    string contractnumber = Console.ReadLine();

                    Transport s2 = new Transport();
                    s2.setuserinfo(new userinfo(username, usergender, contractnumber));
                    s2.setcompanyname(companyname);
                    s2.setmodelname(modelname);
                    s2.setengineserial(engineserial);
                    s2.showinfo();

                }
                else if (option1 == 3)
                {
                    Console.Write("Airplane Info");
                    Console.Write(" Enter Company Name : ");
                    string companyname = Console.ReadLine();
                    Console.Write(" Enter Model Name : ");
                    string modelname = Console.ReadLine();
                    Console.Write(" Enter Engine Serial : ");
                    int engineserial = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter User Name: ");
                    string username = Console.ReadLine();
                    Console.Write(" Enter User Gender : ");
                    string usergender = Console.ReadLine();
                    Console.Write(" Enter Contract Number : ");
                    string contractnumber = Console.ReadLine();

                    Transport s3 = new Transport();
                    s3.setuserinfo(new userinfo(username, usergender, contractnumber));
                    s3.setcompanyname(companyname);
                    s3.setmodelname(modelname);
                    s3.setengineserial(engineserial);
                    s3.showinfo();

                }

                else if (option1 == 4)
                {
                    Console.WriteLine("Exit");
                    break;

                }

            } while (flag = true);


            }
    }
}
