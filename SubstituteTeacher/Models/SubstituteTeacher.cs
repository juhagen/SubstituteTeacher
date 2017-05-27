using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubstituteTeacher.Models
{
    /// <summary>
    /// 实践教师的字段
    /// </summary>
    public class SubstituteTeacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public Subject Subject { get; set; }
        public string Education { get; set; }
        public GradeSection GradeSection{ get; set; }
    }
}