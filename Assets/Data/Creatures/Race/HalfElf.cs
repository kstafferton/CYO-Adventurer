namespace Data.Creatures
{
    public class HalfElf : Creature
    {
        #region Fields

        private Stats.StatType _statBonus1;
        private Stats.StatType _statBonus2;

        #endregion

        #region Constructor

        public HalfElf(string name, Stats stats, int speed, int maxHitPoints, Stats.StatType statBonus1, Stats.StatType statBonus2) : base(name, stats, speed, maxHitPoints)
        {
            if (statBonus1 == Stats.StatType.Charisma || statBonus2 == Stats.StatType.Charisma)
            {
                throw new System.ArgumentException("Ability score bonuses cannot be applied to Charisma (already +2)");
            }

            _statBonus1 = statBonus1;
            _statBonus2 = statBonus2;
            _speed = 30; // Base speed for all half-elves
            _size = SizeType.Medium; // All half-elves are Medium size
        }

        #endregion

        #region Methods

        public override int GetStat(Stats.StatType statType)
        {
            int baseValue = base.GetStat(statType);
            if (statType == Stats.StatType.Charisma)
            {
                baseValue += 2; // All half-elves get +2 Charisma
            }
            if (statType == _statBonus1 || statType == _statBonus2)
            {
                return baseValue + 1; // Half-elves get +1 to two chosen ability scores
            }
            return baseValue;
        }

        #endregion
    }
}
