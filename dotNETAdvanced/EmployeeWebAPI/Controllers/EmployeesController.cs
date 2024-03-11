using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using AutoMapper;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IMapper _mapper;
        readonly IEmpDataAceess dal;

        public EmployeesController(IMapper mapper, IEmpDataAceess dal)
        {
            _mapper = mapper;
            this.dal = dal;
        }

       


        [HttpGet]
        [Route("getAllEmp")]
        public List<Employee> Get()
        {
           // EmployeeDataAccess dal = new EmployeeDataAccess();
            List<Employee> employees = dal.GetEmps();
            return employees;
        }

        [HttpGet]
        [Route("GetEmpById/{id}")]
        //public Employee GetEmpById(int id)
            public ActionResult GetEmpById(int id)
        {
            try
            {
               // EmployeeDataAccess dal = new EmployeeDataAccess();
                Employee employee = dal.GetEmpById(id);
                return Ok(employee);
            }

            catch (Exception ex)
            { 
            
            return NotFound(ex.Message);

            }
        }

        

        [HttpPost]
        [Route("addEmployee")]
       // public void Post([FromBody] Employee employee)
        public ActionResult Post([FromBody] Employee employee)
        {
            try
            {
               // EmployeeDataAccess dal = new EmployeeDataAccess();
                dal.AddEmployee(employee);
                //returning success
                return Ok("record inserted successfully");
            }

            catch (Exception ex)
            {
                //returning error
                return BadRequest(ex.Message);
            }
        
        }

        [HttpDelete]
        [Route("deleteEmp/{id}")]

        public void Delete(int id)
        {
           // EmployeeDataAccess dal = new EmployeeDataAccess();
             dal.DeleteEmployee(id);

        }

        [HttpPut]
        [Route("updateEmp")]
        public void Put(Employee employee) 
        {
           // EmployeeDataAccess dal = new EmployeeDataAccess();
            dal.UpdateEmployee(employee);
        }

        [HttpGet]
        [Route("AddNumbers/{x}/{y}")]

        public int AddNumbers(int x, int y)
        {
            return x + y;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public CustomerDestination GetCustomer()
        {
            CustomerSource source = new CustomerSource
            {
                CustId = 1001,
                CustName = "Alex",
                City = "Texas",
                Region = "r1"
            };

        //    //manual mapping
        //    CustomerDestination destination new CustomerDestination
        //    {
        //        CustId = source.CustId;
        //    CustName = source.CustName;
        //};
        //return destination;

            //using automapper
            //configure and create mapper object
            MapperConfiguration config = new MapperConfiguration(c=>
                                         c.CreateMap<CustomerSource, CustomerDestination>());

            IMapper mapper = config.CreateMapper();

            //map the source to destination
            CustomerDestination destination = mapper.Map<CustomerDestination>(source);


            return destination;
        }


        [HttpGet]
        [Route("getCustomers")]

        public List<CustomerDestination> getCustomers()
        {
            List<CustomerSource> sourcelist = new List<CustomerSource>
            {


                new CustomerSource {CustId = 1001, CustName = "Alex",City = "Texas",Region = "r1"},
                new CustomerSource {CustId = 1002, CustName = "Adam",City = "Texas",Region = "r2"},
                new CustomerSource {CustId = 1003, CustName = "benjamin",City = "Texas",Region = "r3"},

                new CustomerSource {CustId = 1004, CustName = "alen",City = "Texas",Region = "r4"}


            };

            //MapperConfiguration config = new MapperConfiguration(c =>
            //                             c.CreateMap<CustomerSource, CustomerDestination>());

            //IMapper mapper = config.CreateMapper();

            //map the source to destination
            List<CustomerDestination> destinationlist = _mapper.Map<List<CustomerDestination>>(sourcelist);
            return destinationlist;

        }
    }
}
