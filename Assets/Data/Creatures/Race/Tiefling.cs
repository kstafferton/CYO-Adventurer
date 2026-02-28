namespace Data.Creatures
{
    public class Tiefling : Creature
    {
        #region Constructor

        public Tiefling(string name, Stats stats, int speed, int maxHitPoints) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 30; // Base speed for all tieflings
            _size = SizeType.Medium; // All tieflings are Medium size
        }

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);

            if (statType == Stats.StatType.Intelligence)
            {
                baseValue += 1; // All tieflings get +1 Intelligence
            }
            else if (statType == Stats.StatType.Charisma)
            {
                baseValue += 2; // All tieflings get +2 Charisma
            }

            return baseValue;
        }

        #endregion
    }
}