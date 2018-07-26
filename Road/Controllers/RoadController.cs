using Microsoft.AspNetCore.Mvc;
using Road.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

namespace Road.Controllers
{
    public class RoadController : Controller
    {
        private IMemoryCache cache;
        public RoadController(IMemoryCache cache)
        {
            this.cache = cache;
        }
        public ActionResult Index()
        {
            return View();
        }

        public Player GetPlayer(int id)
        {
            var player = PlayerManager.GetPlayer(id);
            //HttpContext.Session.SetString("player" , player);
            return player;
        }
        public List<Card> DrawCards(int playerId)
        {
            var player = GetPlayer(playerId);
            var cards = player.DrawCards();
            cache.Set("last_draw_cards", cards);
            return cards;
        }

        public void PickCard(int playerId, int cardId)
        {
            var player = GetPlayer(playerId);
            var cards = cache.Get<List<Card>>("last_draw_cards");
            var card = cards.Where(c => c.ID == cardId).Single();
            player.MoveNext(card);
            PlayerManager.SavePlayer(player);
        }

        
    }
}
