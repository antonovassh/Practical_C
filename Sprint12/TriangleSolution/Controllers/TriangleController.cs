using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Triangles.Models;
using Triangles.Services;

namespace Triangles.Controllers
{
    public class TriangleController : Controller
    {
        private readonly ITriangleServices _triangleServices;

        public TriangleController() //(ITriangleServices triangleServices) changed due to the tests because they require a constructor without parameters.
        {
            _triangleServices = new TriangleService();
        }

        public IActionResult Info(Triangle triangle)
        {
            List<Triangle> viewModel = new List<Triangle>();
            viewModel.Add(_triangleServices.GetTriangle(triangle));

            return View("~/Views/Triangle/InfoOutput.cshtml", viewModel);
        }
        
        public IActionResult Area(Triangle triangle)
        {
            ViewData["methodName "] = "Area.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.Area(triangle));
        }
       
        public IActionResult Perimeter(Triangle triangle)
        {
            ViewData["methodName "] = "Perimeter.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.Perimeter(triangle));
        }
       
        public IActionResult IsRightAngled(Triangle triangle)
        {
            ViewData["methodName "] = "Is Right Angled.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.IsRightAngled(triangle));
        }
       
        public IActionResult IsEquilateral(Triangle triangle)
        {
            ViewData["methodName "] = "Is Equilateral.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.IsEquilateral(triangle));
        }
      
        public IActionResult IsIsosceles(Triangle triangle)
        {
            ViewData["methodName "] = "Is Isosceles.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.IsIsosceles(triangle));
        }
       
        public IActionResult AreCongruent(Triangle tr1, Triangle tr2)
        {
            ViewData["methodName "] = "Are Congruent.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.AreCongruent(_triangleServices.GetTriangle(tr1), _triangleServices.GetTriangle(tr2)));
        }
        
        public IActionResult AreSimilar(Triangle tr1, Triangle tr2)
        {
            ViewData["methodName "] = "Are Similar.";

            return View("~/Views/Triangle/Result.cshtml", _triangleServices.AreSimilar(tr1, tr2));
        }
       
        public IActionResult GreatesByPerimeter(Triangle[] tr)
        {
            List<Triangle> viewModel = new List<Triangle>();
            viewModel.Add(_triangleServices.GetTriangle(_triangleServices.GreatesByPerimeter(tr)));

            return View("~/Views/Triangle/InfoOutput.cshtml", viewModel);
        }
       
        public IActionResult GreatestByArea(Triangle[] tr)
        {
            List<Triangle> viewModel = new List<Triangle>();
            viewModel.Add(_triangleServices.GetTriangle(_triangleServices.GetTriangle(_triangleServices.GreatesByArea(tr))));

            return View("~/Views/Triangle/InfoOutput.cshtml", viewModel);
        }
  
        public IActionResult NumbersPairwiseNotSimilar(Triangle[] tr)
        {
            ViewData["methodName "] = "Pairwise Non Similar.";
           
            return View(_triangleServices.NumbersPairwiseNotSimilar(tr));
        }
        public IActionResult InfoGreatestArea(Triangle[] tr)
        {
            List<Triangle> viewModel = new List<Triangle>();

            return View("Info", viewModel);
        }

        public IActionResult InfoGreatestPerimeter(Triangle[] tr)
        {
            List<Triangle> viewModel = new List<Triangle>();

            return View("Info", viewModel);
        }
    }
}
