namespace Data.Creatures
{
    public class Human : Creature
    {
        #region Constructor

        public Human(string name, Stats stats, int speed, int maxHitPoints) : base(name, stats, speed, maxHitPoints) 
        { 
            _speed = 30; // Base speed for all humans
            _size = SizeType.Medium; // All humans are Medium size
        }

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);
            return baseValue + 1; // All humans get +1 to all stats
        }

        #endregion


    }
}