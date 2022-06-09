using Assets.Scripts.GameObjects;
using System;
using System.Collections.ObjectModel;
using UnityEngine;

public class CardDatabase : ICardDatabase
{
    private static Collection<ICard> _cardCollection;

    private void Awake()
    {
        CreateCards();
    }

    private void CreateCards()
    {
        CreateResourceCards();
        CreateEquipmentCards();
        CreateCreatureCards();
        CreateMagicCards();
    }

    private void CreateResourceCards()
    {
        _cardCollection.Add(new Resource(
            0,
            2,
            2,
            "Ein wenig Gold",
            "Erhalte 1 Gold.",
            "Ein klein wenig kosmischer Reichtum eines Helden.",
            CardColor.Gold,
            ResourceCategory.Gold));

        _cardCollection.Add(new Resource(
            1,
            5,
            4,
            "Etwas Gold", "Erhalte 2 Gold.",
            "Kleiner kosmischer Reichtum eines Helden.",
            CardColor.Gold,
            ResourceCategory.Gold));

        _cardCollection.Add(new Resource(
            2,
            8,
            6,
            "Viel Gold",
            "Erhalte 3 Gold.",
            "Gro�er kosmischer Reichtum eines Helden.",
            CardColor.Gold,
            ResourceCategory.Gold));

        _cardCollection.Add(new Resource(
            3,
            5,
            3,
            "Kleine Manaessenz",
            "Erhalte 1 Mana.",
            "Ein wenig Kraft und Energie eines Helden. Die Manaessenz.",
            CardColor.LightBlue,
            ResourceCategory.Mana));

        _cardCollection.Add(new Resource(
            4,
            8,
            6,
            "Gro�e Manaessenz",
            "Erhalte 2 Mana.",
            "Viel Kraft und Energie eines Helden. Die Manaessenz.",
            CardColor.LightBlue,
            ResourceCategory.Mana));
    }
    private void CreateEquipmentCards()
    {
        _cardCollection.Add(new Equipment(
            5,
            5,
            2,
            "Leichte Ausr�stung",
            "Lege diese Karte unter eine Kreatur. Diese bleibt bis zur n�chsten eigenen Ziehphase liegen. Die Kreatur erh�lt 1 Angriffspunkt.",
            "Die Macht um seine beschworenen Kreaturen leicht zu verst�rken.",
            CardColor.Red,
            EquipmentCategory.Attackpoint));

        _cardCollection.Add(new Equipment(
            6,
            8,
            4,
            "Ausgeglichene Ausr�stung",
            "Lege diese Karte unter eine Kreatur. Diese bleibt bis zur n�chsten eigenen Ziehphase liegen. Die Kreatur erh�lt 3 Lebenspunkte.",
            "Die Macht um seine beschworenen Kreaturen ausgeglichen zu verst�rken.",
            CardColor.Red,
            EquipmentCategory.Lifepoint));

        _cardCollection.Add(new Equipment(
            7,
            12,
            6,
            "Schwere Ausr�stung",
            "Lege diese Karte unter eine Kreatur. Diese bleibt bis zur n�chsten eigenen Ziehphase liegen. Die Kreatur erh�lt 4 Angriffspunkte.",
            "Die Macht um seine beschworenen Kreaturen schwer zu verst�rken.",
            CardColor.Red,
            EquipmentCategory.Attackpoint));
    }
    private void CreateCreatureCards()
    {
        _cardCollection.Add(new Creature(
            8,
            0,
            1,
            "Schutzsph�re",
            "",
            "Ein treuer Begleiter, dessen einziger Sinn es ist, den Helden zu besch�tzen.",
            CardColor.LightBrown,
            CreatureCategory.NoneEffect,
            CardProperty.Unidentifiziert));

        _cardCollection.Add(new Creature(
            9,
            3,
            1,
            "Laufender Tod",
            "Diese Karte ist maximal 3-mal stapelbar. Erhalte +1 Zauber. Wird diese Karte durch einen Gegner zerst�rt, dann verlierst du 1 Lebenspunkt.",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Leblos));

        _cardCollection.Add(new Creature(
            10,
            4,
            1,
            "Totenbeschw�rer",
            "Diese Karte ist maximal 3-mal stapelbar. Erhalte +1 Beschw�ren. (Einmal in deinem Zug) Du darfst eine von deinen entfernten Karten zur�ck in deinen Ablagestapel legen.",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Leblos));

        _cardCollection.Add(new Creature(
            11,
            5,
            1,
            "Wahrer der Helligkeit",
            "Zerst�re eine Kreatur mit 0 Lebenspunkten. (In der Aufr�umphase) Du darfst diese Kreatur zerst�ren und dann eine Zauberkarte oder eine Kreatur mit 0 Lebenspunkten deines Gegners zerst�ren.",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Erleuchtete));
        
        _cardCollection.Add(new Creature(
            12,
            5,
            2,
            "K�nig der Toten",
            "Lege 2 Mana ab. Jedes mal, wenn eine oder mehrere entsorgte Karten zur�ck ins Spiel kommen, dann darfst du w�hlen: Erhalte +1 Karte, +1 Zauber oder erhalte +1 Mana, +1 Beschw�ren.",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Leblos));

        _cardCollection.Add(new Creature(
            13,
            6,
            2,
            "Antiker Paladin",
            "Lege 2 Mana ab. (Dauerhaft) Erhalte +1 Gold. Falls sich unter den abgeworfen Karten mindestens eine 'Kleine Manaessenz' befindet, dann darfst du eine davon entsorgen und dir eine gro�e Manaessenz geben. Falls du dies nicht ust, dann gebe einer Kreatur von dir, au�er dieser, 2 Lebenspunkte.",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Antik));

        _cardCollection.Add(new Creature(
            14,
            7,
            3,
            "Paladine der Erleuchtung",
            "Lege 2 Mana ab. (Dauerhaft) Erhalte +2 Gold und +1 Kauf. Du darfst in dem Zug, in dem diese Kreatur beschworen wurde, mit einer Kreatur die 2 Lebenspunkte besitzt einen zus�tzlichen Angriff durchf�hren oder eine weitere Ausr�stungskarte ausspielen. ",
            "",
            CardColor.Brown,
            CreatureCategory.Effect,
            CardProperty.Erleuchtete));

    }
    private void CreateMagicCards()
    {
        _cardCollection.Add(new Magic( 
            15,
            4,
            6,
            "Schildbarriere",
            "(Reaktion) Annulliere einen Effekt oder bleibe von 1 Angriff verschont. (Normal) Erhalte +2 Karten.",
            "",
            CardColor.Blue,
            MagicCategory.Reaction,
            CardProperty.Unidentifiziert));

        _cardCollection.Add(new Magic(
            16,
            4,
            3,
            "Totenbegr�bnis",
            "F�r jede von dir entsorgte Karte, lege einen Chip auf diese Karte (maximal 3). (In der Zauber- und Beschw�renphase) Du darfst 3 Chips von dieser Karte entfernen und einen w�hlen: Erhalte +1 Karte und +1 Zauber oder Ziehe einen Gegner 1 Lebenspunkt ab.",
            "",
            CardColor.Green,
            MagicCategory.Permanent,
            CardProperty.Leblos));

        _cardCollection.Add(new Magic(
            17,
            3,
            3,
            "Leerenw�chter",
            "Entsorge eine beliebige Anzahl an Karten aus deiner Hand.",
            "",
            CardColor.White,
            MagicCategory.Normal,
            CardProperty.Leblos));

        _cardCollection.Add(new Magic(
            18,
            4,
            3,
            "Begleiter der Erleuchteten",
            "Erhalte +2 Gold und +1 Kauf oder erhalte +1 Angriff.",
            "",
            CardColor.White,
            MagicCategory.Normal,
            CardProperty.Erleuchtete));
        
        _cardCollection.Add(new Magic(
            19,
            5,
            5,
            "Antike Baustelle",
            "Entsorge eine Karte. Dann nimm dir eine Karte vom Markt die genau 2 Gold mehr, als die entsorge Karte, kostet oder wirf 1 Karte ab und nimm dir eine Goldkarte die bis zu 3 mehr kostet, als die entsorge Karte.",
            "",
            CardColor.White,
            MagicCategory.Normal,
            CardProperty.Antik));
        
        _cardCollection.Add(new Magic(
            20,
            5,
            4,
            "Beschw�rungszauberer",
            "Erhalte +3 Karten oder erhalte +3 Mana und +1 Beschw�ren.",
            "",
            CardColor.White,
            MagicCategory.Normal,
            CardProperty.Leblos));
        
        _cardCollection.Add(new Magic(
            21,
            6,
            4,
            "Versteckte Wahrheit",
            "Erhalte +1 Karte, +2 Zauber und +1 Gold.",
            "",
            CardColor.White,
            MagicCategory.Normal,
            CardProperty.Unidentifiziert));
    }
}
