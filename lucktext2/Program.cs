using System.Threading.Tasks.Dataflow;
using System.Data;
using System.Dynamic;
using System;
using System.Threading;


///         ----------  ↓ hela Typerwriter setup ↓  ----------          //



static void Typewrite(string message, int speed)     //message = vad den ska skrive, speed=tiden i ms mellan varje karaktär
{
    for (int i = 0; i < message.Length; i++)
    {
        Console.Write(message[i]);
        System.Threading.Thread.Sleep(speed);
    }

}



///         ----------  ↑ hela Typerwriter setup ↑  ----------          ///


Console.CursorVisible = false;
Console.WriteLine("");
Typewrite("Hej främling, hur lyder ditt namn?", 30);    //Typewrite = klassen som gör typewriter effekten
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine();

string name;
string answer1;

Thread.Sleep(500);
Console.WriteLine("");
Typewrite("...", 5);
Thread.Sleep(1000);
Console.Clear();

Thread.Sleep(500);
Console.WriteLine("");
Typewrite("Nå?", 30);
Console.WriteLine("");
Console.WriteLine("");
Console.CursorVisible = true;
name = Console.ReadLine();
Console.WriteLine();
Console.CursorVisible = false;
Typewrite($"Hej, {name}.", 30);
Console.WriteLine();
Thread.Sleep(500);
Console.Clear();

Console.WriteLine("");
Typewrite("Du får ursäkta mig, men jag är ivrig att få lära känna dig. Åh så ivrig!", 20);
Console.WriteLine();
Thread.Sleep(750);
Console.Clear();

Console.WriteLine("");
Typewrite("Det var länge någon annan än jag befann sig så högt upp och så långt bort från civilisationen. Mhm, ja det var det.", 15);
Console.WriteLine();
Thread.Sleep(750);
Console.Clear();

Console.WriteLine("");
Typewrite("Hur som helst, jag vill spela ett spel. Inte ett stort spel, åh nej. Men ett litet.", 20);
Thread.Sleep(1500);
Console.WriteLine("");
Console.WriteLine("");
Typewrite($"Säg mig, är du intresserad, {name}?", 30);
Console.WriteLine("");
Console.WriteLine("");
Thread.Sleep(200);
Console.CursorVisible = true;
answer1 = Console.ReadLine();
Console.CursorVisible = false;
Console.WriteLine();
Typewrite($"Hej {name}, ditt svar är {answer1}, eller misstar jag mig förskräckligt?", 30);
Console.WriteLine();
Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("");
Thread.Sleep(500);
Console.WriteLine("");
Typewrite("...", 10);
Console.WriteLine("");
Thread.Sleep(500);
Console.Clear();

Thread.Sleep(1000);
Console.WriteLine("");
Typewrite("Det svaret duger utmärkt,", 30);
Thread.Sleep(1500);
Console.WriteLine("");
Console.WriteLine("");
Console.CursorVisible = true;
Typewrite($"{name}.", 1);
Console.CursorVisible = false;
Thread.Sleep(1500);
Console.Clear();



