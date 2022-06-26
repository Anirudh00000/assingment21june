using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcorefirst
{
    public class CRUDMamagerForEmployeEducation
    {
        DemoDbContext context;
        public CRUDMamagerForEmployeEducation()
        {
            context = new DemoDbContext();
        }

        //public void AddEducation(EmployeEducation employeEducation)
        //{
        //    context.EmployeEducations.Add(employeEducation);    
        //    context.SaveChanges();
        //    Console.WriteLine("done...");
        //}
        //public void deleteEdu(int id)
        //{
        //    var deleteeducation = context.EmployeEducations.Where(edu => edu.EmployeeId == id).FirstOrDefault();
        //    if(deleteeducation != null)
        //    {
        //        context.EmployeEducations.Remove(deleteeducation);
        //        context.SaveChanges();
        //        Console.WriteLine("Delete Education ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Data Not found To be Delete with Id= {0}",id);
        //    }
        //}
        //public void updateEdu(int EmployeeId,EmployeEducation employeEducation)
        //{
        //    var updateedu=context.EmployeEducations.Where(edu=>edu.EmployeeId==EmployeeId).FirstOrDefault();
        //    if(updateedu != null)
        //    {
        //        updateedu.CourseName=employeEducation.CourseName;
        //        updateedu.UniversityName = employeEducation.UniversityName;
        //        updateedu.MarksPercentage=employeEducation.MarksPercentage;
        //        updateedu.PassingYear=employeEducation.PassingYear;
        //        context.EmployeEducations.Update(updateedu);
        //        context.SaveChanges();
        //        Console.WriteLine("Updated...");

        //    }
        //    else
        //    {
        //        Console.WriteLine(" No record Found With ID= {0}",EmployeeId);
        //    }
        //}
        //public List<EmployeEducation> ShowAllEmpEducation()
        //{
        //    var listEdu = context.EmployeEducations.ToList();
        //    return listEdu;
        //}

    }
}

