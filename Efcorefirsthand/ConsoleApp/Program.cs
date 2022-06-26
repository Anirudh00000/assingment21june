
using Efcorefirst;
using Efcorefirst.Entities;

namespace ConsoleApp
{


    public class program
    { 
    public static void Main()
    {
        #region employee
        CRUDManagerForEmployee employeePerformance = new CRUDManagerForEmployee();
        // employeePerformance.AddEmployee(new Employee { EmployeeName = "raj", EmployeeAddress = "Dehi" });

        //var data = employeePerformance.showAllEmployee();
        //foreach (var emp in data)
        //{
        //    Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
        //}
        //employeePerformance.UpdateEmployee(1, new Employee { EmployeeName = "Shivam Kumar", EmployeeAddress = "Aligarh" });
        //employeePerformance.DeleteEmployeeById(1);
        //var empdata = employeePerformance.showAllEmployee();
        //foreach (var emp in empdata)
        //{
        //    Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
        //}
        //#endregion

        //#region EmpEdu
        //CRUDMamagerForEmployeEducation employeEducation = new CRUDMamagerForEmployeEducation();
        //employeEducation.AddEducation(new EmployeEducation { CourseName = "BCA", UniversityName = "GLA University", PassingYear = 2022, MarksPercentage = 85, EmployeeId = 3 });

        //employeEducation.AddEducation(new EmployeEducation { CourseName = "BCA", UniversityName = "GLA University", PassingYear = 2021, MarksPercentage = 85, EmployeeId = 2 });
        //var edu = employeEducation.ShowAllEmpEducation();
        //foreach (var employe in edu)
        //{
        //    Console.WriteLine("Employee Id : " + employe.EmployeeId);
        //    Console.WriteLine("Employee Course Name : " + employe.CourseName);
        //    Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
        //    Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
        //    Console.WriteLine();
        //}
        //employeEducation.updateEdu(1, new EmployeEducation { CourseName = "B.Tech", UniversityName = "GLA University", PassingYear = 2021, MarksPercentage = 89, EmployeeId = 1 });
        //edu = employeEducation.ShowAllEmpEducation();
        //foreach (var employe in edu)
        //{
        //    Console.WriteLine("Employee Id : " + employe.EmployeeId);
        //    Console.WriteLine("Employee Course Name : " + employe.CourseName);
        //    Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
        //    Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
        //    Console.WriteLine();
        //}
        //employeEducation.deleteEdu(2);
        //edu = employeEducation.ShowAllEmpEducation();
        //foreach (var employe in edu)
        //{
        //    Console.WriteLine("Employee Id : " + employe.EmployeeId);
        //    Console.WriteLine("Employee Course Name : " + employe.CourseName);
        //    Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
        //    Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
        //    Console.WriteLine();
        //}

        #endregion

        #region Adddata
        List<EmployeEducation> employeEducations = new List<EmployeEducation>();
        employeEducations.Add(new EmployeEducation { CourseName = "Bca", MarksPercentage = 80, PassingYear = 2022, UniversityName = "aktu" });
        Employee employee1 = new Employee { EmployeeName = "Rajan", EmployeeAddress = "gorakhpur", employeeEducation = employeEducations };
        employeePerformance.AddEmployee(employee1);
        var data = employeePerformance.showAllEmployee();
        foreach (var emp in data)
        {
            Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
            foreach (var edu in emp.employeeEducation)
            {
                Console.WriteLine(edu.CourseName);
                Console.WriteLine(edu.PassingYear);
                Console.WriteLine(edu.MarksPercentage);
            }
        }

        employeePerformance.DeleteEmployeeById(1);
        data = employeePerformance.showAllEmployee();
        //foreach (var emp in data)
        //{
        //    Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
        //    foreach (var edu in emp.employeeEducation)
        //    {
        //        Console.WriteLine(edu.CourseName);
        //        Console.WriteLine(edu.PassingYear);
        //        Console.WriteLine(edu.MarksPercentage);
        //    }
        //}




        #endregion
        Console.ReadLine();


    }
}
}