/*Console.WriteLine(@"[Hint] Are you sure you want to proceed? Type ""/y"" if you are certain:");
Console.WriteLine("");
Console.WriteLine("");
Console.CursorVisible = true;

string x2 = "";
while (x2 != "/y")
{
    x2 = Console.ReadLine();
    x2 = x2.ToLower();
    if (x2 == "")
    {
        Thread.Sleep(2000);
        Console.CursorVisible = false;
        Console.WriteLine("");
        Typewrite("Haxx0r ipsum vi bit /dev/null mainframe win interpreter tunnel in crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flood null private foad memory leak fatal fopen bytes big-endian warez I'm compiling port daemon. Linux python bit access semaphore default boolean gnu break it's a feature foo echo. Linux xss socket buffer bypass Leslie Lamport float kilo vi I'm sorry Dave, I'm afraid I can't do that chown. Emacs class blob char injection wannabee sudo machine code ip rm -rf recursively function linux ctl-c else L0phtCrack stdio.h man pages loop rsa. Packet sniffer d00dz ifdef bang afk public lib spoof bin hexadecimal concurrently todo void. fail server vi crack tera if continue back door gcc function class emacs mountain dew fopen big-endian. Ack recursively cd finally highjack lib mutex while shell salt wannabee flush boolean afk gurfle malloc Trojan horse null new int terminal. Ip fork man pages float for case I'm sorry Dave, I'm afraid I can't do that. It's a feature mega tarball script kiddies foo Linus Torvalds giga L0phtCrack. Piggyback race condition bypass Leslie Lamport eaten by a grue ddos protected snarf bar printf char stack strlen. Warez flood James T. Kirk brute force gobble echo python less mailbomb long linux access injection segfault piggyback var frack bytes. Leapfrog overflow loop bang error concurrently machine code. Hash deadlock leet packet sniffer bin gnu system grep stdio.h worm. Regex cat mainframe cookie stack trace /dev/null spoof semaphore *.* ip blob false exception client ssh alloc rsa daemon suitably small values. Gc chown baz Dennis Ritchie wombat else port hello world data syn bit interpreter perl Donald Knuth eof ascii firewall. Snarf mainframe injection all your base are belong to us root do unix hash leet terminal overflow malloc snarf Linus Torvalds gurfle. Cd concurrently then eof flush semaphore sql baz frack highjack function machine code it's a feature leapfrog. I'm sorry Dave, I'm afraid I can't do that emacs fork error thread blob syn. Ip dereference infinite loop worm ip true todo spoof while void Starcraft echo memory leak new finally wombat ascii int mutex nak case access tarball. Irc xss ssh break bytes kilo pragma foo mega packet sniffer. Regex James T. Kirk gobble system printf script kiddies foad strlen ddos if fail Donald Knuth recursively perl bin. Ban else wannabee tunnel in stack trace bar char eaten by a grue stdio.h race condition buffer. Suitably small values packet /dev/null firewall Leslie Lamport suitably small values. Piggyback afk crack gc var rm -rf giga headers double bubble sort ack. Man pages protected long man pages daemon for class mountain dew bit epoch segfault ctl-c gcc private socket server. Gurfle gcc memory leak all your base are belong to us system socket thread tunnel in public gurfle rsa. Interpreter race condition man pages tarball recursively cat endif loop hack the mainframe overflow warez flush brute force. Frack chown double Starcraft irc ack malloc bubble sort finally fork packet Dennis Ritchie server root bin printf d00dz sudo alloc highjack. Void rm -rf bang concurrently terminal hash true *.* fail bar access wannabee leet eaten by a grue Leslie Lamport perl try catch todo segfault. Break mega Trojan horse ip long private syn it's a feature wombat xss default hexadecimal strlen port mountain dew emacs. Back door class mailbomb stack trace ddos vi stdio.h ban gnu. Nak python kilo giga salt sql cookie Linus Torvalds leapfrog float script kiddies else gc lib infinite loop. Unix worm shell fopen over clock void buffer packet sniffer I'm compiling interpreter flood pragma. Donald Knuth function piggyback null cd bypass regex epoch afk back door do machine code grep I'm sorry Dave, I'm afraid I can't do that. Tcp cache ascii spoof semaphore L0phtCrack error pwned protocol boolean new tera injection mainframe.", 0);
        Typewrite("crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flood null private foad memory leak fatal fopen bytes big-endian warez I'm compiling port daemon. Linux python bit access semaphore default boolean gnu break it's a feature foo echo. Linux xss socket buffer bypass Leslie Lamport float kilo vi I'm sorry Dave, I'm afraid I can't do that chown. Emacs class blob char injection wannabee sudo machine code ip rm -rf recursively function linux ctl-c else L0phtCrack stdio.h man pages loop rsa. Packet sniffer d00dz ifdef bang afk public lib spoof bin hexadecimal concurrently todo void. fail server vi crack tera if continue back door gcc function class emacs mountain dew fopen big-endian. Ack recursively cd finally highjack lib mutex while shell salt wannabee flush boolean afk gurfle malloc Trojan horse null new int terminal. Ip fork man pages float for case I'm sorry Dave, I'm afraid I can't do that. It's a feature mega tarball script kiddies foo Linus Torvalds giga L0phtCrack. Piggyback race condition bypass Leslie Lamport eaten by a grue ddos protected snarf bar printf char stack strlen. Warez flood James T. Kirk brute force gobble echo python less mailbomb long linux access injection segfault piggyback var frack bytes. Leapfrog overflow loop bang error concurrently machine code. Hash deadlock leet packet sniffer bin gnu system grep stdio.h worm. Regex cat mainframe cookie stack trace /dev/null spoof semaphore *.* ip blob false exception client ssh alloc rsa daemon suitably small values. Gc chown baz Dennis Ritchie wombat else port hello world data syn bit interpreter perl Donald Knuth eof ascii firewall. Snarf mainframe injection all your base are belong to us root do unix hash leet terminal overflow malloc snarf Linus Torvalds gurfle. Cd concurrently then eof flush semaphore sql baz frack highjack function machine code it's a feature leapfrog. I'm sorry Dave, I'm afraid I can't do that emacs fork error thread blob syn. Ip dereference infinite loop worm ip true todo spoof while void Starcraft echo memory leak new finally wombat ascii int mutex nak case access tarball. Irc xss ssh break bytes kilo pragma foo mega packet sniffer. Regex James T. Kirk gobble system printf script kiddies foad strlen ddos if fail Donald Knuth recursively perl bin. Ban else wannabee tunnel in stack trace bar char eaten by a grue stdio.h race condition buffer. Suitably small values packet /dev/null firewall Leslie Lamport suitably small values. Piggyback afk crack gc var rm -rf giga headers double bubble sort ack. Man pages protected long man pages daemon for class mountain dew bit epoch segfault ctl-c gcc private socket server. Gurfle gcc memory leak all your base are belong to us system socket thread tunnel in public gurfle rsa. Interpreter race condition man pages tarball recursively cat endif loop hack the mainframe overflow warez flush brute force. Frack chown double Starcraft irc ack malloc bubble sort finally fork packet Dennis Ritchie server root bin printf d00dz sudo alloc highjack. Void rm -rf bang concurrently terminal hash true *.* fail bar access wannabee leet eaten by a grue Leslie Lamport perl try catch todo segfault. Break mega Trojan horse ip long private syn it's a feature wombat xss default hexadecimal strlen port mountain dew emacs. Back door class mailbomb stack trace ddos vi stdio.h ban gnu. Nak python kilo giga salt sql cookie Linus Torvalds leapfrog float script kiddies else gc lib infinite loop. Unix worm shell fopen over clock void buffer packet sniffer I'm compiling interpreter flood pragma. Donald Knuth function piggyback null cd bypass regex epoch afk back door do machine code grep I'm sorry Dave, I'm afraid I can't do that. Tcp cache ascii spoof semaphore L0phtCrack error pwned protocol boolean new tera injection mainframe", 0);
        Typewrite("crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flo", 0);
        Typewrite("Haxx0r ipsum vi bit /dev/null mainframe win interpreter tunnel in crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flood null private foad memory leak fatal fopen bytes big-endian warez I'm compiling port daemon. Linux python bit access semaphore default boolean gnu break it's a feature foo echo. Linux xss socket buffer bypass Leslie Lamport float kilo vi I'm sorry Dave, I'm afraid I can't do that chown. Emacs class blob char injection wannabee sudo machine code ip rm -rf recursively function linux ctl-c else L0phtCrack stdio.h man pages loop rsa. Packet sniffer d00dz ifdef bang afk public lib spoof bin hexadecimal concurrently todo void. fail server vi crack tera if continue back door gcc function class emacs mountain dew fopen big-endian. Ack recursively cd finally highjack lib mutex while shell salt wannabee flush boolean afk gurfle malloc Trojan horse null new int terminal. Ip fork man pages float for case I'm sorry Dave, I'm afraid I can't do that. It's a feature mega tarball script kiddies foo Linus Torvalds giga L0phtCrack. Piggyback race condition bypass Leslie Lamport eaten by a grue ddos protected snarf bar printf char stack strlen. Warez flood James T. Kirk brute force gobble echo python less mailbomb long linux access injection segfault piggyback var frack bytes. Leapfrog overflow loop bang error concurrently machine code. Hash deadlock leet packet sniffer bin gnu system grep stdio.h worm. Regex cat mainframe cookie stack trace /dev/null spoof semaphore *.* ip blob false exception client ssh alloc rsa daemon suitably small values. Gc chown baz Dennis Ritchie wombat else port hello world data syn bit interpreter perl Donald Knuth eof ascii firewall. Snarf mainframe injection all your base are belong to us root do unix hash leet terminal overflow malloc snarf Linus Torvalds gurfle. Cd concurrently then eof flush semaphore sql baz frack highjack function machine code it's a feature leapfrog. I'm sorry Dave, I'm afraid I can't do that emacs fork error thread blob syn. Ip dereference infinite loop worm ip true todo spoof while void Starcraft echo memory leak new finally wombat ascii int mutex nak case access tarball. Irc xss ssh break bytes kilo pragma foo mega packet sniffer. Regex James T. Kirk gobble system printf script kiddies foad strlen ddos if fail Donald Knuth recursively perl bin. Ban else wannabee tunnel in stack trace bar char eaten by a grue stdio.h race condition buffer. Suitably small values packet /dev/null firewall Leslie Lamport suitably small values. Piggyback afk crack gc var rm -rf giga headers double bubble sort ack. Man pages protected long man pages daemon for class mountain dew bit epoch segfault ctl-c gcc private socket server. Gurfle gcc memory leak all your base are belong to us system socket thread tunnel in public gurfle rsa. Interpreter race condition man pages tarball recursively cat endif loop hack the mainframe overflow warez flush brute force. Frack chown double Starcraft irc ack malloc bubble sort finally fork packet Dennis Ritchie server root bin printf d00dz sudo alloc highjack. Void rm -rf bang concurrently terminal hash true *.* fail bar access wannabee leet eaten by a grue Leslie Lamport perl try catch todo segfault. Break mega Trojan horse ip long private syn it's a feature wombat xss default hexadecimal strlen port mountain dew emacs. Back door class mailbomb stack trace ddos vi stdio.h ban gnu. Nak python kilo giga salt sql cookie Linus Torvalds leapfrog float script kiddies else gc lib infinite loop. Unix worm shell fopen over clock void buffer packet sniffer I'm compiling interpreter flood pragma. Donald Knuth function piggyback null cd bypass regex epoch afk back door do machine code grep I'm sorry Dave, I'm afraid I can't do that. Tcp cache ascii spoof semaphore L0phtCrack error pwned protocol boolean new tera injection mainframe.", 0);
        Typewrite("crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flood null private foad memory leak fatal fopen bytes big-endian warez I'm compiling port daemon. Linux python bit access semaphore default boolean gnu break it's a feature foo echo. Linux xss socket buffer bypass Leslie Lamport float kilo vi I'm sorry Dave, I'm afraid I can't do that chown. Emacs class blob char injection wannabee sudo machine code ip rm -rf recursively function linux ctl-c else L0phtCrack stdio.h man pages loop rsa. Packet sniffer d00dz ifdef bang afk public lib spoof bin hexadecimal concurrently todo void. fail server vi crack tera if continue back door gcc function class emacs mountain dew fopen big-endian. Ack recursively cd finally highjack lib mutex while shell salt wannabee flush boolean afk gurfle malloc Trojan horse null new int terminal. Ip fork man pages float for case I'm sorry Dave, I'm afraid I can't do that. It's a feature mega tarball script kiddies foo Linus Torvalds giga L0phtCrack. Piggyback race condition bypass Leslie Lamport eaten by a grue ddos protected snarf bar printf char stack strlen. Warez flood James T. Kirk brute force gobble echo python less mailbomb long linux access injection segfault piggyback var frack bytes. Leapfrog overflow loop bang error concurrently machine code. Hash deadlock leet packet sniffer bin gnu system grep stdio.h worm. Regex cat mainframe cookie stack trace /dev/null spoof semaphore *.* ip blob false exception client ssh alloc rsa daemon suitably small values. Gc chown baz Dennis Ritchie wombat else port hello world data syn bit interpreter perl Donald Knuth eof ascii firewall. Snarf mainframe injection all your base are belong to us root do unix hash leet terminal overflow malloc snarf Linus Torvalds gurfle. Cd concurrently then eof flush semaphore sql baz frack highjack function machine code it's a feature leapfrog. I'm sorry Dave, I'm afraid I can't do that emacs fork error thread blob syn. Ip dereference infinite loop worm ip true todo spoof while void Starcraft echo memory leak new finally wombat ascii int mutex nak case access tarball. Irc xss ssh break bytes kilo pragma foo mega packet sniffer. Regex James T. Kirk gobble system printf script kiddies foad strlen ddos if fail Donald Knuth recursively perl bin. Ban else wannabee tunnel in stack trace bar char eaten by a grue stdio.h race condition buffer. Suitably small values packet /dev/null firewall Leslie Lamport suitably small values. Piggyback afk crack gc var rm -rf giga headers double bubble sort ack. Man pages protected long man pages daemon for class mountain dew bit epoch segfault ctl-c gcc private socket server. Gurfle gcc memory leak all your base are belong to us system socket thread tunnel in public gurfle rsa. Interpreter race condition man pages tarball recursively cat endif loop hack the mainframe overflow warez flush brute force. Frack chown double Starcraft irc ack malloc bubble sort finally fork packet Dennis Ritchie server root bin printf d00dz sudo alloc highjack. Void rm -rf bang concurrently terminal hash true *.* fail bar access wannabee leet eaten by a grue Leslie Lamport perl try catch todo segfault. Break mega Trojan horse ip long private syn it's a feature wombat xss default hexadecimal strlen port mountain dew emacs. Back door class mailbomb stack trace ddos vi stdio.h ban gnu. Nak python kilo giga salt sql cookie Linus Torvalds leapfrog float script kiddies else gc lib infinite loop. Unix worm shell fopen over clock void buffer packet sniffer I'm compiling interpreter flood pragma. Donald Knuth function piggyback null cd bypass regex epoch afk back door do machine code grep I'm sorry Dave, I'm afraid I can't do that. Tcp cache ascii spoof semaphore L0phtCrack error pwned protocol boolean new tera injection mainframe", 0);
        Typewrite("crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flo", 0);
        Typewrite("crack hack the mainframe. Fatal protected double overflow terminal bang root tera ban big-endian. Ack giga true do endif case man pages cat pwned Trojan horse bar throw printf foo while var server ack James T. Kirk semaphore xss if infinite loop. Long socket mega afk grep dereference Starcraft foad wannabee perl ifdef injection hello world blob gnu recursively ip Dennis Ritchie rm -rf. Daemon flood packet sniffer public d00dz ddos lib baz eof firewall back door bin gc stack trace bypass chown. Private concurrently ssh exception stdio.h gobble false unix less class long *.* data continue break echo. Bytes mutex L0phtCrack sql cookie for worm kilo default regex system I'm compiling. Try catch warez cache alloc wabbit strlen float finally eaten by a grue char. January 1, 1970 client void mailbomb else rsa salt script kiddies highjack segfault frack hexadecimal machine code. Spoof leapfrog daemon shell leet sudo error all your base are belong to us stack. Injection else continue back door Leslie Lamport error loop concurrently highjack. Root function foad foo sudo ack brute force worm gurfle Dennis Ritchie irc fork printf man pages. Headers epoch semaphore lib public infinite loop big-endian tera cache leapfrog suitably small values Donald Knuth. Nak giga false deadlock case long buffer stack trace client null regex strlen cookie wannabee warez gcc bypass class then try catch. Pragma piggyback Linus Torvalds xss d00dz overflow eof bubble sort salt protocol double bin. Firewall pragma ssh machine code ip wabbit rsa unix packet sniffer January 1, 1970 kilo /dev/null. Sql perl ascii hack the mainframe over clock I'm compiling finally firewall new flush. Wombat rm -rf recursively *.* injection nak Trojan horse daemon char blob tarball memory leak eaten by a grue. Ctl-c root ban syn gobble malloc data mountain dew python all your base are belong to us hash port boolean flood endif wombat Starcraft. Chown interpreter leet alloc bytes tunnel in cd true gnu todo if tcp for pwned afk mailbomb access do bit fail protected terminal while default ctl-c. Ip unix ssh nak perl regex mountain dew false race condition throw stack alloc worm suitably small values client protected flush stack trace double. Interpreter James T. Kirk snarf server less hack the mainframe mutex try catch interpreter root pragma then Linus Torvalds. Grep eaten by a grue cache thread all your base are belong to us hello world protocol terminal sql irc cat ack finally leet fork frack. Bubble sort new ddos over clock firewall malloc headers gobble gurfle tarball Trojan horse piggyback leapfrog bar syn mainframe. Infinite loop mega deadlock packet overflow var win Donald Knuth. Semaphore grep hash flo", 0);

    }
    else
    {
        Thread.Sleep(1000);
        Console.CursorVisible = false;
        Console.WriteLine("");
        Typewrite("That's not quite what I expected you to do", 30);
        Console.WriteLine("");
        Console.WriteLine("");
        Typewrite("Try again.", 50); Thread.Sleep(500); Console.WriteLine("  :/");
        Console.WriteLine("");
        Console.CursorVisible = true;
        Console.WriteLine("");

    }
}*/

