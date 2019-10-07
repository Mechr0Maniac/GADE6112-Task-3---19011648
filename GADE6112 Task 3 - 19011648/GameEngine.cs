using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace GADE6112_Task_3___19011648
{
    [Serializable]
    public class GameEngine
    {
        BinaryFormatter format = new BinaryFormatter();
        Map map;
        private int round;
        Random r = new Random();
        GroupBox grpMap;

        string SAVE_GAME = "save.dat";

        public int Round
        {
            get { return round; }
        }

        public GameEngine(int numUnits, int numBuilds, TextBox txtInfo, GroupBox gMap, int mapWidth, int mapHeight)
        {
            grpMap = gMap;
            map = new Map(numUnits, numBuilds, txtInfo, mapWidth, mapHeight);
            map.Generate();
            map.Display(grpMap);
            round = 1;
        }

        public void Update()
        {
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)map.Units[i];
                    if (mu.Health <= mu.MaxHealth * 0.25)
                    {
                        mu.Move(r.Next(0, 4));
                    }
                    else
                    {
                        (Unit closest, int distanceTo) = mu.Closest(map.Units);
                        if (distanceTo <= mu.AttackRange)
                        {
                            mu.IsAttacking = true;
                            mu.Combat(closest);
                        }
                        else
                        {
                            if (closest is MeleeUnit)
                            {
                                MeleeUnit closestMu = (MeleeUnit)closest;
                                if (mu.XPos > closestMu.XPos)
                                {
                                    mu.Move(0);
                                }
                                else if (mu.YPos < closestMu.YPos)
                                {
                                    mu.Move(1);
                                }
                                else if (mu.XPos < closestMu.XPos)
                                {
                                    mu.Move(2);
                                }
                                else if (mu.YPos > closestMu.YPos)
                                {
                                    mu.Move(3);
                                }
                            }
                            else if (closest is RangedUnit)
                            {
                                RangedUnit closestRu = (RangedUnit)closest;
                                if (mu.XPos > closestRu.XPos)
                                {
                                    mu.Move(0);
                                }
                                else if (mu.YPos < closestRu.YPos)
                                {
                                    mu.Move(1);
                                }
                                else if (mu.XPos < closestRu.XPos)
                                {
                                    mu.Move(2);
                                }
                                else if (mu.YPos > closestRu.YPos)
                                {
                                    mu.Move(3);
                                }
                            }
                        }

                    }
                }
                else if (map.Units[i] is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)map.Units[i];
                    (Unit closest, int distanceTo) = ru.Closest(map.Units);
                    if (distanceTo <= ru.AttackRange)
                    {
                        ru.IsAttacking = true;
                        ru.Combat(closest);
                    }
                    else
                    {
                        if (closest is MeleeUnit)
                        {
                            MeleeUnit closestMu = (MeleeUnit)closest;
                            if (ru.XPos > closestMu.XPos)
                            {
                                ru.Move(0);
                            }
                            else if (ru.YPos < closestMu.YPos)
                            {
                                ru.Move(1);
                            }
                            else if (ru.XPos < closestMu.XPos)
                            {
                                ru.Move(2);
                            }
                            else if (ru.YPos > closestMu.YPos)
                            {
                                ru.Move(3);
                            }
                        }
                        else if (closest is RangedUnit)
                        {
                            RangedUnit closestRu = (RangedUnit)closest;
                            if (ru.XPos > closestRu.XPos)
                            {
                                ru.Move(0);
                            }
                            else if (ru.YPos < closestRu.YPos)
                            {
                                ru.Move(1);
                            }
                            else if (ru.XPos < closestRu.XPos)
                            {
                                ru.Move(2);
                            }
                            else if (ru.YPos > closestRu.YPos)
                            {
                                ru.Move(3);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < map.Builds.Count; i++)
            {
                if (map.Builds[i] is ResourceBuilding)
                {
                    ResourceBuilding rb = (ResourceBuilding)map.Builds[i];
                    rb.Generator();
                }
                else
                {
                    FactoryBuilding fb = (FactoryBuilding)map.Builds[i];
                    if (fb.ProductSpeed >= 7)
                    {
                        map.Units.Add(fb.Spawn());
                        fb.ProductSpeed = 0;
                    }
                    fb.ProductSpeed++;
                }
            }
            map.Display(grpMap);
            round++;
        }

        public int DistanceTo(Unit a, Unit b)
        {
            int distance = 0;

            if (a is MeleeUnit && b is MeleeUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangedUnit && b is MeleeUnit)
            {
                RangedUnit start = (RangedUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangedUnit && b is RangedUnit)
            {
                RangedUnit start = (RangedUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is MeleeUnit && b is RangedUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            return distance;
        }
        public void Save()
        {
            FileStream save = new FileStream(SAVE_GAME, FileMode.Create, FileAccess.Write);
            using (save)
            {
                format.Serialize(save, map);
            }
            save.Close();
        }
        public void Load()
        {
            FileStream load = new FileStream(SAVE_GAME, FileMode.Open, FileAccess.Read);
            format.Deserialize(load);
        }
    }
}
