using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Charge2 : Ability
    {
        public Charge2()
        {
            Name = "Charge";
            FlavorText = "Slam through an enemy giving them no chance to defend";
            ModifiedStat = StatEnum.PhysicalAttack;
            Modifier = 5;
            impactedTurns = 0;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
