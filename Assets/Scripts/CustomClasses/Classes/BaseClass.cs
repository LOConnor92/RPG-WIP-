using UnityEngine;

public abstract class BaseClass
{
    // The current stats and how much we improve per level
    public Stats stats = new Stats();
    protected Stats improveBy = new Stats();

    // Used when we level up to add to stats
    public int pointsToSpend;

    // How many points we get per level
    protected const int pointsPerLevel = 20;

    // ctor
    public BaseClass() { }

    public abstract void LevelUp();

    public int GenerateDamage(int weapon, int skillLevel)
    {
        // Generate damage

        // strength + weapon strength = base strength
        // skill level * 1-1.5 = damage modifier
        // base strength * damage modifier = damage
        float damage = stats.str + weapon;
        damage *= Random.Range(1f, 1.5f) * Random.Range(0f, skillLevel);

        // Convert float to int. Adding 0.5 will make the damage round correctly
        damage += 0.5f;

        return (int)damage;
    }

    // Adds exp (should be called on enemy killed
    public void AddExp(int exp)
    {
        stats.exp += exp;

        while (stats.exp > stats.expToNext)
        {
            pointsToSpend += pointsPerLevel;
            LevelUp();
        }
    }
}