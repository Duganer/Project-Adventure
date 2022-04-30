using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Block : Ability
    {
        public Block()
        {
            Name = "Block";
            FlavorText = "Fighter Prepares Shield to stop next attack. Increases defenses.";
            ModifiedStat = StatEnum.Defense;
            Modifier = 3;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
