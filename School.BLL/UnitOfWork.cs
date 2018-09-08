using School.Contact;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly SchoolContext _context = new SchoolContext();
        private IStudent _studentRepository;
        private ICourse _courseRepository;
        private IEnrollment _enrollmentRepository;

        public UnitOfWork()
        {
            _studentRepository = new StudentBiz(_context);
            _courseRepository = new CourseBiz(_context);
            _enrollmentRepository = new EnrollmentBiz(_context);
        }
        public IStudent StudentRepository
        {
            get 
            {
                if(_studentRepository ==null)
                    _studentRepository = new StudentBiz(_context);
                return _studentRepository;
            }
        }

        public ICourse CourseRepository
        {
            get
            {
                if (_courseRepository == null)
                    _courseRepository = new CourseBiz(_context);
                return _courseRepository;
            }
        }

        public IEnrollment EnrollmentRepository
        {
            get
            {
                if (_enrollmentRepository == null)
                    _enrollmentRepository = new EnrollmentBiz(_context);
                return _enrollmentRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
