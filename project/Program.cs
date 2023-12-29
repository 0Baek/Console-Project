using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum job  //직업 
{
    None=0,
    knight,
    Archer,
    Mage,
    thief
}
enum MonsterType //몬스터 종류
{
    None=0,
    Neko,
    Slime,
    Snail, //하급
    MushMom,
    Golem,
    Yeti, //중급
    Balrog,
    Magnon,
    PinkBean,//상급
    Baron//보스
}
 enum CommonType //공통
{
    None=0,
    Player,
    Monster
}
 enum GameMode // 선택지
{
    None,
    Lobby,
    Town,
    Field,
    Smith,
    Start,
    Home,
    Ending,
    Help

}
namespace _3day_project

{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.process();
            
            }

        }
    }
}
