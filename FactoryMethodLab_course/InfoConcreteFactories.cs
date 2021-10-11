using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLab_course
{
    class Teacher_Info : Info
    {
        private int _id;
        private string _name;
        public Teacher_Info(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public override AbstractInfo AddInfo(string param)
        {
            return new Teacher(_id, _name, param);
        }
    }
    class Student_Info : Info
    {
        private int _id;
        private string _name;
        public Student_Info(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public override AbstractInfo AddInfo(string param)
        {
            return new Student(_id, _name, param);
        }
    }
    class Course_Info : Info
    {
        private int _id;
        private string _name;
        public Course_Info(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public override AbstractInfo AddInfo(string param)
        {
            return new Course(_id, _name, param);
        }
    }
}
