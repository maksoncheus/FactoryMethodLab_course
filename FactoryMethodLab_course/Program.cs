using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLab_course
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.Write("Choose an action:\n1|Add info\t2|CheckInfo\t3|Exit : ");
            try
            {
                string information = null;
                Info factory = null;
                int k = Int16.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (k)
                {
                    case 1:
                        {
                            Console.Write("\nAdd \t1|Student\t2|Teacher\t3|Course : ");
                            int sw = Int16.Parse(Console.ReadLine());
                            Console.Write("\nType Id and Name with ',' delimiter : ");
                            string[] someinfo = Console.ReadLine().Split(',');
                            Console.WriteLine();
                            switch (sw)
                            {
                                case 1:
                                    {
                                        factory = new Student_Info(Int32.Parse(someinfo[0]), someinfo[1]);
                                        Console.Write("\nType ids of courses with ',' delimiter : ");
                                        string[] tmp = Console.ReadLine().Split(',');
                                        information = string.Join(",",tmp);
                                        break;
                                    }
                                case 2:
                                    {
                                        factory = new Teacher_Info(Int32.Parse(someinfo[0]), someinfo[1]);
                                        Console.Write("\nType experience and ids of courses with ',' delimiter : ");
                                        string[] tmp = Console.ReadLine().Split(',');
                                        information = string.Join(",", tmp);
                                        information = information.Insert(0, "Exp = ");
                                        information = information.Insert(information.IndexOf(',') + 1, " Courses = ");
                                        break;
                                    }
                                case 3:
                                    {
                                        factory = new Course_Info(Int32.Parse(someinfo[0]), someinfo[1]);
                                        Console.Write("\nType id of teacher and ids of students with ',' delimiter : ");
                                        string[] tmp = Console.ReadLine().Split(',');
                                        information = string.Join(",", tmp);
                                        information = information.Insert(0, "Teacher id = ");
                                        information = information.Insert(information.IndexOf(',') + 1, " Students id = ");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Fail");
                                        break;
                                    }
                            }

                            AbstractInfo inf = factory.AddInfo(information);
                            File.AppendAllText("info.txt", inf.GetInfo());
                            break;
                        }
                    case 2:
                        {
                            if (File.Exists("info.txt"))
                            {
                                string[] str = File.ReadAllLines("info.txt");
                                for (int i = 0; i < str.Length; i++)
                                    Console.WriteLine(str[i]);
                            }
                            else
                            {
                                Console.WriteLine("\n No info yet");
                            }
                            break;
                        }
                    case 3:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Try again :)");
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            //if (File.Exists("info.txt"))
            //{
            //    List<string> lst = new List<string>();
            //    lst.Add("abc");
            //    string str = string.Join(",",lst);
            //    Info inf = new Teacher_Info(1,"abc");
            //    AbstractInfo abs = inf.AddInfo(str);
            //    File.AppendAllText("info.txt",abs.GetInfo());

            //}
            //else File.Create("info.txt");
            Console.ReadKey();
            Menu();
        }
    }
}
