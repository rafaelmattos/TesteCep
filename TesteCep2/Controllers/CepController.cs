using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TesteCep2.Models;

namespace TesteCep2.Controllers
{
    public class CepController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Cep
        public async Task<ActionResult> Index()
        {
            return View(await db.Cep.ToListAsync());
        }

        // GET: Cep/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cep cep = await db.Cep.FindAsync(id);
            if (cep == null)
            {
                return HttpNotFound();
            }
            return View(cep);
        }

        // GET: Cep/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cep/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,NumCep,Logradouro,Complemento,Bairro,Localidade,Uf,Unidade,Ibge,Gia")] Cep cep)
        {
            if (ModelState.IsValid)
            {
                db.Cep.Add(cep);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cep);
        }

        // GET: Cep/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cep cep = await db.Cep.FindAsync(id);
            if (cep == null)
            {
                return HttpNotFound();
            }
            return View(cep);
        }

        // POST: Cep/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NumCep,Logradouro,Complemento,Bairro,Localidade,Uf,Unidade,Ibge,Gia")] Cep cep)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cep).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cep);
        }

        // GET: Cep/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cep cep = await db.Cep.FindAsync(id);
            if (cep == null)
            {
                return HttpNotFound();
            }
            return View(cep);
        }

        // POST: Cep/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Cep cep = await db.Cep.FindAsync(id);
            db.Cep.Remove(cep);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
