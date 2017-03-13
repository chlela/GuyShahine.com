using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Gshahine.DotNetCore.ViewModels;
using MongoDB.Bson;
using System.IO;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gshahine.DotNetCore.Controllers
{
  public class GuestListController : Controller
  {
    private MongoClient client;
    private IMongoCollection<GuestVM> collection;

    public GuestListController()
    {
      this.client = new MongoClient("mongodb://rachjamie:AlORdxybQj4uG8gKb4rAg2oiJJ9eBMy2hfKfk25ujdQuTetEP9ussGdyinwJZUjEi8ms9aJR9RTu200zg6MVWg==@rachjamie.documents.azure.com:10250/?ssl=true");
      var database = client.GetDatabase("guest-list");
      this.collection = database.GetCollection<GuestVM>("guests2");
    }

    // GET: /<controller>/
    public async Task<IActionResult> Index()
    {
      var options = new FindOptions<GuestVM>
      {
        Sort = Builders<GuestVM>.Sort.Descending(f => f.CreatedAtUtc)
      };

      var names = await (await collection.FindAsync(f => f.Id != null, options).ConfigureAwait(false)).ToListAsync();

      return View(names);
    }

    public async Task<IActionResult> GuestOf(string id)
    {
      var names = await (await collection.FindAsync(f => f.GuestOf == id).ConfigureAwait(false)).ToListAsync();

      return View("~/Views/GuestList/Index.cshtml", names);
    }

    public async Task<IActionResult> Edit(string id)
    {
      var names = await (await collection.FindAsync(f => f.Id == new ObjectId(id)).ConfigureAwait(false)).ToListAsync();

      return View(names.FirstOrDefault());
    }

    [HttpPost]
    public async Task<IActionResult> Edit(string id, GuestVM guest)
    {
      if (await collection.FindOneAndReplaceAsync(f => f.Id == new ObjectId(id), guest) != null)
      {
        return RedirectToAction("Index");
      }

      return View(guest);
    }

    [HttpPost]
    public async Task<IActionResult> Add(GuestVM guest)
    {
      guest.Id = ObjectId.GenerateNewId();
      guest.CreatedAtUtc = DateTime.UtcNow;

      await collection.InsertOneAsync(guest);

      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
      await collection.DeleteOneAsync(f => f.Id == new ObjectId(id));
      return RedirectToAction("Index");
    }

  }
}
