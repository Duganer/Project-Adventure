using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Melody : Ability
    {
        public Melody()
        {
            Name = "Melody";
            FlavorText = "Play your favorite tune and damage your enemies ears. Lowers magic attacks";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
