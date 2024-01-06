using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LaboratoryController : Controller
{
    private readonly LabManagerContext _context;

    public LaboratoryController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        return View(_context.Laboratories);
    }

    public IActionResult Show(int id)
    {
        Laboratory? laboratory =_context.Laboratories.Find(id);

        if(laboratory == null)
        {
            return NotFound();
        }
        return View(laboratory);
    }

    public IActionResult Create(){
                
        return View();
    }

    public IActionResult CreateResult(int id, int number, string name, string block)
    {
        if(_context.Laboratories.Find(id) == null)
        {
            _context.Laboratories.Add(new Laboratory(id,number,name,block));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe um laboratorio com esse id");
        }
       
    }

    public IActionResult Delete(int id){
        _context.Laboratories.Remove(_context.Laboratories.Find(id));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int id)
    {
        Laboratory laboratory = _context.Laboratories.Find(id);
        if(laboratory == null)
        {
            return Content("Esse laboratorio não existe!");
        }
        else
        {
           return View(laboratory);
        }
    }

    public IActionResult UpdateResult(int id, int number, string name, string block)
    {
        Laboratory laboratory = _context.Laboratories.Find(id);

        laboratory.Number = number;
        laboratory.Name = name;
        laboratory.Block = block;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
}