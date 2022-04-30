using ProjectAdventure.CharacterClasses.Common;

namespace ProjectAdventure.CharacterClasses.Abilities
{
    public class ProgramOffense : Ability
    {
        public ProgramOffense()
        {
            var random = new System.Random();
            Name = "Program";
            FlavorText = "Feeling lucky today? Increases attack.";
            ModifiedStat = StatEnum.Attack;
            Modifier = random.Next(-5, 10);
            impactedTurns = 2;
            UseOnEnemy = true;
            ManaCost = random.Next(3, 7);
        }
    }
}
