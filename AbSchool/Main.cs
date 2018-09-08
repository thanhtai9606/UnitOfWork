using School.BLL;
using School.Contact;
using School.Model;
using School.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbSchool
{
    public partial class Main : Form
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        private OperationResult _opreationResult = new OperationResult();
        public Main()
        {
            InitializeComponent();
            RegisterCommand();
        }
        void RegisterCommand()
        {
            btnAdd.Click += btnAdd_Click;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
           // Student std = new Student();
           // std.StdID = Guid.NewGuid().ToString().ToUpper();
           // std.Name = txtName.Text;
           // std.Address = txtAddress.Text;
            
           // _opreationResult =_unitOfWork.StudentRepository.Add(std);

           //MessageBox.Show(_unitOfWork.StudentRepository.GetInfo());
            
           // _unitOfWork.Save();
           // _unitOfWork.Dispose();
           // MessageBox.Show(_opreationResult.Message);
            MessageBox.Show(_unitOfWork.EnrollmentRepository.Addition(5, 2).ToString());
            //_unitOfWork.CourseRepository
            
        }
    }
}
