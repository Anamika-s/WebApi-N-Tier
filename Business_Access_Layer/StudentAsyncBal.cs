using Business_Access_Layer.Models;
using Data_Access_Layer;

using Data_Access_Layer.Repository.Entities;

namespace Business_Access_Layer
{
    public class StudentAsyncBal
    {
        private StudentAsyncDal _dal;
        public StudentAsyncBal() { 
        _dal = new StudentAsyncDal();
        }

        public async Task<List<Student>>GetStudents()
        {
            return await _dal.GetStudents();
        }

        public async Task<Student> GetStudentById(int id)
        {
            // filter
            // search
            // modify the request in BAL
            return await _dal.GetStudentById(id);
        }
        public async Task<Student> AddStudent(Student student)
        {
            return await _dal.AddStudent(student);
        }

    }
}