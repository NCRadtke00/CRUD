using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactCRUD.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string RollNo { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public int Id { get; internal set; }
    }
}