namespace SuperHeroAPI.Services

{
    public interface IsuperHeroService
    {
        List<SuperHero> GetSuperHeroes();
        SuperHero? GetSuperHeroById(int id);
        List<SuperHero> AddSuperHero(SuperHero hero);
        List<SuperHero>? UpdateSuperHero(int id, SuperHero newHero);
        List<SuperHero>? DeleteSuperHero(int id);


    }
}
