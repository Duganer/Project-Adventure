using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Random : Ability
    {
        public Random()
        {
            var random = new System.Random();
            Name = "Random";
            FlavorText = "Put your odds in probabilty.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = random.Next(-5, 20);
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = random.Next(5, 10);
        }
    }
}
