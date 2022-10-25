//Isaiah Keith Ferguson
//10/25/2022
//Reverse It
//The user will input a message / number and we will output the reverse.
//Peer Reviewed by:


using Microsoft.AspNetCore.Mvc;

namespace FergusonIReverseItEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{

    [HttpGet]
    [Route("ReverseIt/{Input}")]

    public string ReverseIt(string input)
    {
        string revInput = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            revInput = revInput + input[i];
        }
        return $"This program will let the user input a string an output the reverse. \nFor Example: \n{input} | {revInput}";
    }
}