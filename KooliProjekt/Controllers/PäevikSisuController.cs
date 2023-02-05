using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KooliProjekt.Models;
using KooliProjekt.Services;

namespace KooliProjekt.Controllers
{
    public class PäevikSisuController : Controller
    {
        private readonly IPäevikService _päevikService;
        private readonly IPäevikSisuService _sisuService;  //enne oli _taskService

        public PäevikSisuController(IPäevikService projectService,
                                      IPäevikSisuService sisuService)
        {
            _päevikService = projectService;
            _sisuService = sisuService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _sisuService.List<PäevikSisuListModel>();

            return View(result);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var päevikSisu = await _sisuService.Get<PäevikSisuModel>(id.Value);
            if (päevikSisu == null)
            {
                return NotFound();
            }

            return View(päevikSisu);
        }

        public IActionResult Create()
        {
            var model = new PäevikSisuEditModel();

            FillEditModel(model);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PäevikSisuEditModel päevikSisuEditModel)
        {
            if (!ModelState.IsValid)
            {
                FillEditModel(päevikSisuEditModel);
                return View(päevikSisuEditModel);
            }

            await _sisuService.Save(päevikSisuEditModel.Task);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var päevikSisu = await _sisuService.Get<PäevikSisuModel>(id.Value);
            if (päevikSisu == null)
            {
                return NotFound();
            }

            var model = new PäevikSisuEditModel();
            model.Task = päevikSisu;

            FillEditModel(model);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PäevikSisuEditModel päevikSisuEditModel)
        {
            if (id != päevikSisuEditModel.Task.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                FillEditModel(päevikSisuEditModel);
                return View(päevikSisuEditModel);
            }

            await _sisuService.Save(päevikSisuEditModel.Task);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var päevikSisu = await _sisuService.Get<PäevikSisuModel>(id.Value);
            if (päevikSisu == null)
            {
                return NotFound();
            }

            return View(päevikSisu);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _sisuService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        private async void FillEditModel(PäevikSisuEditModel model)
        {
            var päevik = await _päevikService.Lookup();

            model.Päevik = päevik.Select(p => new SelectListItem
                                        {
                                            Value = p.Id.ToString(),
                                            Text = p.DisplayName
                                        }).ToList();
        }
    }
}
