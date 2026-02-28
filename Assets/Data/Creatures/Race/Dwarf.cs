namespace Data.Creatures
{
    public class Dwarf : Creature
    {
        #region Constants

        public enum SubraceType
        {
            Unspecified,
            MountainDwarf,
            HillDwarf,
            Duergar // Not used in this implementation, but included for completeness
        }

        #endregion

        #region Fields
        
        protected SubraceType _subrace = SubraceType.Unspecified;

        #endregion

        #region Constructor

        public Dwarf(string name, Stats stats, int speed, int maxHitPoints, SubraceType subrace ) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 25; // Base speed for all dwarves
            _size = SizeType.Medium; // All dwarves are Medium size
            _subrace = subrace;
        }

        #endregion

        #region Properties

        public SubraceType Subrace => _subrace;

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);

            if (statType == Stats.StatType.Constitution)
            {
                baseValue += 2; // All dwarves get +2 Constitution
            }

            switch (Subrace)
            {
                case SubraceType.MountainDwarf:
                    if (statType == Stats.StatType.Strength)
                    {
                        return baseValue + 2; // Mountain dwarves get +2 Strength
                    }
                    break;
                case SubraceType.HillDwarf:
                    if (statType == Stats.StatType.Wisdom)
                    {
                        return baseValue + 1; // Hill dwarves get +1 Wisdom
                    }
                    break;
            }
            return baseValue;  // Other stats are unchanged
        }

        #endregion
    }
}
