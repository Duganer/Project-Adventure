using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Dash : Ability
    {
        public Dash()
        {
            Name = "Dash";
            FlavorText = "Run really fast. Increases speed.";
            ModifiedStat = StatEnum.Speed;
            Modifier = 3;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 1;
        }
    }
}
