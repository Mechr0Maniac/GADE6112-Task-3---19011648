using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_3___19011648
{
    public class RangedUnit : Unit
    {
        public bool IsDead { get; set; }

        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Faction
        {
            get { return faction; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public bool IsAttacking
        {
            get { return isAttacking; }
            set { isAttacking = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public RangedUnit(int x, int y, string n, int h, int s, int a, int ar, int f, string sy)
        {
            XPos = x;
            YPos = y;
            name = n;
            Health = h;
            maxHealth = h;
            Speed = s;
            Attack = a;
            AttackRange = ar;
            faction = f;
            Symbol = sy;
            IsAttacking = false;
            IsDead = false;
        }

        public override void Death()
        {
            symbol = "X";
            IsDead = true;
        }

        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0:
                    YPos--;
                    break;
                case 1:
                    XPos++;
                    break;
                case 2:
                    YPos++;
                    break;
                case 3:
                    XPos--;
                    break;
                default: break;
            }
        }

        public override void Combat(Unit attacker)
        {
            if (attacker is MeleeUnit)
            {
                Health = Health - ((MeleeUnit)attacker).Attack;
            }
            else if (attacker is RangedUnit)
            {
                RangedUnit ru = (RangedUnit)attacker;
                Health = Health - (ru.Attack - ru.AttackRange);
            }

            if (Health <= 0)
            {
                Death();
            }
        }

        public override bool InRange(Unit other)
        {
            int distance;
            int otherX = 0;
            int otherY = 0;
            if (other is MeleeUnit)
            {
                otherX = ((MeleeUnit)other).XPos;
                otherY = ((MeleeUnit)other).YPos;
            }
            else if (other is RangedUnit)
            {
                otherX = ((RangedUnit)other).XPos;
                otherY = ((RangedUnit)other).YPos;
            }

            distance = Math.Abs(XPos - otherX) + Math.Abs(YPos - otherY);
            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override (Unit, int) Closest(List<Unit> units)
        {
            int shortest = 100;
            Unit closest = this;
            foreach (Unit u in units)
            {
                if (u is MeleeUnit && u != this)
                {
                    MeleeUnit otherMu = (MeleeUnit)u;
                    int distance = Math.Abs(XPos - otherMu.XPos)
                               + Math.Abs(YPos - otherMu.YPos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherMu;
                    }
                }
                else if (u is RangedUnit && u != this)
                {
                    RangedUnit otherRu = (RangedUnit)u;
                    int distance = Math.Abs(XPos - otherRu.XPos)
                               + Math.Abs(YPos - otherRu.YPos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherRu;
                    }
                }

            }
            return (closest, shortest);
        }

        public override string ToString()
        {
            string temp = "";
            temp += "Ranged: ";
            temp += Name;
            temp += "{" + Symbol + "}";
            temp += "(" + XPos + "," + YPos + ") ";
            temp += Health + ", " + Attack + ", " + AttackRange + ", " + Speed;
            temp += (IsDead ? " DEAD!" : " ALIVE!");
            return temp;
        }

        public override bool AliveNt()
        {
            return IsDead;
        }
        public override int FactionCheck()
        {
            return Faction;
        }
    }
}
