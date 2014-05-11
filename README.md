#The Mermaid`s Rush 

![alt tag]         (http://s27.postimg.org/ug2vz492b/mainmenu.jpg)

##Опис на играта

Оваа апликација претставува игра каде ние го контролираме главниот карактер, сирена, која има за цел да ги избегнува морските мини, кои ако ја удрат го забавуват нејзиното движење и ајкулата доаѓа поблизу до неа.  Освен тоа треба да собираме ноти кои го зголемуваат вкуниот број на поени и времето преостанато за играње. Сирената можеме да ја движиме само нагоре доколку го држиме притиснато соодветно копче, во спротивно таа паѓа надолу. Доколку удриме 4 пати во морска мина или ни истече вкупното време за играње, тоа значи дека е крај на играта.  Од главното мени можеме да отвориме уште две други форми, од кои едната ни ги покажува петте највисоки резултати досега, а другата е кратко објаснување за начинот на играње. Исто така на почетната форма на играта може да се забележи и копче со кое се регулира тоа дали сакаме позадинска музика на главното мени, или не. 
        
##Опис на решението
        
За оваа игра беа потребни 8 форми и 2 класи, а играњето се одвива во формата Play.cs. Со помош на еден timer и Paint() метода во континуирани дискретни интервали се движат морските мини и нотите низ мапата. Постојат неколку лабели и прогрес бар кои се едитираат при некоја извршена акција. Играта има можност да памти 5 најдобри резултати кои се чуваат во соодветни датотеки и се читаат и впишуваат при секое ново отворање или затворање на играта. Сите дополнителни податоци од типот на слики и звуци се чуваат во ресурсите на проектот.

##Опис на методот Tick()

Оваа е една од посложените методи во нашата игра. Во неа се прават сите проверки и едитирања за идниот тек на играта. Најпрво се придвижуваат сите елементи на мапата и се запишуваат информациите за тоа колку поени сме постигнале досега, уште колку животи ни остануваат и се намалува преостанатото време за играње на ProgresBar . Потоа се вршат проверки за тековните позиции на сирената, ајкулата, мините и нотите. Доколку постои интеракција помеѓу нив се случуваат предвидени последици. Како што спомнавме предходно во точно одредени интервали од времето морските мини и нотите се генерираат на случајни позиции на мапата

    
##ScreenShots
При клик на копчето "How to Play?" се појавува следнава форма:
![alt tag]         (http://s29.postimg.org/6xj673gpz/howtoplayss.jpg)
 
При клик на копчето "Play" се појавува главната форма на играта која изгледа вака:
![alt tag]         (http://s21.postimg.org/6qv6zq7mv/Play.jpg)
 
Ако при играње на играта го притиснете копчето "P" се појавува следнава форма и се паузира играта, а за да се продолжи со играње потребно е да притиснете на копчете "R":
![alt tag]         (http://s30.postimg.org/g9s8olehd/paused.jpg)
Ако изгубите без да соберете доволно ноти за да се впишете во "High Scores" ви се појавува следнава форма каде може да одберите дали сакате да играте повторно или не.
![alt tag]         (http://s15.postimg.org/nwdum983f/tryagain.jpg)
Доколку изгубите, но имате собрано доволно ноти за да се впишете во "High Scores" ви се појавува следнава форма каде може да одберите дали сакате да играте повторно или да го зачувате вашиот резултат.
![alt tag]         (http://s24.postimg.org/ksj6848tx/hse.jpg)
Ако притиснете на копчето "Submit" автоматски ви се зачувува вашиот резултат со името кое сте го внеле и се отвора формата "High Scores" каде што се зачувани најдобрите 5 резултати.
![alt tag]         (http://s11.postimg.org/5i7tl26hf/High_Scores.jpg)
Доколку сакате да ја исклучите играта, односно го кликнете копчето "Exit" ќе ви се појави следната форма, каде доколку одберете "Yes" ви се гаси играта.                        
![alt tag]         (http://s27.postimg.org/v8twh5azn/Exit.jpg)
 
 
 
 
 
 
