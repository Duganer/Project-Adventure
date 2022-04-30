using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Starfall : Ability
    {
        public Starfall()
        {
            Name = "Starfall";
            FlavorText = "That shooting star is getting offly close to the enemies face.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 10;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
