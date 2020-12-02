using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
        public string Branch { get; set; }
        public string EmailId { get; set; }
    }
}