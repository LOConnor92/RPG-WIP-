/* Staffs will replace magic in game.
 * They have 4 possible outcomes
 * Projectile shot
 * Area shot
 * Heal player
 * Heal area
 */
public abstract class StaffBase : Holdable
{
    // How strong the spell is
    public int power;

    // How long before we can cast this spell again
    public float timeBetweenMagic;

    // The spell logic
    public abstract void Magic();
}