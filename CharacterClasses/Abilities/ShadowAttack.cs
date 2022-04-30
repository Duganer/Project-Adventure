using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class ShadowAttack : Ability
    {
        public ShadowAttack()
        {
            Name = "Shadow Attack";
            FlavorText = "Leap from the darkness to attack an opponent.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 5;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 4;
        }
    }
}
