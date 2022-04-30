using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class TimeBomb : Ability
    {
        public TimeBomb()
        {
            Name = "Time Bomb";
            FlavorText = "Tick. Tick. Boom!";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 5;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
