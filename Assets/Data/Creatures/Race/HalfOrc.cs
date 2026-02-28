namespace Data.Creatures
{
    public class HalfOrc : Creature
    {
        #region Constructor

        public HalfOrc(string name, Stats stats, int speed, int maxHitPoints) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 30; // Base speed for all half-orcs
            _size = SizeType.Medium; // All half-orcs are Medium size
        }

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);

            if (statType == Stats.StatType.Strength)
            {
                baseValue += 2; // All half-orcs get +2 Strength
            }
            else if (statType == Stats.StatType.Constitution)
            {
                baseValue += 1; // All half-orcs get +1 Constitution
            }

            return baseValue;
        }

        #endregion
    }
}