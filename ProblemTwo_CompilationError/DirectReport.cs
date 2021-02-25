using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport
    {
        public int empId;
        public string empName;
        public int empLevel;
        public DateTime dateTime;
        public object emp;
        public string  empSPno;
        private static object eID;
        private static object eName;
        private static object eLevel;
        private static object eDoJ;
        private static object espno;
        private static object eNull;

        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj, string pCode) : base(eID, eName, eLevel, eDoJ, eNull, espno)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

        public DirectReport(int empId, string empName, int empLevel, DateTime dateTime, string NoOfLeaves, string empSPno)
        {
            this.empId = empId;
            this.empName = empName;
            this.empLevel = empLevel;
            this.dateTime = dateTime;
            this.NoOfLeaves = NoOfLeaves;
            this.empSPno = empSPno;
        }
    }
}
