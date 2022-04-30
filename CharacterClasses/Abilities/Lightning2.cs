using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Lightning2 : Ability
    {
        public Lightning2()
        {
            Name = "Lightning";
            FlavorText = "The air fills with sparks and single strike hits an enemy.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 6;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
