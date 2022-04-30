using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Trap : Ability
    {
        public Trap()
        {
            Name = "Trap";
            FlavorText = "Increase your defenses by put down objects to protect you. Increase defenses.";
            ModifiedStat = StatEnum.Defense;
            Modifier = 2;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 1;
        }
    }
}
