using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StoreController : Controller
    {
        KETIEntities storeDB = new KETIEntities();
        //private AlbumDBContext storeDB = new AlbumDBContext();

        /*
        // GET: Store
        public ActionResult Index(string subject)
        {
            var item = storeDB.single_photo.ToList();
            
            //var o = new single_photo { objectName = subject };
            //return View(o);            
            return View(item);
        }
        */

        public ActionResult Index()
        {
            //var item = storeDB.object_list.ToList();   
            var item = storeDB.single_photo.ToList();
            /*             
            var item = new List<subject_list>
            {
                new subject_list { Name = "freetime" },
                new subject_list { Name = "gear" }
             };
             */
            return View(item);
        }
        
        public ActionResult Display()
        {
            var item = storeDB.single_photo.ToList();
            return View(item);
        }

        /*
        public byte[] GetImageFromDataBase(int Id = 1)
        {
            var single_data = storeDB.single_photo.Find(Id);
            //byte[] canvas = single_data.img.First();
            //return canvas;
        }
        */

    }


}