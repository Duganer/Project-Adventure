using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Protect : Ability
    {
        public Protect()
        {
            Name = "Protect";
            FlavorText = "Raises a teamamtes defenses to help in battle. Increases Defenses";
            ModifiedStat = StatEnum.Defense;
            Modifier = 3;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
