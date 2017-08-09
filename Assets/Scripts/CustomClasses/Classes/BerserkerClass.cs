public class BerserkerClass : BaseClass
{
    // Initial values for the warrior class
    public BerserkerClass()
    {
        // Berserker focuses on strength
        stats.hp = 100;
        stats.str = 25;
        stats.def = 5;
        stats.stl = 5;

        // Thesewill always be 0, 1, 1 to start.
        stats.exp = 0;
        stats.expToNext = 1;
        stats.lvl = 1;
    }

    public override void LevelUp()
    {
        stats.str += 10;
        stats.hp += 50;

        pointsToSpend -= 15;
    }
}