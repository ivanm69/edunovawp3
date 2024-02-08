using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnoGrananjeIF : ControllerBase
    {
       


        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a,int b)
        {

            
                



            //return(a+b)%2==0 ? a*b:a+b;

            var zbroj = a + b;
            if (zbroj % 2 == 0)
            {
                return a * b;
            }
            else
            {
                return zbroj;
            }
        }



        [HttpGet]
        [Route("zad2")]
        public string Zad2(int ocjena)
        {


            if (ocjena == 1)
            {
                return ("Nedovoljan");
            }
            else if (ocjena == 2)
            {
                return ("Dovoljan");
            }

            else if (ocjena == 3)
            {
                return ("Dobar");
            }
            else if (ocjena == 4)
            {
                return ("Vrlo Dobar");

            }
            else if (ocjena == 5)
            {
                return ("Odličan");
            }
            else
                return ("Nije ocjena");
                

            //moze i sa switch

            //switch(ocjena)
            //{
            //    case 1:
            //        return "Nedovoljan";
            //    case 2:
            //        return "Dovoljan";
            //    case 3:
            //        return "Dobar";
            //    case 4:
            //        return "Vrlo Dobar";
            //    case 5:
            //        return "Odličan";
            //    default:
            //        return "Nije ocjena";

            //}




           
            

           
           
        }




    }
}
