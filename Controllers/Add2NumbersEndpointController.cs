//Kenneth Fujimura
//Last Revised: 10-25-2022
//Say Hello - Endpoint
//This is an API that is designed to work like our original console Mini Challenge of the same name through a web interface.
//Peer Reviewed By: Reed Goodwin - I This is a well written piece of code! functions as intended, I like how it tells you the two numbers you added.

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKAdd2NumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersEndpointController : ControllerBase
{
    [HttpGet]
    [Route("Add2Numbers/{num1}/{num2}")]
    //localHost9000/Input/Hello/{name}
    public string Add2Numbers(string num1, string num2){
        int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);

        return $"The sum of {num1} and {num2} is {sum}";
    }
}