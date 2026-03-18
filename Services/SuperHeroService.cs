using SuperHeroAPI.Data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public class SuperHeroService : IsuperHeroService
    {
        private readonly DataContext _datacontext;

        public SuperHeroService(DataContext dataContext)
        {
            _datacontext = dataContext;
        }

        public List<SuperHero> GetSuperHeroes()
        {
            return _datacontext.SuperHeroes.ToList();
        }

        public SuperHero? GetSuperHeroById(int id)
        {
            return _datacontext.SuperHeroes.Find(id);
        }

        public List<SuperHero> AddSuperHero(SuperHero hero)
        {
            _datacontext.SuperHeroes.Add(hero);
            _datacontext.SaveChanges();
            return _datacontext.SuperHeroes.ToList();
        }

        public List<SuperHero>? UpdateSuperHero(int id, SuperHero newHero)
        {
            var hero = _datacontext.SuperHeroes.Find(id);
            if (hero == null) return null;

            hero.Name = newHero.Name;
            hero.FirstName = newHero.FirstName;
            hero.LastName = newHero.LastName;
            hero.Place = newHero.Place;

            _datacontext.SaveChanges();
            return _datacontext.SuperHeroes.ToList();
        }

        public List<SuperHero>? DeleteSuperHero(int id)
        {
            var hero = _datacontext.SuperHeroes.Find(id);
            if (hero == null) return null;

            _datacontext.SuperHeroes.Remove(hero);
            _datacontext.SaveChanges();
            return _datacontext.SuperHeroes.ToList();
        }
    }
}