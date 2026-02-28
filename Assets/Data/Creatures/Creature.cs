namespace Data.Creatures
{
    public abstract class Creature
    {
        #region Enums

        public enum SizeType
        {
            Unknown,
            Tiny,
            Small,
            Medium,
            Large,
            Huge,
            Gargantuan
        }

        public enum AlignmentType
        {
            Unaligned,
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            TrueNeutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil
        }

        #endregion

        #region Fields

        protected string _name;

        protected Stats _stats;

        protected int _speed;

        protected int _maxHitPoints;
        protected int _hitPoints;

        protected AlignmentType _alignment;

        protected SizeType _size;

        #endregion

        #region Properties
        public string Name => _name;

        public virtual int ArmorClass => 10 + (_stats.Dexterity - 10) / 2;

        public int Speed => _speed;

        public int MaxHitPoints => _maxHitPoints;

        public AlignmentType Alignment => _alignment;

        public SizeType Size => _size;

        #endregion

        #region Constructor
        protected Creature(string name, Stats stats, int speed, int maxHitPoints)
        {
            _name = name;
            _stats = stats;
            _speed = speed;
            _hitPoints = _maxHitPoints = maxHitPoints;
        }

        ~Creature()
        {
            // Cleanup code if needed
        }

        #endregion

        #region Methods

        public virtual int GetStat(Stats.StatType statType)
        {
            switch (statType)
            {
                case Stats.StatType.Strength:
                    return _stats.Strength;
                case Stats.StatType.Dexterity:
                    return _stats.Dexterity;
                case Stats.StatType.Constitution:
                    return _stats.Constitution;
                case Stats.StatType.Intelligence:
                    return _stats.Intelligence;
                case Stats.StatType.Wisdom:
                    return _stats.Wisdom;
                case Stats.StatType.Charisma:
                    return _stats.Charisma;
                default:
                    throw new System.ArgumentException("Invalid stat type");
            }
        }

        public virtual void SetStatsFromDiceRolls(int strengthRoll, int dexterityRoll, int constitutionRoll, int intelligenceRoll, int wisdomRoll, int charismaRoll)
        {
            _stats = new Stats(strengthRoll, dexterityRoll, constitutionRoll, intelligenceRoll, wisdomRoll, charismaRoll);
        }

        public virtual void TakeDamage(int damage)
        {
            _hitPoints -= damage;
            if (_hitPoints < 0)
            {
                _hitPoints = 0;
            }
        }

        public virtual void Heal(int amount)
        {
            _hitPoints += amount;
            if (_hitPoints > _maxHitPoints)
            {
                _hitPoints = _maxHitPoints;
            }
        }

        public virtual int CalculateInitiative(int roll)
        {
            return roll + (_stats.Dexterity - 10) / 2;
        }

        #endregion
    }
}