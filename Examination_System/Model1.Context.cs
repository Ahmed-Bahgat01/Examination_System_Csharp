﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Error_log> Error_log { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_answer_question> Student_answer_question { get; set; }
        public virtual DbSet<Student_takes_exam> Student_takes_exam { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
    
        public virtual int Course_name_instructorId_deptId_Update(Nullable<int> crs_id, string crs_name, Nullable<int> instructor_id, Nullable<int> dept_id)
        {
            var crs_idParameter = crs_id.HasValue ?
                new ObjectParameter("crs_id", crs_id) :
                new ObjectParameter("crs_id", typeof(int));
    
            var crs_nameParameter = crs_name != null ?
                new ObjectParameter("crs_name", crs_name) :
                new ObjectParameter("crs_name", typeof(string));
    
            var instructor_idParameter = instructor_id.HasValue ?
                new ObjectParameter("Instructor_id", instructor_id) :
                new ObjectParameter("Instructor_id", typeof(int));
    
            var dept_idParameter = dept_id.HasValue ?
                new ObjectParameter("dept_id", dept_id) :
                new ObjectParameter("dept_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Course_name_instructorId_deptId_Update", crs_idParameter, crs_nameParameter, instructor_idParameter, dept_idParameter);
        }
    
        public virtual int delete_course_proc(Nullable<int> courseId, string referrer)
        {
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_course_proc", courseIdParameter, referrerParameter);
        }
    
        public virtual int delete_department_proc(Nullable<int> deptId, string referrer)
        {
            var deptIdParameter = deptId.HasValue ?
                new ObjectParameter("DeptId", deptId) :
                new ObjectParameter("DeptId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_department_proc", deptIdParameter, referrerParameter);
        }
    
        public virtual int delete_exam_has_questions_proc(Nullable<int> examId, Nullable<int> questionId, string referrer)
        {
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_exam_has_questions_proc", examIdParameter, questionIdParameter, referrerParameter);
        }
    
        public virtual int delete_exam_proc(Nullable<int> examId, string referrer)
        {
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_exam_proc", examIdParameter, referrerParameter);
        }
    
        public virtual int delete_instructor_proc(Nullable<int> insturctorId, string referrer)
        {
            var insturctorIdParameter = insturctorId.HasValue ?
                new ObjectParameter("InsturctorId", insturctorId) :
                new ObjectParameter("InsturctorId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_instructor_proc", insturctorIdParameter, referrerParameter);
        }
    
        public virtual int delete_question_proc(Nullable<int> questionId, string referrer)
        {
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_question_proc", questionIdParameter, referrerParameter);
        }
    
        public virtual int delete_student_answer_question_proc(Nullable<int> studentId, Nullable<int> examId, Nullable<int> questionId, string referrer)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_student_answer_question_proc", studentIdParameter, examIdParameter, questionIdParameter, referrerParameter);
        }
    
        public virtual int delete_student_proc(Nullable<int> studentId, string referrer)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_student_proc", studentIdParameter, referrerParameter);
        }
    
        public virtual int delete_student_takes_course_proc(Nullable<int> studentId, Nullable<int> courseId, string referrer)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var courseIdParameter = courseId.HasValue ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_student_takes_course_proc", studentIdParameter, courseIdParameter, referrerParameter);
        }
    
        public virtual int delete_student_takes_exam_proc(Nullable<int> studentId, Nullable<int> examId, string referrer)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_student_takes_exam_proc", studentIdParameter, examIdParameter, referrerParameter);
        }
    
        public virtual int delete_topic_proc(Nullable<int> topicId, string referrer)
        {
            var topicIdParameter = topicId.HasValue ?
                new ObjectParameter("TopicId", topicId) :
                new ObjectParameter("TopicId", typeof(int));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_topic_proc", topicIdParameter, referrerParameter);
        }
    
        public virtual int Department_Name_Update(Nullable<int> dep_id, string dep_name)
        {
            var dep_idParameter = dep_id.HasValue ?
                new ObjectParameter("dep_id", dep_id) :
                new ObjectParameter("dep_id", typeof(int));
    
            var dep_nameParameter = dep_name != null ?
                new ObjectParameter("dep_name", dep_name) :
                new ObjectParameter("dep_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Department_Name_Update", dep_idParameter, dep_nameParameter);
        }
    
        public virtual int ErrorLogInsert(string affectedTable, string referrer)
        {
            var affectedTableParameter = affectedTable != null ?
                new ObjectParameter("AffectedTable", affectedTable) :
                new ObjectParameter("AffectedTable", typeof(string));
    
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ErrorLogInsert", affectedTableParameter, referrerParameter);
        }
    
        public virtual int Exam_courseNum_Update(Nullable<int> exam_id, Nullable<int> exam_num)
        {
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("Exam_id", exam_id) :
                new ObjectParameter("Exam_id", typeof(int));
    
            var exam_numParameter = exam_num.HasValue ?
                new ObjectParameter("Exam_num", exam_num) :
                new ObjectParameter("Exam_num", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Exam_courseNum_Update", exam_idParameter, exam_numParameter);
        }
    
        public virtual int ExamCorrection(Nullable<int> examNum, Nullable<int> stdtID)
        {
            var examNumParameter = examNum.HasValue ?
                new ObjectParameter("ExamNum", examNum) :
                new ObjectParameter("ExamNum", typeof(int));
    
            var stdtIDParameter = stdtID.HasValue ?
                new ObjectParameter("StdtID", stdtID) :
                new ObjectParameter("StdtID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExamCorrection", examNumParameter, stdtIDParameter);
        }
    
        public virtual int generate_exam(Nullable<int> course, Nullable<int> tf, Nullable<int> mcq)
        {
            var courseParameter = course.HasValue ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(int));
    
            var tfParameter = tf.HasValue ?
                new ObjectParameter("tf", tf) :
                new ObjectParameter("tf", typeof(int));
    
            var mcqParameter = mcq.HasValue ?
                new ObjectParameter("mcq", mcq) :
                new ObjectParameter("mcq", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("generate_exam", courseParameter, tfParameter, mcqParameter);
        }
    
        public virtual ObjectResult<Get_Course_Topics_Report_Result> Get_Course_Topics_Report(Nullable<int> crs_Id)
        {
            var crs_IdParameter = crs_Id.HasValue ?
                new ObjectParameter("Crs_Id", crs_Id) :
                new ObjectParameter("Crs_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Course_Topics_Report_Result>("Get_Course_Topics_Report", crs_IdParameter);
        }
    
        public virtual ObjectResult<get_exam_with_stu_answer_proc_Result> get_exam_with_stu_answer_proc(string referrer, Nullable<int> examId, Nullable<int> studentId)
        {
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_exam_with_stu_answer_proc_Result>("get_exam_with_stu_answer_proc", referrerParameter, examIdParameter, studentIdParameter);
        }
    
        public virtual ObjectResult<Get_Instructor_Course_Report_Result> Get_Instructor_Course_Report(Nullable<int> ins_id)
        {
            var ins_idParameter = ins_id.HasValue ?
                new ObjectParameter("ins_id", ins_id) :
                new ObjectParameter("ins_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Instructor_Course_Report_Result>("Get_Instructor_Course_Report", ins_idParameter);
        }
    
        public virtual ObjectResult<Get_Student_Department_Result> Get_Student_Department(Nullable<int> dept_Id)
        {
            var dept_IdParameter = dept_Id.HasValue ?
                new ObjectParameter("Dept_Id", dept_Id) :
                new ObjectParameter("Dept_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Student_Department_Result>("Get_Student_Department", dept_IdParameter);
        }
    
        public virtual ObjectResult<Get_Student_Grade_Report_Result> Get_Student_Grade_Report(Nullable<int> std_id)
        {
            var std_idParameter = std_id.HasValue ?
                new ObjectParameter("std_id", std_id) :
                new ObjectParameter("std_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Student_Grade_Report_Result>("Get_Student_Grade_Report", std_idParameter);
        }
    
        public virtual int Insert_Course(Nullable<int> id, string name, Nullable<int> dept, Nullable<int> instruc)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var deptParameter = dept.HasValue ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(int));
    
            var instrucParameter = instruc.HasValue ?
                new ObjectParameter("instruc", instruc) :
                new ObjectParameter("instruc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Course", idParameter, nameParameter, deptParameter, instrucParameter);
        }
    
        public virtual int Insert_Depart(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Depart", idParameter, nameParameter);
        }
    
        public virtual int Insert_Exam(Nullable<int> id, Nullable<int> course)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var courseParameter = course.HasValue ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Exam", idParameter, courseParameter);
        }
    
        public virtual int Insert_ExQues(Nullable<int> exam, Nullable<int> question)
        {
            var examParameter = exam.HasValue ?
                new ObjectParameter("exam", exam) :
                new ObjectParameter("exam", typeof(int));
    
            var questionParameter = question.HasValue ?
                new ObjectParameter("question", question) :
                new ObjectParameter("question", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_ExQues", examParameter, questionParameter);
        }
    
        public virtual int Insert_Instrc(Nullable<int> id, string name, Nullable<int> dept)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var deptParameter = dept.HasValue ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Instrc", idParameter, nameParameter, deptParameter);
        }
    
        public virtual int Insert_Question(Nullable<int> id, string qtext, string qtype, string op1, string op2, string op3, string op4, string model, Nullable<int> course)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var qtextParameter = qtext != null ?
                new ObjectParameter("qtext", qtext) :
                new ObjectParameter("qtext", typeof(string));
    
            var qtypeParameter = qtype != null ?
                new ObjectParameter("qtype", qtype) :
                new ObjectParameter("qtype", typeof(string));
    
            var op1Parameter = op1 != null ?
                new ObjectParameter("op1", op1) :
                new ObjectParameter("op1", typeof(string));
    
            var op2Parameter = op2 != null ?
                new ObjectParameter("op2", op2) :
                new ObjectParameter("op2", typeof(string));
    
            var op3Parameter = op3 != null ?
                new ObjectParameter("op3", op3) :
                new ObjectParameter("op3", typeof(string));
    
            var op4Parameter = op4 != null ?
                new ObjectParameter("op4", op4) :
                new ObjectParameter("op4", typeof(string));
    
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var courseParameter = course.HasValue ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Question", idParameter, qtextParameter, qtypeParameter, op1Parameter, op2Parameter, op3Parameter, op4Parameter, modelParameter, courseParameter);
        }
    
        public virtual int Insert_StuCourse(Nullable<int> student, Nullable<int> course)
        {
            var studentParameter = student.HasValue ?
                new ObjectParameter("student", student) :
                new ObjectParameter("student", typeof(int));
    
            var courseParameter = course.HasValue ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_StuCourse", studentParameter, courseParameter);
        }
    
        public virtual int Insert_Student(Nullable<int> id, string name, Nullable<int> dept)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var deptParameter = dept.HasValue ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Student", idParameter, nameParameter, deptParameter);
        }
    
        public virtual int Insert_StuExam(Nullable<int> student, Nullable<int> exam, Nullable<int> grade)
        {
            var studentParameter = student.HasValue ?
                new ObjectParameter("student", student) :
                new ObjectParameter("student", typeof(int));
    
            var examParameter = exam.HasValue ?
                new ObjectParameter("exam", exam) :
                new ObjectParameter("exam", typeof(int));
    
            var gradeParameter = grade.HasValue ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_StuExam", studentParameter, examParameter, gradeParameter);
        }
    
        public virtual int Insert_StuQuestion(Nullable<int> student, Nullable<int> question, Nullable<int> exam, string answer)
        {
            var studentParameter = student.HasValue ?
                new ObjectParameter("student", student) :
                new ObjectParameter("student", typeof(int));
    
            var questionParameter = question.HasValue ?
                new ObjectParameter("question", question) :
                new ObjectParameter("question", typeof(int));
    
            var examParameter = exam.HasValue ?
                new ObjectParameter("exam", exam) :
                new ObjectParameter("exam", typeof(int));
    
            var answerParameter = answer != null ?
                new ObjectParameter("answer", answer) :
                new ObjectParameter("answer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_StuQuestion", studentParameter, questionParameter, examParameter, answerParameter);
        }
    
        public virtual int Insert_Topic(string name, Nullable<int> course)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var courseParameter = course.HasValue ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Topic", nameParameter, courseParameter);
        }
    
        public virtual int Instructor_name__deptId_Update(Nullable<int> instructor_id, string ins_name, Nullable<int> instructor_dept)
        {
            var instructor_idParameter = instructor_id.HasValue ?
                new ObjectParameter("instructor_id", instructor_id) :
                new ObjectParameter("instructor_id", typeof(int));
    
            var ins_nameParameter = ins_name != null ?
                new ObjectParameter("ins_name", ins_name) :
                new ObjectParameter("ins_name", typeof(string));
    
            var instructor_deptParameter = instructor_dept.HasValue ?
                new ObjectParameter("instructor_dept", instructor_dept) :
                new ObjectParameter("instructor_dept", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Instructor_name__deptId_Update", instructor_idParameter, ins_nameParameter, instructor_deptParameter);
        }
    
        public virtual int Question_ModelAnswer_Update(Nullable<int> q_id, string q_ans)
        {
            var q_idParameter = q_id.HasValue ?
                new ObjectParameter("q_id", q_id) :
                new ObjectParameter("q_id", typeof(int));
    
            var q_ansParameter = q_ans != null ?
                new ObjectParameter("q_ans", q_ans) :
                new ObjectParameter("q_ans", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Question_ModelAnswer_Update", q_idParameter, q_ansParameter);
        }
    
        public virtual ObjectResult<sel_Course_Result> sel_Course(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sel_Course_Result>("sel_Course", idParameter);
        }
    
        public virtual ObjectResult<sel_exam_Result> sel_exam(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sel_exam_Result>("sel_exam", idParameter);
        }
    
        public virtual ObjectResult<sel_stucourse_Result> sel_stucourse(Nullable<int> id, Nullable<int> id_2)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var id_2Parameter = id_2.HasValue ?
                new ObjectParameter("id_2", id_2) :
                new ObjectParameter("id_2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sel_stucourse_Result>("sel_stucourse", idParameter, id_2Parameter);
        }
    
        public virtual ObjectResult<sel_studanswer_Result> sel_studanswer(Nullable<int> studentId, Nullable<int> questionId, Nullable<int> examId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sel_studanswer_Result>("sel_studanswer", studentIdParameter, questionIdParameter, examIdParameter);
        }
    
        public virtual ObjectResult<sel_stuexam_Result> sel_stuexam(Nullable<int> id, Nullable<int> id_2)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var id_2Parameter = id_2.HasValue ?
                new ObjectParameter("id_2", id_2) :
                new ObjectParameter("id_2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sel_stuexam_Result>("sel_stuexam", idParameter, id_2Parameter);
        }
    
        public virtual ObjectResult<select_Dept_Result> select_Dept(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_Dept_Result>("select_Dept", idParameter);
        }
    
        public virtual ObjectResult<select_instu_Result> select_instu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_instu_Result>("select_instu", idParameter);
        }
    
        public virtual ObjectResult<select_quest_Result> select_quest(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_quest_Result>("select_quest", idParameter);
        }
    
        public virtual ObjectResult<select_student_Result> select_student(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_student_Result>("select_student", idParameter);
        }
    
        public virtual ObjectResult<select_Topic_Result> select_Topic(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_Topic_Result>("select_Topic", idParameter);
        }
    
        public virtual ObjectResult<selexqu_Result> selexqu(Nullable<int> id, Nullable<int> id_2)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var id_2Parameter = id_2.HasValue ?
                new ObjectParameter("id_2", id_2) :
                new ObjectParameter("id_2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selexqu_Result>("selexqu", idParameter, id_2Parameter);
        }
    
        public virtual int Student_AnswerID_Update(Nullable<int> student_id, Nullable<int> question_id, Nullable<int> exam_id, string answer)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("Student_id", student_id) :
                new ObjectParameter("Student_id", typeof(int));
    
            var question_idParameter = question_id.HasValue ?
                new ObjectParameter("Question_id", question_id) :
                new ObjectParameter("Question_id", typeof(int));
    
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("exam_id", exam_id) :
                new ObjectParameter("exam_id", typeof(int));
    
            var answerParameter = answer != null ?
                new ObjectParameter("Answer", answer) :
                new ObjectParameter("Answer", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_AnswerID_Update", student_idParameter, question_idParameter, exam_idParameter, answerParameter);
        }
    
        public virtual int Student_Course_Update(Nullable<int> student_id, Nullable<int> course_id)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("Student_id", student_id) :
                new ObjectParameter("Student_id", typeof(int));
    
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("Course_id", course_id) :
                new ObjectParameter("Course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Course_Update", student_idParameter, course_idParameter);
        }
    
        public virtual int Student_grade_Update(Nullable<int> student_id, Nullable<int> exam_id, Nullable<int> stud_Grade)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("Student_id", student_id) :
                new ObjectParameter("Student_id", typeof(int));
    
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("Exam_id", exam_id) :
                new ObjectParameter("Exam_id", typeof(int));
    
            var stud_GradeParameter = stud_Grade.HasValue ?
                new ObjectParameter("Stud_Grade", stud_Grade) :
                new ObjectParameter("Stud_Grade", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_grade_Update", student_idParameter, exam_idParameter, stud_GradeParameter);
        }
    
        public virtual int Student_Question_Update(Nullable<int> exam_id, Nullable<int> question_id)
        {
            var exam_idParameter = exam_id.HasValue ?
                new ObjectParameter("Exam_id", exam_id) :
                new ObjectParameter("Exam_id", typeof(int));
    
            var question_idParameter = question_id.HasValue ?
                new ObjectParameter("Question_id", question_id) :
                new ObjectParameter("Question_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Question_Update", exam_idParameter, question_idParameter);
        }
    
        public virtual int Student_Update(Nullable<int> std_id, string std_name, Nullable<int> depart_id)
        {
            var std_idParameter = std_id.HasValue ?
                new ObjectParameter("std_id", std_id) :
                new ObjectParameter("std_id", typeof(int));
    
            var std_nameParameter = std_name != null ?
                new ObjectParameter("std_name", std_name) :
                new ObjectParameter("std_name", typeof(string));
    
            var depart_idParameter = depart_id.HasValue ?
                new ObjectParameter("depart_id", depart_id) :
                new ObjectParameter("depart_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Student_Update", std_idParameter, std_nameParameter, depart_idParameter);
        }
    
        public virtual int Topic_name_courseId_Update(Nullable<int> top_id, string top_name, Nullable<int> topic_course_id)
        {
            var top_idParameter = top_id.HasValue ?
                new ObjectParameter("top_id", top_id) :
                new ObjectParameter("top_id", typeof(int));
    
            var top_nameParameter = top_name != null ?
                new ObjectParameter("top_name", top_name) :
                new ObjectParameter("top_name", typeof(string));
    
            var topic_course_idParameter = topic_course_id.HasValue ?
                new ObjectParameter("topic_course_id", topic_course_id) :
                new ObjectParameter("topic_course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Topic_name_courseId_Update", top_idParameter, top_nameParameter, topic_course_idParameter);
        }
    
        public virtual ObjectResult<get_exam_questions_proc_Result1> get_exam_questions_proc(string referrer, Nullable<int> examId)
        {
            var referrerParameter = referrer != null ?
                new ObjectParameter("Referrer", referrer) :
                new ObjectParameter("Referrer", typeof(string));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_exam_questions_proc_Result1>("get_exam_questions_proc", referrerParameter, examIdParameter);
        }
    }
}
