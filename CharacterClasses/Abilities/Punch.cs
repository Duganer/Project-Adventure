using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Punch : Ability
    {
        public Punch()
        {
            Name = "Punch";
            FlavorText = "Just curl up your fist and hit the enemy as hard as you can";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
