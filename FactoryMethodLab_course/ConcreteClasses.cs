using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLab_course
{
    class Teacher : AbstractInfo
    {
        public int _id;
        public string _name;
        public readonly string _role;
        public string _info;
        public Teacher(int id, string name, string info)
        {
            _role = "Teacher";
            _id = id;
            _name = name;
            _info = info;
        }
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string Role
        {
            get { return _role; }
        }
        public override string AdditionalInfo
        {
            get { return _info; }
            set { _info = value; }
        }
        public override string GetInfo()
        {
            return $"{_role} Id = {_id}, Name = {_name}, {_info}\n";
        }
    }
    class Student : AbstractInfo
    {
        public int _id;
        public string _name;
        public readonly string _role;
        public string _info;
        public Student(int id, string name, string info)
        {
            _role = "Student";
            _id = id;
            _name = name;
            _info = info;
        }
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string Role
        {
            get { return _role; }
        }
        public override string AdditionalInfo
        {
            get { return _info; }
            set { _info = value; }
        }
        public override string GetInfo()
        {
            return $"{_role} Id = {_id}, Name = {_name}, Courses = {_info}\n";
        }
    }
    class Course : AbstractInfo
    {
        public int _id;
        public string _name;
        public readonly string _role;
        public string _info;
        public Course(int id, string name, string info)
        {
            _role = "Course";
            _id = id;
            _name = name;
            _info = info;
        }
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string Role
        {
            get { return _role; }
        }
        public override string AdditionalInfo
        {
            get { return _info; }
            set { _info = value; }
        }
        public override string GetInfo()
        {
            return $"{_role} Id = {_id}, Name = {_name}, {_info}\n";
        }
    }
}
