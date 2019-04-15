using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundsharpMVC.Controllers
{
    public class TrackController : Controller
    {

        private static TrackList trackList = new TrackList();

        public TrackController()
        {
            if (trackList.Count == 0)
            {
                Track t1 = new Track();
                t1.Name = "Yellow";
                t1.Artist = "Coldplay";
                t1.AlbumSource = "Parachutes";
                t1.Length = new AudioDevices.Time(0, 4, 29);
                t1.Style = Category.Pop;

                Track t2 = new Track();
                t2.Name = "Shiver";
                t2.Artist = "Coldplay";
                t2.AlbumSource = "Parachutes";
                t2.Length = new AudioDevices.Time(0, 4, 59);
                t2.Style = Category.Pop;

                Track t3 = new Track(0 ,  "Maneater");
                t3.Artist = "Nelly Futado";
                t3.AlbumSource = "Loose";
                t3.Style = Category.Pop;
                t3.Length = new AudioDevices.Time(281);

                Track t4 = new Track(4, "Guitar", "Prince");
                t4.Style = Category.Pop;
                t4.Length = new AudioDevices.Time(3, 72);

                trackList.Add(t1);
                trackList.Add(t2);
                trackList.Add(t3);
                trackList.Add(t4);
            }
        }

        // GET: Track
        public ActionResult Index()
        {
            ViewBag.TotalTime = trackList.TotalTime.ToString();
            return View(trackList.Shuffle());
        }

        // GET: Track/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Track/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Track/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                int hours = int.Parse(collection["Hours"]);
                int minutes = int.Parse(collection["Minutes"]);
                int seconds = int.Parse(collection["Seconds"]);
                Track track = new Track();
                track.Name = collection["Name"];
                track.Artist = collection["Artist"];
                track.AlbumSource = collection["AlbumSource"];
                track.Length = new AudioDevices.Time(hours, minutes, seconds);
                track.Style = (Category)Enum.Parse(typeof(Category) , collection["Style"]);
                trackList.Add(track);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Track/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Track/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
