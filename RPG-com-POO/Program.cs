namespace RPG_com_POO;

public class Program
{
    public static void Main()
    {
        Character player = new Character();
        Character enemy = new Character();

        Console.WriteLine("==========RPG SIMPLES==========");
        Console.WriteLine("Digite o nome do seu jogador:");
        string playerName = Console.ReadLine();

        player.characName = playerName;

        Console.WriteLine("Digite o nome do inimigo:");
        string enemyName = Console.ReadLine();

        enemy.characName = enemyName;
        
        Console.WriteLine();
        Console.WriteLine("----------O RPG COMEÇOU!----------");

        while (player.characHp > 0 && enemy.characHp > 0)
        {
            int playerDamage = player.Attack();
            int enemyDamage = enemy.Attack();
            
            bool enemyAttack = Random.Shared.Next(0, 2) == 1;

            if (enemyAttack)
            {
                if (player.characHp <= enemyDamage)
                {
                    player.characHp = 0;
                    Console.WriteLine($"{player.characName} perdeu!\n");
                }
                else
                {
                    Console.WriteLine($"{player.characName} recebeu {enemyDamage} de dano!\n");
                    player.TakeDamage(enemyDamage);
                    Console.WriteLine($"Vida de {player.characName}: {player.characHp}");
                    Console.WriteLine($"Vida de {enemy.characName}: {enemy.characHp}\n");
                }
            }
            else
            {
                if (enemy.characHp <= playerDamage)
                {
                    enemy.characHp = 0;
                    Console.WriteLine($"{enemy.characName} perdeu para {player.characName}!\n");
                }
                else
                {
                    Console.WriteLine($"{enemy.characName} recebeu {playerDamage} de dano!\n");
                    enemy.TakeDamage(playerDamage);
                    Console.WriteLine($"Vida de {player.characName}: {player.characHp}");
                    Console.WriteLine($"Vida de {enemy.characName}: {enemy.characHp}\n");
                }
            }
        }

        Console.WriteLine($"Vida de {player.characName}: {player.characHp}");
        Console.WriteLine($"Vida de {enemy.characName}: {enemy.characHp}\n");
        Console.WriteLine("----------FIM DE JOGO!----------");
        Console.WriteLine("===============================");
    }
}