using System;

namespace EmployeesLiveDemoWithMvpAndNinject.Models
{
    public class EmpDetailsEventArgs : EventArgs
    {
        public int Id { get; private set; }

        public EmpDetailsEventArgs(int id)
        {
            this.Id = id;
        }
    }
}