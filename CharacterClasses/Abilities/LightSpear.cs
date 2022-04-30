using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class LightSpear : Ability
    {
        public LightSpear()
        {
            Name = "Light Spear";
            FlavorText = "Create a spear of light and chuck it at an enemy.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
