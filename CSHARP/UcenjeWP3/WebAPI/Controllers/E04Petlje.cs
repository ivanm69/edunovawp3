using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Petlje : ControllerBase
    {



        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            int zbroj = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    zbroj += i;
                }
            }

            return zbroj;


            





        }  
    }

}

