using AutoMapper;
using Business_Access_Layer.Models;
using Data_Access_Layer;
 
using Data_Access_Layer.Repository.Entities;

namespace Business_Access_Layer
{
    public class StudentBal1
    {
        private StudentDal _dal;
        private Mapper _mapper;
        public StudentBal1()
        {
            _dal = new StudentDal();
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<Data_Access_Layer.Repository.Entities.Student, StudentModel>().ReverseMap());
            _mapper = new Mapper(config);
        } 

        public List<StudentModel> GetStudents()
        {
            var list = _dal.GetStudentsBySP();
            List<StudentModel> students = _mapper.Map<List<Student>, List<StudentModel>> (list);
            return students;
            
        }

        public StudentModel GetStudentById(int id)
        {
            // filter
            // search
            // modify the request in BAL
            var student =  _dal.GetStudentById(id);
            StudentModel stu = _mapper.Map<Student,StudentModel>(student);
            return stu;
        }
        public Student AddStudent(StudentModel student)
        {
            Student stu = _mapper.Map<StudentModel, Student> (student);
            return _dal.AddStudent(stu);
        }

    }
}