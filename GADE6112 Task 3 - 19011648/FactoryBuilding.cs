using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_3___19011648
{
    class FactoryBuilding : Building
    {
        private int unitType;
        private int productSpeed;
        private int spawnPoint;
        public bool IsDead { get; set; }
        public int PosX
        {
            get { return bPosX; }
            set { bPosX = value; }
        }
        public int PosY
        {
            get { return bPosY; }
            set { bPosY = value; }
        }
        public int Health
        {
            get { return bHealth; }
            set { bHealth = value; }
        }
        public int MaxHealth
        {
            get { return bHealthMax; }
        }
        public int Faction
        {
            get { return bFaction; }
        }
        public string Symbol
        {
            get { return bSym; }
        }
        public int ProductSpeed
        {
            get { return productSpeed; }
            set { productSpeed = value; }
        }

        public FactoryBuilding(int x, int y, int ut, int h, int ps, int f, string sy)
        {
            PosX = x;
            PosY = y;
            unitType = ut;
            ProductSpeed = ps;
            Health = h;
            bHealthMax = h;
            bFaction = f;
            bSym = sy;
            if (PosY <= 18)
                spawnPoint = PosY + 1;
            else if (PosY > 18)
                spawnPoint = PosY - 1;
        }


        public override void DieDie()
        {
            bSym = "X/X";
            IsDead = true;
        }
        public override string ToString()
        {
            string temp = "";
            temp += "Unit: " + unitType;
            temp += "\nEfficiency: " + ProductSpeed + " turns";
            temp += "\n{" + Symbol + "}";
            temp += "\n(" + PosX + "," + PosY + "), ";
            temp += "\nHeatlth: " + Health + "\n";
            temp += IsDead ? "DESTROYED!" : "FUNCTIONING!";
            return temp;
        }
        public Unit Spawn()
        {
            if (unitType == 0)
            {
                RangedUnit r = new RangedUnit(PosX, spawnPoint, "archer", 100, 1, 20, 5, Faction, "R");
                return r;
            }
            else
            {
                MeleeUnit m = new MeleeUnit(PosX, spawnPoint, "soldier", 100, 1, 20, Faction, "M");
                return m;
            }
        }
        public override bool IsDie()
        {
            return IsDead;
        }
        public override int FactionCheck()
        {
            return Faction;
        }
    }
}
