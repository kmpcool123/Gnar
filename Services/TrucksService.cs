using Gnar.Data;
using Gnar.Models.TrucksModel;
using Gnar.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TrucksService
    {

        private readonly Guid _userId;

        public TrucksService(Guid userId)
        {
            _userId = userId;
        }


        public bool CreateTrucks(TrucksCreate model)
        {
            var entity =
                new Trucks()
                {
                    OwnerId = _userId,
                    TruckName = model.TruckName,
                    Brand = model.Brand,
                    Color = model.Color,
                    Size = model.Size,
                    ProModel = model.ProModel,
                    Weight = model.Weight,                   
                    

                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Trucks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TrucksListItem> GetTrucks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Trucks
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new TrucksListItem
                                {
                                    TrucksId = e.TruckId,
                                    TrucksName = e.TruckName,                                   
                                    CreatedUtc = e.CreatedUtc
                                }
                        );

                return query.ToArray();
            }
        }

        public TrucksDetail GetTrucksById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trucks
                        .Single(e => e.TruckId == id && e.OwnerId == _userId);
                return
                    new TrucksDetail
                    {
                        TruckId = entity.TruckId,
                        TruckName = entity.TruckName,                        
                        Brand = entity.Brand,
                        ProModel = entity.ProModel,
                        Size = entity.Size,
                        Color = entity.Color,
                        Weight = entity.Weight,
                        
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateTrucks(TrucksEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trucks
                        .Single(e => e.TruckId == model.TruckId && e.OwnerId == _userId);

                entity.TruckId = entity.TruckId;
                entity.TruckName = entity.TruckName;
                
                entity.Brand = entity.Brand;
                entity.ProModel = entity.ProModel;
                entity.Size = entity.Size;
                entity.Color = entity.Color;
                entity.Weight = entity.Weight;
                entity.ModifiedUtc = entity.ModifiedUtc;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteTrucks(int truckId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trucks
                        .Single(e => e.TruckId == truckId && e.OwnerId == _userId);

                ctx.Trucks.Remove(entity);

                return ctx.SaveChanges() == 1;
            }

        }
    }
}