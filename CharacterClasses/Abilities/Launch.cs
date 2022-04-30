using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Lunge : Ability
    {
        public Lunge()
        {
            Name = "Lunge";
            FlavorText = "Perfectly stride to stab the opponent with your spear.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 5;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
