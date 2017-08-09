public class PacifistClass : BaseClass
{
    // Initial values for the warrior class
    public PacifistClass()
    {
        // Pacifist focuses on defense
        stats.hp = 100;
        stats.str = 5;
        stats.def = 25;
        stats.stl = 5;

        // Thesewill always be 0, 1, 1 to start.
        stats.exp = 0;
        stats.expToNext = 1;
        stats.lvl = 1;
    }

    public override void LevelUp()
    {
        stats.def += 10;
        stats.hp += 50;

        pointsToSpend -= 15;
    }
}