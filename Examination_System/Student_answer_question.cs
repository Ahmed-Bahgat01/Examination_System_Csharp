//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examination_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_answer_question
    {
        public int fk_student { get; set; }
        public int fk_question { get; set; }
        public int fk_exam { get; set; }
        public string answer { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }
    }
}
