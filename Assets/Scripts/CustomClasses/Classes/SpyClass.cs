public class SpyClass : BaseClass
{
    // Initial values for the warrior class
    public SpyClass()
    {
        // Spy focuses on stealth
        stats.hp = 100;
        stats.str = 5;
        stats.def = 5;
        stats.stl = 25;

        // Thesewill always be 0, 1, 1 to start.
        stats.exp = 0;
        stats.expToNext = 1;
        stats.lvl = 1;
    }

    public override void LevelUp()
    {
        stats.stl += 10;
        stats.hp += 50;

        pointsToSpend -= 15;
    }
}