using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRPG
{
    public enum ClassType
    {
        Athlete, Brainiac, Clown, NewStudent, Prodigy
    }

    public class Character
    {
        public string Name;
        public ClassType Class;

        public int MaxHp;
        public int Hp;
        public int Attack;
        public int Defense;
        public int Wits;
        public int Stress;
        public int MaxStress;
        public int MentalStrength;

        public bool IsStunned = false;
        public bool PassiveTriggered = false;
        public bool IsDefending = false;

        private Random rand = new Random();

        public Character(string name, ClassType classType)
        {
            Name = name;
            Class = classType;
            SetupStatsByClass(classType);
        }

        private void SetupStatsByClass(ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Athlete:
                    MaxHp = 100; Attack = 10; Defense = 9; Wits = 1; MaxStress = 20; MentalStrength = 5;
                    break;
                case ClassType.Brainiac:
                    MaxHp = 80; Attack = 3; Defense = 4; Wits = 9; MaxStress = 20; MentalStrength = 10;
                    break;
                case ClassType.Clown:
                    MaxHp = 90; Attack = 7; Defense = 6; Wits = 5; MaxStress = 15; MentalStrength = 7;
                    break;
                case ClassType.NewStudent:
                    MaxHp = 85; Attack = 4; Defense = 4; Wits = 4; MaxStress = 15; MentalStrength = 9;
                    break;
                case ClassType.Prodigy:
                    MaxHp = 80; Attack = 15; Defense = 15; Wits = 8; MaxStress = 10; MentalStrength = 5;
                    break;
            }
            Hp = MaxHp;
        }

        public bool TryResistTaunt()
        {
            return rand.Next(100) < (MentalStrength * 2);
        }

        public void AttackTarget(Character target)
        {
            bool doubleDamage = false;

            // Prodigy passive chance
            if (Class == ClassType.Prodigy && rand.Next(100) < 10)
            {
                doubleDamage = true;
            }

            int baseDamage = doubleDamage ? Attack * 2 : Attack;
            int defenseMultiplier = target.IsDefending ? target.Defense * 2 : target.Defense;
            int damage = Math.Max(baseDamage - defenseMultiplier * 3, 0);
            target.Hp = Math.Max(0, target.Hp - damage);
        }

        public void Taunt(Character target)
        {
            if (target.TryResistTaunt()) return;

            int stressAdded = Wits;

            if (Class == ClassType.Prodigy && rand.Next(100) < 10)
                stressAdded *= 2;

            target.Stress += stressAdded;

            if (target.Stress >= target.MaxStress)
            {
                target.Stress = 0;
                target.IsStunned = true;
                target.Defense = 0;

                if (target.Class == ClassType.Athlete && !target.PassiveTriggered)
                {
                    target.PassiveTriggered = true;
                    target.IsStunned = true;
                }

                if (Class == ClassType.Brainiac)
                    target.Stress -= target.MaxStress / 5; // Reduce 20% from opponent
            }
        }

        public void Defend()
        {
            IsDefending = true;
        }

        public void ApplyPassiveEffects()
        {
            if (Class == ClassType.NewStudent)
            {
                Hp = Math.Min(Hp + 5, MaxHp);
                Attack += 1;
                Defense += 1;
                Wits += 1;
            }

            if (Class == ClassType.Clown)
            {
                Stress = Math.Max(0, Stress - 3);

                if (rand.Next(100) < 10) // 10% stun
                    IsStunned = true;
            }

            if (Class == ClassType.Athlete && PassiveTriggered)
            {
                Attack *= 2;
            }
        }

        public void EndTurnReset()
        {
            IsDefending = false;
            if (IsStunned)
                IsStunned = false;
            ApplyPassiveEffects();
        }

        public bool IsAlive => Hp > 0;
    }
}