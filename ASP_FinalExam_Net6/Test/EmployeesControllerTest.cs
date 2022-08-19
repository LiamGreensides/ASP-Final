using ASP_FinalExam_Net6.Controllers;
using ASP_FinalExam_Net6.Data;
using ASP_FinalExam_Net6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;
namespace ASP_FinalExam_Net6.Test
{
    public class EmployeesControllerTest
    {
        [Fact]
        public async Task Index_Returns_ViewResult_And_EmployeeList()
        {
            using (var testDb = new ApplicationDbContext(this.GetTestDbOpts()))
            {
                var testCtrl = new EmployeesController(testDb);
                var result = await testCtrl.Index();
                var resVr = Assert.IsType<ViewResult>(result);
                Assert.IsAssignableFrom<IEnumerable<Employee>>(resVr.ViewData.Model);
            }
        }


        private DbContextOptions<ApplicationDbContext> GetTestDbOpts()
        {
            var opts = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestEmployeeCntrllr").Options;
            return opts;
        }

    }

    
}
