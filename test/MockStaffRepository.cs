using HRDepartment.Models;
using HRDepartment.Data;
using System.Collections.Generic;
using System.Linq;

namespace HRCheckerApp.Mocks
{
    public class MockStaffRepository : StaffRepository
    {
        private readonly List<Staff> _staffs = new List<Staff>();

        public MockStaffRepository() : base()
        {
            // base() constructor mặc định không dùng file
        }

        public override void Add(Staff s) => _staffs.Add(s);

        public override bool ExistsByStaffId(string staffId) => _staffs.Any(s => s.StaffId == staffId);

        public override IEnumerable<Staff> GetAll() => _staffs;

        public override Staff? GetById(int id) => _staffs.FirstOrDefault(s => s.Id == id);
    }
}
