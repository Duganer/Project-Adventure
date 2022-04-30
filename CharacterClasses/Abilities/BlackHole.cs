using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class BlackHole : Ability
    {
        public BlackHole()
        {
            Name = "Black Hole";
            FlavorText = "Create the science to warp space and time sucking your enemy in.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 5;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
