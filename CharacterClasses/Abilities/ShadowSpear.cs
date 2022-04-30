using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class ShadowSpear : Ability
    {
        public ShadowSpear()
        {
            Name = "Shadow Spear";
            FlavorText = "Create a spear of shadow and chuck it at an enemy.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 12;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 5;
        }
    }
}
