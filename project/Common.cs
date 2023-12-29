using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day_project
{
    class Common
    {
        CommonType type;
        protected int HP = 0;
        protected int MAXHP = 0;
        protected int Att = 0;
        protected int Mexp = 0;
        protected int Weapon = 0;
        protected int gold = 0;
       

        protected Common(CommonType type)
        {
            this.type = type;
        }
        public void Setinfo(int HP, int Att, int Weapon, int MAXHP, int Mexp,int gold)
        {
            this.HP = HP;
            this.Att = Att;
            this.Weapon = Weapon;
            this.MAXHP = MAXHP;
            this.Mexp = Mexp;
            this.gold = gold;
          
        }

        public int GetHP() { return HP; }
        public int GetAtt() { return Att; }
        public int GetWeapon() { return Weapon; }
        public int GetMAXHP() { return MAXHP; }
        public int GetMexp() { return Mexp; }
        public int Getgold() { return gold; }

        
        public bool IsDead() { return HP <= 0; }

        public void OnDMG(int DMG)
        {
            HP -= DMG;
            if (HP < 0)
                HP = 0;

        }
        public void OnSkill(int SKill)
        {
       
                  HP -= SKill;

                    if (HP < 0)
                        HP = 0;
  
        }
        public void Heal(int Heal)
        {
            HP = Heal;

        }
        public void Gold(int Gold)
        {
            gold = Gold;

        }

    }
} 

