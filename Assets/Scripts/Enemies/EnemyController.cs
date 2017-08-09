using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int hp;
    public int exp;
    public int strength;
    public int defense;

    public void DoDamage(int attack)
    {
        // Damage softened by defense * 1-1.5. Add 0.5 to round correctly when converted to int
        float damage = attack - (defense * Random.Range(1f, 1.5f));
        damage += 0.5f;
        attack = (int)damage;

        // Do damage
        hp -= attack;

        if (hp <= 0)
            Die();
    }

    void Die()
    {
        // Death animation

        FindObjectOfType<PlayerController>().AddExp(exp);
    }
}