using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class VocalSolo : Ability
    {
        public VocalSolo()
        {
            Name = "Vocal Solo";
            FlavorText = "An elegant song is heard. Raises Attack.";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 10;
            impactedTurns = 3;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
