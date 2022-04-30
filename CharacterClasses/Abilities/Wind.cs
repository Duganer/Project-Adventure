using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Wind : Ability
    {
        public Wind()
        {
            Name = "Wind";
            FlavorText = "Summon a slight breeze and try to blow them over.";
            ModifiedStat = StatEnum.MagicAttack;
            Modifier = 3;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
