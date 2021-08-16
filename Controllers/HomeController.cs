using HW4Reference.Models;
using HW4Reference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4Reference.Controllers
{
    public class HomeController : Controller
    {
        public static List<Shape> Shapes = new List<Shape>();
        public static string shape = "";
        public ActionResult Index()
        {
            return View(Shapes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ChangeShape(string shapeName)
        {
            ModelState.Clear();
            var vm = new ShapeViewModel();
            shape = shapeName;
            vm.CurrentShape = shapeName;
            if (shapeName == "rectangle")
            {
                vm.Rectangle = new Rectangle();
                return View("AddShape", vm);
            }
            else if (shapeName == "circle")
            {
                vm.Circle = new Circle();
                return View("AddShape", vm);
            }
            else
            {
                vm.Triangle = new Triangle();
                return View("AddShape", vm);
            }
        }

        [HttpGet]
        public ActionResult AddShape()
        {
            ModelState.Clear();
            var vm = new ShapeViewModel();
            vm.CurrentShape = "Init";
            vm.Rectangle = new Rectangle();
            vm.Triangle = new Triangle();
            vm.Circle = new Circle();
            vm.Shape = new Shape();
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddShape(ShapeViewModel vm)
        {
            if (vm.CurrentShape == "rectangle")
            {
                vm.Rectangle.Fill = vm.Shape.Fill;
                vm.Rectangle.StrokeColor = vm.Shape.StrokeColor;
                vm.Rectangle.StrokeWidth = vm.Shape.StrokeWidth;
                vm.Rectangle.Description = vm.Shape.Description;

                Shapes.Add(vm.Rectangle);
                return RedirectToAction("Index");
            }
            else if (vm.CurrentShape == "circle")
            {
                vm.Circle.Fill = vm.Shape.Fill;
                vm.Circle.StrokeColor = vm.Shape.StrokeColor;
                vm.Circle.StrokeWidth = vm.Shape.StrokeWidth;
                vm.Circle.Description = vm.Shape.Description;

                Shapes.Add(vm.Circle);
                return RedirectToAction("Index");
            } else
            {
                vm.Triangle.Fill = vm.Shape.Fill;
                vm.Triangle.StrokeColor = vm.Shape.StrokeColor;
                vm.Triangle.StrokeWidth = vm.Shape.StrokeWidth;
                vm.Triangle.Description = vm.Shape.Description;

                Shapes.Add(vm.Triangle);
                return RedirectToAction("Index");
            }
        }
    }
}