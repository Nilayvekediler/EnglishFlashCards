using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnglishFlashCardsWeb.Models;

namespace EnglishFlashCardsWeb.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateCard(int id) {
            FlashCardManager fcManager = new FlashCardManager();
            ViewBag.card_id = id;
            ViewBag.word = fcManager.GetFlashCard(id).word;
            ViewBag.meaning = fcManager.GetFlashCard(id).meaning;
            ViewBag.set_id = fcManager.GetFlashCard(id).CardsetID;
            ViewBag.word_scenario = fcManager.GetFlashCard(id).story;
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCard(int card_id , int set_id , string word, string meaning, string word_scenario)
        {
            FlashCardManager fmManager = new FlashCardManager();
            FlashCard card = new FlashCard();
            card.cardID = card_id;
            card.word = word;
            card.meaning = meaning;
            card.story = word_scenario;
            fmManager.updateFlashCard(card);
            return RedirectToAction("set", "sets", new { id = set_id });
        }

        [HttpGet]
        public IActionResult DeleteCard(int id)
        {
            FlashCardManager fcManager = new FlashCardManager();
            FlashCard fc = new FlashCard();
            fc.cardID = id;
            fc.word = fcManager.GetFlashCard(id).word;
            fc.meaning = fcManager.GetFlashCard(id).meaning;
            fc.CardsetID = fcManager.GetFlashCard(id).CardsetID;
            fcManager.deleteFlashCard(fc);
            return RedirectToAction("set", "sets", new { id = fc.CardsetID });
        }

    }
}
