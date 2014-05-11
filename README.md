TheMermaidsRush
===============

Game made as a visual programming project

The Mermaid`s Rush
 
Опис на играта


		Оваа апликација претставува игра каде ние го контролираме главниот карактер, сирена, која има за цел да ги избегнува морските мини, кои ако ја удрат го забавуват нејзиното движење и ајкулата доаѓа поблизу до неа.  Освен тоа треба да собираме ноти кои го зголемуваат вкуниот број на поени и времето преостанато за играње. Сирената можеме да ја движиме само нагоре доколку го држиме притиснато соодветно копче, во спротивно таа паѓа надолу. Доколку удриме 4 пати во морска мина или ни истече вкупното време за играње, тоа значи дека е крај на играта.  Од главното мени можеме да отвориме уште две други форми, од кои едната ни ги покажува петте највисоки резултати досега, а другата е кратко објаснување за начинот на играње. Исто така на почетната форма на играта може да се забележи и копче со кое се регулира тоа дали сакаме позадинска музика на главното мени, или не.

		Опис на решението

		За оваа игра беа потребни 8 форми и 2 класи, а играњето се одвива во формата Play.cs. Со помош на еден timer и Paint() метода во континуирани дискретни интервали се движат морските мини и нотите низ мапата. Постојат неколку лабели и прогрес бар кои се едитираат при некоја извршена акција. Играта има можност да памти 5 најдобри резултати кои се чуваат во соодветни датотеки и се читаат и впишуваат при секое ново отворање или затворање на играта.  Сите дополнителни податоци од типот на слики и звуци се чуваат во ресурсите на проектот.  

     Опис на методот Tick()

Оваа е една од посложените методи во нашата игра. Во неа се прават сите проверки и едитирања за идниот тек на играта. Најпрво се придвижуваат сите елементи на мапата и се запишуваат информациите за тоа колку поени сме постигнале досега, уште колку животи ни остануваат и се намалува преостанатото време за играње на ProgresBar . Потоа се вршат проверки за тековните позиции на сирената, ајкулата, мините и нотите. Доколку постои интеракција помеѓу нив се случуваат предвидени последици. Како што спомнавме предходно во точно одредени интервали од времето морските мини и нотите се генерираат на случајни позиции на мапата

ScreenShots
 
 
 
 
 
 

Изработиле:
Дарио Пиперкоски 125006
Мартин Неделковски 125022
Мирче Миравцалиев 125031
