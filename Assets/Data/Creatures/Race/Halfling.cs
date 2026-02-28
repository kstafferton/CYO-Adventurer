namespace Data.Creatures
{
    public class Halfling : Creature
    {
        #region Enums

        public enum SubraceType
        {
            Unspecified,
            Lightfoot,
            Stout,
            Ghostwise // Not used in this implementation, but included for completeness
        }

        #endregion

        #region Fields

        protected SubraceType _subrace = SubraceType.Unspecified;

        #endregion

        #region Constructor

        public Halfling(string name, Stats stats, int speed, int maxHitPoints, SubraceType subrace) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 25; // Base speed for all halflings
            _size = SizeType.Small; // All halflings are Small size
            _subrace = subrace;
        }

        #endregion

        #region Properties

        public SubraceType _Subrace => _subrace;

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);

            if (statType == Stats.StatType.Dexterity)
            {
                baseValue += 2; // All halflings get +2 Dexterity
            }

            switch (_subrace)
            {
                case SubraceType.Lightfoot:
                    if (statType == Stats.StatType.Charisma)
                    {
                        return baseValue + 1;
                    }
                    break;
                case SubraceType.Stout:
                    if (statType == Stats.StatType.Constitution)
                    {
                        return baseValue + 1;
                    }
                    break;
            }
            return baseValue;
        }

        #endregion
    }
}
