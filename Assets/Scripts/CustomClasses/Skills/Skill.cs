public class Skill
{
    // The current skill level
    public int skillLevel;

    // How much exp we have and how much we need to level up
    protected int skillExp;
    protected int skillToNextLevel;

    // The max level of skills (capping to 100
    private const int maxLevel = 100;

    //ctor, sets initial skill level up
    public Skill()
    {
        skillToNextLevel = 10;
    }

    // Adds to the skill. Should be called every time you attack, even if you pass 0
    public void AddSkill(int increaseBy = 1)
    {
        // If we're at the level cap, exit function
        if (skillLevel == maxLevel)
            return;

        // Add the exp to current exp
        skillExp += increaseBy;

        // While loop in case of multiple level ups (early character coming across late character etc)
        while (skillExp >= skillToNextLevel && skillLevel < maxLevel)
        {
            // Add one to skill level
            skillLevel++;

            // Work out next skill exp needed
            skillToNextLevel += skillLevel * skillLevel* skillLevel;
        }
    }
}