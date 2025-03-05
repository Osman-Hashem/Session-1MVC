using Microsoft.AspNetCore.Mvc;
using Session_1MVC.Models;

namespace Session_1MVC.Controllers
{

    // MVC Controller 
    public class MovieController : Controller
    {
        // ACtions : Public non-static method 
        // Actions : Have Special Return Types
        // ActionResult

        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id :  {id} ";
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id :  {id} ";
        //}


        /////
        ///

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With ID : {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200

        //    };
        //    return contentResult;
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With ID : {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200

        //    };
        //    return contentResult;
        //}


        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/webhp?hl=ar&ictx=0&sa=X&ved=0ahUKEwjWtd2p8e6LAxWn8wIHHbMRNwoQpYkNCAo")
        //    {

        //    };
        //    return redirectResult;
        //}


        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });

        //    return redirectToActionResult;
        //}


        //[ActionName("GetMovie")]
        //[HttpPost]
        //public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With ID : {id}", ContentType = "text/html" };
        //        return Content ( $"Get Movie With ID : {id}",  "text/html" );
        //    }
        //    else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With ID : {id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie With ID : {id}", "object/pdf");

        //    }
        //    else if (id == 3)
        //    {
        //        //return new RedirectResult("https://www.google.com/");
        //        return Redirect("https://www.google.com/");

        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //        return RedirectToAction ("AddMovie", "Movie", new { id = 133 });

        //    }
        //}

        ////////////////////////////


        // Action Parameters Binding 
        // 1- Form 
        // 2- Segment 
        // 3- Query Prams 
        // 4- Files 


        public IActionResult GetMovie( Movie movie)
        {
            return Content($"Ger Movie With Id : {movie.Id} , Name = {movie.Name}" , "text/html");
        }





    }
}
 