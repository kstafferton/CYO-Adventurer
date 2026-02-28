namespace Data.Creatures
{
    public class Gnome : Creature
    {
        #region Enums

        public enum SubraceType
        {
            Unspecified,
            ForestGnome,
            RockGnome,
            DeepGnome // Not used in this implementation, but included for completeness
        }

        #endregion

        #region Fields

        protected SubraceType _subrace = SubraceType.Unspecified;

        #endregion

        #region Constructor

        public Gnome(string name, Stats stats, int speed, int maxHitPoints, SubraceType subraceType) : base(name, stats, speed, maxHitPoints)
        {
            _speed = 25; // Base speed for all gnomes
            _size = SizeType.Small; // All gnomes are Small size
            _subrace = subraceType;
        }

        #endregion

        #region Properties

        public SubraceType Subrace => _subrace;

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);

            if (statType == Stats.StatType.Intelligence)
            {
                baseValue += 2; // All gnomes get +2 Intelligence
            }

            switch (_subrace)
            {
                case SubraceType.ForestGnome:
                    if (statType == Stats.StatType.Dexterity)
                    {
                        return baseValue + 1; // Forest gnomes get +1 Dexterity
                    }
                    break;
                case SubraceType.RockGnome:
                    if (statType == Stats.StatType.Constitution)
                    {
                        return baseValue + 1; // Rock gnomes get +1 Constitution
                    }
                    break;
            }
            return baseValue; // Other stats are unchanged
        }

        #endregion
    }
}
