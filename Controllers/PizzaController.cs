using Microsoft.AspNetCore.Mvc;
using api_aspnet.Models;
using api_aspnet.Services;
using System.Reflection.Emit;

[ApiController] //attributetomake class in a api
[Route("[Controller]")] //How our controller call Pizza controller this route will be https://localhost:{PORT}/pizza.
public class PizzaController : ControllerBase //ControllerBase is a standart class for working whit HTTP requests
{

    //constructior method
    public PizzaController()
    {

    }

    //Define our API Get Method, using the PizzaService to get information
    [HttpGet]
    public ActionResult<List<Pizza>> GetAllPizzas() =>
    PizzaService.GetAll();

    //Define a Api GEt method to get a product by id pizza/1
    //our use the pizzaservice to get information by Id througt get()
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    //HTTP post method / Creat a pizza register
    //The tipe IActionResult allows the client knows 200 - requisition ok or 400 bad request (invalid object)
    //Thereturn creataction makes a request to method GET this controler and return the new id created
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    //Put methodto update a pizza register
    //this methodo expects a parameter on URL, in this case the id pizza: /pizza/1
    //..and in the body the object json pizza 
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = PizzaService.Get(id);
        if (existingPizza is null)
            return NotFound();

        PizzaService.Update(pizza);

        return NoContent();
    }

    //Delete method is like put
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza is null)
            return NotFound();

        PizzaService.Delete(id);

        return NoContent();
    }

}
