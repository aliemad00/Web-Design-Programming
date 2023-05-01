using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using industry4._0.Data;
using industry4._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace industry4._0.Controllers
{
    public class FeedbackPostsController : Controller
    {
        private readonly industry4_0Context _context;

        public FeedbackPostsController(industry4_0Context context)
        {
            _context = context;
        }

        // GET: FeedbackPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.FeedbackPost.ToListAsync());
        }

        // GET: FeedbackPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (feedbackPost == null)
            {
                return NotFound();
            }

            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Create
        [Authorize(Roles = "Admin, User")]
        public IActionResult Create()
        {
            FeedbackPost fd = new FeedbackPost();
            fd.Date = DateTime.Now;
            fd.Username = User.Identity.Name;
            fd.Agree = 0;
            fd.Disagree = 0;
            return View(fd);
        }

        // POST: FeedbackPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Create([Bind("ID,Date,Username,HEading,StarRating,Feedback,Agree,Disagree,CompanyOrganisationName,canIncreaseAgree,canIncreaseDisagree")] FeedbackPost feedbackPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedbackPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            if (feedbackPost == null)
            {
                return NotFound();
            }
            return View(feedbackPost);
        }

        // POST: FeedbackPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,Username,HEading,StarRating,Feedback,Agree,Disagree,CompanyOrganisationName,canIncreaseAgree,canIncreaseDisagree")] FeedbackPost feedbackPost)
        {
            if (id != feedbackPost.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedbackPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackPostExists(feedbackPost.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (feedbackPost == null)
            {
                return NotFound();
            }

            return View(feedbackPost);
        }

        // POST: FeedbackPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            _context.FeedbackPost.Remove(feedbackPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedbackPostExists(int id)
        {
            return _context.FeedbackPost.Any(e => e.ID == id);
        }
    }
}
