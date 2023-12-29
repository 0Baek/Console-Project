using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day_project
{
    class Monster:Common 
    {

        protected MonsterType type = MonsterType.None;

        protected Monster(MonsterType type):base(CommonType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetMonsterType() { return type; }


    }
    class Neko:Monster
    {
        public Neko() : base(MonsterType.Neko)
        {
            Setinfo(80,10,0,80,100,100);
        }
    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            Setinfo(100,15,0,100,100,100);
        }
    }
    class Snail: Monster
    {
        public Snail() : base(MonsterType.Snail)
        {
            Setinfo(110,10,0,110,100,100);
        }
    }
    //중급 
    class MushMom:Monster
    {
        public MushMom() : base(MonsterType.MushMom)
        {
            Setinfo(1000,80,0,400,300,300);
        }
    }
    class Golem : Monster 
    { 
        public Golem() : base(MonsterType.Golem)
        {
            Setinfo(1500,100,0,1500,400,400);
        }

    }
    class Yeti : Monster
    {
        public Yeti() : base(MonsterType.Yeti)
        {
            Setinfo(2000,200,0,2000,500,500);
        }
    }
    //상급
    class Balrog:Monster
    {
        public Balrog() : base(MonsterType.Balrog)
        {
            Setinfo(5000, 300,0,5000,1000,1000);
        }
    }
    class Magnon : Monster
    {
        public Magnon() : base(MonsterType.Magnon)
        {
            Setinfo(8000, 500, 0,8000,1500,1500);
        }
    }
    class PinkBean : Monster
    {
        public PinkBean() : base(MonsterType.PinkBean)
        {
            Setinfo(10000, 1000,0, 10000,3000,3000);
        }
    }
    class Baron:Monster
    {
        public Baron() : base(MonsterType.Baron)
        {
            Setinfo(9999999, 999999999, 0, 9999999, 100000,9999);
        }
    }


}
