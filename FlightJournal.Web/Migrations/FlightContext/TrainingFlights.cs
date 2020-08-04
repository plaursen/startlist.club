using System.Data.Entity.Migrations;
using FlightJournal.Web.Models.Training;

namespace FlightJournal.Web.Migrations.FlightContext
{
    internal static class TrainingFlights
    {
        public static void InitializeTrainingLessons(Models.FlightContext context)
        {
            // ren r�v
            context.TrainingPrograms.RemoveRange(context.TrainingPrograms);


            var tpSPL_S = new Training2Program("SPL-S", "SPL, spilstart",
                    @"<b>S�rligt for elever, der indtr�der i tr�ningsprogrammet fra en anden DTO/ATO:</b> <br>
                        N�r elever, der er startet p� uddannelsen til SPL - certifikat i en anden DTO / ATO, �nsker at forts�tte uddannelsen i DSvU�s DTO, skal den uddannelsesansvarlige p� den flyveplads, hvor eleven �nsker at forts�tte uddannelsen, skabe sig overblik over, hvor langt eleven er kommet i sin uddannelse.<br>
                        Den uddannelsesansvarlige skal hvis muligt indhente oplysninger hos Assisterende Head of Training i den ATO / DTO, som eleven kommer fra.Inden uddannelsen kan forts�tte i DSvU�s DTO, skal den uddannelsesansvarlige flyve en eller flere flyvninger med eleven for at konstatere det aktuelle uddannelsesniveau.<br>
                        <br>
                        <b>Operationelle bestemmelser for at flyve f�rste soloflyvning:</b> <br>
                        Ved f�rste soloflyvning m� vindhastigheden ikke overstige 20 kts, og sidevindskomponenten m� ikke overstige 12 kts.Eleven skal forud for soloflyvningen have vist evnen til at kunne starte i den maksimale sidevindskomponent, og begr�nsninger i skoleflyets h�ndbog skal under alle omst�ndigheder overholdes."
                )
                {Url = @"https://medlem.dsvu.dk/grp900/2129-uhb922-flyvelektioner-til-spl-certifikat-spilstart/file/menu-id-117" };


            var lessSPL_A0 =  new Models.Training.Training2Lesson(
                "A0",
                @"<h4>Introduktion til skoleflyet</h4> 
                Eleven skal instrueres i, hvordan skoleflyet er indrettet og hvilke elementer, der skal betjenes under flyvningen. <br>
                Lektionen b�r gennemf�res som det allerf�rste i elevens uddannelsen. �velsen i sig selv medf�rer ikke flyvning.<br>
                <h4>Faretilstande og n�dudstyr</h4>
                Eleven skal instrueres i sin rolle, hvis der skulle opst� en faresituation under flyvning, og hvilke ting han skal g�re i en s�dan situation. <br>
                Eleven skal endvidere instrueres i, at der under uddannelsen vil opst� situationer som led i tr�ningen, og som ikke er hverken en faretilstand eller en n�dsituation.<br>
                <h4>Sikkerhed og rapportering</h4> 
                Instrukt�ren skal vise eleven, hvordan han kan rapportere sikkerhedsm�ssige oplevelser til DSvU�s Safety Management System, for at andre kan l�re af denne oplevelse. 
                Han skal endvidere orientere om, hvordan en pilot forholder sig, hvis der sker h�ndelse eller havari, og hvordan en pilot kan lave en rapportering, hvis han g�r sig skyldig i noget, som medf�rer overtr�delse af regler og bestemmelser<br>"
            )
            {
                Precondition = @"Eleven skal v�re fyldt 14 �r for at kunne flyve solo efter afsluttet uddannelse som sv�veflyvepilot"
            };
            var lessSPL_A1 = new Models.Training.Training2Lesson(
                "A1",
                @"<h4>Forberedelse til flyvning</h4> 
                Eleven skal orienteres om, hvad der skal v�re p� plads, inden man kan flyve, og at enhver skolingsflyvning starter med en briefing om, hvad der skal ske under flyvningen.<br>
                <h4>Omst�ndigheder p� jorden</h4>Eleven skal hj�lpe med til at f� fly ud af hangaren og hj�lpe med til Dagligt Tilsyn.<br>
                <h4>Tilpasning i cockpit</h4>Eleven skal instrueres i, hvad han skal have med i flyet, for at tyngdepunktet ligger korrekt og for at sidde godt, s� han kan n� styregrejerne og have et tilstr�kkeligt udsyn.<br>
                <h4>Forberedelse inden start</h4>Eleven skal l�re at lave cockpitcheck efter flyets checkliste. Han skal forberede sig mentalt p� en afbrudt start samt l�re, at wiren under spilstart skal udkobles, hvis min. hastighed eller max. hastighed i spilstart n�s.<br>
                <h4>Tilv�nningsflyvning</h4>Eleven skal orienteres om, hvordan flyveplads og terr�n ser ud fra luften, og han skal l�re at kigge ud inden �ndring af flyveretning.<br>"
            );
            var lessSPL_A2 = new Models.Training.Training2Lesson(
                "A2",
                @"
<h4>Fartkontrol og brug af ror</h4>
Eleven skal l�re at bruge visuelle referencer under flyvning � is�r flyets stilling ift. horisonten. Han skal have demonstreret virkningen af de enkelte ror og derved opleve, at kun kombination af rorene giver god flyvning. <br>
Han skal have demonstreret og senere selv pr�ve at bringe flyet i sin normale position ved ligeudflyvning under normal glid.<br>
Luftbremser og evt. flaps demonstreres, s� eleven kan opleve virkningen
                "
            );
            var lessSPL_A3 = new Models.Training.Training2Lesson(
                "A3",
                @"
<h4>Ligeudflyvning</h4>
Eleven skal pr�ve at flyve med forskellige hastigheder for herefter at vende tilbage til normal flyvestilling ved brug af visuel reference til horisonten. <br>
Samtidig skal han overv�ge instrumenter � is�r fartm�ler og variometer. Han erfarer, at fartm�leren reagerer bagefter flyets bev�gelser.<br>


<h4>Kursflyvning</h4>
Eleven skal l�re at flyve kursflyvning mod et punkt langt v�k eller langs en linje p� jorden (vej, jernbane, skovkant osv).<br>
Eleven skal endvidere kunne korrigere kursen ved brug af sm� bev�gelser p� side- og kr�ngeror. 
Eleven skal endvidere l�re at bruge flyets trim, s� flyet selv holder den valgte hastighed, selv om styrepinden slippes<br>
                "
            );
            var lessSPL_A4 = new Models.Training.Training2Lesson(
                "A4",
                @"
<h4>Rorkoordination</h4>
Eleven skal l�re at bruge side- og kr�ngeror samtidigt for kunne lave koordinerede drej. Rorenes sekund�re virkning skal demonstreres for eleven. <br>
Eleven skal endvidere l�re, hvordan uldsnoren eller kuglelibellen kommer ind p� plads, s� flyve flyver rent. I denne forbindelse skal eleven l�re at vurdere, om det den urene flyvning skyldes en forkert kr�ngning eller et forkert udslag p� sideroret.<br>

<h4>Kr�ngning og drej</h4>
Ind- og udgang af drej med 20&deg; kr�ngning med korrektion, n�r kr�ngning er n�et. Eleven skal l�re at korrigere i drejet<br>
                "
            );
            var lessSPL_A5 = new Models.Training.Training2Lesson(
                "A5",
                @"
<h4>Drej med 30&deg; kr�ngning</h4>
Med udgangspunkt A5 skal eleven �ve drej med st�rre kr�ngning p� 30&deg; kr�ngning, som skal fastholdes idrejet. B�de ind- og udgang i drejet skal v�re koordineret og rent, og eleven skal kunne flyve 8-taller med 30&deg; kr�ngning.<br>

<h4>Udretning p� bestemte kurser</h4>
Eleven skal l�re at rette ud mod bestemt terr�npunkt eller p� en given kompaskurs. Sideglidning og udskridning i drej demonstreres<br>

<h4>Landingsrunde</h4>
Eleven skal l�re at s�tte en korrekt landingsrunde op under hensyntagen til vind og anden trafik.<br> 
Eleven skal l�re proceduren for udkig i landingsrunden og forst� betydningen af begrebet sigtepunkt i indflyvningen samt begynde at bruge luftbremser til regulering af indflyvning
                "
            );
            var lessSPL_A6 = new Models.Training.Training2Lesson(
                "A6",
                @"
<h4>Forberedelse til spilstart</h4>
Efter at instrukt�ren har demonstreret spilstart, skal eleven l�re at udf�re spilstart. Eleven og instrukt�ren skal p� forh�nd aftale, i hvilke situationer instrukt�ren overtager styringen i spilstarten.<br> 
Eleven skal l�re kommunikation og signalgivning under spilstart og tr�nes i, at wiren skal udl�ses, hvis hastigheden kommer ned p� min. hastighed og op p� max. hastighed i spilstart.

<h4>Normal spilstart</h4>
Eleven skal forts�tte tr�ningen i spilstart med hovedv�gten p� starter i nogenlunde direkte modvind. <br>
Eleven skal forberede sig mentalt til en evt. afbrudt start, og eleven skal under cockpitcheck fort�lle, hvad hans beslutning er vedr. afbrudt start i forskellige h�jdeb�nd.<br>
Eleven skal l�re at aflaste wiren, n�r toppen af spilstarten er ved at v�re n�et, s�ledes at wiren ikke er sp�ndt og dermed risikerer at lave overl�b i spillet<br>


<h4>Spilstart i sidevind</h4>
Eleven skal forts�tte tr�ningen i spilstart med hovedv�gten p� starter i sidevind. Eleven skal forberede sig mentalt til en evt. afbrudt start, og eleven skal under cockpitcheck fort�lle, hvad hans beslutning er vedr. afbrudt start i forskellige h�jdeb�nd.<br>
Eleven skal l�re at aflaste wiren, n�r toppen af spilstarten er ved at v�re n�et, s�ledes at wiren ikke er sp�ndt og dermed risikerer at lave overl�b i spillet<br>


<h4>Faresituationer i spilstart</h4>
Eleven skal kende faresituationerne i spilstarten og l�re at agere p� dem. Is�r bevidstheden om minimum fart i spilstart er helt afg�rende. N�r denne n�s, s�nkes n�sen og wiren kobles af � uanset h�jden.<br>
Hvis max. hastighed ispilstart n�s, uden at signalering har virket, kobles wiren ogs� af.<br>
Eleven skal tr�nes i afbrudte starter i forskellige h�jder. Nogle af disse kan godt ske p� senere lektioner, s�ledes at nogle afbrudte starter st�r �bne i elevloggen i nogen tid.<br>


<h4>Landingsrunde - fortsat</h4>
Eleven skal l�re at sideglide p� kurs i stor h�jde for at kunne bruge det som landingshj�lp.<br>
Eleven skal forts�tte tr�ningen i indflyvning og landing.

                "
            );
            var lessSPL_A7 = new Models.Training.Training2Lesson(
                "A7",
                @"
<h4>Landing</h4>
Eleven skal l�re at lave korrekt m�rkelanding indenfor +/- 25 meter, og udfladningen skal beherskes selvst�ndigt.<br>
Eleven skal l�re at tage hensyn til vinden og dermed l�ngden af indflyvningen afh�ngig af vindstyrken.<br>
Eleven skal l�re at flyve ind med fuldt luftbremseudslag i en stejl nedflyvning, og eleven skal �ve landinger i sidevind<br>


<h4>Kort landing</h4>
Eleven skal l�re at landing med kort afl�b � teknik ved udelanding. Hvis det er muligt vil denne �velse med fordel kunne laves et andet sted p� flyvepladsen, end hvor landingsfeltet normalt ligger.
                "
            );
            var lessSPL_A8 = new Models.Training.Training2Lesson(
                "A8",
                @"
<h4>Langsomflyvning</h4>
Eleven skal l�re at styre flyet ved lav hastighed og stor og kritisk indfaldsvinkel samt erkende symptomer p�, at flyet er t�t p� stallingsgr�nsen.<br>
 Forud for man�vrer som kan medf�re stall eller spind er det afg�rende at sikre sig, at luftrummet under flyet er frit.

<h4>Stall</h4>
Eleven skal pr�ve at flyve flyet ind i et stall fra ligeudflyvning for herefter at rette ud ved at f� flyvefart p� igen ved at trykke flyets n�se.<br>
 Han skal endvidere instrueres om proceduren for udretning, hvis den ene vinger dykker i stallet

<h4>S�rlige stall</h4>
Eleven skal pr�ve at stalle, n�r flyet er i landingskonfiguration med luftbremser ud og evt. flaps udf�ldet. <br>
Udretning skal ogs� indeholde lukning af luftbremser.<br>
Eleven skal ogs� pr�ve stall under stor G-p�virkning � f.eks. med stor kr�ngning eller high-speed-stall
"
            );
            var lessSPL_A9 = new Models.Training.Training2Lesson(
                "A9",
                @"
<h4>Drej med stor kr�ngning</h4>
Eleven skal l�re drej med 45&deg; kr�ngning samt pr�ve og rette ud fra unormale flyvestillinger.<br>
 Eleven skal ogs� pr�ve at g� ind i spiraldyk samt rette ud af denne ved f�rst at bruge kr�ngeror og herefter h�jderor.<br>

<h4>Forebyggelse af spind</h4>
Eleven skal pr�ve et stall under drej samt l�re at rette ud af det.<br>
 Proceduren er den samme som ved udretning af spind (modsat sideror � kort pause � pinden lidt frem � ret ud af dykket).<br>
 Eleven skal endvidere l�re at undg�, at et stall under drej udvikler sig til et egentligt spind.
                "
            );
            var lessSPL_A10 = new Models.Training.Training2Lesson(
                "A10",
                @"
<h4>Begyndende spind</h4>
Eleven skal pr�ve at g� ind i et spind fra et stall under drej, der udvikler sig fra at den ene vinge dykker. <br>
Eleven skal l�re at rette ud fra spindet.<br>
Hvis uddannelsesstedet ikke har et skolefly, der kan spinde, b�r denne �velse foreg� i et fly, der kan spinde.<br>

<h4>Udviklet spind</h4>
Eleven skal pr�ve et fuldt udviklet spind p� mindst �n hel omgang.<br>
Eleven skal kunne h�ndtere den stressede situation, der kan opst� under denne man�vre.<br>
Hvis uddannelsesstedet ikke har et skolefly, der kan spinde, b�r denne �velse foreg� i et fly, der kan spinde.                "
            );
            var lessSPL_A11 = new Models.Training.Training2Lesson(
                "A11",
                @"
<h4>Opsamling f�r solo</h4>
Eleven skal selvst�ndigt demonstrere dagligt tilsyn p� skoleflyet og udfylde omskolingsskema til flyet med udgangspunkt i flyets h�ndbog. Eleven skal redeg�re for cockpitcheck, som skal udf�res under soloflyvning <br>

<h4>Programflyvninger</h4>
Eleven skal flyve et program, som instrukt�ren har givet forud for flyvningen. Hvis programmet indeholder flere emner, end flyvetiden tillader, skal eleven selvst�ndigt afbryde programmet for at kunne udf�re en korrekt landingsrunde og landing.<br>

<h4>Visuel reference</h4>
Eleven skal flyve en flyvning med tild�kket h�jdem�ler, hvor eleven alene ud fra visuelle referencer gennemf�rer en landingsrunde og m�rkelanding uden at kunne bruge h�jdem�leren.<br>

<h4>Gennemgang af relevant teori</h4>
Eleven skal gennemg� relevant teori med emner fra fagene i SPL-teorien, hvis ikke eleven i forvejen har best�et teorien til SPL-certifikatet. Teorien skal indeholde relevante emner, som vedr�rer den konkrete flyveplads, som soloflyvningen skal foreg� fra � f.eks. luftrum, klarering, milj�bestemmelser osv."
            );
            var lessSPL_A12 = new Models.Training.Training2Lesson(
                "A12",
                @"
<h4>Soloflyvning</h4>
Eleven skal gennemf�re min. tre soloflyvninger p� skoleflyet
                "
            );
            var lessSPL_B1 = new Models.Training.Training2Lesson(
                "B1",
                @"
<h4>Typeomskoling - forberedelse</h4>
Eleven skal forberede omskolingen til et ens�det sv�vefly, som kan bruges til resten af den soloflyvning, der skal til for at f� et SPL-certifikat.<br>
Forberedelsen omfatter gennemgang flyets h�ndbog med udfyldelse af omskolingsskema, instruktion om indretning af cockpit samt adskillelse og samling af det p�g�ldende sv�vefly<br>

<h4>Typeomskoling � praktisk flyvning</h4>
Eleven skal gennemg� den praktiske omskoling til flyet incl. flyvning med lav og h�j hastighed, stall fra ligeudflyvning, betjening af optr�kkeligt understel
                "
            );
            var lessSPL_B2 = new Models.Training.Training2Lesson(
                "B2",
                @"
<h4>Soloflyvning p� en-s�det sv�vefly</h4>
Eleven skal min. have 2 timers soloflyvning, og denne lektion giver mulighed for at opbygge rutine p� flyet til opn�else af disse to timer og til evt. at flyve solostr�kflyvning som en senere del af uddannelsen til SPL-certifikatet. <br>
I denne lektion f�r eleven lejlighed til at pr�ve det ens�dede sv�vefly i forskellige vejrforhold                "
            );
            var lessSPL_B3 = new Models.Training.Training2Lesson(
                "B3",
                @"
<h4>Begyndende termikflyvning</h4>
Eleven skal l�re at flyve i termikken, og �velsen kan gennemf�res p� b�de to-s�det og en-s�det sv�vefly. <br>
I starten af �velsen vil det v�re hensigtsm�ssigt, hvis eleven f�r lejlighed til at tr�ne uden at skulle ligge i opvindsomr�der med mange andre sv�vefly<br>

                "
            );
            var lessSPL_B4 = new Models.Training.Training2Lesson(
                "B4",
                @"
<h4>Videreg�ende termikflyvning og anden trafik</h4>
Eleven skal l�re at flyve i termikken, og �velsen kan gennemf�res p� b�de to-s�det og en-s�det sv�vefly. <br>
I denne �velse vil det v�re hensigtsm�ssigt, hvis eleven f�r lejlighed til at tr�ne flyvning, hvor han ogs� skal holde �je med andre sv�vefly i opvindsomr�det<br>

                "
            );
            var lessSPL_B5 = new Models.Training.Training2Lesson(
                "B5",
                @"
<h4>Udelanding</h4>
Eleven skal l�re at udpege egnede marker til udelanding, vurdere indflyvningsforhold samt vurdere markens overflade og h�ldning.<br>
Eleven skal med udgangspunkt i den engelske landingsrunde l�re at s�tte en landingsrunde op til den mark, som han vil bruge.<br>
H�jden skal vurderes med den vinkel, som eleven ser marken i.<br>
I denne �velse b�r landing p� en anden flyveplads indg�.<br>
Det er oplagt at bruge en TMG til denne �velse, da �velsen kan gentages igen og igen, indtil resultatet er tilfredsstillende. <br>
</i>Denne �velse kan kun ske i to-s�det fly med instrukt�r</i>. <br>
<h4>Bem�rk:</h4>
Landings�velser til marker skal afbrydes i min. 500� AGL, medmindre der foreligger en skriftlig aftale med markens ejer om, at marken m� bruges til landings�velser.<br>
Hvis en s�dan tilladelse foreligger, skal indflyvningen afbrydes senest i 50� (15 meter) AGL.
                "
            );
            var lessSPL_B6 = new Models.Training.Training2Lesson(
                "B6",
                @"
<h4>Planl�gning af str�kflyvning</h4>
Eleven skal i denne lektion selvst�ndigt, men under overv�relse af en instrukt�r, planl�gge en str�kflyvning, som skal v�re p� min. 50 km, hvis den flyves solo, og min. 100 km hvis den flyves med instrukt�r i et to-s�det sv�vefly.<br>
�velsen i to-s�det sv�vefly med instrukt�r m� alternativt foreg� i en TMG, men flyvningen skal gennemf�res s�ledes, at den svarer til flyvning i et sv�vefly. Den praktiske udf�relse fremg�r af B7.<br>
                "
            )
            {Precondition = @"Alle del�velser i denne lektion skal v�re gennemg�et, inden eleven flyver str�kflyvning solo eller med instrukt�r" };
            var lessSPL_B7 = new Models.Training.Training2Lesson(
                "B7",
                @"
<h4>Str�kflyvning og optimering</h4>
Eleven skal i denne lektion demonstrere, at han under flyvningen kan h�ndtere de situationer, som opst�r, og udf�re n�dvendige tiltag i den udstr�kning, der bliver behov for det.<br>
 Eleven skal samtidig kunne navigere p� ruten og sikre sig klarering ved flyvekontrollen i den udstr�kning, der er behov for det.<br>
Opst�r der usikkerhed om flyets position, skal eleven kunne iv�rks�tte s�danne tiltag, at sikkerhed om positionen igen opn�s.<br>
Ved landing p� en anden flyveplads skal eleven kunne placere sig i landingsrunden og i forhold til anden trafik samt lande sikkert p� den fremmede flyveplads.<br>
Hvis flyvningen flyves med instrukt�r, skal distancen er v�re min. 100 km.<br>
Hvis flyvningen foreg�r i TMG, skal den tilrettel�gges s�ledes, at flyvningen kommer til at ligne en flyvning i sv�vefly � dvs. med stigning med motor en en given h�jde, hvorefter flyvningen forts�tter med motoren i tomgang. 
Hvis der ikke er termik, kan denne erstattes af stigning med motor, indtil h�jde er n�et til n�ste del af str�kflyvningen. Motoren m� betjenes af instrukt�ren under flyvningen.
                "
            )
            {Precondition= @"Alle del�velser i lektion 43 skal v�re gennemg�et, inden eleven flyver str�kflyvning solo eller med instrukt�r. Hvis
str�kflyvningen flyves solo, skal distancen v�re min. 50 km, og instrukt�ren skal autorisere eleven til denne flyvning.
" };
            var lessSPL_B8 = new Models.Training.Training2Lesson(
                "B8",
                @"
<h4>Forberedelse til certifikatpr�ve</h4>
Efter gennemf�relse af nogle flyvninger under denne lektion skal instrukt�ren kunne indstille eleven til pr�ve hos en eksaminator.<br>
 Eleven skal kunne blive indstillet ved at kunne udf�re �velserne indenfor de angivne tolerancer, der er beskrevet nedenfor.                "
            )
            {Precondition= @"
<ul>
<li>Eleven skal v�re fyldt 16 �r</li>
<li>Uddannelsesprogram fra A-0 til B-7 skal v�re gennemf�rt</li>
<li>Eleven skal have mindst 15 timers flyvetid p� sv�vefly, heraf:
  <ul>
    <li>min. 10 timers to-s�det instruktion</li>
    <li>min. 2 timers soloflyvning</li>
  </ul>
</li>

<li>Eleven skal have mindst 45 starter</li>
<li>Min. �n solostr�kflyvning p� 50 km eller mindst �n to-s�det str�kflyvning p� 100 km med instrukt�r</li>
<li>Eleven skal have gennemg�et og best�et teorien til SPL-certifikat</li>
</ul>

Kravet om min. 15 timers samlet flyvetid som elev kan reduceres til min. 7,5 timer<br>
Kravet om flyvetid solo p� sv�vefly p� min. 2 timer kan ikke reduceres<br>
Krav om str�kflyvning kan ikke reduceres eller erstattes<br>
" };
            ;

            var exSPL_dummy = new Training2Exercise("(placeholder)");
            var exSPL_A0_1 = new Training2Exercise("Sv�veflyets karakteristika", true);
            var exSPL_A0_2 = new Training2Exercise("Cockpit, instrumenter og udstyr", true);
            var exSPL_A0_3 = new Training2Exercise("Styregrejer, h�ndtag og kontakter", true);
            var exSPL_A0_4 = new Training2Exercise("Checkliste, procedure og kontrol", true);
            var exSPL_A0_5 = new Training2Exercise("N�dkast af f�rersk�rm og funktion af faldsk�rm", true){Note= @"f.eks. blokeret ror, luftbremse, udl�ser til kobling osv. " };
            var exSPL_A0_6 = new Training2Exercise("Systemsvigt � hvad g�r man?", true);
            var exSPL_A0_7 = new Training2Exercise("Procedure for udspring", true);
            var exSPL_A0_8 = new Training2Exercise("DSvU�s Safety Management System", true){Note= @"Grundlag for at �ge den fremtidige flyvesikkerhed" };
            var exSPL_A0_9 = new Training2Exercise("Rapportering af h�ndelser m.v.", true){Note= @"Ogs� hvor der ikke skete noget, men hvor risikoen var der" };
            var exSPL_A0_10 = new Training2Exercise("Hvordan rapporterer man", true){Note= @"Via DSvU�s hjemmeside" };

            var exSPL_A1_1 = new Training2Exercise("Briefing inden flyvning", true){Note= @"Instrukt�ren har forud kigget i elevens uddannelseslog." };
            var exSPL_A1_2 = new Training2Exercise("Dokumenter til r�dighed", true){Note= @"Flyets dokumenter mv" };
            var exSPL_A1_3 = new Training2Exercise("N�dvendigt udstyr", true);
            var exSPL_A1_4 = new Training2Exercise("H�ndtering af fly f�r flyvning");
            var exSPL_A1_5 = new Training2Exercise("Tilsyn og kontrol med fly");
            var exSPL_A1_6 = new Training2Exercise("Max. og min. v�gt / tyngdepunkt"){Note= @"Evt. ballast ved elev med lav v�gt" };
            var exSPL_A1_7 = new Training2Exercise("Indstilling af s�de, pedaler og seler");
            var exSPL_A1_8 = new Training2Exercise("Cockpitcheck efter checkliste");
            var exSPL_A1_9 = new Training2Exercise("Hvad er flyets mindste hastighed i spilstart") { Note = @"Udkobling hvis min. hastighed n�s " };
            var exSPL_A1_10 = new Training2Exercise("Hvad er flyets maksimale hastighed i spilstart") { Note = @"Udkobling hvis max. hastighed n�s " };
            var exSPL_A1_11 = new Training2Exercise("Forberedelse til afbrudt start"){Note= @"Eleven l�rer, at han fremover skal fort�lle om sine overvejelser om en evt. afbrudt start" };
            var exSPL_A1_12 = new Training2Exercise("Orientering fra luften"){Note= @"Markante terr�npunkter" };
            var exSPL_A1_13 = new Training2Exercise("Procedure for udkig");

            tpSPL_S.Lessons = new[]
            {
                lessSPL_A0,
                lessSPL_A1,
                lessSPL_A2,
                lessSPL_A3,
                lessSPL_A4,
                lessSPL_A5,
                lessSPL_A6,
                lessSPL_A7,
                lessSPL_A8,
                lessSPL_A9,
                lessSPL_A10,
                lessSPL_A11,
                lessSPL_A12,
                lessSPL_B1,
                lessSPL_B2,
                lessSPL_B3,
                lessSPL_B4,
                lessSPL_B5,
                lessSPL_B6,
                lessSPL_B7,
                lessSPL_B8
            };
                
                lessSPL_A0.Exercises = new[]{                
                    exSPL_A0_1,
                    exSPL_A0_2,
                    exSPL_A0_3,
                    exSPL_A0_4,
                    exSPL_A0_5,
                    exSPL_A0_6,
                    exSPL_A0_7,
                    exSPL_A0_8,
                    exSPL_A0_9,
                    exSPL_A0_10,
                };

                lessSPL_A1.Exercises = new[] {                
                    exSPL_A1_1,
                    exSPL_A1_2,
                    exSPL_A1_3,
                    exSPL_A1_4,
                    exSPL_A1_5,
                    exSPL_A1_6,
                    exSPL_A1_7,
                    exSPL_A1_8,
                    exSPL_A1_9,
                    exSPL_A1_10,
                    exSPL_A1_11,
                    exSPL_A1_12,
                    exSPL_A1_13
                };
            context.TrainingPrograms.AddOrUpdate(
                tpSPL_S
            );
            lessSPL_A2.Exercises = new[] {exSPL_dummy};
            lessSPL_A3.Exercises = new[] {exSPL_dummy};
            lessSPL_A4.Exercises = new[] {exSPL_dummy};
            lessSPL_A5.Exercises = new[] {exSPL_dummy};
            lessSPL_A6.Exercises = new[] {exSPL_dummy};
            lessSPL_A7.Exercises = new[] {exSPL_dummy};
            lessSPL_A8.Exercises = new[] {exSPL_dummy};
            lessSPL_A9.Exercises = new[] {exSPL_dummy};
            lessSPL_A10.Exercises = new[] {exSPL_dummy};
            lessSPL_A11.Exercises = new[] {exSPL_dummy};
            lessSPL_A12.Exercises = new[] {exSPL_dummy};
            lessSPL_B1.Exercises = new[] {exSPL_dummy};
            lessSPL_B2.Exercises = new[] {exSPL_dummy};
            lessSPL_B3.Exercises = new[] {exSPL_dummy};
            lessSPL_B4.Exercises = new[] {exSPL_dummy};
            lessSPL_B5.Exercises = new[] {exSPL_dummy};
            lessSPL_B6.Exercises = new[] {exSPL_dummy};
            lessSPL_B7.Exercises = new[] {exSPL_dummy};
            lessSPL_B8.Exercises = new[] {exSPL_dummy};


            context.SaveChanges();
        }
    }
}