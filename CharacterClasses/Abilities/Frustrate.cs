using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class Frustrate : Ability
    {
        public Frustrate()
        {
            Name = "Frustrate";
            FlavorText = "Trash talk and get in an enemies head. Decreases attacks.";
            ModifiedStat = StatEnum.Attack;
            Modifier = 5;
            impactedTurns = 2;
            UseOnEnemy = true;
            ManaCost = 3;
        }
    }
}
