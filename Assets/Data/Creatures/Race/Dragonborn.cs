namespace Data.Creatures
{
    public class Dragonborn : Creature
    {
        #region Constructor

        public Dragonborn(string name, Stats stats, int speed, int maxHitPoints) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 30; // Base speed for all dragonborn
            _size = SizeType.Medium; // All dragonborn are Medium size
        }

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);
            if (statType == Stats.StatType.Strength)
            {
                return baseValue + 2; // All dragonborn get +2 Strength
            }
            else if (statType == Stats.StatType.Charisma)
            {
                return baseValue + 1; // All dragonborn get +1 Charisma
            }
            return baseValue; // Other stats are unchanged
        }

        #endregion
    }
}