Console.Clear();
Console.CursorVisible = false;
Thread.Sleep(500);
Console.WriteLine("");
Console.WriteLine(@"[Hint] try typing ""Where am I?"" in the row below, if you want:");
Console.WriteLine("");
Console.WriteLine("");
Console.CursorVisible = true;

string x = "";
while (x != "where am i?")
{
    x = Console.ReadLine();
    x = x.ToLower();
    if (x == "where am i?")
    {
        Thread.Sleep(2000);
        Console.CursorVisible = false;
        Console.WriteLine("");
        Typewrite("Du får mig att spännas av rysning", 30); Typewrite(", och jag blir full av förljusning!", 50); Thread.Sleep(1500); Console.WriteLine("  ^^");

    }
    else
    {
        Thread.Sleep(1000);
        Console.CursorVisible = false;
        Console.WriteLine("");
        Typewrite("That's not quite what I expected you to do", 30);
        Console.WriteLine("");
        Console.WriteLine("");
        Typewrite("Try again.", 50); Thread.Sleep(500); Console.WriteLine("  :/");
        Console.WriteLine("");
        Console.CursorVisible = true;
        Console.WriteLine("");

    }
}
Console.CursorVisible = true;
Thread.Sleep(500);
Console.Clear();
Thread.Sleep(1000);
Console.CursorVisible = false;
Console.Clear();
Console.ReadLine();

/*else if (x == "where am i?") 
{
    Thread.Sleep(1000);
    Typewrite("I'm thrilled  you asked!", 30);
}*/



// Console.ReadLine();



