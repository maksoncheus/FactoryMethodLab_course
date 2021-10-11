using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLab_course
{
    abstract class AbstractInfo
    {
        public abstract string Role { get; }
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string AdditionalInfo { get; set; }
        public abstract string GetInfo();

    }
}
