using MovieFlix.Core.Contracts.Repository;
using MovieFlix.Core.Contracts.Service;
using MovieFlix.Core.Entities;
using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Infrastructure.Service
{

    public class CastServiceAsync : ICastServiceAsync
    {

        ICastRepositoryAsync castRep;

        public CastServiceAsync (ICastRepositoryAsync castRep)
        {
            this.castRep = castRep;
        }

        public Task<int> DeleteCastAsync(int Id)
        {
            return castRep.DeleteAsync(Id);
        }

        public async Task<CastModel> GetCastByIdAsync(int Id)
        {
            Cast cast = await castRep.GetByIdAsync(Id);

            if(cast != null)
            {
                CastModel castModel = new CastModel()
                {
                    Id = cast.Id,
                    Name = cast.Name,
                    Gender = cast.Gender,
                    TmdbUrl = cast.TmdbUrl,
                    ProfilePath = cast.ProfilePath
                };
                return castModel;

            }
            return null;
        }

        public async Task<int> InsertCastAsync(CastModel model)
        {
            Cast castModel = new Cast()
            {
                Name = model.Name,
                Gender = model.Gender,
                TmdbUrl = model.TmdbUrl,
                ProfilePath = model.ProfilePath
            };
            
            return await castRep.InsertAsync(castModel);

        }

        public async Task<int> UpdateCastAsync(CastModel model)
        {
            Cast castModel = new Cast()
            {
                Id = model.Id,
                Name = model.Name,
                Gender = model.Gender,
                TmdbUrl = model.TmdbUrl,
                ProfilePath = model.ProfilePath
            };
            return await castRep.UpdateAsync(castModel);
        }

        public async Task<IEnumerable<CastModel>> GetAllCastsAsync()
        {
            var result = await castRep.GetAllAsync();
            if (result != null)
            {
                List<CastModel> list = new List<CastModel>();
                result = result.OrderByDescending(x => x.Id);
                foreach (var item in result)
                {
                    CastModel model = new CastModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.TmdbUrl = item.TmdbUrl;
                    model.ProfilePath = item.ProfilePath;
                    model.Gender = item.Gender;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }








    }
}
