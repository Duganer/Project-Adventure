using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Kick : Ability
    {
        public Kick()
        {
            Name = "Kick";
            FlavorText = "Think of a punch but with your leg. That works right? I think it does.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 2;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 2;
        }
    }
}
