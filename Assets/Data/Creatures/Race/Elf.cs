namespace Data.Creatures
{
    public class Elf : Creature
    {
        #region Enums

        public enum SubraceType
        {
            Unspecified,
            HighElf,
            WoodElf,
            Drow
        }

        #endregion

        #region Fields

        protected SubraceType _subrace = SubraceType.Unspecified;

        #endregion

        #region Constructor

        public Elf(string name, Stats stats, int speed, int maxHitPoints, SubraceType subrace) : base(name, stats, speed, maxHitPoints) 
        {
            _speed = 30; // Base speed for all elves
            _size = SizeType.Medium; // All elves are Medium size
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

            if (statType == Stats.StatType.Dexterity)
            {
                baseValue += 2; // All elves get +2 Dexterity
            }

            switch (_subrace)
            {
                case SubraceType.HighElf:
                    if (statType == Stats.StatType.Intelligence)
                    {
                        return baseValue + 1;
                    }
                    break;
                case SubraceType.WoodElf:
                    if (statType == Stats.StatType.Wisdom)
                    {
                        return baseValue + 1;
                    }
                    break;
                case SubraceType.Drow:
                    if (statType == Stats.StatType.Charisma)
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
    

