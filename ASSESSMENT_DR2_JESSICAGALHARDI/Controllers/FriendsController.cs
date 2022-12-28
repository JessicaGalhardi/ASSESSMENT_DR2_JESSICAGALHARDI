
using FriendXY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Numerics;

namespace FriendXY.Controllers
{
    public class FriendsController : Controller
    {
        public readonly DBBirthdayContext db;
        public FriendsController(DBBirthdayContext dBBirthdayContext)
        {
            db = dBBirthdayContext;
        }
        public IActionResult Home()
        {
            
            var lstFriends = db.friends.OrderByDescending(friendX => friendX.BirthDate).ToList();
          
            
           
            return View("home", lstFriends);
            
        }

        public IActionResult Index()
        {
            var lstBirthDay = db.friends.Where(friendX => friendX.BirthDate.Day == DateTime.Now.Day)
              .Where(friendX => friendX.BirthDate.Month == DateTime.Now.Month).ToList();

            

            return View("Index", lstBirthDay);

        }


        public IActionResult List()
        {

            var lstFriends = db.friends.ToList();

          
            return View("List", lstFriends);
        }

     

        [HttpGet]
        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateResult([Bind(include: "Name,LastName,BirthDate")] Friend friend)
        {

            db.friends.Add(friend);
            db.SaveChanges();


            return RedirectToAction("List", friend);
        }

        public IActionResult Details(int Id)
        {
            var contact = db.friends.First(contact => contact.Id == Id);

            return View(contact);
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            return View("Update", db.friends.FirstOrDefault(friendX => friendX.Id == Id));
        }

        [HttpPost, ActionName("Update")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateResult(int Id, Friend friendX)
        {
            var friendUpdate = db.friends.Find(Id);

            friendUpdate.Name = friendX.Name;
            friendUpdate.LastName = friendX.LastName;
            friendUpdate.BirthDate = friendX.BirthDate;


            var upResult = db.friends.Update(friendUpdate);
            db.SaveChanges();

            return RedirectToAction("List", upResult);
        }


        public IActionResult Delete(int Id)
        {

            var friend = db.friends.Find(Id);
            db.friends.Remove(friend);

            db.SaveChanges();


            return RedirectToAction("List", friend);
        }

        [HttpGet]
        public ActionResult Search()
        {
            var lstFriends = db.friends.ToList();

            return View("List", lstFriends);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Search(string Name)
        {

            var newSearch = db.friends.Where(friendX=> friendX.Name!.Contains(Name));


            return View("SearchResult", newSearch);
            
        }


    }
}
