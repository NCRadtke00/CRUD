﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactCRUD.Models;
using ReactCRUD;
namespace ReactCRUD.Controllers
{
    public class DefaultController : Controller
    {
        private readonly CrudDemoEntities DB;
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [Route("AddotrUpdatestudent")]
        [HttpPost]
        public object AddotrUpdatestudent(Student st)
        {
            try
            {
                if (st.Id == 0)
                {
                    studentmaster sm = new studentmaster();
                    sm.Name = st.Name;
                    sm.RollNo = st.Rollno;
                    sm.Address = st.Address;
                    sm.Class = st.Class;
                    DB.studentmasters.Add(sm);
                    DB.SaveChanges();
                    return new Response
                    {
                        Status = "Success",
                        Message = "Data Successfully"
                    };
                }
                else
                {
                    var obj = DB.studentmasters.Where(x => x.Id == st.Id).ToList().FirstOrDefault();
                    if (obj.Id > 0)
                    {

                        obj.Name = st.Name;
                        obj.RollNo = st.Rollno;
                        obj.Address = st.Address;
                        obj.Class = st.Class;
                        DB.SaveChanges();
                        return new Response
                        {
                            Status = "Updated",
                            Message = "Updated Successfully"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return new Response
            {
                Status = "Error",
                Message = "Data not insert"
            };

        }
        [Route("Deletestudent")]
        [HttpDelete]
        public object Deletestudent(int id)
        {
            var obj = DB.studentmasters.Where(x => x.Id == id).ToList().FirstOrDefault();
            DB.studentmasters.Remove(obj);
            DB.SaveChanges();
            return new Response
            {
                Status = "Delete",
                Message = "Delete Successfuly"
            };
        }

    }
}