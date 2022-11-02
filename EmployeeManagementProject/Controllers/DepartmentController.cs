using EmployeeManagementProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly SchoolManagementDbContext _schoolManagementDbContext;
    
        public DepartmentController(SchoolManagementDbContext schoolManagementDbContext)
        {
            _schoolManagementDbContext = schoolManagementDbContext;
        }

        [HttpGet]
        public List<Department> Departments()
        {
            return _schoolManagementDbContext.Department.ToList();
        }


        [HttpGet]
        public List<Department> GetDepartments()
        {
            var DeptDetails = (from d in _schoolManagementDbContext.Department
                               select new
                               {
                                   d.DepartmentId,
                                   d.DepartmentName,
                                   d.Id,
                                   d.Acronym

                               }).ToList();
            return _schoolManagementDbContext.Department.ToList();
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            //if(department.DepartmentId == null)
            //{
                department.DepartmentId = Guid.NewGuid();
            //}
            _schoolManagementDbContext.Department.Add(department);
            _schoolManagementDbContext.SaveChanges();
            return Created(department.DepartmentName + "was created successfully", department);
        }


        [HttpPut, Route("{id}")]
        public IActionResult UpdateDepartment(int id, Department department)
        {
            try
            {
                var dept = _schoolManagementDbContext.Department.FirstOrDefault(x => x.Id == id);
                if (dept != null)
                {
                    dept.DepartmentName = department.DepartmentName;
                    dept.Acronym = department.Acronym;

                    var result = _schoolManagementDbContext.SaveChanges();

                    if (result > 0)
                    {
                        return Ok("Update was succeccful");
                    }

                    return BadRequest("Update was not successful");

                }
                return BadRequest("Department with the id does not exist" + id);
            }

            catch (Exception ex)
            {
                return BadRequest();

            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {

            try 
            {
                var Dep = _schoolManagementDbContext.Department.FirstOrDefault(x => x.Id == id);
                if (Dep != null)
                {
                    _schoolManagementDbContext.Department.Remove(Dep);
                    _schoolManagementDbContext.SaveChanges();

                    return Ok("The department was deleted successfully");
                }
                return BadRequest("department with the id does not exist" + id);


            }

            catch(Exception ex) 
            {
                return BadRequest();
           
            }
        }








    }
}
