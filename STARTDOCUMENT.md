# Start Document Design Patterns

Stendinator the game – VERSIE 2.0

Henk bembom, sydney minnaar en Jordy Neef

2022

# Contents

[1. Idee](#Idee)

[Werkmethode](#Werkmethode)

[Ontwerppatronen](#3. Ontwerppatronen)

&emsp;[Strategy](#3.1 Strategy)

&emsp;[Factory](#3.2 Factory)

&emsp;[Builder](#3.3 Builder)

&emsp;[Observer](#3.4 Observer)

&emsp;[Decorator](#3.5 Decorator)

[Klassendiagrammen](#4 Klassendiagrammen)

## Idee

Voor de eindopdracht van Design Patterns moet er een softwareproduct worden opgeleverd. Aan de eindopdracht zijn eisen gesteld. Het softwareproduct moet minimaal vier _design patterns_ bevatten. Design patterns zijn software architectonisch van aard om een specifiek probleem in de code op te lossen.

De projectgroep dat gaat werken aan de eindopdracht bestaat uit drie personen. Het idee is om een game te ontwikkelen waarbij vijf design patterns worden toegepast. De game heet _Stendinator._ In de game kan de speler een cyborg samenstellen om vervolgens tegen vijanden te vechten. De vijand en de speler moeten om de beurt een actie uitvoeren. De speler kan niet winnen in het spel, omdat het spel oneindig doorgaat.

De speler begint met het samenstellen van de cyborg. De cyborg bestaat uit verschillende ledematen. De ledematen kunnen verschillende unieke eigenschappen hebben. Zo kan een ledemaat offensief of defensief van aard zijn.

Als de speler tevreden is met zijn cyborg, dan begint het spel. De speler wordt naar verschillende planeten gestuurd om tegen vijanden te vechten. Planeten kunnen een positief- of negatief effect hebben op de prestatie van de cyborg om de gevechten spannend te maken. De speler vecht tegen twee vijandige facties: De Aliens en de (kwaadaardige) cyborgs. De vijanden worden random gegenereerd, waardoor geen enkel gevecht hetzelfde zal zijn. Hoe meer vooruitgang de speler boekt, hoe sterker de vijanden worden.

Wanneer de speler een vijand verslaat, krijgt hij resources om ledematen te upgraden. Afhankelijk van het type ledemaat dat wordt geüpgraded kunnen bepaalde statistieken van de cyborg aangepast worden.

  1.
## **Stappen die worden doorlopen bij het spel**

De volgende stappen is de procedure die de speler in de console bij langs gaat:

1. Bouw de Robot
  1. Componenten uitkiezen om te worden toegevoegd
2. Versla een vijand
3. Upgrade de Robot
  1. Selecteer nieuwe componenten met betere statistieken:
 Er worden een willekeurig aantal componenten gedropt en de componenten zijn ook willekeurig, de statistieken worden vermenigvuldigd met het planeetniveau)
  2. Er is een tien procent kans dat er een buff wordt gedropt. De speler kan kiezen op welk component hij deze buff toepast.
4. Versla een planeet (Verhoog het planeetniveau)
5. Begin opnieuw bij stap 2.

# 2. Werkmethode

De projectgroep bestaat uit drie personen: Henk Bembom, Sydney Minnaar en Jordy Neef. Om het idee te realiseren zal er eerst een klassendiagram moeten worden gemaakt. Tijdens het ontwerpen zal direct rekening worden gehouden met de gekozen ontwerppatronen.

Ontwerppatronen zijn best practices die softwareontwikkelaars kunnen toepassen om softwareproblemen op te lossen, zoals het overzichtelijker maken van code. Het zijn daarom zeer handige middelen om toe te passen bij het ontwerpen en realiseren van Stendinator.

Verder zal de projectgroep de SOLID principes toepassen om ten einde te komen van Clean Code. Dit houdt in dat code flexibel en duidelijk is, zodat andere softwareontwikkelaars eenvoudig verder kunnen voortbouwen op de bestaande code.

Om code tussen de projectleden uit te wisselen zal gebruikt worden gemaakt van Github. Hierbij zal gebruik worden gemaakt van Branches, zodat projectleden binnen veilig in hun eigen omgeving kunnen werken zonder code stuk te maken in de _master_ branch.

De projectleden zullen werken in de nieuwste versie van Visual Studio (2022).

Tot slot zal het team de door NHL Stenden gedocumenteerde C# programmeerconventie hanteren om de kwaliteit van de code hoog te houden.

# 3. Ontwerppatronen

In dit hoofdstuk worden de toegepaste ontwerppatronen onderbouwd.

## 3.1 Strategy

Voor het bepalen van het type creature wordt de strategy toegepast, aangezien de verschillende soorten creatures vergelijkbaar met elkaar zijn maar verschillend gedrag hebben. Zo heeft elke creature zijn eigen attacks, en de planeten van elk soort creature net een andere (de-)buff voor de speler heeft.

## 3.2 Factory

De factory method maakt het mogelijk om het planeet object (superclass) creatures aan te laten maken zonder de kennis te hebben van de alien of cyborg (derived classes). Dit zorgt ervoor dat het planeet object geen logica van het creëren van de specifieke objecten, waardoor de klasse niet hoeft worden aangepast als er een nieuwe creature wordt toegevoegd.

## 3.3 Builder

De cyborg bestaat uit veel complexe componenten zoals ledematen. Dit willen we niet in de constructor hebben aangezien deze dan te groot wordt en daarom wordt de builder toegepast. De builder maakt het dan ook mogelijk om de complexe objecten te kunnen creëren. Op deze manier kunnen we de benodigde parameters om tot eenvoudige stappen die achter elkaar uitgevoerd kunnen worden.

## 3.4 Observer

Er zijn situaties waarin meerdere creatures bestaan uit hetzelfde component. Hierdoor wordt dan ook de observer pattern toegepast om de creatures (die bestaan uit de desbetreffende components) op de hoogte te stellen dat ze zijn gebruikt.

## 3.5 Decorator

Een component kan krachtiger worden gemaakt door middel van buffs. Deze buffs worden geïnherit van de ActiveComponent klasse (zie klassediagram). Daarnaast is het de bedoeling dat deze buffs zo veel mogelijk kunnen worden gestacked. Een ontwerppatroon die ons bij deze opzet kan helpen is de decorator.

# 4 Klassendiagrammen

In dit hoofdstuk worden de klassendiagrammen van het ontwerp gevisualiseerd. Daarnaast wordt er ook beschreven welke klassen gerelateerd zijn aan welke ontwerppatronen.

![](RackMultipart20220415-4-1a8t2lf_html_17832d1711ff29b.png)

_Figuur 1 Klassendiagram Kern-project_
