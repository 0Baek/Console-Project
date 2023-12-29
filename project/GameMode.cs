using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace _3day_project
{
    class Game
    {
        private GameMode mode = GameMode.Start;
        private Player player = null;
        private Monster monster = null;
        private Random rand = new Random();
        int Exp;
        int DMG;
        int Skill;
        int Gold;
        SoundPlayer _player = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\die\\DED.wav"); //죽는 소리
        SoundPlayer _player2 = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\Att\\Att.wav"); //어택
        SoundPlayer _player3 = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\GG\\GG.wav"); //보스등장
        SoundPlayer _player4 = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\plus\\plus.wav"); //강화성공
        SoundPlayer _player5 = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\failure\\failure.wav"); //강화실패
        SoundPlayer _player6 = new SoundPlayer("C:\\Users\\KGA\\Desktop\\project\\Music\\openthedoor\\openthedoor.wav");//입장
        public void process()
        {
            switch (mode)
            {
                case GameMode.Start:
                    ProcessStart();
                    break;
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
                case GameMode.Smith:
                    ProcessSmith();
                    break;
                case GameMode.Home:
                    ProcessHome();
                    break;
                case GameMode.Ending:
                    ProcessEnding();
                    break;
                case GameMode.Help:
                    ProcessHelp();
                    break;


            }
        }
        private void ProcessStart()
        {
            bool visible = true;
            bool Exit = false; // 1을 눌렀을 때 종료 플래그

            while (true)
            {
                Console.Clear();

                if (visible)
                {
                    // 깜빡이는 화면의 내용을 출력합니다.
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("           ~:::::::, .::~::::::: ,::::   ~@@#   ;;         *@@@@@@@       @     @       ");
                    Console.WriteLine("           =@@@$@@@@:,@@=@@@@@@@.~@@@@  ;=  .@  ;;        *!.....$    ,,,,,,,  @        ");
                    Console.WriteLine("           *@@@=@@@@  @@=@@@@@@@ -@@@@  @    !; ;;        *;     $     !#@#*   @        ");
                    Console.WriteLine("           *@@@!@@@   @@=@@@@@@@ .@@@@  @    !; ;;         *;     $    :*   #.==@       ");
                    Console.WriteLine("           *@@@:@@@  @@@::*@@@;;  @@@@  !!  -#  ;;        *;     $    !;   $.  @        ");
                    Console.WriteLine("           *@@@.#@@  @@@  :@@@.   @@@@   *$#=,  ;;        ;==$@===     =#!@=   @        ");
                    Console.WriteLine("           *@@@ !@@@@@@@  :@@@    @@@@          ;;           ,@                         ");
                    Console.WriteLine("           *@@@ ~@#~@@@=  :@@@    @@@$          ;;           ,@         !@@@@@@@        ");
                    Console.WriteLine("           *@@@ ,@# .@@!  :@@@  :~@@@$ $$$$$$$$*;;           ,@         *      @        ");
                    Console.WriteLine("           ;@@@ .@#   :;  :@@@  ;@@@@; ,-,..    ;;       ~~~~~~~~~~~    *      @        ");
                    Console.WriteLine("           ,~~~  ~~    .  .~~~  -;;;.           ;;       ~~~~~~~~~~~    *******@        ");
                    Console.WriteLine("                                                -                                       ");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@#####@@@@@@@@@@@@@*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@#@@@@@$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@        ~:::::~-@@;-:~:::::::::::::::::::~~::---$---:-::::~::::::::~:~:@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@##@@@#!!!!!!!!!=;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!:!!!!!!!!!!!!!!!!!!!!!;,~*$@@@@@@@@@");
                    Console.WriteLine("@$$$#@$$$$$##@#@#@@@@@@@@@#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#=!;~=@@@@@@@@");
                    Console.WriteLine("#@@@@#@@@@@@#@@@#@@@@#@@@@@@@@@@  @@=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#@@@@@@@@@#!@:-;#@@@@");
                    Console.WriteLine("#####@####@##@@@#@@@@@#@@@@@@@@@   @@=~=@!!@~.,@@:..#@=..=@@..!@@..: @@@@@@@@@@@@@@*~$=!~@@@@");
                    Console.WriteLine("##$$$#@@$#@@#@@@#@@@@@@@:;@!@;@@.=@$.=~-@,;!,@-~=-@=,# -~;@.$@-@-~@     @@@@@@@@@@@@@@@#*~#@@");
                    Console.WriteLine("##$=##                    ;#$$*;@.=#                                   #################$!;@@");
                    Console.WriteLine("###$@##$$#@###@@#@@@@@@@$;       =@-:@~-@,;;,@-~=.#!,# *@~@.!@.@-~@  @@@@@@@@@@@@@@@@@@$!;@@@");
                    Console.WriteLine("#@###@@##@@##@#@#@@@@@@@@@@@@@@@    @@@;:!@==@#!#;:-.@#::$@@::=@!@@=@@@#@@@@@@@@@@@@#=!~!@@@@");
                    Console.WriteLine("##@@@@@@@@@@@@@@#@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#@@@@@@@@#*!;~~@@@@@@");
                    Console.WriteLine("@@###########@@@#$$$$=**$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$!$$$$!!$$$$=!;~:*$@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@       ::::#~::::::::::::::~::::::::::::::::::::::::::::~#::::~*:::::~:@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@######*$$$$@#$$$$$$$$$$$$$=#=$$$$$$$$$$$$$$$$$$$$$$$$$$$$@$$$=#@=$$$$@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@#@@@@@#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@               1.게임시작                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                    // 이하 생략...
                }

                visible = !visible;

                Thread.Sleep(350);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1)
                    {
                        // 1을 누르면 다음 단계로 넘어가기 위해 플래그를 설정합니다.
                        Exit = true;
                    }
                 
                }

                if (Exit)
                {
                    // 1이 눌렸을 때 다음 단계로 넘어가는 코드를 추가합니다.
                    Console.Clear();

                    // 원하는 다음 단계의 코드를 여기에 추가합니다.
                    // 예: mode = GameMode.Lobby;
                    mode = GameMode.Help;

                    break; // 무한 루프를 종료합니다.
                }
            }

        }
        private void ProcessLobby()
        {
            Console.Clear();
            Console.WriteLine("   ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ  ");
            Console.WriteLine("  |                  -~                      |                                           |");
            Console.WriteLine("  |           .     ,-~,     .::,            |                   ,-                      |");
            Console.WriteLine("  |           ;     ,!;-~~:~                 |                  -,..                     |");
            Console.WriteLine("  |                 ;*;::.                   |                  .~~,                     |");
            Console.WriteLine("  |            --:!=$=:!;.      1.검사       |                  :-~:      2.궁수         |");
            Console.WriteLine("  |        .:,$*!;:*!:-~;*,                  |                 *$==-;                    |");
            Console.WriteLine("  |       **!; ! #:-:-!#**~      HP: 100     |                 :*#$*-~      HP: 75       |");
            Console.WriteLine("  |       .~**!;!=::,,~=;~,     Att: 10      |                 ,*===*-     Att: 15       |");
            Console.WriteLine("  |         .-!:=#*:-,~*=~:.  Skill:일격필살 |                 !=*#!!~   SKill:스나이핑  |");
            Console.WriteLine("  |            -=$:;:~!* :;-                 |               .$=$:#$=,                   |");
            Console.WriteLine("  |               ;!;=** ;,-                 |               ,#$$=$:=                    |");
            Console.WriteLine("  |              ,;:-;** ;..                 |                : =$=:~                    |");
            Console.WriteLine("  |              ,*=#!*=* ,.                 |                :-$$-#=                    |");
            Console.WriteLine("  |              ;##$**==$:~                 |    ,,;          =#:===,                   |");
            Console.WriteLine("  |              *==$$:!$;--                 |      ,;         !$;!$!=-                  |");
            Console.WriteLine("  |             ,!$*$$##*!:-                 |        ;~.$---!$=*#=***   -!:!            |");
            Console.WriteLine("  |            . $=$=$$$$*=                  |          :;*!*@@###$!*=;..!,              |");
            Console.WriteLine("  |              $=$=$$$$.                   |             ;*$#@##=$==!:;.               |");
            Console.WriteLine("  |              !##$=$$$,                   |            :!$#==*$=#$#!                  |");
            Console.WriteLine("  |              !$$;~$*#                    |            -==# .,~~**=!                  |");
            Console.WriteLine("  |              ;;!; ;:;.                   |             !$#,     $*==                 |");
            Console.WriteLine("  |              ~;#! ;~~;                   |             ;$$: .   ,=*$=                |");
            Console.WriteLine("  |              ,;;, -;-:                   |              ==  ;     .#=,               |");
            Console.WriteLine("  |              .!*.  !::                   |              ==         .$=               |");
            Console.WriteLine("  |               :$   ,;-                   |              ##          -=;              |");
            Console.WriteLine("  |              .~=   .:.                   |            .:##$          $$.             |");
            Console.WriteLine("  |              ,~!   .:~                   |            !$$!!          *$:             |");
            Console.WriteLine("  |            .,:.    .,~                   |               ..          ...             |");
            Console.WriteLine("  |                    .--                   |                                           |");
            Console.WriteLine("  |                      --                  |                                           |");
            Console.WriteLine("  |                                    직업을|선택하세요                                 |");
            Console.WriteLine("  |ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ  |");
            Console.WriteLine("  |                   ..,                    |              ..,                          |");
            Console.WriteLine("  |                   -!                     |            :*$!$$#$                       |");
            Console.WriteLine("  |                   ~!;        3.마법사    |          =##~,. ~          4.도적         |");
            Console.WriteLine("  |                   ;!!                    |          .!::,.~-,                        |");
            Console.WriteLine("  |          --       :;!*--~~,    HP: 50    |          ;;,:-,~:-~-        HP: 60        |");
            Console.WriteLine("  |         !::.    ..:;;!*==*:   Att: 20    |             -:;;!;;!,      Att: 15        |");
            Console.WriteLine("  |        -; !   *===*;;~;*:   Skill:메테오 |              $$$=$$*;#*  Skill:심장추적자 |");
            Console.WriteLine("  |         !;     ... ~,-;:                 |            !$$==###$;$#$=!                |");
            Console.WriteLine("  |         .:  .  .., ;--*:;-               |          .=$##$=####!**=#@##*;            |");
            Console.WriteLine("  |         ,; . ,,-;-~:,,;!!;,              |           -$##@#$#@$ !*;;======*  *       |");
            Console.WriteLine("  |          !  ,-, =$~~~~!::~:              |            =$@@#$##$  -:~~:~   :  ;       |");
            Console.WriteLine("  |          -~  ~  .$;;~~~:~:~.             |            =#$@###,:=~.                   |");
            Console.WriteLine("  |          -;      ==~~-~~~~.,.            |            #$*$$$$==:  ~  .~.             |");
            Console.WriteLine("  |          .:,    .;=;:~~~::!,-            |           :,=*=~:#$*.   --;,              |");
            Console.WriteLine("  |          .;~,;:-:;!$!::~:!;-,.,          |          .!!*#!!*#$##!  -:~.              |");
            Console.WriteLine("  |          .~.~:::;;;*=:;;!!;--~           |          -!$##~!$*!!!;~~:-                |");
            Console.WriteLine("  |           .!!;;:~**;;**!*!;;!;~          |          #*$=#@@ *@####$                  |");
            Console.WriteLine("  |            *~;:~;~;;::::!;;!!;!;;~,      |          !$###$   ,$####$                 |");
            Console.WriteLine("  |            ;.~ :.:::!;:!~;;!*;;!;;;;;    |          ,####!     =####-                |");
            Console.WriteLine("  |             :  .~::;;;;::;!!;;!!!;;;!.   |           ##$!         ,###*~             |");
            Console.WriteLine("  |              ,,-~::::;::;:::;!;!;;~*!.   |          =###              :##,           |");
            Console.WriteLine("  |              ~-~~:::::;:;;:::;!!!;       |           ##;                ~#=  .       |");
            Console.WriteLine("  |              ,-~::;::;:::;:::;;!:-       |           ##~                 #$$         |");
            Console.WriteLine("  |              ~-~:::::;;:::;:::;;.        |           ##:                  ##         |");
            Console.WriteLine("  |             ,-~~:::::;;:::;;::::         |          .##!                 :@ @        |");
            Console.WriteLine("  |             *!,~:::::;;;:::!:~~          |          ,###                ,@@@         |");
            Console.WriteLine("  |           ,;!!~,.,~:~~~:::~~;!!:.        |        =@@@-               ,,,,           |");
            Console.WriteLine("   ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    player = new knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
                case "4":
                    player = new thief();
                    mode = GameMode.Town;
                    break;
            }

        }
        private void ProcessTown()
        {

            Console.Clear();
            Console.WriteLine("    |ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ | ");
            Console.WriteLine("    |              1.던전                    |                2.대장간                | ");
            Console.WriteLine("    |                                        |                                        | ");
            Console.WriteLine("    |               -~!=!~,                  |                                        | ");
            Console.WriteLine("    |            .$@@@@@@@@@$                |                                        | ");
            Console.WriteLine("    |           =@@;  .@   !@@;              |                                        | ");
            Console.WriteLine("    |          @@@@.  .@   ;@#@#             |                                        | ");
            Console.WriteLine("    |         @@  @@;@@@@@*@* ,@#            |                                        | ");
            Console.WriteLine("    |        *@.  -@@*...$@@.  -@;           |                              -=$       | ");
            Console.WriteLine("    |        @@@-~@=       $@,~@@@           |                          -!$###=.      | ");
            Console.WriteLine("    |       ~@.#@@$         @@@#.@.          |                       !$####*.         | ");
            Console.WriteLine("    |       #@  #@           @*  @;          |          ;##.    .:=###$*~             | ");
            Console.WriteLine("    |       @@. @:           *@ .@*          |          ,##: ~$####$~                 | ");
            Console.WriteLine("    |       @@@@@.   @= *@   ~@@@@*          |           #$$###=;,                    | ");
            Console.WriteLine("    |       @@ ;@    ~@@@:   ,@, @*          |          ~=##~.                        | ");
            Console.WriteLine("    |       @@,*@     @@@    ,@~,@*          |           ~##=                         | ");
            Console.WriteLine("    |       @@@@@  #@@@-@@@@ ,@@@@*          |            ###                         | ");
            Console.WriteLine("    |       @@ ;@  ,@@,  @@~ ,@, @*          |            -:,                         | ");
            Console.WriteLine("    |       @@ ;@  @@@@ @@@@ ,@, @*          |     ,.   ,;;;;;;;;;;-                  | ");
            Console.WriteLine("    |       @@@@@  ~       ~ ,@@@@*          |      *############*~.                  | ");
            Console.WriteLine("    |       @@,!@            ,@~,@*          |        ~=###$#$=.                      | ");
            Console.WriteLine("    |       @@ ;@            ,@, @*          |          .###*.                        | ");
            Console.WriteLine("    |     ,@@@@@@            ,@@@@@@         |           ###                          | ");
            Console.WriteLine("    |     @@===#@#############@$===@#        |          -###~                         | ");
            Console.WriteLine("    |     @$   ;@$$$$$$$$$$$$$@,   @@        |         ;#####*                        | ");
            Console.WriteLine("    |     @$   ;@            ,@,   @@        |                                        | ");
            Console.WriteLine("    |     @@@@@@@@@@@@@@@@@@@@@@@@@@=        |                                        | ");
            Console.WriteLine("    |      ---~~~~~-------~~~~~-----         |                                        | ");
            Console.WriteLine("    |                                        |                                        | ");
            Console.WriteLine("    |ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ | ");
            Console.WriteLine("    |                                        |                                        | ");
            Console.WriteLine("    |              3.휴식 (회복)             |            4.직업선택 다시하기         | ");
            Console.WriteLine("    |                                        |                                        | ");
            Console.WriteLine("    |                     ====               |                                        | ");
            Console.WriteLine("    |                 =@. #@@#               |                      ~                 | ");
            Console.WriteLine("    |               .@@@@!~@@=               |                     @@;                | ");
            Console.WriteLine("    |              *@@@#@@@~@=               |                    @@@@:               | ");
            Console.WriteLine("    |            ,@@@#.*~@@@=:               |                 =###@@@@!              | ");
            Console.WriteLine("    |           *@@@:=@@@-#@@@,              |              ;@@@@@@@@@@@!             | ");
            Console.WriteLine("    |         ,@@@#~@@@@@@#~@@@*             |             @@@@@@@@@@@@@.             | ");
            Console.WriteLine("    |        =@@@-$@@@@@@@@@-$@@@,           |           .@@@@@!~-;@@@@-              | ");
            Console.WriteLine("    |       @@@=-@@@@@@@@@@@@$.@@@,          |           @@@@~    @@@@                | ");
            Console.WriteLine("    |       #@-$@@@@@@@@@@@@@@@~=@.          |          ~@@@.      =@.                | ");
            Console.WriteLine("    |         @@@=****@@=****@@@.            |          @@@:                          | ");
            Console.WriteLine("    |         @@@~    @@-    @@@.            |          @@@                           | ");
            Console.WriteLine("    |         @@@=****@@=****@@@.            |         ,@@@                           | ");
            Console.WriteLine("    |         @@@@@@@@@@@@@@@@@@.            |         ~@@#            ~!!,           | ");
            Console.WriteLine("    |         @@@=****@@=*@**@@@.            |         .@@@            @@@.           | ");
            Console.WriteLine("    |         @@@-    @@- @  @@@.            |          @@@.           @@@.           | ");
            Console.WriteLine("    |         @@@-    @@=*@**@@@.            |          @@@=          =@@@            | ");
            Console.WriteLine("    |         @@@-    @@- @  @@@.            |          .@@@!        ~@@@;            | ");
            Console.WriteLine("    |         @@@-    @@@@@@@@@@.            |           =@@@$      =@@@@             | ");
            Console.WriteLine("    |         @@@-    @@@@@@@@@@.            |            @@@@@#**#@@@@@              | ");
            Console.WriteLine("    |       :@@@@@@@@@@@@@@@@@@@@@           |             =@@@@@@@@@@#               | ");
            Console.WriteLine("    |       .~~~~~~~~~~~~~~~~~~~~~           |              ,#@@@@@@@,                | ");
            Console.WriteLine("    |                                        |                  ,,                    | ");
            Console.WriteLine("    |ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ | ");
            string input = Console  .ReadLine();                                                              

            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Smith;
                    break;
                case "3":
                    mode = GameMode.Home;
                    break;
                case "4":
                    mode = GameMode.Lobby;
                    break;
            }
            Console.Clear();
        }
        private void ProcessField()
        {

            _player6.PlaySync();
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                             ☆★☆★던전에 입장했습니다★☆★☆                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine(" ==============================================================================================");
            Console.WriteLine("                                  1.하급 던전 들어가기                                                     ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                 '그냥 들어가 이새끼야'                                                    ");
            Console.WriteLine(" ==============================================================================================");
            Console.WriteLine("                                  2.중급 던전 들어가기                                                     ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                             '체력 1000 이상 공격력 500이상 추천'                                          ");
            Console.WriteLine(" ==============================================================================================");
            Console.WriteLine("                                  3.상급 던전 들어가기                                                     ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                            '체력 10000 이상 공격력 1000 이상 추천'                                        ");
            Console.WriteLine(" ==============================================================================================");
            Console.WriteLine("    Warning            Warning                       Warning                                               ");
            Console.WriteLine("                                  4.  ※※ 보    스 ※※                       Warning                     ");
            Console.WriteLine("                Warning                                                                                    ");
            Console.WriteLine("                                               Warning                                                     ");
            Console.WriteLine("Warning             Warning                                                    Warning                     ");


            string input = Console.ReadLine();
            switch (input)
            {
                case "1": ProcessDungeon1();
                    
                    break;
                case "2": ProcessDungeon2();
                  
                    break;
                case "3": ProcessDungeon3();
                   
                    break;
                case "4": ProcessVOSS();
                  
                    break;
            }

        }



        private void ProcessSmith()
        {







            Console.WriteLine(" ");
            
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"                     강화를 시도합니다.강화 1회비용 :500G // 보유 골드{player.Getgold()} ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("                       강화성공 무기 공격력 +10 | 강화 실패 무기 공격력 -10 ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("                                   1.무기강화 2.돌아가기");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int enhancementSuccess = EnhanceItem(player); // 강화 시도하고 결과를 받아옴
                    if (enhancementSuccess ==1)
                    {
                        Console.Clear();
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@~~-;@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@##=!@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@*:~#@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@@;=@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@@~*@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@$; @#                              ;@@@@@@@@@@@@@@#-,=@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@~,   @#                              ;@@@@@@@@@@@@@@!.,@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@#     !@#                              ;@@@@@@@@@@@@@$;;~:*@$@@@#@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@      #@#                              ;@@@@@@@@@@@@@@:$!~:-#@=#@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@:     .@@#                .             ;@@@@@@@@@@;!;$:;::~;;=@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@=      -@@#                -.            ;@@@@@@@@$*@=,,;~::-,#@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@=       :@@#               ,-..           ;@@@@@@@@#@~-~~: .~!-#@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@-      ~@@@#                ,,,           ;@@@@@@@@!=:!!::  ::~,$@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@.      -@@@@#                 ,~,          ;@@@@@@@@@@,#$:;;;:=$#*$@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@*      ~@@@@@#                 ,,.,.        ;@@@@@@@@@@:@=-.,:*$#@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@$      -@@@@@@#                  ,,,,.       ;@!!@@@@@@@=#!=;;!=#@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@.     -@@@@@@@#                   .,,,       ;@@::@@@@@@----,;*;@@@@@@@@@;@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@~     ~@@@@@@@@#                     -,.      ;@@#!=@@@@@@@@;~:*#@@@@@@@=!#@@@=  ");
                        Console.WriteLine("@@@@@@@@@@@@:     ,@@@@@@@@@#     ,,,,,,,,,-,,,,,,,,,      ;@@@;*#@@@@@@@;,; #@@@@@@@#$@~@@@= ");
                        Console.WriteLine("@@@@@@@#@@@$     ~@@@@@@@@@@#    .-,,,,,,,,,,----,,-,.     ;@@@@=#=@@@@@@;.- @@@@@@@@:@@@!#;= ");
                        Console.WriteLine("@@@@@@@;@@#     -@@@@@@@@@@@#     -,,,-,,,,,,,-,,,,,,,     ;@@@@!@=$@@@@@:-~ *@@@@@@!@@@@$-$= ");
                        Console.WriteLine("@@@@@@@ @@.    -@@@@@@@@@@@@#     .,,,-,,-,,-,,,.,-,-,     ;@@@@@@@=#@@@@!.- #@@@@@@!@@@**-@= ");
                        Console.WriteLine("@@@@@@@ ,:    ~@@@@@@@@@@@@@#                     ,-,,     ;@@@@@@@@@@@@@!.~ @@@@@#!@@@!@@$@= ");
                        Console.WriteLine("@@@@@@@;     ,@@@@@@@@@@@@@@#                   .-,,,      ;@@@@@@@@@@@@@!., @@@@@;@@@@@@@~@= ");
                        Console.WriteLine("@@@@@@@#   .~@@@@@@@@@@@@@@@#                  .-,,,       ;@@$@@@@@@@@@@!.: @@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@=~. .@@@@@@@@@@@@@@@@#                 .,,,.        ;@@=*@@@@@@@@@!-; @@@@@@@@@@@@@~#= ");
                        Console.WriteLine("@@@@@@@~-:  *@@@@@@@@@@@@@@@#               .,,-,,         ;@@=#$@@@@@@@@!-! @@@@@@@@@@@@:#== ");
                        Console.WriteLine("@@@@@#~:~$!  ;@@@@@@@@@@@@@@#              ,,-.-.          ;@@@:@@@@@@@@@;.: @@@@@@@$@@@*@@$= ");
                        Console.WriteLine("@@@@@~-~*@@@!-=@@@@@@@@@@@@@#             ,-,-,.           ;@@@@#@@@@@@@@; , @@@@@@#*-#*@@@;* ");
                        Console.WriteLine("@@@@::~!@@@@@@@@@@@@@@@@@@@@#             .-,.             ;@@@@@@@@@@@@@; , @@@@@@~@-$@@@@@* ");
                        Console.WriteLine("@@!!-~!@@@@@@@@@@@@@@@@@@@@@#              .               ;@@@@@@@@@@@@@;.- @@@@@*@@-@@@@@@= ");
                        Console.WriteLine("@! .-;@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@; ~ @@@@:@@@-@@@@@@= ");
                        Console.WriteLine("@@- -@@@@@@@@@@@@@@@@@@@@@@@#                              ;=$@@@~**@@@@@;.; @@@*#@@@@#=*~@@= ");
                        Console.WriteLine("@@#  @@@@@@@@@@@@@@@@@@@@@@@#                              ;#-@@@:@@:~@@@;.: @@@@@@@@@;@#*@@= ");
                        Console.WriteLine("@@@#$@@@@@@@@@@@@@@@@@@@@@@@#                              ;@=@@@#=@@@@@@;.$ @@@@@@@@@#$$@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@!@@@@*@@@@@@;.= @@@@@@@@@@*@$@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@:@@@@@:@@@@@;.; @@@@@@@@@@@@!@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@!@@@@$@@@@@;.* @@@@@@@@@@@=$@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@*@@@@@@@@@@;.= @@@@@@@@@@@;@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@!;- @@@@@@@@@!=@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@-=@@@@@@@@@@@@@@@=  ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@#                              ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                        Console.WriteLine("~===========================~                              ~================================; ");
                        _player4.PlaySync();
                        Console.WriteLine("강화에 성공했습니다!");
                        Console.WriteLine(" ");
                        Console.WriteLine($"현재 공격력: {player.GetWeapon()}");
                        Console.WriteLine(" ");
                    }
                    else if(enhancementSuccess == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("                        ,:~. ~ . ,.. .   , .               .,                           ");
                        Console.WriteLine("                        ..  . ..     .  -             .-   ..  ..                       ");
                        Console.WriteLine("                        .,  ,  .. . ~ ,   .            .       ,.                       ");
                        Console.WriteLine("                        .~..  :,    , ,.   ,---,      ,.   ,   .                        ");
                        Console.WriteLine("                         ,   !,-          ::-- ,-     ,    ,  .                         ");
                        Console.WriteLine("                             ~~,   .          ~, -.           .                         ");
                        Console.WriteLine("                            .~~~.              ,- -.  ..     ,                          ");
                        Console.WriteLine("                                                 : ~  ,.    ~                           ");
                        Console.WriteLine("                                                  ~.:.,     :                      .    ");
                        Console.WriteLine("                           .:           ..-!!:,   .-,~;     -,    ..,-,,,.,-.     ..  . ");
                        Console.WriteLine("                          ;-=          ...~$@@$*, ,--;;      :--~~,..,     .--    ., .. ");
                        Console.WriteLine("                          =~=~         .   !@@@@@~ ~,~;      ,.      ,~;;!;- ,-   ,- ...");
                        Console.WriteLine("                            *          ,,... -!$#@!.,--      .;-,,,~~       :-~-  ,- ...");
                        Console.WriteLine("                            :          .,.,,.. .~:*: -~,.    .~~;:-,,.       .-!  .- ..,");
                        Console.WriteLine("                                       ,          ., ,:..     ~......          :  .- ..,");
                        Console.WriteLine("                                       :.   --,,,.   .!-     .$@@@#!-.            ., ..,");
                        Console.WriteLine("                          -,          .-             ,       !$##@@@##$;-.         , ..,");
                        Console.WriteLine("                        ~,::          ,,             ,        .,~~~:$####=:.       . ..,");
                        Console.WriteLine("                        *~;!          ..            !        .-     ;,,;$#*;~,      ...,");
                        Console.WriteLine("                          -:                        .         .:,.  :,   .-  .-     .  ,");
                        Console.WriteLine("                          ,~                       ~          .  ,-, .-..     ,.    .  .");
                        Console.WriteLine("                           .          -            ,          ,          ,-  .,     .   ");
                        Console.WriteLine("                                      -           -,          ..          .,-           ");
                        Console.WriteLine("                            ,                     ,.           ,           ,-           ");
                        Console.WriteLine("                          ,,*                   --~            .           ~            ");
                        Console.WriteLine("                          *;$.                 ~=~              ..        ,-            ");
                        Console.WriteLine("                          ,,*.                ,!~*         ,              .             ");
                        Console.WriteLine($"현재 공격력: {player.GetWeapon()}             *                 -,$;,  -;,   ~              .             ");
                        Console.WriteLine("                            :        ~       -  .-~!!:--  .:              .             ");
                        Console.WriteLine("                               ..    ,      .~    ~,      ,;.            .,             ");
                        Console.WriteLine("                                *   -       !    .!,       .-            ..             ");
                        Console.WriteLine("                              *:$   -      ,    .,:~        ~             .             ");
                        Console.WriteLine("                              ;-$- ,       -                ;            ..             ");
                        Console.WriteLine("                              . =  .      ,,  .~;-          ..           .              ");
                        Console.WriteLine("                          -,.-, : .,      ,  -....!=*~-      ,           -              ");
                        Console.WriteLine("                          ~-.~, . -~     .~ *-;- ..   ,-.    -           ~              ");
                        Console.WriteLine("                          --.~, . ,~     ~ -,..,,*=;:~-,!-   ;           -              ");
                        Console.WriteLine("                          ,-.~,.        . ,~.~~~:~,:,,;.,~-  -          -               ");
                        Console.WriteLine("                          .,.~,. -,     : :,.!=:.*;!-~!-.,:, ,          -               ");
                        Console.WriteLine("                           . ~.-.;:.     .;. :;~~~~~-,-,.,~, .        .,                ");
                        Console.WriteLine("                             -.-.;-      ,,;*,,.~,;!*~~-.~~- .       .-                 ");
                        Console.WriteLine("                             - -.-.      .-~,      .. .*.::- ,       ..                 ");
                        Console.WriteLine("                             . . . .     .:;,           ;..- -       ,         .        ");
                        Console.WriteLine("                                  .:.     -.~,-          -~- -       -        ...       ");
                        Console.WriteLine("                                  ,:      .. .-.::.      ,.-        ~.   .  , .-        ");
                        Console.WriteLine("                                  .,       !.    . .,~;~. ~-       ~:    ,.,  -- ,      ");
                        Console.WriteLine("                                            =.           ,-        ,:   ~. , -., .      ");
                        Console.WriteLine("                                    ~        ---      .-.:         ~   .,., .,-.-..     ");
                        Console.WriteLine("                                    ~         .,.~;;:,.,              .-,., -.,,...     ");
                        Console.WriteLine("                                             .;---        ,,        --. - .- ..         ");
                        Console.WriteLine("                                              -$!        .:         .,,~ . ,  .         ");
                        Console.WriteLine("                 !=,                                     ;         ,,.., ,.  .          ");
                        Console.WriteLine("                 *@=.   ,@@@@#*.                  !*   .=*.         -., .      !*.    #. ");
                        Console.WriteLine("!@@@@@@@@@@@@$.  ~@#,                            *@@.   #@*.       , ,        -#@~    @; ");
                        Console.WriteLine("        --~*@@- ~@@:    =@@@@@@@@@@@@@#@~      ;@@=.     @@~    -!**=******===*@@;    @=.");
                        Console.WriteLine("         .=@#-  *@$                   ;@#    -@@@@@#;,   @@~   ;#$$#$$$$$$$$$=*@@;    @$,");
                        Console.WriteLine("        !@@!    !@@@@@@@!    =#@!     ~@@   @@@*  -!@@*  @@~     .*@!   .;,    $@*    @@~");
                        Console.WriteLine("       ;@@=     :@@@        *@@@@;    ~@@  @@       .$:  @@-     .$@;   =@!    =@=.   @@:");
                        Console.WriteLine("     -*@@=      -@#~       .$@@@@@-   ~@@                @@-     ,#@-  .@@;    *@$.   @@;");
                        Console.WriteLine("     =$:.       -@#~        :@@#@@;   :@@#@@#  ,*$###@@@#*-      ~@#! .=@$.    -@@*@@;@# ");
                        Console.WriteLine("                .@@:         -@#,     =@*      --        ;@$     -$#    ;::*#! .;@@:  #@!");
                        Console.WriteLine("                            -@@;     .@@.        .!$@@@@@@@=    ;@@@@@@@@@@@$,  .@@-  #@;");
                        Console.WriteLine("       !@@@@@@@@;           @@@     .,@@,       =@#!:::;:~,                     .@@-  @@:");
                        Console.WriteLine("      :@@=!!--=@#     ~@@@@@@@@@@@@$..@@*       #@*                             .@@-  @@:");
                        Console.WriteLine("      $@$~.  .*@#                     @@        =@$~                          ; @@=.  =@*");
                        Console.WriteLine("      ~#@@=;:*@@;                               ,@@#*!;:::~:;;,                 @$-  :@#.");
                        Console.WriteLine("       -=@@@@@@*.                                -#@@@@@@@@@@@;              :@@;    ,@@.");
                        _player5.PlaySync();
                     
                        Console.WriteLine(" ");
         
     
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================================================================================== ");
                        Console.WriteLine("                               골드가 없습니다.강화할 수 없습니다.");
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================================================================================== ");
                        Console.WriteLine(" ");
                    }
                        break;
                case "2":
                  
                    ProcessTown();
                    break;
                default:
                    Console.Clear();
                
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine(" ");
                    break;
            }
        }//강화

        public int EnhanceItem(Player player)
        {
            // 강화 확률을 설정합니다 (예: 50% 확률로 성공)
            Random rand = new Random();
            int percentage = rand.Next(0, 101); // 0부터 100까지의 랜덤 값
            int originalWeapon = player.GetWeapon();
            int Gold = player.Getgold();

            if (Gold>=500)
            {
                if (percentage <= 40)
                {
                    // 강화 성공 시 공격력을 증가시킵니다
                    // 10만큼 강화

                    player.Setinfo(player.GetHP(), player.GetAtt(), originalWeapon + 10, player.GetMAXHP(), player.GetExp(), player.Getgold()-500);

                    return 1;// 강화 성공
                }
                else
                {


                    // 무기 공격력이 음수가 되지 않도록 보정
                    if (originalWeapon >= 10)
                    {
                        player.Setinfo(player.GetHP(), player.GetAtt(), originalWeapon - 10, player.GetMAXHP(), player.GetExp(), player.Getgold()-500);
                    }
                    else
                    {
                        // 무기 공격력이 10 미만이면 0으로 설정
                        player.Setinfo(player.GetHP(), player.GetAtt(), 0, player.GetMAXHP(), player.GetExp(), player.Getgold()-500);
                    }
                }
                return 2;// 강화 실패
            }
            else
            {
               
            }
            return 3;

       
        }//강화확률
        private void RandomMonster1()
        {
            int randValue = rand.Next(0, 3);
          
           
           

            switch (randValue)
            {
                case 0:
                    Console.Clear();
                    monster = new Neko();
                  
                    while (true)
                    {

                        Console.Clear();
                   
                        Console.WriteLine("                                                                      ");
                        Console.WriteLine("                                                    .  .~             ");
                        Console.WriteLine("                                                   .**:;!;;*!         ");
                        Console.WriteLine("                                                  ;;;*!!*!**;         ");
                        Console.WriteLine("                                                  ;*;;;!;;;!*~        ");
                        Console.WriteLine("                                                 :;==!*!!*!!*~        ");
                        Console.WriteLine("                                                -~-~;::**::!!!.       ");
                        Console.WriteLine("             네코                              :,-,..,:-,-~:;~        ");
                        Console.WriteLine("                                               .--, !~, -,,-~;;.      ");
                        Console.WriteLine($"        HP:{monster.GetHP()} Att:{monster.GetAtt()}                           ,-~ ,$-!  :,-~;:~;.    ");
                        Console.WriteLine("                                               ~.,- !!   ~,,~~~!;:    ");
                        Console.WriteLine("                                               ~ .,--..-~,.,-~!!:~    ");
                        Console.WriteLine("                                               ~,,-,--~-.  .--;::     ");
                        Console.WriteLine("                                               .~-==;;:~-..,~!;,      ");
                        Console.WriteLine("                                                ,;*~,,-;:--~:!-       ");
                        Console.WriteLine("                                                 .:*;;;!::;;!-        ");
                        Console.WriteLine("                                                  ,:~;!!!**;          ");
                        Console.WriteLine("                                                 .~--..-~;;~-         ");
                        Console.WriteLine("                                                 :.-:  ,~:!:~         ");
                        Console.WriteLine("                 ..,,.                           ;.,:. .-~;!~.        ");
                        Console.WriteLine("               -!!::,.:~                        ::,.:!,,~~!:,-        ");
                        Console.WriteLine("              -:~*@@#=~-,                       .~-...,~~:;!~.        ");
                        Console.WriteLine("              ;~;=@@@@#~--                         ;:~~:;!*,          ");
                        Console.WriteLine("             ,~~!$@@@@@*!~                         -~;!~-:*           ");
                        Console.WriteLine("             ~~;*@@@@@@*:#,                       ,~~;!~,;*.          ");
                        Console.WriteLine("            ,*=##@@@@@@=~#!                       ;;;!*:;!*,          ");
                        Console.WriteLine("           ;$@@@@@@#$##;~=:.                                          ");
                        Console.WriteLine("          .!!***=**$!=~,-,                                            ");
                        Console.WriteLine("             .*@#@@@!-  ,.                                            ");
                        Console.WriteLine("              ,#@@@=;   ,.                                            ");
                        Console.WriteLine("             .,;@@$~,, ,~                                             ");
                        Console.WriteLine("            ~--~$;,,,;:-                                              ");
                        Console.WriteLine("           ~. .:!, ,;,   ,                                       ,,   ");
                        Console.WriteLine("          ,:  ..!- -$!~-:--                                      $@.  ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                 LV:{player.GetLevel()}                $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                 HP : {player.GetHP()}             $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |          Att: {player.GetAtt()}             $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,          무기: {player.GetWeapon()}            #@.  ");
                        Console.WriteLine($"       ~-,--~~;!~-~~.::;;=*~    ~=@,         골드: {player.Getgold() }            .=@=   ");
                        Console.WriteLine("       ~,,,,---=;-;,.,::-..    .:::~~~~~~~~~~~~~~~~~~~~~~~~~~~~:::.   ");
                        Console.WriteLine("                                                                      ");
                        Console.WriteLine(".;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;.");
                        Console.WriteLine(";*==================================================================*;");
                        Console.WriteLine(";!                                                                  !;");
                        Console.WriteLine(";!                                                                  !;");
                        Console.WriteLine(";!      1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기   !;");
                        Console.WriteLine(";!                                                                  !;");
                        Console.WriteLine(";!                                                                  !;");
                        Console.WriteLine(";!-------------------------------------------------------------~#@#,!;");
                        Console.WriteLine(";!*************************************************************!,=,-!;");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격

                                Skill = player.GetSkill();
                                if (Gold>=Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }
                                


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                                             ,.  .,.                      ");
                        Console.WriteLine("                                                            .::~~~~-,,                    ");
                        Console.WriteLine("                                                         ....:::::;:-,,                   ");
                        Console.WriteLine("                                                      -:::::~~;:::::~-,:                  ");
                        Console.WriteLine("                                                      .:::;::::;:::~~~-~~~~-,.            ");
                        Console.WriteLine("                                                     -::;::::;:::::::~~~~~~~~~~,.         ");
                        Console.WriteLine("                                                    ~::;::::;:::::::~~-~~~~~~-,           ");
                        Console.WriteLine("                                                    .:;!:;!!;:::::;:~~,-:~~~,:,..         ");
                        Console.WriteLine("                                                     .:!!!;!;::;;!;;~-,::~~~,~~,.         ");
                        Console.WriteLine("                                                     ~:;;;;!!!!!;;;;:~;;;;~~-,:~,.        ");
                        Console.WriteLine("                                                    :;;;;;;;;:-,,-:!;::::~::~.-~~.        ");
                        Console.WriteLine("     네코가 공격 했습니다!!                        -!;;;;;~         .:;;~..,--,.-         ");
                        Console.WriteLine("                                                 ,-:;;;;;,   -~-.     -;:..  ,--,-        ");
                        Console.WriteLine($"       HP:{monster.GetHP()} Att:{monster.GetAtt()}                               .:~;;;;;.  ,;!*!;:     -:,...~,,,,.,.     ");
                        Console.WriteLine("                                                ,~:;;;;,   ;*$$!~!.    .:,...~~.  ,-.     ");
                        Console.WriteLine("                                                --:;;;;.   ;*$$$*!     .:,...,~-   ,      ");
                        Console.WriteLine("                                                --;;;;;-   ,!**!;,     -;,....~~.   ,     ");
                        Console.WriteLine("                                                -~;;;;;;-    ..      .-;:,....-~,  .-     ");
                        Console.WriteLine("                                                ,~;::;;;:~,.      .,~:;;:-....-:-. .,     ");
                        Console.WriteLine("                                                ,-;::;;;:::;;;;;;;;::::::~,..,~-.  -      ");
                        Console.WriteLine("                                                ,-;:::!*!;::::::::;;!!!!::-,,~~.. .,      ");
                        Console.WriteLine("                                                 .~:;;!!;:~,,,----::::;!!;:-.....,        ");
                        Console.WriteLine("                                                  ,:::;!!~.  .    -;;;!:::-.....,.        ");
                        Console.WriteLine("                                                   ,:::::-        ,.~:::::~....-          ");
                        Console.WriteLine("                                                    ~:::~~,     .,   .~::::,.,,           ");
                        Console.WriteLine("                                                     ::-..,--,-,.     .~:::-..            ");
                        Console.WriteLine("                                                     :~.               ,~~~~. ,           ");
                        Console.WriteLine("                                                    ,:-                .~~~~. -           ");
                        Console.WriteLine("                                                    ~~,                .~~~~, ,           ");
                        Console.WriteLine("                      .,:::-                        ~~,                ,~~~~, ,.          ");
                        Console.WriteLine("                   .-;;:!;~,:~-                    .~~,  ,;!;;;~,,~~-,,~~~~~, ,.          ");
                        Console.WriteLine("                  .:;~*@@#=;~-~,                   .~:-  ~;;;;:~:~~~~~~~~~~~, -.          ");
                        Console.WriteLine("                  ~:~;=@@@@@#:,-~                   ::~. .;;;;:~~:~~~~~~~~~-. ,           ");
                        Console.WriteLine("                 .!~~*=@@@@@@=-~;                   ~::-. :;;;;:~~~~~~~~~~~-. -           ");
                        Console.WriteLine("                 -:~;*#@@@@@@@:;!                   .::;~.,:;;;:~~~~~~~~~~-- ,.           ");
                        Console.WriteLine("                 :::!*#@@@@@@@:;#:                   ~:;;;:;;;;;:~~~~~~~~~~..~            ");
                        Console.WriteLine("                .;!;*$@@@@@@@@:-=$.                  .::;;;;!;;;:~~~~~~~~~,,-             ");
                        Console.WriteLine("               ,*#@@@@@@@@@@@@*;$#:                   ,::;;;;!;;!!!:~~~--:,.              ");
                        Console.WriteLine("              :==@@@@@@@@=*#@*-~*,~.                    ::;;;;;;;~, ....                  ");
                        Console.WriteLine("             .;;;**=$$$=*$:*!-,-~                        -~:!;;;;:-                       ");
                        Console.WriteLine("                .-=@#$##@@:~.. -,                          .~;;;;:,                       ");
                        Console.WriteLine("                  -@@@@@@#:.   .-                            ~:::~,                       ");
                        Console.WriteLine("                   !@@@@@;~.   -,                             --~~.                       ");
                        Console.WriteLine("                 ,::=@@$;-,,  ~-                                 .                        ");
                        Console.WriteLine("                ::-~=@;-,,,~---                                                           ");
                        Console.WriteLine("              .~, .-;=-.,,~:~,                                                            ");
                        Console.WriteLine("             .~,   ,;!. .-=~ . .:,                                                 ~!;.   ");
                        Console.WriteLine("             ,:   ..,!~. !*!-~~;-,-                                                ,@@,   ");
                        Console.WriteLine("            .:!;:~~,..~:-$!:*-~=!~;.                                               .@@-   ");
                        Console.WriteLine("            :::;::;!~,,-;@$!=*!::;;                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         :~,------~==:~::..-~:*;~~~.    .;*==;~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:*==~    ");
                        Console.WriteLine("!!*::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::*!!");
                        Console.WriteLine("!;,                                                                                    ,;!");
                        Console.WriteLine($"!;,                    {monster.GetAtt()}만큼 피해를 입었습니다!!                                       .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!!*::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::*!!");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {

                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }

                    }
                    break;
                case 1:
                    
                    monster = new Slime();
                    
                    while (true)
                    {

                        Console.Clear();
                        Console.WriteLine("                             ");
                        Console.WriteLine("                                                                  .::=$$!:.               ");
                        Console.WriteLine("                                              .-~-,              -!=:~--:;=!-             ");
                        Console.WriteLine("                                             .::-.-,             *!,      .;=,            ");
                        Console.WriteLine("                                             ~:~,..,           ,;**,        !$,           ");
                        Console.WriteLine("                                             ~~:-,-,          .~~~,,-       .=;           ");
                        Console.WriteLine("                                             .:*;-~,         .~~~-,.-~       ;;.          ");
                        Console.WriteLine("              슬라임                          ;!:;         .-:~:~-,. ~,      :;,          ");
                        Console.WriteLine("                                              :!.        ,~~~~:~--,.. ,~.    ~*,          ");
                        Console.WriteLine($"          HP:{monster.GetHP()} Att:{monster.GetAtt()}                        .=-     .~;~~~::~--,,..  .-~   ;=,          ");
                        Console.WriteLine("                                               :=, .~;;,-~::~~--,,,.     ,*, *=.          ");
                        Console.WriteLine("                                               .;#:~~,-~:::~~---,,..       -;#;           ");
                        Console.WriteLine("                                                ~;--~~::::~~---,,,..        ~$.           ");
                        Console.WriteLine("                                               -~,:$!=:::~~---,,,,..         ::           ");
                        Console.WriteLine("                                              .!--*,!@!::~~--,,~!:!,          !.          ");
                        Console.WriteLine("                                              ::-~=-~;;::~---,-=;~#!..        ~~          ");
                        Console.WriteLine("                                              #.-:;$@*:;:~---,-~. ,:......    -~          ");
                        Console.WriteLine("                                              #,~:;;;::!;;:~-,-!*:#;,........ ,~          ");
                        Console.WriteLine("                                              #,~:;;;:::=~;~-,,-~~~,,,,,.  .. .:          ");
                        Console.WriteLine("                                              #,-:;;;:::$*$---,,,,,,,,,,.  .. ,:          ");
                        Console.WriteLine("                                              ;~-~::::::=!*---,,,,,,,,,,,.... :~          ");
                        Console.WriteLine("                                              .!,-~~::::;,:~---,,,,,,,,,,,,,. =,          ");
                        Console.WriteLine("                                               :~,,-~:::!.:~----,,,,,,,,,,,. !:           ");
                        Console.WriteLine("                                               .:-..-~:::!;~~-------,,,,-,..;;            ");
                        Console.WriteLine("                                                .:;.,~:::::~~~~~--------,.~!~             ");
                        Console.WriteLine("                     .,~*==:.                     ,*-,-~~::::::::::~~~,.~=:               ");
                        Console.WriteLine("                   ,:*!;!;-,;~~                     -;~:;:--~~~~~-:;::~!~                 ");
                        Console.WriteLine("                  .;:~*@@@#=;-~,.                     .--,.~****!,,--,                    ");
                        Console.WriteLine("                  :~~!=@@@@@@;,-:                                                         ");
                        Console.WriteLine("                 .!~~*=@@@@@@$~:;                                                         ");
                        Console.WriteLine("                 ~:~;*#@@@@@@@:!*.                                                        ");
                        Console.WriteLine("                 ::~!*#@@@@@@@:;#!                                                        ");
                        Console.WriteLine("                .!**=#@@@@@@@@;-=#,                                                       ");
                        Console.WriteLine("              .~=@@@@@@@@@@#@#*:$=;                                                       ");
                        Console.WriteLine("             .;;!#@@@@@@@!!#@;--;..                                                       ");
                        Console.WriteLine("             .:!;;!*===**#:!:,.-~                                                         ");
                        Console.WriteLine("                 ,*@###@@@:-   ,.                                                         ");
                        Console.WriteLine("                  ,@@@@@@#;    .:                                                         ");
                        Console.WriteLine("                   ;@@@@#~~.   -.                                                         ");
                        Console.WriteLine("                 ~!:=@@*~,,,  :,                                                          ");
                        Console.WriteLine("                ;~.-*@:,,,,::~.                                                           ");
                        Console.WriteLine("              .:. .-!*, ,-:~,.                                                            ");
                        Console.WriteLine("             .:.   ,;*,  ~=~ . ,:-.                                                .**,   ");
                        Console.WriteLine("             --   ...~;. =!*~~!!..-                                                .@@-   ");
                        Console.WriteLine("            .;==;:~-..-!-$!~*-~$*~;.                                               .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         :~,------~=$:-::..,-;=;--,     .!===!;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!*==-    ");
                        Console.WriteLine("         ,.........-~-.,....,-.                                                           ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine("::======================================================================================::");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.            1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기               .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!::~~~~~~~~~~~~~~~~~~~~~---~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:*@@$-::!");
                        string input = Console.ReadLine();

                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격

                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }



                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                               
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear(); 
                        Console.WriteLine("                                                  .....                                   ");
                        Console.WriteLine("                                                ~:~---~~-                                 ");
                        Console.WriteLine("                                               ;-.      -!.                               ");
                        Console.WriteLine("                                              *,         .!.                              ");
                        Console.WriteLine("                                             :-           .;-                             ");
                        Console.WriteLine("                                            .;             .;.                            ");
                        Console.WriteLine("                                            ,,               :~                           ");
                        Console.WriteLine("                                             ;.                 ;                         ");
                        Console.WriteLine("                                              !-                 .:,                      ");
                        Console.WriteLine("                                               -:                   ~;,                   ");
                        Console.WriteLine("                                                ~;-..                .~:-                 ");
                        Console.WriteLine("     슬라임이 공격 했습니다!!                   .-.  --.               .-!~          ,~,  ");
                        Console.WriteLine("                                                , ,,.  ,,.                -;:-..   .~   - ");
                        Console.WriteLine($"          HP:{monster.GetHP()} Att:{monster.GetAtt()}                           , --,.   .,..               .-~~~~~;,.  ,-");
                        Console.WriteLine("                                                ..-~-,..    .,,                 ...!~-,-~:");
                        Console.WriteLine("                                                ..-:-,,..      --.                 ,:::::.");
                        Console.WriteLine("                                                , ,:~-,,..        ..,               .---. ");
                        Console.WriteLine("                                                , ,::~,,..            ,.                  ");
                        Console.WriteLine("                                               ,..-:~~,..              ..                 ");
                        Console.WriteLine("                                             .. .-::~-,.                .,                ");
                        Console.WriteLine("                                            .. .-:::-,.                   -               ");
                        Console.WriteLine("                                         ...-;;::-,.        ..             .,             ");
                        Console.WriteLine("                                         ,.-;;::-,.        ,;,              ,             ");
                        Console.WriteLine("                                        ,.-;;;:-,..       ~:.            .. ,             ");
                        Console.WriteLine("                                       .--:;;:~,,..     .;-             .... :            ");
                        Console.WriteLine("                                       , ~=*;~,,,..   .~!.              .,-, ;            ");
                        Console.WriteLine("                                       - -;**!~,,...-::-               .,,~, ;            ");
                        Console.WriteLine("                        ...            -.~;!;:;!***~,.              ..,,,,,.,             ");
                        Console.WriteLine("                     ~,,:::--.         -.;*==!!~,,,~:~~~~~--~~~~:....,,,,,,.,             ");
                        Console.WriteLine("                   ,!:*=$*-.-~;        , ,:;!!~,,,,,:...,,,,-----..,,,,,-,...             ");
                        Console.WriteLine("                  .;~~*@@@@=;--,.       :.-:;!*~::,-:...........,,,,,,,--. ,              ");
                        Console.WriteLine("                  ;~~!=@@@@@@;--:       ..,~:;;;~~~~,,.......,,,,,,,,,~~..,               ");
                        Console.WriteLine("                 .!~~*=@@@@@@$~:;        ..,~:;;:~--,,,,,,,,,,,,,,,-~~-. ,                ");
                        Console.WriteLine("                 ~~~!*@@@@@@@@:!*.        , .-::;:::~~-----,-----~~~~,  ,                 ");
                        Console.WriteLine("                 ::~!=@@@@@@@@::$!         ...,-~::::::::::::::~~~-, ...                  ");
                        Console.WriteLine("                .*==$@@@@@@@@@;-$#-          ,- .,--~~~:::::~~-,.. .,-                    ");
                        Console.WriteLine("              .~$@@@@@@@@@#@@#*;$=;            ,,.    ......     .,.                      ");
                        Console.WriteLine("             .!===$$@@@#$=!$#:--!.,              ,...,,,,,,,....,.                        ");
                        Console.WriteLine("              ,-~*$$!!!=$#:;-,.-,                    .......                              ");
                        Console.WriteLine("                  *@@@@@@@:,   ,,                                                         ");
                        Console.WriteLine("                  ,$@@@@@=:.   .-                                                         ");
                        Console.WriteLine("                   ~#@@@$~-.  .:.                                                         ");
                        Console.WriteLine("                .~!:=@#!~,,,..:.                                                          ");
                        Console.WriteLine("               ,~-,-!#:,,,-::-.                                                           ");
                        Console.WriteLine("              -~.  -!;, ,-:-.                                                             ");
                        Console.WriteLine("             .:    .:*,  :$:.,.,;-.                                                .##,   ");
                        Console.WriteLine("             ~;~,....~:-.=!;:-:*:,~                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         -:-,---~~:*;~-~!.,::;!;;*:,    .~*@@;------------------------------------!@@*.   ");
                        Console.WriteLine("         :~,--,----*#!~;~,,,~;:-...     .~:::~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:::.    ");
                        Console.WriteLine("                   ...       .                                                            ");
                        Console.WriteLine(" ,~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~, ");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine($"!;,                    {monster.GetAtt()}만큼 피해를 입었습니다!!                                       .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(" ,~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~, ");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }

                    }
                    break;
                case 2:
                    
                    monster = new Snail();

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("                                                           ...      ...                   ");
                        Console.WriteLine("                                                         ~~!!;~.  -~!!!:~                 ");
                        Console.WriteLine("                                                        ~~-::::! ,:,~:::;;                ");
                        Console.WriteLine("                                                       ,;:::::;!!!;::::;!=::,             ");
                        Console.WriteLine("                                                       ~!**=*!!***!*$=::;*~ --.           ");
                        Console.WriteLine("                                                       ,-:!@*.,-*!:=@*..,!~..-~.          ");
                        Console.WriteLine("             검은 달팽이                               .--$$- .::;:$=-  -!~-,.:-          ");
                        Console.WriteLine("                                                        --    ~!;!;,   -;:-,-~~:,         ");
                        Console.WriteLine("                                                         ,!:~!:,~:~:**=!:: ,~:::;         ");
                        Console.WriteLine("                                                           ,-;-;;;:~:~!;::.-;:;;;         ");
                        Console.WriteLine("                                                           ,;~;:-~;,=:-;;-~:~~:;~-        ");
                        Console.WriteLine("                                                           ,-;.   .**=--;-~:-::!:-        ");
                        Console.WriteLine($"             HP:{monster.GetHP()} Att:{monster.GetAtt()}                                  ,; .     -=*,:;~:~!;!:~        ");
                        Console.WriteLine("                                                           .- -::-   ;$:-!~:~;;:~~        ");
                        Console.WriteLine("                                                           -. -!::   ,$*-!::~::;;-        ");
                        Console.WriteLine("                                                           ,  ,---   .!=~;:~;!!*;-        ");
                        Console.WriteLine("                                                          .-   --    .-$:~!~~;!;~-        ");
                        Console.WriteLine("                                                          .-   ..     .!;~!:::;;;         ");
                        Console.WriteLine("                                                          .,          .-=:;!!!!!:         ");
                        Console.WriteLine("                                                          .,          ..~!:;!!*!~         ");
                        Console.WriteLine("                                                          .-         .,..-*!!!*!          ");
                        Console.WriteLine("                                                           ,         ......:=*-:          ");
                        Console.WriteLine("                                                           ,-.     ..,..,,.,.,--          ");
                        Console.WriteLine("                                                            ..!=!~-,,---:*=*, .           ");
                        Console.WriteLine("                    .,,~***~,                                                             ");
                        Console.WriteLine("                   -:!!!!;--:~~                                                           ");
                        Console.WriteLine("                  ~;~~$@@@#=:--,                                                          ");
                        Console.WriteLine("                 .~~~**@@@@@@:,~;                                                         ");
                        Console.WriteLine("                 ,:~:!$@@@@@@$~;!                                                         ");
                        Console.WriteLine("                 ::~!=@@@@@@@@:=*                                                         ");
                        Console.WriteLine("                 :::*=@@@@@@@@:;#;                                                        ");
                        Console.WriteLine("                ,**=$@@@@@@@@@;~$$,                                                       ");
                        Console.WriteLine("              ,!#@@@@@@@@@@#@#*:@=:                                                       ");
                        Console.WriteLine("             .!!*###@@@@#!!##:,~*.,                                                       ");
                        Console.WriteLine("             .:::!*======@~;~,.~-                                                         ");
                        Console.WriteLine("                 ,=@@@@@@@-,   -.                                                         ");
                        Console.WriteLine("                  :@@@@@@#~    ,:                                                         ");
                        Console.WriteLine("                  .!@@@@=~-.  .-.                                                         ");
                        Console.WriteLine("                .:*~=@@;-,,, .~.                                                          ");
                        Console.WriteLine("               ,;-.~=$-,,,-:~-,                                                           ");
                        Console.WriteLine("              -~  .~!;. ,,;-,                                                             ");
                        Console.WriteLine("             .~    ,;;   ;$~ , -;-.                                                 !$;   ");
                        Console.WriteLine("             :~, ...,~:.,#;;;~;!,,-                                                 *@!   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         ::,,--~~~!;:~-~;.,!:!;~!*:-     ,;#@~....................................~@@#~   ");
                        Console.WriteLine("         *,,------:$$:-;~..,:;!~,,,     ,:!!!;::::::::::::::::::::::::::::::::::::;!!~    ");
                        Console.WriteLine("!!######################################################################################!!");
                        Console.WriteLine("!:.                                                                                    .:!");
                        Console.WriteLine("!:                                                                                      :!");
                        Console.WriteLine("!:                1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기             :!");
                        Console.WriteLine("!:                                                                                      :!");
                        Console.WriteLine("!::~~~~~~~~~~~~~~~~~~~~~---~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:*@@$-::!");
                        Console.WriteLine(";!::::::::::::::::::::::~~~::::::::::::::::::::::::::::::::::::::::::::::::::::::~,!$-.~!;");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격


                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }



                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                                                          .:*=*~          ");
                        Console.WriteLine("                                                                         .;::~;*~         ");
                        Console.WriteLine("                                                                         ~~!~!:!*         ");
                        Console.WriteLine("                                                          .,~!===:~.     ~~!;:=!*         ");
                        Console.WriteLine("                                        --:::~-.         -::::;;!=**;,,;:~;!:~;:.         ");
                        Console.WriteLine("                                      ,!~~:::;!*~       :~~~~::;;****!;=;~!!*,.           ");
                        Console.WriteLine("                                     ,:---~:::;!*:.    ~;---~::;;****=$!;!:!*;            ");
                        Console.WriteLine("                                   .-!~--~~:::;!*=;  ,;!---~~::;!*****=**;!!=:            ");
                        Console.WriteLine("                                  .*!;;;;;;;;!!***=!.,*:::::;;!*=******===;:;!!*;!!..     ");
                        Console.WriteLine("                                   ~!:::;**!!!****=!,~=!;;;:!==!:~-....!*;;;;;;;!*=!!!:   ");
                        Console.WriteLine("                                   --    .-@#=****=!~~!=;::*$$,     ...;!;;;;;;!!!!==:$-  ");
                        Console.WriteLine("   검은 달팽이가 공격합니다!!      .:     ,@;,;====*-~*;;!*~**       .-=:;;;;;!!!~!;! ..  ");
                        Console.WriteLine("                                    ~-    .$~  ,:==$~:=$=~  ;;      ..;!;;;;;;!!!!!!!,    ");
                        Console.WriteLine($"          HP:{monster.GetHP()} Att:{monster.GetAtt()}               :.    -.  ..;!;~:!=;   ,,     ..-!;;;!!!!!!!!!!!:..  ");
                        Console.WriteLine("                                      ~-..   .,-:~--~**!;:,       .,~!!!!!!!!!!!!!**;!$=~ ");
                        Console.WriteLine("                                       ---:::::$:-!**;:!==!~:,...:;!*!!!!!!**!!*!***!;=.  ");
                        Console.WriteLine("                                            -;,*$#*;:-:::;,!;*===!!!**!!*!!**==*=*****:   ");
                        Console.WriteLine("                                              !~!,      ;,!=~:;;!**!*==*=*==$$$==***$;    ");
                        Console.WriteLine("                                              :~.      .,~!!!~;;!*====$#=*==$=$==*$$$*.   ");
                        Console.WriteLine("                                             ~            ~:*;;;!*====#$$*=$=**$**$$==.   ");
                        Console.WriteLine("                                            ,,            ,:!!;***=##$**$=$===**==$===.   ");
                        Console.WriteLine("                                           :.              ,::*$$=$$=!!****$$=*=**=*==.   ");
                        Console.WriteLine("                                         .-                 ~:!!***$=******==*!**==**;    ");
                        Console.WriteLine("                                         ,,                 ~:;!***=$!*=***=$****=*=*:    ");
                        Console.WriteLine("                                         ~. ,;;!!!;;;;;;.   .;!;!**=$*!!==========**!.    ");
                        Console.WriteLine("                                        .~  ~*:!;;:::~:;~    ,!*****$=!!*==******=*=-     ");
                        Console.WriteLine("                                        ,~   ...........     .,;*!**===!!*******=**:      ");
                        Console.WriteLine("                                        ,~                    .~!!!**=$$=****===**~       ");
                        Console.WriteLine("                                        ,~                    .,~;!!***==$$===##=-        ");
                        Console.WriteLine("                                        ,~                    ..,-~!***=====$$$#,         ");
                        Console.WriteLine("                                        .~.                ......,----:;!*$==$$$!         ");
                        Console.WriteLine("                                         ,-.. .       .   .......,-------~:$$$==$;        ");
                        Console.WriteLine("                    .~--!!;~-.           -, .................,,,,---------~~;*==$!        ");
                        Console.WriteLine("                   ,;;!==*~,~~:.        -,  ..................,,,,,,,,,,,,,---~:*;.       ");
                        Console.WriteLine("                  ,!~~*@@@@#!-,,.      ~.......................................,--:       ");
                        Console.WriteLine("                  ;~~!=@@@@@@!--:       :;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,       ");
                        Console.WriteLine("                 .;~~*=@@@@@@$~:;                                                         ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:!*.                                                        ");
                        Console.WriteLine("                 :::!=#@@@@@@@::$!                                                        ");
                        Console.WriteLine("                ,=$$#@@@@@@@@@;~$#-                                                       ");
                        Console.WriteLine("              ,:@@@@@@@@@@##@#*;$*!                                                       ");
                        Console.WriteLine("             .;**=$$@@@#$*!$#:,-;..                                                       ");
                        Console.WriteLine("              ,-~!$$***=$#:;-,.-,                                                         ");
                        Console.WriteLine("                  !@@@@@@@:,   ,,                                                         ");
                        Console.WriteLine("                  ,$@@@@@=:.   .-                                                         ");
                        Console.WriteLine("                   ~#@@@$~-,  .:.                                                         ");
                        Console.WriteLine("                .:=;*@#;-,,, .;.                                                          ");
                        Console.WriteLine("               ,~-.-*#~,,,-:~-.                                                           ");
                        Console.WriteLine("              -~.  -!;, .-;,.                                                       ..    ");
                        Console.WriteLine("             .:    .:=,  ~#;.,.-;~.                                                .##,   ");
                        Console.WriteLine("             ~;~,....-:-.=!;:-:*:,~                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         -:-,---~~:*!~-~!.,::;*;;*:,    .~*@@;------------------------------------*@@*.   ");
                        Console.WriteLine("                    .                                                                     ");
                        Console.WriteLine(" ,~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~, ");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine($"!;,                    {monster.GetAtt()}만큼 피해를 입었습니다!!                                       .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(" ,~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~, ");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);
                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); 
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }






                    }
                    break;

                   
           

            }
        } // 초급 
        private void RandomMonster2()
        {
            int randValue = rand.Next(0, 3);
          
            switch (randValue)
            {
                case 0:
                    monster = new MushMom();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                                .......,..                ");
                        Console.WriteLine("                                                              ...   ...,--~,              ");
                        Console.WriteLine("                                                             ,        ..,----.            ");
                        Console.WriteLine("                                                           ..         ..,,,---,           ");
                        Console.WriteLine("                                                          ,.           .,,--,,,,          ");
                        Console.WriteLine("                                                         ..            ..,,,,-,-,         ");
                        Console.WriteLine("                                                       ...             ..,,,,,,,-         ");
                        Console.WriteLine("                                                      .,              ...,,,,,,,,.        ");
                        Console.WriteLine("                                                    ...                .....,,,,,-        ");
                        Console.WriteLine("                 머쉬맘                          ....                 .....,,,,,,,.       ");
                        Console.WriteLine("                                                .                      .....,,,,,,-.      ");
                        Console.WriteLine("                                               .   ..                   .....,,,,,,-.     ");
                        Console.WriteLine("                                              ,.,,,,,,...                ....,,,,,,,,.    ");
                        Console.WriteLine($"    HP:{monster.GetHP()} Att:{monster.GetAtt()}                             -,,----,,,,,.                ...,,,-,,,-.   ");
                        Console.WriteLine("                                              ----~~~~~~-,,,..             ....,,,,,,,-.  ");
                        Console.WriteLine("                                              ~,,:!!****~~-,,,,....        ....,,-----,-. ");
                        Console.WriteLine("                                              -,,;!!***;~~~:-,,,,,,...........,,--------, ");
                        Console.WriteLine("                                              .,,~!!***:~~::::~--,,,,,,,,,,,---------~~~, ");
                        Console.WriteLine("                                               .,,~;!!;~*;~:::::~~~--,,,,------------~~-, ");
                        Console.WriteLine("                                                .~,-~::;$=~~~::~~~:~~::~~------~~----~--, ");
                        Console.WriteLine("                                                  ,-,,-=$!...,--~~~~:;*;~~~~~~--~,,,---,. ");
                        Console.WriteLine("                                                   ... ,,. .   ...-~;=#*~~~::~~-,-,,,,,,  ");
                        Console.WriteLine("                                                  ..       ... .   .-=#;:::~~~~~--,,.,,   ");
                        Console.WriteLine("                                                 ,..          .     .,-~~~~~~~~~-,-,,.    ");
                        Console.WriteLine("                                                 ,.                   .,~~~~~~~~-,.       ");
                        Console.WriteLine("                                                ...                    .,~~~~~~~-,.       ");
                        Console.WriteLine("                                                ,..                     .,~~~~~-,,.       ");
                        Console.WriteLine("                      .,~~~,                    ,..                      .-~~~~-,,.       ");
                        Console.WriteLine("                    ,!:-::~-;-.                 .,.                       .-~~--,,.       ");
                        Console.WriteLine("                   ~;~*#@#!:-~:.                .,..                      .,-~--,,        ");
                        Console.WriteLine("                  -:~:=@@@@@$~,--                -,.                       ,----,,        ");
                        Console.WriteLine("                  *~~*=@@@@@@=-~;                 ,,.                      ,----,         ");
                        Console.WriteLine("                 -:~:*$@@@@@@#~;!                  ,,.                     ,,-,,.         ");
                        Console.WriteLine("                 ::~!*#@@@@@@@:!$~                  ,-..                  .,,,-.          ");
                        Console.WriteLine("                 ;;:*$@@@@@@@@:-=$.                   ,,...             ..,,,-.           ");
                        Console.WriteLine("               ,;##@@@@@@@@@@@*:$#:                     .,,,............,,-,.             ");
                        Console.WriteLine("              :*=@@@@@@@@==#@*~~*-:                        .,--,,,,,,,,--,                ");
                        Console.WriteLine("             .!!!!**$#$=*=:**-,-:                              .,-----.                   ");
                        Console.WriteLine("                .~=#$$$#@@:~.. -,                                                         ");
                        Console.WriteLine("                  ~@@@@@@@:.   .~                                                         ");
                        Console.WriteLine("                   !@@@@@;:.   ,,                                                         ");
                        Console.WriteLine("                 ,~~$@@$;-,,  --                                                          ");
                        Console.WriteLine("                ::,~=@;-,,,~---                                                           ");
                        Console.WriteLine("              .~, .-;=-.,,~::,                                                            ");
                        Console.WriteLine("             .~,   ,;!. .-=~ . .~,                                                  !!.   ");
                        Console.WriteLine("             ,~   ..,!:  ***-::;,,-                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,--~~~;!~---!--**!~-;=~~     .~##~                                    :@@#,   ");
                        Console.WriteLine("         :~,------~=$:~::..,-:*!~~~     .;===;::::::::::::::::::::::::::::::::::::*==~    ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine(".~;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;~.");
                        Console.WriteLine("!*!------------------------------------------------------------------------------------!*!");
                        Console.WriteLine("!;,                                                                                    ,;!");
                        Console.WriteLine("!;.           1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(".~;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;~.");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격

                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }



                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                                                    .....                 ");
                        Console.WriteLine("                                                                 ,-.......-               ");
                        Console.WriteLine("                                                              ,--,        -:,             ");
                        Console.WriteLine("                                                          .,-,,           .,-,            ");
                        Console.WriteLine("                                                         ,-..              .,-,           ");
                        Console.WriteLine("                                                        -. ......... .     .,-:,          ");
                        Console.WriteLine("                                                      ., .,-----,,,,.,,,,....,~~,         ");
                        Console.WriteLine("                                                      ..-~~----,,,,..---,----,--:-        ");
                        Console.WriteLine("   머쉬맘이 공격 했습니다!!                          ,,-----~:;!!;::~--,,--~~~--~~,       ");
                        Console.WriteLine("                                                     -----;*!*=**=**=*!;:~--~~~~~--.      ");
                        Console.WriteLine($"    HP:{monster.GetHP()} Att:{monster.GetAtt()}                                    ,,--!*=**=====*=****!;---~~~-,~      ");
                        Console.WriteLine("                                                    -,-,!*====******=*==**=*:-~~~-,-,     ");
                        Console.WriteLine("                                                    ,,,~*===*!:::::::;!**==**;~----,~     ");
                        Console.WriteLine("                                                    .,,!===*::~~-~~:::::;*====!~---.~     ");
                        Console.WriteLine("                                                     -,!*=*;:,     .-::!;:;==*!;~--,-     ");
                        Console.WriteLine("                                                     ,.~*=;;;~ ,...  ~~*:::;*==*!,,,-     ");
                        Console.WriteLine("                                                     .-.:*:.,..*==-  .~;:::~:===*~,.-     ");
                        Console.WriteLine("                                                      .,,:,   .!!*-    .~::~-==**~..~     ");
                        Console.WriteLine("                                                        -~    .:;;-     ,~:~~;=*;,.-,     ");
                        Console.WriteLine("                                                        -,     ~~--      ,~~~-*:-..-      ");
                        Console.WriteLine("                                                        ~      --,-       -~~~~..,-       ");
                        Console.WriteLine("                                                        ~      --,.        -~~-~-,        ");
                        Console.WriteLine("                                                        -                  .----          ");
                        Console.WriteLine("                       .,,,.                            -                   .-,~          ");
                        Console.WriteLine("                    ,:~~!;:-~-,                        ,.                    ,,~          ");
                        Console.WriteLine("                   ~;~!##$!~--:.                       ,.                    .,,-         ");
                        Console.WriteLine("                  -;~:=@@@@@=~,-,                       -                     ..~         ");
                        Console.WriteLine("                  !~~!=@@@@@@*--:                       -                     .,~         ");
                        Console.WriteLine("                 ,:~:*$@@@@@@#~;!                       ~                     .-,         ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:!$-                      ,                     .-          ");
                        Console.WriteLine("                 ;::*$@@@@@@@@:~==.                      .                    .-          ");
                        Console.WriteLine("                :$##@@@@@@@@@@*:$@~                      ..                   -.          ");
                        Console.WriteLine("              ~*#@@@@@@@@#$#@=::=:;.                      ,-                 ,.           ");
                        Console.WriteLine("             .;;!===$$$===;=*~,-:                          .,              .,.            ");
                        Console.WriteLine("              ...~##$==#@@:~.. -,                           .-,.          -,              ");
                        Console.WriteLine("                  :@@@@@@#:,   .,                             .-----------.               ");
                        Console.WriteLine("                  .*@@@@@!:.   ,-                                                         ");
                        Console.WriteLine("                 .,~$@@#*--,  ,~                                                          ");
                        Console.WriteLine("                -:;:*@*~,,,-,,~                                                           ");
                        Console.WriteLine("               ~-..-;$-.,,~::,                                                            ");
                        Console.WriteLine("              ~,   -!;. .-*-    -,                                                        ");
                        Console.WriteLine("             ,:    .-=-  ;=!,~,:~--                                                 !!.   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,--~~~!;~---!~~;=;,.~;~~      ,!$~                                    -$@#,   ");
                        Console.WriteLine("         ~:,,---~~~==~~:;..~~:=!:;~.    .;=##;~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:*##;    ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine("!!$************************************************************************************$!!");
                        Console.WriteLine("!;-                                                                                    -;!");
                        Console.WriteLine($"!;,               {monster.GetAtt()}만큼 피해를 입었습니다!!                                            .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!!$************************************************************************************$!!");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }


                    }
                    break;
                case 1:
                    monster = new Golem();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                       ,,. ..                 ~:::;~~     ");
                        Console.WriteLine("                                                      -~:;!*!;              .~--~~:;**,   ");
                        Console.WriteLine("                                                    .~-,.,:!*=:  .,~:~,     :!;---~;!**-. ");
                        Console.WriteLine("                                                   ~:,-~~:;*$$= ,~~*==*:   ,!*:~--;*=***  ");
                        Console.WriteLine("                                                   ~;~!!!!$#$$=.-.:!:!==*;-;!;;!;~*===!*- ");
                        Console.WriteLine("                                                   :;;!!!!$$$$*~;-*;:;*#=***!!*!!;!;*$$=- ");
                        Console.WriteLine("                                                  .::!!!!!==$$~~:!*!:;*$**!!;!*!!;;:*$$*. ");
                        Console.WriteLine("              골렘                                -:~!**;;!$$~-!**=$$*$*=*;!;*;!*:;;$$$!  ");
                        Console.WriteLine("                                                  .:!***!;*$=!*!==$$#=$**!!!:!!;*;;;$$$=, ");
                        Console.WriteLine("                                                  .:!!*;!;*=!;*::;*;;;!::;:*::!;!;:;$$$=- ");
                        Console.WriteLine($"        HP:{monster.GetHP()} Att:{monster.GetAtt()}                              .~:;!*!;*:~:;::;*::=;;;;*=;;!;!!;;$$$=, ");
                        Console.WriteLine("                                                   --:;*!;*::;!**$=**====*$=;;;;!;;;$$$*. ");
                        Console.WriteLine("                                                   ,:~:;:;=*==*=*$$=*=****=$;;;;;;;!$$$=  ");
                        Console.WriteLine("                                                    !**;;!#=====*##**===**$$$!;;;;;*$##-  ");
                        Console.WriteLine("                                                    .!**!=$$*=*==$$=====*===$=***!*$#@!   ");
                        Console.WriteLine("                                                     ,*==$*!==*$=**===**=**$$:*=*=$$#*.   ");
                        Console.WriteLine("                                                     .**;;:.=*===**====*=**=;  .***$*,    ");
                        Console.WriteLine("                                                     ,=*;!* ;*=$=======*===!.  ,!*!=*.    ");
                        Console.WriteLine("                                                   ,,;*=!=~ .,,::-!;::*=!;~    .*===-     ");
                        Console.WriteLine("                                                  .:;;:-*;       ~.,. :!:      ~::;--     ");
                        Console.WriteLine("                                                  :;;;~:$=-     .-,,,-;;: ,.  ,;!;:;!*,   ");
                        Console.WriteLine("                                                 -:;!:~=$$=  .:!;!~,--;!:-*=-.~:*;;$$$-   ");
                        Console.WriteLine("                                                 !;!!!!$#$:  --*$=:~-:**;:;$;-;;:;!$$$-   ");
                        Console.WriteLine("                                                 ;!;!;*$#$;  .-;=$=!!*;:~:==-!!!;!*$#$-   ");
                        Console.WriteLine("                                                ,;*;;*=$$$-   ~~*=$$~--;!=$!,:!!;;*##$.   ");
                        Console.WriteLine("                        ...                     ,:::;;=#$=.  .:!!*=* -!!**$.,;!;*;=##$.   ");
                        Console.WriteLine("                    ,~~~!!;-~,.                 -;!!;*$$#*   ~:**!;, ,;!*:=;~:;!;!$#$*    ");
                        Console.WriteLine("                   ~;:!$$=;--~:.                ~;;;;*$$$:  ,:;*$;    .~:;=$*;;;:*$#$:    ");
                        Console.WriteLine("                  -;~~=@@@@@=-,-,              .~;;;;=$$*.  ~;!=$=.    ;:*==!*!!=$$#*,    ");
                        Console.WriteLine("                  !~~!=@@@@@@*--:              .:;;!!$$$~   :!=!==-   .;**;*===$$$#$!     ");
                        Console.WriteLine("                 ,;~:*$@@@@@@#~;!               ~!**!$#=    ~;;:*$:   ,:;;~=$$$#$$$$,     ");
                        Console.WriteLine("                 ::~!*#@@@@@@@:!=,              ,;=#=$#-   .!;;;*=*.  ,;;;;=$**$$$$;      ");
                        Console.WriteLine("                 ;::*=@@@@@@@@:~$=.             .;*=*==    ,;:;**=$,  -;:;*====#$$*,      ");
                        Console.WriteLine("                ~=$$#@@@@@@@@@!:$@~              ,;$$=:    ~~~;===#~  :~~!$=$$$$#$~       ");
                        Console.WriteLine("              -=@@@@@@@@@@$#@$;:$;!.                       ;;=$$=$#; .:;=$$$$#=~.         ");
                        Console.WriteLine("             .;;!==$###$$*;$=~,-:                         -:;*==**=~ ,;;===*==:           ");
                        Console.WriteLine("              ,,-:$$===$#@::,..-,                          ,,,,,,,,   .,,,,,,,            ");
                        Console.WriteLine("                  ;@@@@@@@:,   .,                                                         ");
                        Console.WriteLine("                  .=@@@@@*:.   ,-                                                         ");
                        Console.WriteLine("                 ..~#@@@=--,  ,~.                                                         ");
                        Console.WriteLine("                ,;!:=@=:-,,,.,:                                                           ");
                        Console.WriteLine("               ,~..-;#~.,,-;;-.                                                           ");
                        Console.WriteLine("              --   -!!, .-!-    ,.                                                  --.   ");
                        Console.WriteLine("             .:    .~$,  :$!.~.~~--                                                .@@,   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("          ;-,--~~~!:----!~~;$;. -:~:       :=-                                    .=@@-   ");
                        Console.WriteLine("         ~:,,---~~:*!~-~;..~~:**!*;,    .~=@#:,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,-*@@!.   ");
                        Console.WriteLine("         ~-,,,,,---!*:-~-..,-:~,        .~~~~~-----------------------------------~~~~.    ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine(" ,--------------------------------------------------------------------------------------, ");
                        Console.WriteLine("-:!************************************************************************************!:-");
                        Console.WriteLine("!!~                                                                                    ~!!");
                        Console.WriteLine("!;.           1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("-:!************************************************************************************!:-");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold); ;
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격


                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                            .....                                         ");
                        Console.WriteLine("                                         ~~::----:~-:~,                                   ");
                        Console.WriteLine("                                        - .~~:~~-,-:,-,,-.                                ");
                        Console.WriteLine("                                       ,  .,~~~;!;::~.------~                             ");
                        Console.WriteLine("                                       -,. .~::**!;!;~~--:--:.                            ");
                        Console.WriteLine("                                       ,...~~;*==!!*!!;~;:--~~...        ,...             ");
                        Console.WriteLine("                                       ,-,,::!$$=**==**;=;,.,- ..-      ~~,,,             ");
                        Console.WriteLine("                                        -,~;!=#$=*!~!!*!=:-,--,,,--,,  ~:-~,--            ");
                        Console.WriteLine("         골렘이 공격 했습니다!!         ,,~;!*=!;-. :;**!:--~---,--..,,,-~:-~:.           ");
                        Console.WriteLine("                                           .....    :;=*!:~~:~:~-:~...,,~;;;!:.-..        ");
                        Console.WriteLine($"       HP:{monster.GetHP()} Att:{monster.GetAtt()}                                   .~:**!;:~:,-~~*:,,,,-:!!!!: .  ,.      ");
                        Console.WriteLine("                                                   .~~**!!;:;~~~;=~----~!!!!!;-..  ,,     ");
                        Console.WriteLine("                                                    ~~!!!!!;*:~:*;~~~~:!***!!~--,,,,~~.   ");
                        Console.WriteLine("                                                    -~;!!!!;!===!;;;;!*!!!!!;~,,~;::-,~,  ");
                        Console.WriteLine("                                                     ,~;!**;!!!!*=*!!!!!!!;;==!=*!!~~;;;: ");
                        Console.WriteLine("                                                      ,;*=*!*!!**$*!!!*!!;- ,~=#*!:~.-!;;.");
                        Console.WriteLine("                                                     .:*=!=!*****!==*$*;~,    ,!!:.,..,*!.");
                        Console.WriteLine("                                                 .-:!**=##$;!!!*==$$$=:.       :;~--,:!!, ");
                        Console.WriteLine("                                                .,~:!**$###$$==$$===*!!        ,::-:;;~.  ");
                        Console.WriteLine("                                               .,,-:!***$######$$****!!~        ,:;:..    ");
                        Console.WriteLine("                                              -..,-;!!*=##===$$*=**!;~-,-        ::.,     ");
                        Console.WriteLine("                                             .-..,~!*=$$$$!;!*=;=*!:~,. ..                ");
                        Console.WriteLine("                                             ,,.,-:*=$$$!, -,~*;**;~-,. ,.                ");
                        Console.WriteLine("                                              ~--:!=*!!$,    ,;:*=:~-.....                ");
                        Console.WriteLine("                                             , .;!!~~!=*-    .~:!*~~-.  ..                ");
                        Console.WriteLine("                                             .:-:!==!*=!.     ~~~!::~-,.,,                ");
                        Console.WriteLine("                                              ,;**;!*=*,      .~:----~:;:,                ");
                        Console.WriteLine("                                                   ~=$-        -!-  ,-, ,                 ");
                        Console.WriteLine("                                                   -;~        -:!:-..,. ,                 ");
                        Console.WriteLine("                                                             ,~-*;~-,,,..                 ");
                        Console.WriteLine("                                                             :.:**-.   ~                  ");
                        Console.WriteLine("                      .-;;;-                               ;$#@#=*==:.                    ");
                        Console.WriteLine("                    ,$:,,,..=~.                            :#$*=**:                       ");
                        Console.WriteLine("                  .:;~*@@#*:--:,                           =#!:~~;-                       ");
                        Console.WriteLine("                  -:~;=@@@@@$:,-~                          ;$*~-,,.                       ");
                        Console.WriteLine("                  =~~*=@@@@@@=--:                           -==*!;-                       ");
                        Console.WriteLine("                 -:~:*$@@@@@@@:!!                              ,-                         ");
                        Console.WriteLine("                 ::~!*#@@@@@@@:;$~                                                        ");
                        Console.WriteLine("                 :::!#@@@@@@@@:-*=.                                                       ");
                        Console.WriteLine("               ,;#@@@@@@@@@@@@!:##:                                                       ");
                        Console.WriteLine("              ~;=@@@@@@@@==#@*:~*~~                                                       ");
                        Console.WriteLine("             .*$=;:;$##*:$:**-,-:                                                         ");
                        Console.WriteLine("                .:$@===#@@:~.. ,.                                                         ");
                        Console.WriteLine("                  ~@@@@@@#:.   .-                                                         ");
                        Console.WriteLine("                   *@@@@@;:.   ,,                                                         ");
                        Console.WriteLine("                 .-~$@@#!-,,  -~                                                          ");
                        Console.WriteLine("                ~:~~*@!~,,,~---                                                           ");
                        Console.WriteLine("               :, ,-!$-.,,~:~.                                                            ");
                        Console.WriteLine("              ~,   -;;, .-!-   .,.                                                  ~~.   ");
                        Console.WriteLine("             ,~   ..-;~  !=!,~~:-,,                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,--~~~!;~---!--;*;--:!:~     .-*$-                                    -$@#,   ");
                        Console.WriteLine("         ::,,---~~~==~~:; .--:#*::~.    ,*#@@=!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!#@@:    ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine(" :======================================================================================: ");
                        Console.WriteLine("!;,                                                                                    ,;!");
                        Console.WriteLine($"!;,               {monster.GetAtt()}만큼 피해를 입었습니다!!                                            .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(" :======================================================================================: ");

                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }

                    }
                    break;
                case 2:
                    monster = new Yeti();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                            -:;     ~;,                   ");
                        Console.WriteLine("                                                     ., ..~;:-~..~:;~:::,..               ");
                        Console.WriteLine("                                                   ,--~---.  .---..     ,-~--,.           ");
                        Console.WriteLine("                                             -:, .~-. .                     .,-,          ");
                        Console.WriteLine("                                            ,- ~!:.                            --         ");
                        Console.WriteLine("                                            --  ,~-.                            --        ");
                        Console.WriteLine("                                           .;-  ..:.                            ~!~       ");
                        Console.WriteLine("                                          ,~--                 ...              .:        ");
                        Console.WriteLine("         예티                            -- .-                 ...               ~,       ");
                        Console.WriteLine("                                        ,-                     .....             ~-       ");
                        Console.WriteLine("                                        ;.                    ......             -~       ");
                        Console.WriteLine("                                        ;.                    ...,,,.,          .-~       ");
                        Console.WriteLine($"         HP:{monster.GetHP()} Att:{monster.GetAtt()}                  .~           ,.       ....---:.         .-~       ");
                        Console.WriteLine("                                         ~.         .#!        ...,-~;.          -~       ");
                        Console.WriteLine("                                         -,          -,        ..,--:;,          --       ");
                        Console.WriteLine("                                         ,~~           ,---.    .,-~:;;           ~..,    ");
                        Console.WriteLine("                                          ;=       --,-, ..   . ..,~::!,           ~;~    ");
                        Console.WriteLine("                                          .;  .,, ,,.,,        ...-~::;;            -:;   ");
                        Console.WriteLine("                                          ,:---..-.            ...-:::*~            -~;   ");
                        Console.WriteLine("                                          :  .               .....,:;;!.            .~~   ");
                        Console.WriteLine("                                          :.                  ...-::;;;             ,:-   ");
                        Console.WriteLine("                                          -~                 ..,,*;:;!-            .-:-   ");
                        Console.WriteLine("                                          .;               ....,~*:~:;            .,-:,,  ");
                        Console.WriteLine("                                           --              ..,,~;~~~;,             .,:;~  ");
                        Console.WriteLine("                                            ~.           ...,~!;~--::              ..,!.  ");
                        Console.WriteLine("                                            --       .  .--~!*,---~:             ...,::   ");
                        Console.WriteLine("                                             -~,. ,,,:--:;!!:-----:,             .,,-;,   ");
                        Console.WriteLine("                                              -!:-!:!:;;;;:!~-----!!             .--~;.   ");
                        Console.WriteLine("                                              ,::!-~~-~~:;;!-..---::             .,~::    ");
                        Console.WriteLine("                     ...---,.                .;--,-----~~:*~..,,,-:,             .,~;-    ");
                        Console.WriteLine("                   .-;::;;-,:~-              .:,.....,-~-;;,...,--:            ...,-;     ");
                        Console.WriteLine("                   :;~!@@@=~,-:.             ~.    ..,--~*-...,--~~             .,,-;     ");
                        Console.WriteLine("                  ~:~:=@@@@@$~,--           -,     ..,-~:,..,,---:-             .--~;-    ");
                        Console.WriteLine("                  *~~!=@@@@@@*--:           ~.      ..~~.  .---~~:-.           .,-~~;     ");
                        Console.WriteLine("                 ,~~:*$@@@@@@@:!!           *.      ..:.  ..~;~::=,.          .--~::~     ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:;$~          -,      .,:.  .-;;:::*,..-. .. ..,::~:;:.     ");
                        Console.WriteLine("                 ;;;*$@@@@@@@@:~==.         ~,    ..,-~:..,-::, .~:-:~~,:~-:~;~:;:;~:     ");
                        Console.WriteLine("                ;#@@@@@@@@@@@@=:#@:         ~,~-.,!~--:!----~:;  -!; .;!,,!,;~  ;=:,;     ");
                        Console.WriteLine("              ~*$@@@@@@@@$=#@*:~=~:         ~:-~~:.~::--;~~~:~*  ,;.  ,!.   -:  .~~,;     ");
                        Console.WriteLine("             .;;!**=$$$=*=:=*-,-~           ~, .~  ,:, -;;!;;;;,  :.  .=.  .-:   ,-,;     ");
                        Console.WriteLine("                .~#@$$$#@@:~.. ~,           ~, ,~...!,::,,,~-,-~ .;-,,,*,.,,~;,,,,~;.     ");
                        Console.WriteLine("                  ~@@@@@@#:.   .,           ,:::~:::~:;;;;!:~::-  ,;::;:;::;:;:::::       ");
                        Console.WriteLine("                  .*@@@@@;:.   ,,                                                         ");
                        Console.WriteLine("                 .,~$@@#!-,,  -:                                                          ");
                        Console.WriteLine("                -::~*@*~,,,---~                                                           ");
                        Console.WriteLine("               ~-..-!=-.,,~:~,                                                            ");
                        Console.WriteLine("              ~,   -!;. .-*,    ~,                                                  ::.   ");
                        Console.WriteLine("             ,:.  ..-*-. ;=!,~-:~--                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,--~~~!;~---!-~;=;-,~!~~     .,!#~                                    -$@#,   ");
                        Console.WriteLine("         ~:,,---~~~==:~:;..-~;=!::~.    .;=##!::::::::::::::::::::::::::::::::::::=#$:    ");
                        Console.WriteLine(" ~::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::~ ");
                        Console.WriteLine("!;-                                                                                    -;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.           1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!:.                                                                                    .;!");
                        Console.WriteLine(" ~::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::~ ");

                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격


                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }

                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                       
                        Console.WriteLine("                                                        .        .                        ");
                        Console.WriteLine("                                                       ...     .     .                    ");
                        Console.WriteLine("                                                      .   .  .         ..                 ");
                        Console.WriteLine("                                                                   . .  .                 ");
                        Console.WriteLine("                                                                   .                      ");
                        Console.WriteLine("                                                       .-  .      .                       ");
                        Console.WriteLine("                                                     ..,.,.     ...     .                 ");
                        Console.WriteLine("                                                     . .         .    .                   ");
                        Console.WriteLine("                                             ...     .                 .                  ");
                        Console.WriteLine("     Warning  예티가 공격합니다!!           ,.. .,.  .                  ,,.               ");
                        Console.WriteLine("                                         ..   .   ...                  ..,                ");
                        Console.WriteLine("                                        . . . .   .,   -.      .-     ..,,                ");
                        Console.WriteLine($"         HP:{monster.GetHP()} Att:{monster.GetAtt()}             .   .  ......-.,:     .~,.    ..,.-~~~-,          ");
                        Console.WriteLine("                                        .       . ...-..~     .,,.   ...~~--,,,-:-,.      ");
                        Console.WriteLine("                                        . .       .,, .-..-  -..-.   ...,,,,,.....-,,     ");
                        Console.WriteLine("                                        ....  .  ..--.~,:~.~~.~:.~   ...,-,..     ..,,    ");
                        Console.WriteLine("                                        ,        ..-.                 ..,,,         .,,   ");
                        Console.WriteLine("                                        ..       ..,.                ...,,,          .,-  ");
                        Console.WriteLine("                                         ,      ...-.                ..,,,.           .-, ");
                        Console.WriteLine("                                          -      ..,-                ..,,-,           .,, ");
                        Console.WriteLine("                                           ,,     .,-,.................,---,-,         ., ");
                        Console.WriteLine("                                            .,    .,,---..,.,........,-,----~,,.        ..");
                        Console.WriteLine("                                              -....,,,,-*~---~~:-~~~--,,,,,,,- ,        ..");
                        Console.WriteLine("                                               ,--------;-,,,,,,,,,,,,,,,,,,,-.,          ");
                        Console.WriteLine("                     ...~:;:,.                   ,.......~............,,,,,,,-.           ");
                        Console.WriteLine("                    -!!:::-.~:~,                         .-............,,,,,,-       .  . ");
                        Console.WriteLine("                   ~;:;@@@$*:,~-.                         ,,.         ..,,,,-. .    .   . ");
                        Console.WriteLine("                  -:~:!@@@@@@*-,:.                         -.         ..,,,--  .   .  .   ");
                        Console.WriteLine("                  :~~;*@@@@@@@:,!.                         .,          ..,--   ..   ,.    ");
                        Console.WriteLine("                 .~~~!=@@@@@@@$:#,                         ~   .,,,,,  ..:-               ");
                        Console.WriteLine("                 ,;~;*$@@@@@@@#~$*,                       ,-....-...,   .,-,              ");
                        Console.WriteLine("                 -!:*=@@@@@@@@#-:#;                       ,~-----   .-,..,-~              ");
                        Console.WriteLine("               .:$@@@@@@@@@@@@#;*@$,                       ,:~~;       ~-,-.              ");
                        Console.WriteLine("              -!=#@@@@@@@#$=@#;~*!~,                         ,-.        -.                ");
                        Console.WriteLine("              ~!;***=$$=*==:=:,,;.                                                        ");
                        Console.WriteLine("                 -*@$$$$@@$,,..,~                                                         ");
                        Console.WriteLine("                  -#@@@@@@$..   -.                                                        ");
                        Console.WriteLine("                   ;@@@@@=!,   .~                                                         ");
                        Console.WriteLine("                  ,,*@@@=~-,.  ~,                                                         ");
                        Console.WriteLine("                ,:;:;#$;,,,--.~,                                                          ");
                        Console.WriteLine("               ,~,.,:=;.,,-::-.                                                           ");
                        Console.WriteLine("              --   ,;!-  ,!!.   ,-.                                                  -~-  ");
                        Console.WriteLine("              :,   .,!:  ,#*~~--:--.                                                 *@=  ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("          !-,,--~~;;----:;-;*!~  ::;.      .;=.                                     :@@=  ");
                        Console.WriteLine("         -;-,---~~~**:~-;- -~~!*!=*~     .;$@#-,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,:#@#-  ");
                        Console.WriteLine("         -~,,,,,---:=!--:,.,,::~...      ,~:::~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~::-   ");
                        Console.WriteLine("                   ...       .                                                            ");
                        Console.WriteLine(";;$=====================================================================================$=");
                        Console.WriteLine("!!~                                                                                     .=");
                        Console.WriteLine($"!;,               {monster.GetAtt()}만큼 피해를 입었습니다!!                                            !");
                        Console.WriteLine("!;,                                                                                      !");
                        Console.WriteLine("!;,                                                                                      !");
                        Console.WriteLine(";;$=====================================================================================$=");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }
                    }
                    break;

                default:
                    break;
            }

        } // 중급
        private void RandomMonster3() 
        {
            int randValue = rand.Next(0, 3);
          
            switch (randValue)
            {
                case 0:
                    monster = new Balrog();

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                          -.                              ");
                        Console.WriteLine("                                                       .  :~.   -     .-~-,               ");
                        Console.WriteLine("                                                      ,=-,:-~,,.-!.  ,!!*!!=;             ");
                        Console.WriteLine("                                                   .:$##**!,;~~;;*#=!*=!;;!!$~            ");
                        Console.WriteLine("                                                  .*#;=*!:;~::-~:~**#@@=!;*$@#:           ");
                        Console.WriteLine("                                                  -#=***:,,,,-::,.!$##@@$$@#*##*          ");
                        Console.WriteLine("                                                  ,$@#$#$=;:**#=~:$$#$#@@@@=!@##=.        ");
                        Console.WriteLine("                                                   !#@@=!*****!;;!=##@#@@#=;!$$##*.       ");
                        Console.WriteLine("         발록                                      :!*=~*=*::---;;=#@@@@$*!!*=$###;       ");
                        Console.WriteLine("                                                  -*!!*-;---:,,:;;;!@@@#$$$==#$####:      ");
                        Console.WriteLine($"           HP:{monster.GetHP()} Att:{monster.GetAtt()}                           *=***!:--~!***:***@#$##*#$=@=$###$      ");
                        Console.WriteLine("                                                 ,$$$==-!!!*~;*=!!;*$@#@@=@###=$####-     ");
                        Console.WriteLine("                                                 !$#$$$*:-,-:!!$*~-*=$#$###*==*$####;     ");
                        Console.WriteLine("                                                -!$#$$#=::~:~***:-;=$$##$$#==*!=####*     ");
                        Console.WriteLine("                                                :*##$*#*;*;;;**;~;*$$#$#!!=##!!*$###=.    ");
                        Console.WriteLine("                                                ;=##=!=;;=$$$*:-:;!*##*==!;==!*=$###$-    ");
                        Console.WriteLine("                                               ,!$##$!=:-!*!;;:-!**:*=*=#*!**;*$$$###;    ");
                        Console.WriteLine("                                               ,*$###*=*~~~!*;:;=$$$===$##*****$$$###$.   ");
                        Console.WriteLine("                                               ~*$###==$!:;!**=$$###=**=$#$=*===$$$###!   ");
                        Console.WriteLine("                                               !*$####=##$$#######$=$=**$#.*=$$$$$$$###~  ");
                        Console.WriteLine("                                              ,*$$#####$###;  -*!=!!;!=$$#!*$$$$$$$#####! ");
                        Console.WriteLine("                                              -*$$#########:   *=**!*=$$$#==$$$$$########!");
                        Console.WriteLine("                                              :*#$####=$###;  .=$*!!$$$$$#*$$$$$#########:");
                        Console.WriteLine("                                              ;=##$##==*=$#!  ~#$$==$$=*=$=$$$$########=- ");
                        Console.WriteLine("                                              ;$##$##@$==$##- *$$####=!**=$$$$$#$#####*,  ");
                        Console.WriteLine("                       .,,,.                  $$#####@$*=$##~,=!=$##*=!!=$#$$$$#####$-    ");
                        Console.WriteLine("                    ,:~~!;:-~-,               $$#######$$$==!~!!=###;$!*$$####$#####!     ");
                        Console.WriteLine("                   ~;~!##$!~--:.              #$######=***$**!*!=###.**$$###########,     ");
                        Console.WriteLine("                  -;~:=@@@@@=~,-,             #$######===*#=!:=!*$##.~$$###########*      ");
                        Console.WriteLine("                  !~~!=@@@@@@*--:             #$#####=*=$*=*!.~=$$##*-=$###########;      ");
                        Console.WriteLine("                 ,:~:*$@@@@@@#~;!             *$####:.~*$*!!~  :=####;$############:      ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:!$-            ;$###!     ,:~     ~#################:      ");
                        Console.WriteLine("                 ;::*$@@@@@@@@:~==.           ;$##$,              !##$#############:      ");
                        Console.WriteLine("                :$##@@@@@@@@@@*:$@~           -$##!               ~#$##############:      ");
                        Console.WriteLine("              ~*#@@@@@@@@#$#@=::=:;.          ,$##,               -=#########====$$$      ");
                        Console.WriteLine("             .;;!===$$$===;=*~,-:              $##                ;$#####@@@=.....-:      ");
                        Console.WriteLine("              ...~##$==#@@:~.. -,              ;##               -$##@@#!@@@=             ");
                        Console.WriteLine("                  :@@@@@@#:,   .,              -$;               ==~~##=-=@#;             ");
                        Console.WriteLine("                  .*@@@@@!:.   ,-              .*!              ::.  ,,. -!~              ");
                        Console.WriteLine("                 .,~$@@#*--,  ,~                -$              .                         ");
                        Console.WriteLine("                -:;:*@*~,,,-,,~                  ~                                        ");
                        Console.WriteLine("               ~-..-;$-.,,~::,                                                            ");
                        Console.WriteLine("              ~,   -!;. .-*-    -,                                                  ~~.   ");
                        Console.WriteLine("             ,:    .-=-  ;=!,~,:~--                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,--~~~!;~---!~~;=;,.~;~~      ,!$~                                    -$@#,   ");
                        Console.WriteLine("         ~:,,---~~~==~~:;..~~:=!:;~.    .;=##;~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:*##;    ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine("~~!************************************************************************************!~~");
                        Console.WriteLine("!;-                                                                                    -;!");
                        Console.WriteLine("!;.         1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                  .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.************************************************************************************.;!");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격

                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;
                                    default:
                                Console.WriteLine("잘못 입력했습니다.");
                                break;



                        }

                        // 몬스터 타격
                        Console.Clear();
                      
                        Console.WriteLine("                                                  -!*          ,;~.                       ");
                        Console.WriteLine("                                                 -**;          :**=!-                     ");
                        Console.WriteLine("                                               .:*==,          -*$$==;~                   ");
                        Console.WriteLine("                                               ;=#$=           .!$###$=:                  ");
                        Console.WriteLine("                                             ,*=$$$;            :=$$##$$;.                ");
                        Console.WriteLine("                                           ,;$$$=$$!            ~=$$#$$$$*.               ");
                        Console.WriteLine("                                          ;*$#$*$#$!            ;$$$#$$$$$=.              ");
                        Console.WriteLine("     Warning  발록이 공격합니다!!       ,*=##$*$#$$#     -,    ,!$$$$#$$$$$*,             ");
                        Console.WriteLine("                                       ~=$$##=$##$$$~    .!;~,.;$$$$#$$$$$$$=.            ");
                        Console.WriteLine("                                      -=$$$##$@$$$$$$!-, . :$@##$$$$$$$$$$$$$$.           ");
                        Console.WriteLine($"           HP:{monster.GetHP()} Att:{monster.GetAtt()}               ,*$$$$##@$$$##$*!*=###**##@#$$$$$$$$$$$$$=,          ");
                        Console.WriteLine("                                    ,!$$$$$$@@#####=*$#@#######@@######$$$$$$$#*          ");
                        Console.WriteLine("                                    :=$$$$$#$##@$=;*!!;;!=##@#@#@$########$$$$$$!         ");
                        Console.WriteLine("                                   ,!$$$$$##$=!!!~!;~~;;;!$$$####$$#######$$$$$$$:        ");
                        Console.WriteLine("                                   -=$$$$$#$$!**;:--:;!!*!*#$#$$$$=$$#####$$$$$$$$~:;-..  ");
                        Console.WriteLine("                                   :$$$$$#$$$*$=:*::;-;$**=$$$=$$$=!*$#####$$$$$$$!*$$!~~ ");
                        Console.WriteLine("                                   *$$$$$#$$$=$!;;--~:;!$=*!*==**!!!*=####$$$$$$$=::*;~-~-");
                        Console.WriteLine("                                  .=$$$$$$$$#$#:;-:~~,!$==*!!*$*!!!!=$####$$$$$$$$*!:;!;:;");
                        Console.WriteLine("                                  ~=$$$$$$$$$#!-;;=!:=*=*!!!;;;!*!!!*$$$$##$$$$$$##*-,~=;=");
                        Console.WriteLine("                                  ~$$$:;$$$$$#:--~!=**!!!;;:~:;;*$$$$==**$$$==###=*$=!:*=!");
                        Console.WriteLine("                                  ;$#:  $$$$$$;---~:~;;;:~~--~;!*$$=*****=*!!*==$=$$$=*=*,");
                        Console.WriteLine("                                  !$!   $$$=  !~--~~~-~~------;!*##=!!!!**!!!!=$$######=- ");
                        Console.WriteLine("                                  !$,   ~$*   ~!!;!!!;:~----~:;!=$=:!*****!**==$$$!*###:  ");
                        Console.WriteLine("                                  $!    .=,    *=$$==*!!;;;;;!=$$-. .,-!!==$$$$*-, .;$#*  ");
                        Console.WriteLine("                                  $~    .:,.  *!*=$##!!$=!==*$#$!        !=,         !$=, ");
                        Console.WriteLine("                        ...       -     !:;=!:$=!!*$=--*==#!!!=$!.      .,           ~$=, ");
                        Console.WriteLine("                     -,-;;;~~,         ~!$$=*=$====~.  :====$**$$=*-                  *=  ");
                        Console.WriteLine("                   ,!;*$$*-.-:!       ,::$=*:;#$=~:   :$$*!!!*=$$$$$$.                !;  ");
                        Console.WriteLine("                  ,;~~*@@@@=;--,.      ;;;$**;:-     :$$$$=**=$$=**=$=,               ,.  ");
                        Console.WriteLine("                  ;~~!=@@@@@@!--:       .:;$~-      -***$$##$$#=!!!!=$!                   ");
                        Console.WriteLine("                 .*~~!=@@@@@@$-~;        ==         *!!!=$##==,!=!!**$#~                  ");
                        Console.WriteLine("                 ~~~;*#@@@@@@@:!=,       -.        .!!!!=##$,. :##$$=$$,                  ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:~#*                 -!!!*$##=    *$##!~~                   ");
                        Console.WriteLine("                ,*==$@@@@@@@@@;~=#                  -**$;##$.    $@@#@=.                  ");
                        Console.WriteLine("              ,;$@@@@@@@@@##@#!:$!                   ,-*####~    :$#@@@$,                 ");
                        Console.WriteLine("             .!!*==$@@@#=!;$#:-~;.                    ;#@@#@;    .$#@@@#~                 ");
                        Console.WriteLine("              ,-~!$$*!*=$#:;-,.-,                      .....      ......                  ");
                        Console.WriteLine("                  !@@@@@@@:,   ,,                                                         ");
                        Console.WriteLine("                  ,$@@@@@=;.   .,                                                         ");
                        Console.WriteLine("                  .~#@@@$~-,  .~.                                                         ");
                        Console.WriteLine("                ,~~~$@=;~,,,.,~.                                                          ");
                        Console.WriteLine("               .:.,-:@:,,,,!=~.                                                           ");
                        Console.WriteLine("              ,:   -!!, .-!-    ,.                                                  ,,    ");
                        Console.WriteLine("             .:    ,~=,  :$;.-.-~-,                                                .$$,   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("          ;-,---~~!:----!:~:=;. ~:~~       :*-                                    .*@@-   ");
                        Console.WriteLine("         ~:,,--~~~:*!~-~;..~~~===$*,     ~$@@:...................................,*@@*.   ");
                        Console.WriteLine(";;$====================================================================================$;;");
                        Console.WriteLine("!!~                                                                                    ~!!");
                        Console.WriteLine($"!;.                         {monster.GetAtt()}만큼 피해를 입었습니다!!                                  .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(";;$====================================================================================$;;");

                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {

                           
                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");

                            _player.PlaySync();
                          
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");
                            Thread.Sleep(1000);
                            mode = GameMode.Town;


                            break;
                        }
                    }
                    break;
                case 1:
                    monster = new Magnon();

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                .-     -                                  ");
                        Console.WriteLine("                                                ,!    .:.                                 ");
                        Console.WriteLine("                                                -!    -*                                  ");
                        Console.WriteLine("                                               .,;   .-!                                  ");
                        Console.WriteLine("                                               ,-* .-,~-,-                                ");
                        Console.WriteLine("                                          ..   --*.:~,:--- .,                             ");
                        Console.WriteLine("                                          ,~, .,~!~~,-!~-~-~~. .-                         ");
                        Console.WriteLine("                                           :~.-.~!;~,~;:~~~-;:--:.                        ");
                        Console.WriteLine("                                           ~,:;-:!:,,~;!;--;;:~:~~. ,~         ..,:;      ");
                        Console.WriteLine("     마뇽                                 ~~-~ .-;-.,~!~.-;;;;;:::~~--   ,--,,-;::-       ");
                        Console.WriteLine("                                          ,;;, .-~ .,~;~:!!;;;;;;;::~-.  --,-::-,-        ");
                        Console.WriteLine($"         HP:{monster.GetHP()} Att:{monster.GetAtt()}                       --.::~~:-~. :;~;:~~~::::;;;:~:~::~:-,.:.       ");
                        Console.WriteLine("                                            .~,...-~:-:~!~;*:~~~~~~::::;;:*. ,:           ");
                        Console.WriteLine("                                             , . ,:;!-:.. ::~:~~~~~~:::;:~~               ");
                        Console.WriteLine("                                            ,....-;;      ,-.,~~~~~~~:::::~.              ");
                        Console.WriteLine("                                         ,.-... .-:- ,.,.~:  .---~~~:;::::-- -.           ");
                        Console.WriteLine("                                          ~.,. .~..,~.~-:-~   ,.-.,-;::::::, :,-..~  .    ");
                        Console.WriteLine("                                          .!,.,-~::.~.~,~,,-.,~,,.~:-:~:::;-,:,-~:~-~~.   ");
                        Console.WriteLine("                                           ,~-:;;~..!~~.., .,.--;~;-~~~::::~-;-::::::::-  ");
                        Console.WriteLine("                                               ..   :.  ..- .~-.,:-,-:!;:::;::::~~~~~~:~, ");
                        Console.WriteLine("                                                   ~.      -..;~,.,- . .:!;;::::~~~~~~~;~ ");
                        Console.WriteLine("                                                 ,,.  .... .-~:~;~~  ...~;!*:~~~~:::~~~~~ ");
                        Console.WriteLine("                                               .-,        ..-~::;:;-.  ,:;**;~~::;:~~~~~~.");
                        Console.WriteLine("                                               ~,.          .,!;~.  -;~~!*!*;~::;:~..--~:.");
                        Console.WriteLine("                                             .,.    .......,-..-,.    .-~;!*;::;::--. --;.");
                        Console.WriteLine("                                            ..-      .... ..-..-.     .-:;;*;:;;:~, .,,.:.");
                        Console.WriteLine("                                            ,,,            .,. -,    .,~:!!*;;;;:~   .,.~.");
                        Console.WriteLine("                                           .,,    ........,,-..,~,,.,-:;!!!!;;;:~~   ,, -.");
                        Console.WriteLine("                                           -..    ..........,,..,:;:;;;!**;;;;;:;    ,- ,.");
                        Console.WriteLine("                       .....               ~.,  ............-,.,---::::~::;;;;;:~    ..,. ");
                        Console.WriteLine("                    .:--;;:-:,.            ---.........,,,--~-,---~~:,   ,~:!:::       -  ");
                        Console.WriteLine("                   -!:*$#=:,,~;.            :-,...........,,-~---~~~:.   .-:;:::.         ");
                        Console.WriteLine("                  ,;~~=@@@@#*-,-.           !-,,--,,,,,,------~-~~~~;   .,-~::::.         ");
                        Console.WriteLine("                  ;~~!=@@@@@@!--:           ;:-,--------------:~~~~~:   .-~:;::;.         ");
                        Console.WriteLine("                 .;~~*=@@@@@@#~;;           -~~----------:::-~~~~~:::...,-::::::          ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:!=,          .~;~~~~-------~~~~~~::::::~~::!:::::          ");
                        Console.WriteLine("                 :::!=@@@@@@@@:~=*           .-~::~~~~~~~~~~~~~~::::::;;;;::::::          ");
                        Console.WriteLine("                ,=###@@@@@@@@@;~$@-              !*:;;~~~~~:;;::;;;;:;;..~:;:;::.         ");
                        Console.WriteLine("              ,;#@@@@@@@@@##@$*;$!;             ,.~~;*:;:;;;;;;:~--;~   .,~~~;::~         ");
                        Console.WriteLine("             .!**===#@@$==;$$:,-;..              .-:-;-;.~~~~~-          .,;-!-:          ");
                        Console.WriteLine("              .,-!#$*!*$#@::-,.-,                  ... .                   ... .          ");
                        Console.WriteLine("                  ;@@@@@@@:,   .,                                                         ");
                        Console.WriteLine("                  .$@@@@@*:.   .-                                                         ");
                        Console.WriteLine("                   ~#@@@=--,  .:.                                                         ");
                        Console.WriteLine("                .:=:*@$;-,,-..:                                                           ");
                        Console.WriteLine("               -~,.-!#~.,,-:~-.                                                           ");
                        Console.WriteLine("              -~   ~!:, .-;,.   .                                                   ..    ");
                        Console.WriteLine("             .:    .:=,  :$;.,.-;-,                                                .@@-   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,---~~*:~---!~~-=:..-::~      .-*-                                    .*@@,   ");
                        Console.WriteLine("         -:-,---~~:*!~-~;..::;*;;!~,    .:*@@;-----------------------------------~*@@*.   ");
                        Console.WriteLine("                                                                                          ");
                        Console.WriteLine("!;######################################################################################;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.          1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                 .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;######################################################################################;!");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격


                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }


                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                                                               ..,,,,,,.  ");
                        Console.WriteLine("                                                                            --;!~;;;;!~   ");
                        Console.WriteLine("                                                        .,-.     ,,     .-;;:;-...  .,    ");
                        Console.WriteLine("                                                     .,~~:!     ,:-  ,-~;~~,..      .,    ");
                        Console.WriteLine("                                                   .~~~~~~:     ~~-.~~;~..          -     ");
                        Console.WriteLine("                                              -;  ,~~~~~~~~     ~~:~:~.       .. .,--     ");
                        Console.WriteLine("                                              ;:--~~~~~~~~:   ,~~~~;~---..    .~,--.      ");
                        Console.WriteLine("                                              ~~~:~~~~~~~~~~,~,-!~~:;;:--;:,.  -~...-     ");
                        Console.WriteLine("     Warning   마뇽이 공격합니다!!          ..~;~~~~~~~~~:;-,,-:!!~:~-,~~::~:~,.    -     ");
                        Console.WriteLine("                                          .,-,-;~~~~~~~~~::-:~,,-!::;:-. ...,-;:~.  -     ");
                        Console.WriteLine($"      HP:{monster.GetHP()} Att:{monster.GetAtt()}                   .~;!~~~~-~~~:;~~~~:- ~:,.-:~,     .,;;- -     ");
                        Console.WriteLine("                                               ---~~~~-~~:~~~~-. ~:,  .~:-       .~:-,    ");
                        Console.WriteLine("                                                 .,~~::~~~~~!~   ::,  .,,:~      .,-:;    ");
                        Console.WriteLine("                                                   ,~:-,:~~~:. .:~:,  -,~,*-   .,--~,:-   ");
                        Console.WriteLine("                                                    ~~:!;;:::~---~;,,.,~-.,:-  -          ");
                        Console.WriteLine("                                                    ::~:::~~:~,-~;~.:--~   -:..,          ");
                        Console.WriteLine("                                                   ,.:~:~~:~,,~:;~.  ,. -   -;,.          ");
                        Console.WriteLine("                                                 .,~-:~~~~~~~~:;~.,-~-- .,.,,;:           ");
                        Console.WriteLine("                                                .,-;~~~~~~~~~~~:;:;!;;.    ....           ");
                        Console.WriteLine("                                                -.,~~~~~~~~~~~~~~~~::!-                   ");
                        Console.WriteLine("                                               .,.,~~~~~~:~-----~~~~~:;                   ");
                        Console.WriteLine("                                               -..-~~~~~:!:-,,.,-~~~~:!                   ");
                        Console.WriteLine("                                              ~,,~-,-~::*; -,....-~~~~:;                  ");
                        Console.WriteLine("                                             -*::~~;~:=;**~.-....,~~~~:;     ,.-:::,,     ");
                        Console.WriteLine("                                             ::;~~~:;;;!;:: -,...,-~~~::,  :,,-~~~~~:-    ");
                        Console.WriteLine("                                            .,,,~~~~:;;;**. :~,,,,~~~~:~:,,,-~~~;.  .;    ");
                        Console.WriteLine("                        ...                 .-;:;::~:~:~~: .:;:~--~,-~::~~~~~;-.          ");
                        Console.WriteLine("                     -,-;;;~~,                -;:~~~~:::~  .:~:;*::.~~;:::::,.            ");
                        Console.WriteLine("                   ,!;*$$*-.-:!                             ~~:~*.--~;~-,                 ");
                        Console.WriteLine("                  ,;~~*@@@@=;--,.                           .,-::;~~*$!*:                 ");
                        Console.WriteLine("                  ;~~!=@@@@@@!--:                             ~~!   ,;;!.                 ");
                        Console.WriteLine("                 .*~~!=@@@@@@$-~;                           .-:~=: .~-!--                 ");
                        Console.WriteLine("                 ~~~;*#@@@@@@@:!=,                          .,:!;~ ~!~;!.                 ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:~#*                             .    ...                   ");
                        Console.WriteLine("                ,*==$@@@@@@@@@;~=#-                                                       ");
                        Console.WriteLine("              ,;$@@@@@@@@@##@#!:$!;                                                       ");
                        Console.WriteLine("             .!!*==$@@@#=!;$#:-~;..                                                       ");
                        Console.WriteLine("              ,-~!$$*!*=$#:;-,.-,                                                         ");
                        Console.WriteLine("                  !@@@@@@@:,   ,,                                                         ");
                        Console.WriteLine("                  ,$@@@@@=;.   .,                                                         ");
                        Console.WriteLine("                  .~#@@@$~-,  .~.                                                         ");
                        Console.WriteLine("                ,~~~$@=;~,,,.,~.                                                          ");
                        Console.WriteLine("               .:.,-:@:,,,,!=~.                                                           ");
                        Console.WriteLine("              ,:   -!!, .-!-    ,.                                                  ,,    ");
                        Console.WriteLine("             .:    ,~=,  :$;.-.-~-,                                                .$$,   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("          ;-,---~~!:----!:~:=;. ~:~~       :*-                                    .*@@-   ");
                        Console.WriteLine("         ~:,,--~~~:*!~-~;..~~~===$*,     ~$@@:...................................,*@@*.   ");
                        Console.WriteLine("         ~-,,,,,---!=:-:~..,-::-        .::::::::::::::::::::::::::::::::::::::::::::.    ");
                        Console.WriteLine("                   ... .    ..                                                            ");
                        Console.WriteLine(";;$====================================================================================$;;");
                        Console.WriteLine("!!~                                                                                    ~!!");
                        Console.WriteLine($"!;.                  {monster.GetAtt()}만큼 피해를 입었습니다!!                                        .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(";;$====================================================================================$;;");
                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {

                           
                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");
                          
                            Thread.Sleep(1000);
                          
                            mode = GameMode.Town;


                           
                            break;
                        }
                        
                    }
                    break;

                case 2:
                    monster = new PinkBean();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("                                                     .;==-.               .-:!!!          ");
                        Console.WriteLine("                                                     ,===*;~,           ,:!*~:!*          ");
                        Console.WriteLine("                                                     ,=;;!*==~        ,~~!;:!!**          ");
                        Console.WriteLine("                                                     ,!;**!!*=~~~-~~:;!:~:=;;=#*          ");
                        Console.WriteLine("                                                     ,!!;!!:-        .!;;;!*!!*!          ");
                        Console.WriteLine("                                                     ,;:*;,           ;;;;*=$=$:          ");
                        Console.WriteLine("                                                     ,;*-             -*;;;!***-          ");
                        Console.WriteLine("        ※위험※ 핑크빈                              ,*,               ~!;;!***-          ");
                        Console.WriteLine("                                                     ,~                 -!=**=*,          ");
                        Console.WriteLine("                                                     ,-                  .,:;;;           ");
                        Console.WriteLine($"         HP:{monster.GetHP()} Att:{monster.GetAtt()}                                 -.                ...,~,   ,--~~. ");
                        Console.WriteLine("                                                     ~                   ....,~-  .~ .-!: ");
                        Console.WriteLine("                                                     ~  ..          .,.   ...,--  --.,:*!.");
                        Console.WriteLine("                                                     ~ ,=*!        ,$*=.  ....-:  .*~:;*; ");
                        Console.WriteLine("                                                     - ~*-=        :=,$-  ....,:  ,!=*==- ");
                        Console.WriteLine("                                                     ~ .*$~         *#!   ....,:, ~~;~~.  ");
                        Console.WriteLine("                                                     ~. .   .-~,.          ...,-:.:~:     ");
                        Console.WriteLine("                                                     -.     .,,.           ...,-;.~;,     ");
                        Console.WriteLine("                                                     ~.                    ...,-!,~!      ");
                        Console.WriteLine("                                                     ~.-               -. ....,-:-~;,     ");
                        Console.WriteLine("                                                     : :.             --   ...,-~~~-;     ");
                        Console.WriteLine("                                                     : .:            -~  ,~...,--~.;~~    ");
                        Console.WriteLine("                                                    -~-.~,           :,-~:....---~ ;~~    ");
                        Console.WriteLine("                                                    :,-~-            ,-,,....,---: -::    ");
                        Console.WriteLine("                                                   -,                     ...,--~: .::    ");
                        Console.WriteLine("                                                   ~.                    ...,,--~: .::    ");
                        Console.WriteLine("                     ..,;;;-..                    .~                     ..,,---~: ,::    ");
                        Console.WriteLine("                   .:*!;;~..;:~                   .~.                  ...,,,---:~ ;:~    ");
                        Console.WriteLine("                  .:;~*@@@$!~-~,                  .~.                 ....,,---~*-:;;,    ");
                        Console.WriteLine("                  :~~;=@@@@@#;,-~                  ~,               ....,,,----;*!;~.     ");
                        Console.WriteLine("                 .=~~!=@@@@@@=--;               .. ~-.....       ......,,,----~!:-        ");
                        Console.WriteLine("                 -~~;*#@@@@@@@:!*.              ,*~-!-,,..............,,,-~:;!*-          ");
                        Console.WriteLine("                 ::~!*@@@@@@@@:;$;              ,*!~:;;:-,.......,,,,,,--;!;!**;          ");
                        Console.WriteLine("                 ;;;*#@@@@@@@@:-*$,             .*=;~:;*$;-,,-,,,,,----:*!;;!**=;         ");
                        Console.WriteLine("              .-*#@@@@@@@@@@@@*:$$;               ::~~~~:;;~~~~~~~~~~:::::::;;;;.         ");
                        Console.WriteLine("             .:!=###@@@@#=*#@!~~!,-                                                       ");
                        Console.WriteLine("             .:!!*!*****!#:*;,.--                                                         ");
                        Console.WriteLine("                 ,=@###@@@:-   -,                                                         ");
                        Console.WriteLine("                  -#@@@@@$;.   .-                                                         ");
                        Console.WriteLine("                   ;@@@@@:~.   -,                                                         ");
                        Console.WriteLine("                .,~~$@#=:,,,  --                                                          ");
                        Console.WriteLine("               .~~~~!@;-,,,::-,                                                           ");
                        Console.WriteLine("              .;. .-!*,.,,:~,.                                                            ");
                        Console.WriteLine("             .:.   ,;!,  ~=~ . .~,.                                                 !!.   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("          ~~----~~;~----;!-,;:..:~;-       .~.                                     ~@@-   ");
                        Console.WriteLine("         ,;-,--~~~;!:--~!,-:!:::;*;-     .:=#~                                   .:#@$,   ");
                        Console.WriteLine("         ::,----~~~=#:~:;..--;=;,,,     ,*=$$*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*=$=-    ");
                        Console.WriteLine("         ,,........~:~.-....--                                                            ");
                        Console.WriteLine(":~*====================================================================================*~:");
                        Console.WriteLine("!;,                                                                                    ,;!");
                        Console.WriteLine("!;.          1.공격한다     2. 고유 스킬사용    3.일정 확률로 도망가기                 .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(":~*====================================================================================*~:");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                //플레이어 타격
                                _player2.PlaySync();
                                DMG = player.GetAtt() + player.GetWeapon();
                                monster.OnDMG(DMG);


                                if (monster.IsDead())
                                {

                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }
                                break;
                            case "2":
                                //플레이어 타격

                                Skill = player.GetSkill();
                                if (Gold >= Skill)
                                {
                                    Gold -= Skill;
                                    monster.OnSkill(Skill);
                                    Console.WriteLine("스킬을 사용했습니다.");
                                    Console.WriteLine("남은 골드: " + Gold);
                                }
                                else
                                {
                                    Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                                    Thread.Sleep(2000);
                                }



                                if (monster.IsDead())
                                {


                                    Exp = player.GetExp() + monster.GetMexp();
                                    player.XP(Exp);
                                    Gold = player.Getgold() + monster.Getgold();
                                    player.Gold(Gold);
                                    Console.WriteLine("                                                                               .:!:,      ");
                                    Console.WriteLine("                                                                               *@@@=.     ");
                                    Console.WriteLine("                                                                              ,#@@@#~     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                           ...~#@@@#;...  ");
                                    Console.WriteLine("                                                                         .*@@@@@@@@@@@@@=.");
                                    Console.WriteLine("                                                                         ;@@@@@@@@@@@@@@@!");
                                    Console.WriteLine("                                                                         *@@@@@@@@@@@@@@@@");
                                    Console.WriteLine("                                                                         !@@@@@@@@@@@@@@@=");
                                    Console.WriteLine("                                                                         -$@@@@@@@@@@@@@$-");
                                    Console.WriteLine("                                                                          ,:::!@@@@@*:::- ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("                                                                              -#@@@#:     ");
                                    Console.WriteLine("            .:*==========!.     -!;             ,!*~       ..........         -#@@@#:     ");
                                    Console.WriteLine("           .*@@@@@@@@@@@@@@,   !@@@@.          -#@@@:    ,=@@@@@@@@@@@*:.     .#@@@$,     ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@#  ~@@@@@$         ,#@@@@#   .!@@@@@@@@@@@@@@@*,    -#@#~      ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@. :@@@@@@;       .*@@@@@@,  ,#@@@@@@@@@@@@@@@@#:     .        ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@#  ~#@@@@@#~      !@@@@@@@,  -#@@@@@@@@@@@@@@@@@#:             ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@$:   :#@@@@@$,    ~@@@@@@@*   -#@@@@@@@@@@@@@@@@@@#~            ");
                                    Console.WriteLine("           !@@@@@*;;;;;;;;-    .!@@@@@@!   -#@@@@@@=,   -#@@@@@=;;;;;*@@@@@@@!.           ");
                                    Console.WriteLine("           !@@@@@-               ~#@@@@@=-*@@@@@@@:     -#@@@@@;       !@@@@@@~           ");
                                    Console.WriteLine("           !@@@@@-                ;@@@@@@#@@@@@@@!.     -#@@@@@;       .@@@@@@;           ");
                                    Console.WriteLine("           !@@@@@-                 $@@@@@@@@@@@@=,      -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@~                 .@@@@@@@@@@@$-       -#@@@@@;        @@@@@@;           ");
                                    Console.WriteLine("           !@@@@@;------,.          :@@@@@@@@@@:        -#@@@@@;       ~@@@@@@:           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@=-          !@@@@@@@@*         -#@@@@@;      .=@@@@@@-           ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@~         ,$@@@@@@$.         -#@@@@@=;;;;!=@@@@@@@:            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@-         =@@@@@@@@*         -#@@@@@@@@@@@@@@@@@@=,            ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@;         !@@@@@@@@@@;        -#@@@@@@@@@@@@@@@@@$~             ");
                                    Console.WriteLine("           !@@@@@:,-----,,         ~@@@@@@@@@@@#~       -#@@@@@@@@@@@@@@@@#~              ");
                                    Console.WriteLine("           !@@@@@~                ,@@@@@@@@@@@@@=,      -#@@@@@@@@@@@@@@@!.               ");
                                    Console.WriteLine("           !@@@@@-               .$@@@@@@##@@@@@@!      -#@@@@@@@@@@@@*:.                 ");
                                    Console.WriteLine("           !@@@@@-               !@@@@@@@:-#@@@@@@:     -#@@@@@;.,,,.                     ");
                                    Console.WriteLine("           !@@@@@-              :#@@@@@@!. :@@@@@@$-    -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@-             -$@@@@@@=,   *@@@@@@=.   -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@!~~~~~~~~~. .;@@@@@@@:      -@@@@@@@:  -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@#########=.~#@@@@@@;        :@@@@@@#, -#@@@@@;                          ");
                                    Console.WriteLine("           !@@@@@@@@@@@@@@@@:*@@@@@@=         .*@@@@@@: -#@@@@@;                          ");
                                    Console.WriteLine("           ;@@@@@@@@@@@@@@@@=@@@@@@@.          -#@@@@@: ,#@@@@@:                          ");
                                    Console.WriteLine("           ~@@@@@@@@@@@@@@@@-*@@@@@,            :@@@@@-  ;@@@@@,                          ");
                                    Console.WriteLine("           .!##############; -$###~              ;$##;   .:!!;,                           ");
                                    Console.WriteLine("             ,------------.   .,-.                .-.                                     ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("       ...........................................................................        ");
                                    Console.WriteLine("    .:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:.    ");
                                    Console.WriteLine(" ~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ ");
                                    Console.WriteLine(".$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@= ");
                                    Console.WriteLine("~@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@-");
                                    Console.WriteLine("*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 ~$@@@@!");
                                    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;                                                 .!@@@@#");
                                    Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  경험치를 얻었습니다. 현재 EXP: {player.GetExp()}             ;@@@@@");
                                    Console.WriteLine($"$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;   골드를 얻었습니다. 현재 Gold:  {player.Getgold()}           .!@@@@$");
                                    Console.WriteLine(";@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;.                                               .;@@@@@;");
                                    Console.WriteLine(",@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$************************************************$@@@@@@,");
                                    Console.WriteLine(" *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* ");
                                    Console.WriteLine("  -=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=-  ");
                                    Console.WriteLine("   ,!#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!,   ");

                                    Thread.Sleep(2000);
                                    mode = GameMode.Town;
                                    return;
                                }

                                break;
                            case "3":
                                if (TryEscape())
                                {
                                    Console.WriteLine("도망치는 데 성공했습니다!");
                                    mode = GameMode.Town;
                                    return; // 전투 종료
                                }
                                else
                                {
                                    Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                                    Thread.Sleep(900);

                                }
                                break;



                        }
                        // 몬스터 타격
                        Console.Clear();
                        Console.WriteLine("                                            .~~.                     .-~-.                ");
                        Console.WriteLine("                                            ;!=*~.                 .;:~;!;                ");
                        Console.WriteLine("                                            =!***!-              .-;;~:!**                ");
                        Console.WriteLine("                                            *::;***!:,        .-~:::~:;***                ");
                        Console.WriteLine("                                            *:!;;;;*$=::::::::!;~--;:;!!*!                ");
                        Console.WriteLine("                                            *;;:;;*!:-        ~:;:::;;!**-                ");
                        Console.WriteLine("                                            *~:;;~.           ,;:;;!;!***-                ");
                        Console.WriteLine("                                            !~;:.              ;;:::;!**=-                ");
                        Console.WriteLine("  ※ Warning ※ 핑크빈이 공격합니다!!       !;:                ~!;:;;!***-                ");
                        Console.WriteLine("                                            =~                  ~;;;!***!,                ");
                        Console.WriteLine($"           HP:{monster.GetHP()} Att:{monster.GetAtt()}                     =.                 -!***==*.                ");
                        Console.WriteLine("                                            ;                     .,;!*;:                 ");
                        Console.WriteLine("                                           :.                       .,--:.                ");
                        Console.WriteLine("                                           ;                         .,-;-                ");
                        Console.WriteLine("                                          ,~                         .,-:-    ,:;;;.      ");
                        Console.WriteLine("                                          ,~   ,.           .,,      ..,~~   .:.,,:!      ");
                        Console.WriteLine("                                          ,:  ;**,         .:**-      .,-;   :, ,,:*-     ");
                        Console.WriteLine("                                          ,: .#.;!         .!.~;      ..-;~  ;-,-:!=-     ");
                        Console.WriteLine("                                          .: .*;*~         .;;!~      ..,~:  -:::!*$~     ");
                        Console.WriteLine("                                          --, .-,           .-,.,,,..  .,-*.  -*==!*::.   ");
                        Console.WriteLine("                                          :-,~:,..       .....,~, ,..  .,-::   .,. ,~-;.  ");
                        Console.WriteLine("                                          :,:::~~~-------~~~~:~-!::,.  ..,~;.        ~~;. ");
                        Console.WriteLine("                                         .;~,-!;;;;::;;;;;;;;;;;:,,,-. ..,-:,         ;~- ");
                        Console.WriteLine("                                         -- .:;!!!;;:;;;;;!!!!;;:,.... ..,,~-         !-~ ");
                        Console.WriteLine("                                         :,.~~--~:...,,,,-~::~, .--,.. ..,,~~         ;-~ ");
                        Console.WriteLine("                                         :,.-..  ~    .....-.     .-,  ...,-;         ;-~ ");
                        Console.WriteLine("                                         ~-...   ~.    ....,-.     ..  ...,-~~        ;-~ ");
                        Console.WriteLine("                                          -~-.   ,,.    ....--     .......,,~:       .:~- ");
                        Console.WriteLine("                                           .:.    -.    ....,:    ....,...,,-!.      --;. ");
                        Console.WriteLine("                                            ~.    .-.    ...,:.   .....,,.,,-:~      ~-:  ");
                        Console.WriteLine("                                            -,     ,-.  ...,-,  .....,,.,.,---;     ,~:,  ");
                        Console.WriteLine("                                            --      .-,...,--. .....,,,,,,,,--:,    ~~:   ");
                        Console.WriteLine("                                            ,~       .:::::.......,,,,,,,,,,--~,   :-:,   ");
                        Console.WriteLine("                       .---,                ,~ .,,,,,,,,,,,,,,,,,,,,,,,---,---!~:~~~.     ");
                        Console.WriteLine("                    .!~,~~~-!-              ,~,.,,,,,,,,,,,,,,,,,,,,,,-------;:~-:;       ");
                        Console.WriteLine("                   ~!~*##$;~-~;.          ::..!,.,,,,,,,,,,,,,,,,,,,,--,-~~~;!:::,        ");
                        Console.WriteLine("                  -:~:*@@@@#=~,--         !*;;!;-,,,,,,,,,,,,,,,,,-----~;;**!,            ");
                        Console.WriteLine("                  *~~*=@@@@@@*--:         !=!::;!!~,,------------,---~;*;;**=$~           ");
                        Console.WriteLine("                 ,;~:*$@@@@@@#~;!         ,**!;;!!**;:~~~~~~~~~~~~~:;!!;!=====;           ");
                        Console.WriteLine("                 :~~!*#@@@@@@@:!$-         .-~~~~~~~::~~~~~~~~~~-~~~::~~~:::::,           ");
                        Console.WriteLine("                 ::~!=@@@@@@@@:-==.                                                       ");
                        Console.WriteLine("               .~$##@@@@@@@@@@!~$#~                                                       ");
                        Console.WriteLine("              ~!=@@@@@@@@$=#@=::=::                                                       ");
                        Console.WriteLine("             .*=*!!*#@@=!=;==-,-:                                                         ");
                        Console.WriteLine("              ..,:$#***$@@::,. -,                                                         ");
                        Console.WriteLine("                  :@@@@@@@:.   .-                                                         ");
                        Console.WriteLine("                  .=@@@@@!:.   .,                                                         ");
                        Console.WriteLine("                 .,~$@@#*-,,  ,~.                                                         ");
                        Console.WriteLine("                -:~~=@*:-,,-,,~.                                                          ");
                        Console.WriteLine("               ~- ,-;#~.,,~;;-                                                            ");
                        Console.WriteLine("              ~-   -!;, .-!-    ,.                                                  --.   ");
                        Console.WriteLine("             ,~   ..-*~  ;=!,--~~-,                                                .##,   ");
                        Console.WriteLine($"          ;*!;~..-;*=~:.$=;.                                LV: {player.GetLevel()}                   $@.  ");
                        Console.WriteLine($"         ~~;;::;~,-*#:=!~!!.                               HP : {player.GetHP()}                  $@.  ");
                        Console.WriteLine($"        .!;:;;--:;~!;.;*!,$.      |                        Att: {player.GetAtt()}                  $@.  ");
                        Console.WriteLine($"        ;----~:---~!,.:,,!:-      ,                       무기: {player.GetWeapon()}                  #@.  ");
                        Console.WriteLine($"       .;-,--~~~;!~---!--!*!~-:*~~     .-=#~              골드: {player.Getgold()}                  ~#@#,   ");
                        Console.WriteLine("         .;-,---~~!;~---!~-;*;-,:;~~      ,!=-                                    -$@#,   ");
                        Console.WriteLine("         ::,,---~~:=*~-:; .--:$=;!;.    .!#@@!:::::::::::::::::::::::::::::::::::;$@@;    ");
                        Console.WriteLine("!!=!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!=!!");
                        Console.WriteLine("!;-                                                                                    -;!");
                        Console.WriteLine($"!;.                  {monster.GetAtt()}만큼 피해를 입었습니다!!                                        .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine("!;.                                                                                    .;!");
                        Console.WriteLine(" ~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~ ");

                        DMG = monster.GetAtt();
                        player.OnDMG(DMG);
                        Thread.Sleep(1000);

                        if (player.IsDead())
                        {


                            Console.Clear();
                            Console.WriteLine("                                                      .,-~::~-,.                  ");
                            Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                            Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                            Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                            Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                            Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                            Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                            Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                            Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                            Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                            Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                            Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                            Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                            Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                            Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                            Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                            Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                            Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                            Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                            Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                            Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                            Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                            Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                            Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                            Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                            Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                            Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                            Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                            Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                            Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                            Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                            Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                            Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                            Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                            Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  "); ;
                            Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                            Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                            Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                            Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                            Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                            Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                            Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                            Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                            Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                            Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                            Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                            Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                            Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                            Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                            Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                            Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                            Console.WriteLine("                             ,---------------------------,                        ");
                            _player.PlaySync();
                            Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                            Console.WriteLine($"남은 체력 : {player.GetHP()}");

                            Thread.Sleep(1000);

                            mode = GameMode.Town;
                            break;
                        }
                       
                    }
                    break;
               

            }
        }//상급
        private void ProcessDungeon1()
        {
            
            Console.WriteLine(" ");
            RandomMonster1();
            Console.WriteLine(" ");


     /*       string input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
                default:
                    break;


            }*/

        }//랜덤 
        private void ProcessDungeon2()
        {
           
            Console.WriteLine(" ");
            RandomMonster2();
            Console.WriteLine(" ");


        }//랜덤
        private void ProcessDungeon3()//랜덤
        {
            

            Console.WriteLine(" ");
            RandomMonster3();
            Console.WriteLine(" ");


            /*       string input = Console.ReadLine();

                   switch (input)
                   {
                       case "1":

                           ProcessFight();
                           break;
                       case "2":
                           TryEscape();
                           break;
                       default:
                           break;


                   }*/
        }
        private void ProcessVOSS()//보스
        {
           
            monster = new Baron();
            
            Console.Clear();
            _player3.PlaySync();
            while (true)
            {
                Console.Clear();
               
                Console.WriteLine(" ※ WARING ※ ※ WARING ※ ※ WARING ※   내셔 남작   ※ WARING ※ ※ WARING ※ ※ WARING ※");

                Console.WriteLine("                                               .,:==~               ");
                Console.WriteLine("                                               $$=$                 ");
                Console.WriteLine("                                     ;!***! .=$$$$*                 ");
                Console.WriteLine("                                 -:*=****=~!$$$$=.                  ");
                Console.WriteLine("                          -;=#$;~!=====**!!*=$#*.   .               ");
                Console.WriteLine("                      .,;!!!*====$$. ~****====$~-,-!*=-             ");
                Console.WriteLine("                      ;!;!!!!!====$=.-========*****=$=!             ");
                Console.WriteLine("                     ~;:!!!***!!!!;!====$==**=$$$##*:$=.            ");
                Console.WriteLine("                    ;*::;!**!!!;:*====$==****=##@@#=$$$$$$$*        ");
                Console.WriteLine("                   ~!:::;!;;*;;!*=***=$$=====$$$#$=$$$$$$---,       ");
                Console.WriteLine("                  !!;-~-;:~:;;******=$$$$$#**;$$$$$$=$!             ");
                Console.WriteLine("           .    ***:~~=~*:~~**;==*=$=####$**$$=!!#####$$            ");
                Console.WriteLine("       ***=#$##$$$*~;=;-*!;!*;!*==$==$###@$*$$$$####$$#$.           ");
                Console.WriteLine("     $$$#$#$######*~~~~:=!=!;==*=**==$####$##@@@@#####$$$.          ");
                Console.WriteLine("     !-=##=$######!::*;!*====**====$$####@##@@@@@######$$$,         ");
                Console.WriteLine("    ,  ;*$$#!;*=##*!!!**=$=$==;;=$$#$#####@@@@#######$##;;:         ");
                Console.WriteLine("    .:*$#=;   ***,==*****!;;##;;=$#$$######@###########$            ");
                Console.WriteLine("              ::;*===;;:;;#$@@$!$$$$##$#########$$#$#$#~            ");
                Console.WriteLine("               .:  $~~$*!=$$$$$====$$#$###$$###$$$$$$$#             ");
                Console.WriteLine("                .     ,*==**=!!*=**$$$$$$$$$###$$$$$$$=             ");
                Console.WriteLine("                       ~===$$!;;***=$$=$$$$$$##$$$$$$$;             ");
                Console.WriteLine("                  -~. ,*=$$,  .!;!!*=$$==$$$$$#$$$$$$$              ");
                Console.WriteLine("                   ;;!!*$$#,    =*!=#$===$$$$$#$==$$$-              ");
                Console.WriteLine("                    :!**=##,    ;$#$===*==$$$##$==$$~               ");
                Console.WriteLine("                      ..#$.      *#=$======$$##===$$                ");
                Console.WriteLine("                                 !$=******=$$##==$=.                ");
                Console.WriteLine("                                 !#=****==$$$#===$-                 ");
                Console.WriteLine("                                ,=$******=$$#$==$!                  ");
                Console.WriteLine("                              .==*****==$$#$=$$=                    ");
                Console.WriteLine("                             ~$=$==$=$$$$$==$$:                     ");
                Console.WriteLine("                            ==*!!***==$#$==$$-                      ");
                Console.WriteLine("                          ~===***==$$$#$==$$-                       ");
                Console.WriteLine("                        ,==******==$$$$==$$*                        ");
                Console.WriteLine($"                      .;=$!!!!***==$#$==$=$             HP:{monster.GetHP()} Att:{monster.GetAtt()}           ");
                Console.WriteLine("                     ,$=!!!!!!!!**==$$====$                         ");
                Console.WriteLine("                    .$=!;;;;!!!***=$$$==$=$                         ");
                Console.WriteLine("                    $**********!***=$$$==$$$:.                      ");
                Console.WriteLine("                    =**!!**!!!!!**==$$$$$$$$$*.                     ");
                Console.WriteLine("                    ==**!!!!!*=$$$$$$$$$$$$$$$=                     ");
                Console.WriteLine("            *$$$=: ~=$$$***$$$$$$$$$$$#$$$$$$$$*,                   ");
                Console.WriteLine("        :*$$$$$$$$:$====$=$==$$$$$$$$$##$$#$$$$$*                   ");
                Console.WriteLine("    :$$$$$$$;$$$$$$$$=*****=$$=====$########$$$$$$=   ;$;-          ");
                Console.WriteLine("   :*    ,~#$$$$$$$$$##=****$$=$############$$$$$$$$-;$#$$$=-,      ");
                Console.WriteLine("       ,=$$#$$$#$$#$$$$$$$$$####$$$$$##$#$$$$$$$$$$$$$$##$$$$$$:    ");
                Console.WriteLine("   ~$!--  $$##$$$=$$$#$$===========$$$$$$$$$$$$$$$$$$$#$$$$~---$$$#.");
                Console.WriteLine("              ~$$=$*    *$$==$####$$$$$$$$###$$###*#$$$$$$$:.!!-    ");
                Console.WriteLine("              ~$$=$:     .*$$$$$$$$$$$$$$###$$$#$;  !$$$$$$         ");
                Console.WriteLine("              ,$$$$         ;====$$$$$$$$#$$$$:       =$$$=         ");
                Console.WriteLine("               $$$$           -$#$$$$##$$$$$.                       ");
                Console.WriteLine("               :$$;             $$$#$$$$:~-                         ");
                Console.WriteLine("               ,$$~            ;$$:.~.                              ");
                Console.WriteLine("               ,$$~           ,$*                                   ");








                Console.WriteLine(" ");
                
                Console.WriteLine($"플레이어 HP = {player.GetHP()}: 공격력 Att = {player.GetAtt()}: 무기 Att={player.GetWeapon()}: 스킬 데미지={player.GetSkill()}: 보유 골드={player.Getgold()}");
                Console.WriteLine(" ");

                Console.WriteLine("1.공격하기   2.고유 스킬   3.도망 가기 ");


                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":

                        _player2.PlaySync();
                        DMG = player.GetAtt();
                        monster.OnDMG(DMG);


                        if (monster.IsDead())
                        {
                            Exp = player.GetExp() + monster.GetMexp();
                            player.XP(Exp);
                            Console.WriteLine("최종보스를 잡았습니다!!");
                            Thread.Sleep(2000);
                            mode = GameMode.Ending;
                            return;
                        }

                        break;
                    case "2":
                        //플레이어 타격

                        Skill = player.GetSkill();
                        if (Gold >= Skill)
                        {
                            Gold -= Skill;
                            monster.OnSkill(Skill);
                            Console.WriteLine("스킬을 사용했습니다.");
                            Console.WriteLine("남은 골드: " + Gold);
                        }
                        else
                        {
                            Console.WriteLine("골드가 부족하여 스킬을 사용할 수 없습니다.");
                            Thread.Sleep(2000);
                        }



                        if (monster.IsDead())
                        {


                            Exp = player.GetExp() + monster.GetMexp();
                            player.XP(Exp);

                            mode = GameMode.Ending;
                            return;
                        }

                        break;
                    case "3":
                        if (TryEscape())
                        {
                            Console.WriteLine("도망치는 데 성공했습니다!");
                            mode = GameMode.Town;
                            return; // 전투 종료
                        }
                        else
                        {
                            Console.WriteLine("도망치기에 실패했습니다. 전투를 계속합니다.");
                            Thread.Sleep(900);

                        }
                        break;



                }


                Console.Clear();
                Console.WriteLine("                                                                  ~::~                 ");
                Console.WriteLine("                                                                -=$=$                  ");
                Console.WriteLine("                                                    .~;!*==*:.*$$$$;                   ");
                Console.WriteLine("                                                   ;!******~.$$$$$:                    ");                Console.WriteLine("                                            ,;::- ~*====**!*==$#$-                     ");
                Console.WriteLine("                                         ,;:;*##**=!-;===*!!**=#!    !;                ");
                Console.WriteLine("                                     ~!:::;;;*!;;;*====$==****=$###$$$$$$$$$$;         ");
                Console.WriteLine("        ※Waring※                  :!;:~;*;;!;;!*=***=$$===$==$$$$==$$$=*.            ");
                Console.WriteLine("    바론이 공격합니다!!            ~*;::-:!~:;;!******=$$$##***=$$$$$$$$               ");                Console.WriteLine("                                   =*;~~-~!:-~!;**!!*=$$$$$$###$$$$$$$$$:              ");
                Console.WriteLine("                                 .***::!~;*-~:*;!***==$##$$==##$=!##$$$$*.             ");
                Console.WriteLine("                           .:;. .!==;~;*;:=!;**;*====$$####=!=$=*!#####$$,             ");
                Console.WriteLine("                      -=*##$$$#####=!;~:;*!===****===$$######@@@@@#######$=,           ");
                Console.WriteLine("                .     , ~=$$#######*!;!*!*$==$==!=$$$########@@@@@#######=$*.          ");
                Console.WriteLine("                     .-.-!=$$*~;*!===!**==$$$$$;;*$########@@@@##########~--,          ");
                Console.WriteLine("                      :=$$$*.  ;!!;*=**$*=;!!*#;;=$#$=$#####@@##$########,             ");
                Console.WriteLine("                        ~;,    :*!*===!!:;;**#@$!=$$$##$#########$$#####=.             ");
                Console.WriteLine("       ,     .                  -:;;$$=!;;=$$###==$$$##$########$$$$$$##;              ");
                Console.WriteLine("      ~;,    !:~                .:: :: !$*==$======*=$$$$$$$$##$$$$$$$$$~              ");
                Console.WriteLine("     -$$:  .!@=-   .        -~;;!$=~    :=====!!*=**=$$$$$$$$$##$$$$$$$$               ");
                Console.WriteLine("     !$*   ~@@=      .     ~$=*@@@#~ .  ,==*=$=;;!=*=$$==$$$$$###$$$$$$=               ");
                Console.WriteLine("    ,:~:   ~@@!   . ,,     =@$$@@#*,-   -*=$=~.-;;;!*$$==$$$$$$#$$$$$$$,               ");
                Console.WriteLine("   .;~.    -#@*   :~~:  ~-=@#=#@$;,,;~--*=$$:   ~!!;!=$$==$$$$$#$$$$$$=                ");
                Console.WriteLine("   ~;:-    -;@! .~$=!*;*#@#*$#@*:,  ~;;;!*$#;    !**=#$====$$$$#$==$$$-                ");
                Console.WriteLine("  .-. :   -:$$!.$$@;,;$@@#;;!$$!,    -:!*=##:    -=$$$==*===$$$#$==$$*.                ");
                Console.WriteLine("  ,..~;   -;$@@;@@$- ~$@=- ;$@#*~      .*$#!      *$$==**=$$$$$#$==$$,                 ");
                Console.WriteLine("   -.=;   ~~*@@~@@=;=$$=  ,$#@@@~                 :$$==***===$##$=$$!                  ");
                Console.WriteLine("  ,*,!!   ##-*$!@!,=##=,.;;@#:!=.                 :$$=****==$$#$==$$.                  ");
                Console.WriteLine(" .*#-@@,  @@~*@@$--$#=;==@@@;~.                   :$=*======$$$$==$:                   ");
                Console.WriteLine("  ;#$$##::@@$@@@!:$==##@@@==:.                   .=$**!***==$$$==$=,                   ");
                Console.WriteLine(" ,==@#,-@*@@@@@#$@$=@@@@@= -:-.,     ,,,         :$$*!!**=$$$$==$$.                    ");
                Console.WriteLine(" ~=!$.,.!$@@*,=@@@##@@@@$*: ,.      ;:;:.       -==*======$$$==$$,                     ");
                Console.WriteLine("-=$=$.$#=#@#;;:;@@@=#*$!*@=.       ,$!*-.      ~==**!**==$$$===$!                      ");
                Console.WriteLine("~;@@@@@@==#*:!!:@@@-##$:*#=~     *$*.         ~$==*==$$$$$$==$=$                       ");
                Console.WriteLine("*#*#@@@@-=**=$###@@=#$: .*#, ~!@@$~          ~=******==$$$===$*                        ");
                Console.WriteLine(";##@@@@@$@@$#@@$-#@!*!, !##$=@@*;-          ;$=***===$$$$=*=$*.                        ");
                Console.WriteLine(":$@@@@$@@@!*#@--!==,-@=$@@###$,           .!=******==$$#$==$$~                         ");
                Console.WriteLine($"~=!@=*$@@$~==@:*!~,-=@;;!;               -==*!!***==$$$$===$*        HP:{monster.GetHP()} Att:{monster.GetAtt()}       "); 
                Console.WriteLine("-*$@~.;@@@###@-,--!;;;                  ,=$*!!!**==$$##$==$$,                          ");
                Console.WriteLine("!$@@@==@@@@*#$-.**;;~*;-    ..  ,      ~=**=====***==$$===$=.                          ");
                Console.WriteLine("#*@@@@@@@@@$$*;$#@*!=#@*.,!;*~        ~$*!;;;!!!!***=$$===$=.                          ");
                Console.WriteLine(":;@@@@=@@@@$=###=-,@@@=;#@@*,        .*==!;;;!!**=$$$$$$==$$.                          ");
                Console.WriteLine("$@@@@@@@@#*#*=#=*:~!$-:=@@@$.        ~====**=====**==$$$==$$*                          ");
                Console.WriteLine("#@@@@@@@@$-===@@#####$#@@#@!         ==***********!*==$$==$$$;                         ");
                Console.WriteLine("                                     =*!*!!*!!!!!!!*=$$$$$$$$$:                        ");
                Console.WriteLine("                        -=$$$$#$$$$$$$=========$$=$$$==$##$$$$$#$$;                    ");
                Console.WriteLine("                    .!!~   ,=$$$$$$$$$$#$=***=$==$$##########$$$$$$$$;;$#$$==-.        ");
                Console.WriteLine("                         ~;$#$$$$$$#$$$$$$=*=$######$$####$$$$$$$$$$$$=$##$$$$*;-      ");
                Console.WriteLine("                    !;     ,=$#$$$$$$$=!$$========$$#$$$$$$$##$$$$$$$$$#$$$$$=-   .*=: ");
                Console.WriteLine("                                $$$$=      ~=$$$$$$$$$$$$$###$$##=;  ,$$$$$$,          ");
                Console.WriteLine("                                *$$$~       ,:$===$$$$$$$$#$$$$#~.    -##$$$.          ");
                Console.WriteLine("                                ;$$$,         -*=$#$$$$$#$$$$=-          ~!,           ");
                Console.WriteLine("                                ~$$$,           ~=$$###$$$$=:.                         ");
                Console.WriteLine("                                -$$*.           ,=$$#$$$*~.                            ");


                DMG = monster.GetAtt();
                player.OnDMG(DMG);
                Console.WriteLine($"플레이어 HP = {player.GetHP()}: 공격력 Att = {player.GetAtt()}: 무기 Att={player.GetWeapon()}");
                Thread.Sleep(2000);

                if (player.IsDead())
                {

                    mode = GameMode.Town;
                    Console.Clear();
                    Console.WriteLine("                                                      .,-~::~-,.                  ");
                    Console.WriteLine("                                                   .~*=$#@@@@#$=!-                ");
                    Console.WriteLine("                                                 .;#@@@@@@@@@@@@@@#~              ");
                    Console.WriteLine("                                             ,=@@@@@@@@@@@@@@@@@@@@@@@@!          ");
                    Console.WriteLine("                                           -@@@@@@$:   ..    .   .;@@@@@@$.       ");
                    Console.WriteLine("                                           $@@@@@$,   ;=      $=~   -#@@@@@;      ");
                    Console.WriteLine("                                          -@@@@@#,   :@@@     @@@,   ~@@@@@#      ");
                    Console.WriteLine("                                          *@@@@@!    ;@@@@  @@@@;    *@@@@@-      ");
                    Console.WriteLine("                                          *@@@@@     ;@@@@@@@@@@:    ~@@@@@;      ");
                    Console.WriteLine("                                         .=@@@@$       @@@@@@@@      ,#@@@@=      ");
                    Console.WriteLine("                                         .=@@@@;      :  @@@@         $@@@@$      ");
                    Console.WriteLine("                                         .=@@@@;       @@@@@@@       .$@@@@$      ");
                    Console.WriteLine("                                         -#@@@@;     : @@@@@@@@     -#@@@@!       ");
                    Console.WriteLine("                                        ,#@@@@@;     !@@@@@@@@@@;    ;@@@@@~      ");
                    Console.WriteLine("                                       .@@@@@@@,     :@@@@  @@@@-   ,#@@@@@       ");
                    Console.WriteLine("                                      -#@@@@@@=.     ,=@      #*   .=@@@@@*       ");
                    Console.WriteLine("                                     -$@@@@@@@=!!!;.  .~~    ~-   -=@@@@@#-       ");
                    Console.WriteLine("                                    .#@@@@@@@@@@@@@$:           .;#@@@@@@!        ");
                    Console.WriteLine("                                    ~@@@@@@@@@@@@@@@@@;.      ,!@@@@@@@@$.        ");
                    Console.WriteLine("                   ,!@@@@@$~.                    ~#@@@@@@@@@@@@@@@@#,             ");
                    Console.WriteLine("                 ~$@@@@@@@@@@;,                    :*$@@@@@@@@@@$*-               ");
                    Console.WriteLine("               ,*@@@@@@@@@@@@@$:                     .~::;!!;::~.                 ");
                    Console.WriteLine("              ,$@@@@@@@@@@@@@@@@!                                                 ");
                    Console.WriteLine("             .=@@@@@@@@@@@@@@@@@@;                                                ");
                    Console.WriteLine("             !@@@@@@@=***=#@@@@@@#:~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-    ");
                    Console.WriteLine("          .;*@@@@@@$~.    -!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*.  ");
                    Console.WriteLine("      ,$@@@@@@@@@;           ,$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,");
                    Console.WriteLine("     .$@@@@@@@@@@.            !@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~");
                    Console.WriteLine("    :@@@@@@@@@@@=             ~#@@@@-                                      .@@@@@:");
                    Console.WriteLine("   .@@@@@@$#@@@@=             -#@@@@-                                      .@@@@@:");
                    Console.WriteLine("   :@@@@@$-$@@@@=             -#@@@@-                                      .@@@@@:");
                    Console.WriteLine("   =@@@@@~.$@@@@=             -#@@@@-                                      .@@@@@:");
                    Console.WriteLine("  ,$@@@@# .$@@@@=             -#@@@@-                          ............,@@@@@:");
                    Console.WriteLine("  -#@@@@; .$@@@@=             -#@@@@-                         -#@@@@@@@@@@@@@@@@@~");
                    Console.WriteLine("  ~@@@@@, .$@@@@=             -#@@@@-                        ,$@@@@@@@@@@@@@@@@@#,");
                    Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                        -#@@@@@@@@@@@@@@@@$. ");
                    Console.WriteLine("  :@@@@@. .$@@@@=             -#@@@@-                          @@@@@$.            ");
                    Console.WriteLine("  :@@@@@. .$@@@@$             :@@@@@-                          =@@@@#-            ");
                    Console.WriteLine("  :@@@@@.  =@@@@@~            *@@@@@                            @@@@@!            ");
                    Console.WriteLine("  :@@@@@.  :@@@@@=           -@@@@@@                            $@@@@*.           ");
                    Console.WriteLine("  :@@@@@.   !@@@@@@;.      ~$@@@@@$.                            :@@@@@@@@@@@@@@:  ");;
                    Console.WriteLine("  :@@@@@.    -@@@@@@@@@@@@@@@@@@@*                              -@@@@@@@@@@@@@@@$.");
                    Console.WriteLine("  ~@@@@@~     ;@@@@@@@@@@@@@@@@@$.                              ,$@@@@@@@@@@@@@@#-");
                    Console.WriteLine("  ,#@@@@=      :@@@@@@@@@@@@@@@*.                                ,;!!!!!!!!!@@@@@:");
                    Console.WriteLine("   !@@@@@*        -#@@@@@@@@;.                                             .@@@@@:");
                    Console.WriteLine("   -@@@@@@:         .-;;;~,                                                .@@@@@:");
                    Console.WriteLine("    =@@@@@#;                                                               .@@@@@:");
                    Console.WriteLine("    .#@@@@@@=:                                                             .@@@@@:");
                    Console.WriteLine("      ;@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-");
                    Console.WriteLine("          ;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@;  ");
                    Console.WriteLine("           .~*=$$$$$$$#@@@@@$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@#$$$$$$$$$$$=*-   ");
                    Console.WriteLine("               .......*@@@@#..............................,@@@@@!............     ");
                    Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                    Console.WriteLine("                      !@@@@#                              .@@@@@;                 ");
                    Console.WriteLine("                      !@@@@@                              ~@@@@@;                 ");
                    Console.WriteLine("                      ;@@@@@!                            .=@@@@@-                 ");
                    Console.WriteLine("                      -#@@@@@=;;;;;;;;;;;;;;;;;;;;;;;;;;!$@@@@@@.                 ");
                    Console.WriteLine("                       =@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  ");
                    Console.WriteLine("                          .;#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$:                      ");
                    Console.WriteLine("                             ,---------------------------,                        ");
                    Console.WriteLine("죽었습니다....마을로 돌아갑니다");
                    Console.WriteLine($"남은 체력 : {player.GetHP()}");
                    Thread.Sleep(900);


                    _player.PlaySync();
                    break;
                }






            }





        }
      /*  private void ProcessFight()
        {
            
        }*/
        private bool TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if (randValue<=100)
            {
                Console.Clear();
                Console.WriteLine("                                    ..........                               ");
                Console.WriteLine("                                     .....,,,,,,,.                           ");
                Console.WriteLine("                                         ....,------,..                      ");
                Console.WriteLine("                                               .,-~~~~~-.                    ");
                Console.WriteLine("                                                  .,~:::;~,.                 ");
                Console.WriteLine("                                                     .,~;;;;:,               ");
                Console.WriteLine("       ..                          .. ..                 ,;!!!:.  .  .       ");
                Console.WriteLine("                                     ..,-----,.            ,:!=*;~,.         ");
                Console.WriteLine("                                   ,::;!**===$$=:.           .!$$$$$;.       ");
                Console.WriteLine("                                .-::;;!!**==$$####!-.          !$#$$##;.     ");
                Console.WriteLine("                              .-~:::;;!!**==$$######=~         .!#!,!!$!     ");
                Console.WriteLine("                            .-~~~:::;;;;:~,....-:*=$##$:-,,,.    ;$, .       ");
                Console.WriteLine("                         ..,--~~~:::~,.            ,~*######$!.   ~,         ");
                Console.WriteLine("                       ..,,---~~~~~.                  .!##$$~=;              ");
                Console.WriteLine("                     ..,,,,---~~,.                      .  ,;.               ");
                Console.WriteLine("                   ....,,,,---,.                                             ");
                Console.WriteLine("                 ......,,,,,,.                                               ");
                Console.WriteLine("                 ......,,..                        -,                        ");
                Console.WriteLine("                  ......                         ,*=!,                       ");
                Console.WriteLine("                                                -$#*~~              ..,      ");
                Console.WriteLine("                                               :==#;~,             ;####.    ");            
                Console.WriteLine("                                             .:$=$=~:~            .=###$.    ");
                Console.WriteLine("                       ....                 ,=*=*!;!~.            ,$$=~.     ");
                Console.WriteLine("                     .....,,,..          .-!#$;,.   -             .=!,       ");
                Console.WriteLine("                   ......,,,,------,..,~!**==,                     =*        ");
                Console.WriteLine("                           ..,--~~::;;!!**!~                       :.        ");
                Console.WriteLine("                              ...,-~::~-,.                 ~!!!***!.         ");
                Console.WriteLine("                                                           =$$$*===.     ,,  ");
                Console.WriteLine("                                                           ======$! .~  ,==~ ");
                Console.WriteLine("                                                       ,#:.*=;.=$#  ,*:.$=$. ");
                Console.WriteLine("                                                       ,===*::!!!.. ~$====-  ");
                Console.WriteLine("                                                       ,===* .,   . =$===;   ");
                Console.WriteLine("                  ...                          ,:;:~.  .$$===:     :,~=$*.   ");
                Console.WriteLine("              ....,,,,,.                      ~$#$$-.  .:~#!-,    ,~  ,~.    ");
                Console.WriteLine("            ......,,,,---.                 .,;###$$*      .:      .          ");
                Console.WriteLine("            ......,,,----~--.           .~!=##$*--$~.     !=;~.              ");
                Console.WriteLine("            ...........,--~~:::-.    .~=####*.    .      .$===*,             ");
                Console.WriteLine("            ..           .,-~:;;!!***=*#$!:.             -**=*=.             ");
                Console.WriteLine("                            .,~~;;;!;;~,.                -!!*!*~             ");
                Console.WriteLine("                                . .         .           ,!=****!.            ");
                Console.WriteLine("                                           ,;;,        .==**=*=*-            ");
                Console.WriteLine("                                           ,!==*-.    .*========;            ");
                Console.WriteLine("                                          ~!*=====;,  !===**===*=            ");
                Console.WriteLine("                                         ,!;*$$$=$=$!!=$$=!.====$,           ");
                Console.WriteLine("                                         :~..:!$=========;  -====*           ");
                Console.WriteLine("                                               ,!===$$=$!    ;====,          ");
                Console.WriteLine("                                                 .;*===!     .====:          ");
                Console.WriteLine("                                                   .-;~.      :===*.         ");
                Console.WriteLine("                                                               ===$-         ");
                Console.WriteLine("                                                               ,===*         ");
                Console.WriteLine("       도망가는 것을 성공헀습니다!!                             ;===~        ");
                Console.WriteLine("                                                                ,===*.       ");
                Console.WriteLine("                                                                 :===-       ");
                Console.WriteLine("                                                                  ===*       ");
                Console.WriteLine("                                                                  ~===-      ");
                Console.WriteLine("                                                                  .*==*~-~.  ");
                Console.WriteLine("                                                                   ,*!!!~,   ");
                Console.WriteLine("                                                                    ~!~~     ");
                Console.WriteLine("                                           .........................,~....   ");
                Console.WriteLine("                                          .................................. ");
              
                Thread.Sleep(900);
                
                
                return true;
            }
            else
            {
                
               
                return false;
            }

        } //도망가기 
        private void ProcessHome()
        {
            int Heal = player.GetMAXHP();
            player.Heal(Heal);
            if (Heal == player.GetHP())
            {
                _player6.PlaySync();                
                Console.WriteLine("                                                                             .,,,,,,,,,,     ");
                Console.WriteLine("                                                                             ;#######$@@,    ");
                Console.WriteLine("                                                                             .,,,-----$=.    ");
                Console.WriteLine("                                                                                    ,=$,     ");
                Console.WriteLine("                                                                                   .==,      ");
                Console.WriteLine("                                         .,,.                                      ;=,       ");
                Console.WriteLine("                                        .:**;,                                    ,=~        ");
                Console.WriteLine("                                        -*===:                      .......       !*,        ");
                Console.WriteLine("                                        ~*===:                     -!!!!!!!~     ,$~         ");
                Console.WriteLine("                    ,~-.          .,~~~~!====:                     ,;;;;=@$~     !*,         ");
                Console.WriteLine("                  .~!=*~     .-~~~:!=========:                          :=-      *;.,-~::::, ");
                Console.WriteLine("                  ,*===!-~:::;*==============!                         ,*;       !=*=$$$$$$~ ");
                Console.WriteLine("                  ,*===*!*===========:-:*===!~:             ,!!!!!:   .;*,  ...  ,~::::~~~~. ");
                Console.WriteLine("                  ,*==========!:--!==;:~----, -:            .;;!=@*   .*$****==~             ");
                Console.WriteLine("                  ,*====*;~;==!;;;!==*~,       !,            ..~=*-    -~~~~~~~,             ");
                Console.WriteLine("                  ,*===!--:!=*:---,;!*-        ,;             -$#$***:                       ");
                Console.WriteLine("                  ,*===;,:;,,,.    .;~;,        *             :@#!~--,                       ");
                Console.WriteLine("                  ,*===;-:~~        ~~!,        *~.           .-,.                           ");
                Console.WriteLine("                  ,*===;~:-:,        :;~        *-:!!!:-                                     ");
                Console.WriteLine("                  ,*===;-~.~~        ;~:.    -;!! ....,:!*!;-                                ");
                Console.WriteLine("                  ,*===!;!,~:        ;::~;**!:...       ....~;**!~.                          ");
                Console.WriteLine("                  ,*===!,~:-~      .::!*;,..                  ...-;***:,                     ");
                Console.WriteLine("                  ,*=!-;==*;~..~!**;-                                 ,;*=*;-                ");
                Console.WriteLine("                  ,*=!.  ,;===!-.                                          .:*=-             ");
                Console.WriteLine("                  ,*=!.     .;=!,                                         ,!=:;-             ");
                Console.WriteLine("                  ,*=*-        .;=!,                                    ~*!,  :-             ");
                Console.WriteLine("                  ,*====*-        .;*!,                              ,;*:     :-             ");
                Console.WriteLine("                  ,*=======*-.       .;*!,.                       .-*!,     .~*-             ");
                Console.WriteLine("                  ,*==========*-..      .;*!-..                .,;*:     .,;===-             ");
                Console.WriteLine("                  ,*=============*~..       :!!-..          ..-!;-     .-!=====-             ");
                Console.WriteLine("                  ,*===*!!==========*~,.       :!!-,.     .,:!:     .,:========-             ");
                Console.WriteLine("                  .!===;.,:!!*=========*~,,       :!;-,,,-!;,     ,-!==========-             ");
                Console.WriteLine("                  .~!*!~    ,:;!*==========:,,.      ~;=;:     .,~*============-             ");
                Console.WriteLine("                    .~-        ,:;!*==========:--.     !     ,-;========*;*====-             ");
                Console.WriteLine("                                  ,:;!===========;--.  !  .-~*=======*!:- :==*!,             ");
                Console.WriteLine("                                     ,::!===========;-~*,-;========*;~,   -::~.              ");
                Console.WriteLine("                                        ,~:;============!========!:~.                        ");
                Console.WriteLine("                                           .~:;===============*;~-                           ");
                Console.WriteLine("                                              .~~;==========*:~.                             ");
                Console.WriteLine("                                                 .~~;=====*~-                                ");
                Console.WriteLine("                                                    .=====;                                  ");
                Console.WriteLine("                                                     =====:                                  ");
                Console.WriteLine("                                                     !====-                                  ");
                Console.WriteLine("                                                     ,----                                   ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine($"                             체력이 모두 회복되었습니다:{player.GetHP()}");

                mode = GameMode.Town;
                Thread.Sleep(1500);
               
            }
        } //휴식 회복

        private void ProcessEnding()
        {
            
            bool visible = true;
            while (true)
            {
                Console.Clear();
                if (visible)
                {
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@$,.-@@@@@@@@@@@@@@@@@@@@#@@@#-@@@@@@@@@@@@@@@@@@@@@@@@@-.,#@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@=  .,#@@@@@@@@@@@@@@@@@@@@-;#*,*$:~@@@@@@@@@@@@@@@@@@@@$-, .$@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@#    ,@@@@@@@@@@@@@@@@@@@@@!..-,,.,*@@@@@@@@@@@@@@@@@@@@@, . -@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@: ,  .#@@@@@@@@@@@@@@@@@@@@$~,-...:@@@@@@@@@@@@@@@@@@@@@$.  . !@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@.     ,@@@@@@@@@@@@@@@@@@@@*--,  ,~#@@@@@@@@@@@@@@@@@@@@-    .-@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@= ,    .~@@@@@@@@@@#@@@@=!#~.,-,.  ,.;#!$@@@@@@@@@@@@@@#~.    ..@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@;..     ,*@@@@@@@@!~@@@=.;##!,~,,..~!$#:.@@@#.*@@@@@@@@!,   ..,.@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@#;,..... .,#@@@@@@; :@=@~,  !#-~---~-@:  ,$@*@, *@@@@@@=.. ..,.-.#@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@!---,,  , -#@@@@#.~,,~@~ .-*!.,~~~~.=*,  ;#--,,-@@@@@=, -  ~~~:~@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@#~~-:-,.-, -:@@@#,. -:!;~~~@-~*:-:!~~@~~~*!:, .-@@@#-- ,-~,~;~:;@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@=~$@,:,,-,~.$@;~..,~$@@*;~$!#@=,$@#!#:;*@@=-,.-,=@*.~,~.-~~@=:$@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@#@@ -- ,~- !@:,-~~=@@@@@@@@@@@~@@@@@@@@@@@*~~-,:@; ~~, ~,,@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@*,# -,-,~- *#~,. .!@@@@@@@@@@@=@@@@@@@@@@@: ..-~!! -----,.$-@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@, @;=#@~:- ::#;-..,!@@@@@@@@@@@@@@@@@@@@@;,..-*$,- -~;@#*!* $@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@. @@@@@::--,@@#;~;#@@@@@@@@@@@@@@@@@@@@@@@#:~;@@*,.~:!@@@@; *@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@#. $@@@@$;-,*@@@@@@@@@@@@@@@@@$==$#@@@@@@@@@@@@@@@;:~;#@@@@..*@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@#. *@@@#@@-!$$@@@@@@@@@=:-,#@,.   .:@@@##@@@@@@@@;#~:@@#@@@  *@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@. :@@@~*@=!~*@@@@@@@@;    #@.    .~@@@-.-!#@@@@@~:;##!~@@=  =@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@~ .*@@~ .*~.@@@@@@@@@!.   #@,     :@@#.   ,#@@@@;.;=..:@@, .$@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@#-. ~@@*-..,-@@@@@@@@@*    #@-     !@@#     =@@@@@.-..-$@* ..*@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@;:. . @@@=!!!=@@@@@@@@@=    #@~     *@@=     ;@@@@#$!!!$@@~ ..;-@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@!.- . !@@@@=-.#@@@@@@@@$    #@:     =@@!     ~@@@$.;@@@@@@ . ,.-@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@#. .. .@@@!   ;@@@@@#@@#    #@!     $@@;     .@@@-  ,@@@@! ..  ;@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@#.. .  #@=     #@@=, *@@.   $@*     #@@~      @@#    ,@@@. .  ,;@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@.   , ,@#,    !@#   ,@@.   *@$    .@@@,      #@=     *@= ..  .!@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@:  .,. =@!     $@.   !@,   !@$    .@@#    ,  #@~    -#@. -. ..#@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@=  ,., -@#,    :@,    #,   ;@$    ,@@=   .-  =$    .!@*  ..  :@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@!... . *@:    .$~    :,   :@#    -@@;   ,-  *!    -#@.   ,.-#@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@#, ,.  ,@$,    ~!  .  ,   :@@.   ~@@~   ;~  ;-   .!@;   , ,$@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@;-!, -.  !@:.   .*. -.     ~@@,   :@@,  .=;  -    -@@.  -..-:,@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@$,.  .,.  #=.    :. ~-     ~@@-   ;@@.  .#!  ,   .!@- ..~   .!@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@=~.,.   -@:     . -*.    ~@@-   !@@.  -@=      -#=    ..-!#@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@$:,.,.  ;$,      ,@~    ~@@~...*@#   *@$     .=$   ,,.~!@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@*-. ,.  .=;.     ,@=,..,;@@!:;:$@#...#@#.    ~#- . ,  ,:@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@*,  .,-- . $-.....-@@;:*=#@@@@@@@@#;::@@@,...-#,. .--.  .;@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@$:;!-,.,.. ,:-,--~;@@@@@@@@@@@@@@@@@@#@@@~-,-:.  .,..,:!:!@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@*~. ..,  ;~-~*#@@@@@@@@@@@@@@@@@@@@@@@=*::!  .,.. -!#@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@*.,-..,-,$*!@@@@@@@@@@@@@@@@@@*@@@@@@@@@#$@~,,, -,.,#@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@=::-,, ,;#@@@@@@@@@@@@@@@#=@@!-*@@@@@@@@@@@#-..-.:;!#@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@::~~~---..-~~~:!#@@@@@@~ .,!@=@@@@$!;::~-.,-~~~~::!@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@=:~~~~-,.  ,,,,,.~#@@@!.~##==@@@=-,,,,,, .,--~~~:;#@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@=;:~~-,. .,,,,,..-@@@..#@;@$@@=..,,,,,,. .--~~:;$@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@#$=;~,.,,,,,.  ~@$.,@,,,#@@..,,,,,,,.,~;*$#@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@#$;,,.*- .#$.,@*-*@@;. :;,,~!$#@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@#;.=#~.*@,.$$$##@,.!@.-*#@@@@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@;*@@:!@!.-$@$$#,=@@.$@@@@@@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=@@@$@@;. .*@@*@@@!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=     ");
                    Console.WriteLine("                  ;@@-                                                  #@             ");
                    Console.WriteLine("                ,@@@#.                                                  @@.            ");
                    Console.WriteLine("               ~@@@$.                             !==$$#####-           @@             ");
                    Console.WriteLine("              *@@@@                             ,@@@@@@@@@@@@-          @@             ");
                    Console.WriteLine("             @@@@@@#~                           :@@@@@@@@@@@@!         ,@@             ");
                    Console.WriteLine("           :@@@#-#@@@@;                          .        ,@@!         *@@             ");
                    Console.WriteLine("          #@@@!   ~@@@@@                                  ,@@!         $@#             ");
                    Console.WriteLine("        .@@@#:      :#@@@,                          .!!*!!!@@!         #@=             ");
                    Console.WriteLine("        :@@;          ;@@$                         ~@@@@@@@@@;         @@*             ");
                    Console.WriteLine("         =,            -@,                        -@@@@@@@@@*         .@@*             ");
                    Console.WriteLine("                                                  *@@-                .@@*             ");
                    Console.WriteLine("                                                  =@@                 .@@*             ");
                    Console.WriteLine("    -#@@@@@=~-------------:@@@~                   :@@.                .@@*             ");
                    Console.WriteLine("    @@@@@@@@@@@@@@@@@@@@@@@@@@!                   -@@$                .@@!             ");
                    Console.WriteLine("                                                    @@@@@@@@@@@@@@@@@~!@@~             ");
                    Console.WriteLine("           *@@@@@@@@@@@$                                              @@@              ");
                    Console.WriteLine("          -@@#===$@@@@@@#                                             @@@              ");
                    Console.WriteLine("          *@@     --,.$@@                                             @@@              ");
                    Console.WriteLine("          *@@,       =@@@                                             @@@              ");
                    Console.WriteLine("          .@@@@$*!*=@@@#                                              .:,              ");
                    Console.WriteLine("           -#@@@@@@@@@$-                                                               ");
                    Console.WriteLine("             ~$#@@@#$.                                                                 ");
                    Console.WriteLine("                ...                                                                    ");
                }
                else
                {
                    Console.WriteLine("                                  ");
                    Console.WriteLine("                                  ");
                    Console.WriteLine("                                  ");
                }
                visible = !visible;


                Thread.Sleep(200);
            }
           

        } //엔딩
 
        private void ProcessHelp()
        {

            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");

            Console.WriteLine("                             ★☆★☆★도움말★☆★☆★");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");
            Console.WriteLine("                  1.레벨업 경험치량은 (1000x레벨)/2");
            Console.WriteLine("                           ");
            Console.WriteLine("                           ");
            Console.WriteLine("                  2.레벨업하면 MAXHP +100 , Att +5 ,Skill +200 이 상승한다.");
            Console.WriteLine("                           ");
            Console.WriteLine("                           ");
            Console.WriteLine("                  3.스킬 사용조건 - 초기 스킬데미지 = 5000 (스킬데미지=보유골드) ");
            Console.WriteLine("                  // 사용하면 골드는 소멸된다.       ");
            Console.WriteLine("                           ");
            Console.WriteLine("                           ");
            Console.WriteLine("                  4.무기강화는 1회당 500G이며 실패해도 0밑으로 내려가진 않는다");
            Console.WriteLine("                               ");
            Console.WriteLine("                           ");
            Console.WriteLine("                  5.최종보스 바론을 잡으면 게임에서 승리한다.             ");
            Console.WriteLine("                                           ");
            Console.WriteLine("                                           ");
            Console.WriteLine("                                           ");
            Console.WriteLine("                                           ");
            Console.WriteLine("                                           ");
            Console.WriteLine("                               ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ           ");
            Console.WriteLine("                               |                   |           ");
            Console.WriteLine("                               |     1.로그인      |          " );
            Console.WriteLine("                               |                   |           ");
            Console.WriteLine("                               ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ           ");

            switch (input)
            {
                case "1":
                    ProcessLobby();
                    break;
                default:           
                    
                    break;
                    
            }
           
        }
}
}
