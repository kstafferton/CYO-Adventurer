using UnityEngine;

namespace Data.Creatures
{
    public struct Stats
    {
        public enum StatType
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }

        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _intelligence;
        private int _wisdom;
        private int _charisma;

        public int Strength => _strength;
        public int Dexterity => _dexterity;
        public int Constitution => _constitution;
        public int Intelligence => _intelligence;
        public int Wisdom => _wisdom;
        public int Charisma => _charisma;

        public Stats(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            _strength = Mathf.Clamp(strength, 1, 20);
            _dexterity = Mathf.Clamp(dexterity, 1, 20);
            _constitution = Mathf.Clamp(constitution, 1, 20);
            _intelligence = Mathf.Clamp(intelligence, 1, 20);
            _wisdom = Mathf.Clamp(wisdom, 1, 20);
            _charisma = Mathf.Clamp(charisma, 1, 20);
        }

        public int AdjustedStat(StatType statType, int value)
        {
            int newValue = 10;
            switch (statType)
            {
                case StatType.Strength:
                    newValue = Mathf.Clamp(_strength + value, 1, 20); // Ensure stat stays between 1 and 20
                    break;
                case StatType.Dexterity:
                    newValue = Mathf.Clamp(_strength + value, 1, 20); // Ensure stat stays bewtween 1 and 20
                    break;
                case StatType.Constitution:
                    newValue = Mathf.Clamp(_constitution + value, 1, 20); // Ensure stat stays between 1 and 20
                    break;
                case StatType.Intelligence:
                    newValue = Mathf.Clamp(_intelligence + value, 1, 20); // Ensure stat stays between 1 and 20
                    break;
                case StatType.Wisdom:
                    newValue = Mathf.Clamp(_wisdom + value, 1, 20); // Ensure stat stays between 1 and 20
                    break;
                case StatType.Charisma:
                    newValue = Mathf.Clamp(_charisma + value, 1, 20); // Ensure stat stays between 1 and 20
                    break;
            }
            return newValue;
        }
    }
}
