using Gnar.Data;
using Gnar.Models;
using Gnar.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DeckService
    {
        private readonly Guid _userId;

        public DeckService(Guid userId)
        {
            _userId = userId;
        }


        public bool CreateDeck(DeckCreate model)
        {
            var entity =
                new Deck()
                {
                    OwnerId = _userId,
                    DeckName = model.DeckName,
                    Brand = model.Brand,
                    Color = model.Color,
                    Size = model.Size,
                    ProModel = model.ProModel,
                    Shape = model.Shape,
                    WheelBase = model.WheelBase,

                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Decks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<DeckListItem> GetDecks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Decks
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new DeckListItem
                                {
                                    DeckId = e.DeckId,
                                    DeckName = e.DeckName,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );

                return query.ToArray();
            }
        }

        public DeckDetail GetDeckById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Decks
                        .Single(e => e.DeckId == id && e.OwnerId == _userId);
                return
                    new DeckDetail
                    {
                        DeckId = entity.DeckId,
                        DeckName = entity.DeckName,
                        Shape = entity.Shape,
                        Brand = entity.Brand,
                        ProModel = entity.ProModel,
                        Size = entity.Size,
                        Color = entity.Color,
                        WheelBase = entity.WheelBase,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
    }
}
