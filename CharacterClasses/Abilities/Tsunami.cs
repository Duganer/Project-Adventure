using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Tsunami : Ability
    {
        public Tsunami()
        {
            Name = "Tsunami";
            FlavorText = "A giant wave crashes followed by series of more waves crashing into you.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
