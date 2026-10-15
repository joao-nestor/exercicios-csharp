namespace RPG_com_POO;

public class Character
{
    public string characName = string.Empty;
    public int characHp = 100;

    public int Attack()
    {
        int damage = Random.Shared.Next(16, 20);
        return damage;
    }

    public void TakeDamage(int damage)
    {
        characHp -= damage;
    }
}