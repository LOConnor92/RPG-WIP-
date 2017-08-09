public class WarriorClass : BaseClass
{
    // Initial values for the warrior class
    public WarriorClass()
    {
        // Warrior is balanced, but not stealthy
        stats.hp = 100;
        stats.str = 15;
        stats.def = 15;
        stats.stl = 5;

        // Thesewill always be 0, 1, 1 to start.
        stats.exp = 0;
        stats.expToNext = 1;
        stats.lvl = 1;
    }

    public override void LevelUp()
    {
        stats.str += 5;
        stats.def += 5;
        stats.hp += 50;

        pointsToSpend -= 15;
    }
}