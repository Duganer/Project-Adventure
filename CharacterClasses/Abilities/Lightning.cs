using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Lightning : Ability
    {
        public Lightning()
        {
            Name = "Lightning";
            FlavorText = "Smite your opponent into a pile of ash.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
