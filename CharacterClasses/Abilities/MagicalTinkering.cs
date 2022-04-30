using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class MagicalTinkering : Ability
    {
        public MagicalTinkering()
        {
            Name = "Magical Tinkering";
            FlavorText = "Invent a way to make your abilities better. Increases magical attacks";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
