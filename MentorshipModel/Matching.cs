using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;


namespace MentorshipModel
{
    public class Matching
    {
        //TODO:
        /*Read from files and add to respective class objects
         * perform match
         * add to MatchedClass List
         * return
         */
        #region Global Variables
        Dictionary<Department, List<Mentor>> _dicMentorDepartment = null;
        Dictionary<Department, List<Mentee>> _dicMenteeDepartment = null;
        List<Matched> _lstFinal = null;      
        public List<Matched> FinalList { get { return _lstFinal; } }
        
        #endregion Global Variables

        public Matching(string mentorPath, string menteePath)
        {
            _dicMentorDepartment = new Dictionary<Department, List<Mentor>>();
            _dicMenteeDepartment = new Dictionary<Department, List<Mentee>>();
            _lstFinal = new List<Matched>();
            populateMentors(mentorPath, RoleType.Mentor);
            populateMentees(menteePath, RoleType.Mentee);
            match();
        }
        private Department setDept(string deptName)
        {
            Department dType;
            if (deptName.ToLower().Contains("computer science"))
                dType = Department.ComputerScience;
            else if (deptName.ToLower().Contains("electrical"))
                dType = Department.Electrical;
            else if (deptName.ToLower().Contains("chemical"))
                dType = Department.Chemical;
            else if (deptName.ToLower().Contains("engineering management"))
                dType = Department.EngineeringManagement;
            else if (deptName.ToLower().Contains("petroleum"))
                dType = Department.Petroleum;
            else if (deptName.ToLower().Contains("informatics"))
                dType = Department.Informatics;
            else if (deptName.ToLower().Contains("astronautical"))
                dType = Department.Astronautical;
            else if (deptName.ToLower().Contains("architecture"))
                dType = Department.Architecture;
            else if (deptName.ToLower().Contains("civil"))
                dType = Department.Civil;
            else if (deptName.ToLower().Contains("computer engineering"))
                dType = Department.ComputerEngineering;
            else if (deptName.ToLower().Contains("cyber"))
                dType = Department.Cyber;
            else if (deptName.ToLower().Contains("biomedical"))
                dType = Department.Biomedical;
            else if (deptName.ToLower().Contains("industrial"))
                dType = Department.Industrial;
            else
                dType = Department.Others;
            return dType;

        }
        private void populateMentors(string path, RoleType rType)
        {
            OfficeOpenXml.ExcelWorksheet ws =  readExcel(path);
            for (int rowNum = 2; rowNum <= ws.Dimension.End.Row; rowNum++)//foreach mentor
            {
                var wsRow = ws.Cells[rowNum, ws.Dimension.End.Column];
                Mentor objMentor = new Mentor();
                objMentor.Name = wsRow["B" + rowNum].Text.Trim();
                objMentor.Dept = setDept(wsRow["G" + rowNum].Text.Trim());
                objMentor.UscId = wsRow["D" + rowNum].Text.Trim();
                objMentor.Contact = wsRow["E" + rowNum].Text.Trim();
                if (!_dicMentorDepartment.ContainsKey(objMentor.Dept))
                {
                    List<Mentor> lstMentors = new List<Mentor>();
                    lstMentors.Add(objMentor);
                    _dicMentorDepartment.Add(objMentor.Dept, lstMentors);
                }
                else
                {
                    List<Mentor> lstMentors = _dicMentorDepartment[objMentor.Dept];
                    lstMentors.Add(objMentor);
                }
            }
        }
        private void populateMentees(string path, RoleType rType)
        {
            OfficeOpenXml.ExcelWorksheet ws = readExcel(path);
            for (int rowNum = 2; rowNum <= ws.Dimension.End.Row; rowNum++)//foreach mentee
            {
                var wsRow = ws.Cells[rowNum, ws.Dimension.End.Column];
                if (wsRow["B" + rowNum].Text.Trim() == string.Empty) continue;
                Mentee objMentee = new Mentee();
                objMentee.Name = wsRow["B" + rowNum].Text.Trim();
                objMentee.Dept = setDept(wsRow["C" + rowNum].Text.Trim());
                objMentee.UscId = wsRow["D" + rowNum].Text.Trim();
                objMentee.Contact = wsRow["E" + rowNum].Text.Trim();
                if (!_dicMenteeDepartment.ContainsKey(objMentee.Dept))
                {
                    List<Mentee> lstMentees = new List<Mentee>();
                    lstMentees.Add(objMentee);
                    _dicMenteeDepartment.Add(objMentee.Dept, lstMentees);
                }
                else
                {
                    List<Mentee> lstMentees = _dicMenteeDepartment[objMentee.Dept];
                    lstMentees.Add(objMentee);
                }
            }

        }
        private OfficeOpenXml.ExcelWorksheet readExcel(string path)
        {
            var ePackage = new OfficeOpenXml.ExcelPackage();
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    ePackage.Load(stream);
                }
                return ePackage.Workbook.Worksheets[1];               
            }
        }
        private void match()
        {           
            foreach(Department d in _dicMenteeDepartment.Keys)
            {
                List<Mentor> lstmentors = _dicMentorDepartment[d];
                List<Mentee> lstmentees = _dicMenteeDepartment[d];
                int mentorCount = 0;            
                for(int i=0;i<lstmentees.Count;i++)
                {                   
                    Mentee objMentee = lstmentees[i];
                    Mentor objMentor = null;
                    if (mentorCount > lstmentors.Count - 1)
                        mentorCount = 0;                    
                    objMentor = lstmentors[mentorCount];
                    mentorCount++;
                    Matched objMatched = new Matched();
                    objMatched.MenteeName = objMentee.Name;
                    objMatched.MenteeDept = objMentee.Dept;
                    objMatched.MenteeUscId = objMentee.UscId;
                    objMatched.MenteeContact = objMentee.Contact;
                    objMatched.MentorName = objMentor.Name;
                    objMatched.MentorDept = objMentor.Dept;
                    objMatched.MentorUscId = objMentor.UscId;
                    objMatched.MentorContact = objMentor.Contact;
                    _lstFinal.Add(objMatched);
                }
            }
        }
    }
    public class Mentor
    {
        #region variables
        public string Name;
        public Department Dept;
        public string UscId;
        public string Contact;
        public int menteeCount;
        #endregion

    }
    public class Mentee
    {
        #region variables
        public string Name;
        public Department Dept;
        public string UscId;
        public string Contact;
        #endregion
    }
    public class Matched
    {
        public string MentorName { get; set; }
        public Department MentorDept { get; set; }
        public string MentorUscId { get; set; }
        public string MentorContact { get; set; }
        public string MenteeName { get; set; }
        public Department MenteeDept { get; set; }
        public string MenteeUscId { get; set; }
        public string MenteeContact { get; set; }
    }
}

