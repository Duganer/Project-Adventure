using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    class Encourage : Ability
    {
        public Encourage()
        {
            Name = "Encourage";
            FlavorText = "Inspire a teammate and increase their strengths. Increases attacks";
            ModifiedStat = StatEnum.Attack;
            Modifier = 3;
            impactedTurns = 2;
            UseOnEnemy = false;
            ManaCost = 2;
        }
    }
}
