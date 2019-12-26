using System.Web.Mvc;
using SortingWebApplication.Models;
using MIddleWare;

namespace SortingWebApplication.Controllers
{
    public class HomeController : Controller
    {
        Model model;
        public HomeController() {
            model = new Model();
        }
        public ActionResult Index()
        {
            model = new Model();
            return View(model);
        }

        

        public ActionResult BubbleSort() 
        {
            model = new Model();
            return View(model);
        }

        public ActionResult InsertionSort()
        {
            model = new Model();
            return View(model);
        }

        public ActionResult SelectionSort()
        {
            model = new Model();
            return View(model);
        }
        public ActionResult MergeSort()
        {
            model = new Model();
            return View(model);
        }
        public ActionResult QuickSort()
        {
            model = new Model();
            return View(model);
        }



        [HttpPost]
        public ActionResult Bubble(string inBox)
        {
            MIddleWare.Bubble sort = new MIddleWare.Bubble();
            model.input = inBox;
            string outp = sort.process(inBox);
            model.output = outp;
            return View("BubbleSort",model);
        }

        [HttpPost]
        public ActionResult BubbleDetailed()
        {
            return View("BubbleSort", model);
        }

        [HttpPost]
        public ActionResult Insertion(string inBox)
        {
            MIddleWare.Insertion sort = new Insertion();
            model.input = inBox;
            model.output = sort.process(inBox);
            return View("InsertionSort",model);
        }

        [HttpPost]
        public ActionResult InsertionDetailed()
        {
            return View("InsertionSort", model);
        }

        [HttpPost]
        public ActionResult Selection(string inBox)
        {
            MIddleWare.Selection sort = new Selection();
            model.input = inBox;
            model.output = sort.process(inBox);
            return View("SelectionSort", model);
        }

        [HttpPost]
        public ActionResult SelectionDetailed()
        {
            return View("SelectionSort", model);
        }


        [HttpPost]
        public ActionResult Merge(string inBox)
        {
            MIddleWare.Merge sort = new Merge();
            model.input = inBox;
            model.output = sort.process(inBox);
            return View("MergeSort", model);
        }

        [HttpPost]
        public ActionResult MergeDetailed()
        {
            return View("MergeSort", model);
        }

        [HttpPost]
        public ActionResult Quick(string inBox)
        {
            MIddleWare.Quick sort = new Quick();
            model.input = inBox;
            model.output = sort.process(inBox); 
            return View("QuickSort", model);
        }

        [HttpPost]
        public ActionResult QuickDetailed()
        {

            return View("QuickSort", model);
        }
    }
}