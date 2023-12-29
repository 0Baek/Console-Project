using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _3day_project
{
    class Player:Common
    {
        
        protected job job = job.None;
        protected int Exp = 0;
        protected int Level = 0;
        protected int Skill = 0;

        protected Player(job job):base(CommonType.Player)
        {
            this.job = job;
        }
        public void Setinfo2(int Exp, int Level)
        {
            this.Exp = Exp;
            this.Level = Level;
        }
        public void Skillset(int Skill)
        {
            this.Skill = Skill;
           
        }
        public void XP(int XP)
        {

            Exp = XP;
            while (true)
            {
                if (XP == (1000* Level)/2)
                {

                    Setinfo( HP, Att+5, Weapon, MAXHP + 100, Mexp,gold);
                    Setinfo(HP = MAXHP, Att, Weapon, MAXHP, Mexp, gold);
                    Setinfo2(Exp, Level + 1);
                    Skillset(Skill + 200);
                    
                    Console.Clear();
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#~!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-  :@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@###@@@$-    :#@###@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@#####@=,      ~$####@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@:.   ,-*#@@@@@@@######$*!,        -!=$@#####@@@@@@@$!-.   .;@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@*~:~:~::=@@@####$$$$: -.          -..*$$$$####@@@!:~~:~:~#@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@!!!***!;@@@#$$$$=~. ,.            ,. .;==$$$####,!*!*!!:@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@;!***:.;##@#$==!,  ,.              ,,  -*==$$$##,.;***!:@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@#:!;,  .:~:$#@$!.  -                 .,  .*$$$$::-.  -;!~@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@#----. .~.   :$$$.  ~                   .,  -$##-   ,-  ,---:@@@@@@@=");
                    Console.WriteLine("        -@@@@@@*~--~:~:-     ,:!,  -                     .-  :!-.    .~::;~-~:*@@@@@=");
                    Console.WriteLine("        -@@@@@#~;!**!:,  ,.  .,- .,                       .- .~,.  ,,  -:!**!;:#@@@@=");
                    Console.WriteLine("        -@@@@@$:$=*!-  ,;~-.  . .~......              ......~. .  .-:;.  ~!*==~#@@@@=");
                    Console.WriteLine("        -@@@@@@~,.   .;;;;~,    . ;$==*;             .!===$. ..  .-~;;;;.   .,-@@@@@=");
                    Console.WriteLine("        -@@@@@@*;. -:!;;;;~  ~*=! ;$$=*!             -*==$$. !*!-  :;;;!;:- ,:$@@@@@=");
                    Console.WriteLine("        -@@@@@@#;*!!!!;;;,  :!*;~ ;$===*.            ~*==$$  -;**;  -;;;!!!!*!@@@@@@=");
                    Console.WriteLine("        -@@@@@@@;**!!;;-  .~::,-. ,#===*-            ;*==$*  .,,!;:.  ~;!!!**!@@@@@@=");
                    Console.WriteLine("        -@@@@@@@$,-,.    ;;;~. .   !$==*;            *==$$,  ., -:;!:    .--,#@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@=:,,.:*$$==- ,-   .$$==*           .*=$$:   .-, ;====!~.,,;=@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@##$$$$$$* !~,.  .*$==.          ~=$$;   .,:= *$#$$$$#####@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@#####$$$$=!;,!!!-   .;*$-          !*=-.  .~:!=.!!*#@@@#####@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@###$$$=**!:  !;      ;-     . ~===, .-      ,~!**=$$##@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@##$$==**;  ~;  ,,. -  . .,. -~, , ,-    , .!**==$$##@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@###$$==! ..-. ..- , ,. ..- ,   - -~..   .:===$$###@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@###$##*.,;;,.;;;- .:-.:;:.~::,: ~; ,..!$$$$$$###@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@##*-,,--,,,;;-;*:,,-~-,,~$=;,.:!~-=$@######@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@####$====*****$=$$*!!!!!!*$$$$***===$$#@@@###@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@##@####$$$$$##$$$=******=@$$$$$$$$$####@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$                                            #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$             현재 레벨  : +1  {Level}             #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$          MAX 체력 증가 : +50 {MAXHP}           $@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$        Att 공격력 증가 : +5  {Att}         #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$  Skill 스킬 데미지 증가: +100 {Skill}         $@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$                                            #@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$      :-     ~::::,:~   :, ~::::.~~         #@@@@@@@@@@@@@@@=");
                    Console.WriteLine("                              #!    :=====~#=  .#~:$====,==                          ");
                    Console.WriteLine("                              #!    ##$$   #=  .#~$#$$   ==                          ");
                    Console.WriteLine("                              #!    #=~~   ~=*,=:.$#~~   ==                          ");
                    Console.WriteLine("                              #####::==$$$: ~*#:  ~$$==$,=####!                      ");
                    Console.WriteLine("                              .....  .....   ..    ..... ......                      ");
                    Console.WriteLine("                                                                                     ");
                    Console.WriteLine("                              ...         ...  .............                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,,,,,,,,,..                         ");
                    Console.WriteLine("                              ....        ,,,  .,,,.......,.                         ");
                    Console.WriteLine("                              ..,.        ,,,  .,,.        ....                      ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.        .,,.                      ");
                    Console.WriteLine("                              .,,.        ,,,  .,.,,,,,,,.,.                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,,,,,,,,,,.                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.   ..                             ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.                                  ");
                    Console.WriteLine("                              ...............  .,,.                                  ");
                    Console.WriteLine("                                 .,,,,,,,,     .,,.                                  ");
                    Console.WriteLine("                                 .........     ....                                  ");
                    Thread.Sleep(1000);

                    Setinfo2(0, Level);
                }
                else if (XP >= (1000 * Level)/2)
                {
                    Setinfo(HP, Att + 5, Weapon, MAXHP + 100, Mexp, gold);
                    Setinfo(HP = MAXHP, Att, Weapon, MAXHP, Mexp, gold);
                    Setinfo2(Exp, Level + 1);
                    Skillset(Skill + 200);
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#~!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-  :@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@@###@@@$-    :#@###@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@@@@@@@@@@#####@=,      ~$####@@@@@@@@@@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@:.   ,-*#@@@@@@@######$*!,        -!=$@#####@@@@@@@$!-.   .;@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@*~:~:~::=@@@####$$$$: -.          -..*$$$$####@@@!:~~:~:~#@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@!!!***!;@@@#$$$$=~. ,.            ,. .;==$$$####,!*!*!!:@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@;!***:.;##@#$==!,  ,.              ,,  -*==$$$##,.;***!:@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@#:!;,  .:~:$#@$!.  -                 .,  .*$$$$::-.  -;!~@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@#----. .~.   :$$$.  ~                   .,  -$##-   ,-  ,---:@@@@@@@=");
                    Console.WriteLine("        -@@@@@@*~--~:~:-     ,:!,  -                     .-  :!-.    .~::;~-~:*@@@@@=");
                    Console.WriteLine("        -@@@@@#~;!**!:,  ,.  .,- .,                       .- .~,.  ,,  -:!**!;:#@@@@=");
                    Console.WriteLine("        -@@@@@$:$=*!-  ,;~-.  . .~......              ......~. .  .-:;.  ~!*==~#@@@@=");
                    Console.WriteLine("        -@@@@@@~,.   .;;;;~,    . ;$==*;             .!===$. ..  .-~;;;;.   .,-@@@@@=");
                    Console.WriteLine("        -@@@@@@*;. -:!;;;;~  ~*=! ;$$=*!             -*==$$. !*!-  :;;;!;:- ,:$@@@@@=");
                    Console.WriteLine("        -@@@@@@#;*!!!!;;;,  :!*;~ ;$===*.            ~*==$$  -;**;  -;;;!!!!*!@@@@@@=");
                    Console.WriteLine("        -@@@@@@@;**!!;;-  .~::,-. ,#===*-            ;*==$*  .,,!;:.  ~;!!!**!@@@@@@=");
                    Console.WriteLine("        -@@@@@@@$,-,.    ;;;~. .   !$==*;            *==$$,  ., -:;!:    .--,#@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@=:,,.:*$$==- ,-   .$$==*           .*=$$:   .-, ;====!~.,,;=@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@##$$$$$$* !~,.  .*$==.          ~=$$;   .,:= *$#$$$$#####@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@#####$$$$=!;,!!!-   .;*$-          !*=-.  .~:!=.!!*#@@@#####@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@###$$$=**!:  !;      ;-     . ~===, .-      ,~!**=$$##@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@##$$==**;  ~;  ,,. -  . .,. -~, , ,-    , .!**==$$##@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@###$$==! ..-. ..- , ,. ..- ,   - -~..   .:===$$###@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@###$##*.,;;,.;;;- .:-.:;:.~::,: ~; ,..!$$$$$$###@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@@##*-,,--,,,;;-;*:,,-~-,,~$=;,.:!~-=$@######@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@####$====*****$=$$*!!!!!!*$$$$***===$$#@@@###@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@@@@##@####$$$$$##$$$=******=@$$$$$$$$$####@@@@@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$                                            #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$             현재 레벨  : +1  {Level}             #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$          MAX 체력 증가 : +50 {MAXHP}           $@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$        Att 공격력 증가 : +5  {Att}         #@@@@@@@@@@@@@@@=");
                    Console.WriteLine($"        -@@@@@@@@@@@@@@$  Skill 스킬 데미지 증가: +100 {Skill}         $@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$                                            #@@@@@@@@@@@@@@@=");
                    Console.WriteLine("        -@@@@@@@@@@@@@@$      :-     ~::::,:~   :, ~::::.~~         #@@@@@@@@@@@@@@@=");
                    Console.WriteLine("                              #!    :=====~#=  .#~:$====,==                          ");
                    Console.WriteLine("                              #!    ##$$   #=  .#~$#$$   ==                          ");
                    Console.WriteLine("                              #!    #=~~   ~=*,=:.$#~~   ==                          ");
                    Console.WriteLine("                              #####::==$$$: ~*#:  ~$$==$,=####!                      ");
                    Console.WriteLine("                              .....  .....   ..    ..... ......                      ");
                    Console.WriteLine("                                                                                     ");
                    Console.WriteLine("                              ...         ...  .............                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,,,,,,,,,..                         ");
                    Console.WriteLine("                              ....        ,,,  .,,,.......,.                         ");
                    Console.WriteLine("                              ..,.        ,,,  .,,.        ....                      ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.        .,,.                      ");
                    Console.WriteLine("                              .,,.        ,,,  .,.,,,,,,,.,.                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,,,,,,,,,,.                         ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.   ..                             ");
                    Console.WriteLine("                              .,,.        ,,,  .,,.                                  ");
                    Console.WriteLine("                              ...............  .,,.                                  ");
                    Console.WriteLine("                                 .,,,,,,,,     .,,.                                  ");
                    Console.WriteLine("                                 .........     ....                                  ");
                    Thread.Sleep(1000);

                    Setinfo2(0, Level);
                }
               
             
                break;




                

            }
          
        }



        public job Getjob() { return job; }
        public int GetExp() { return Exp; }

        public int GetLevel() { return Level; }
        public int GetSkill() { return Skill; }
    


    }
    class knight : Player
    {
        public knight() : base(job.knight)
        {
            Setinfo(10000,1000,10,10000,0,0);
            Setinfo2(0, 1);
            Skillset(5000);
        }

        
    }
    class Archer : Player
    {
        public Archer() : base(job.Archer)
        {
            Setinfo(75,15,10,75,0,0);
            Setinfo2(0, 1);
            Skillset(5000);
        }
    }
    class Mage : Player
    {
        public Mage() : base(job.Mage)
        {
            Setinfo(50,20,10,50,0,0);
            Setinfo2(0, 1);
            Skillset(5000);
        }
    }
    class thief : Player
    {
        public thief() : base(job.thief)
        {
            Setinfo(60,15,15,60,0,0);
            Setinfo2(0, 1);
            Skillset(5000);
        }
    }

}
