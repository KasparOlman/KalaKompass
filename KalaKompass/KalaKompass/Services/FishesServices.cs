using KalaKompass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaKompass.Services
{
    class FishesServices
    {
        private static List<Fish> fishes = new()
        {
            new()
            {
                Name = "Haug",
                HeroImage = "haug.png",
                Description = "Haug ehk harilik haug ehk havi (Esox lucius) on hauglaste" +
                "sugukonda haugi perekonda kuuluv röövkala." +
                "Haugil on nooljas keha, mis on natuke külgedel lamenenud. Seljauim on keha tagaosas,"+
                "suurendades saba tõukepinda. See võimaldab välkkiireid kohaltsööste saagi haaramiseks."+
                "Suhteliselt suurel peal on pardi nokka meenutav suu, millel on tahapoole kaldu olevad hambad."+
                "Haugi värvus sõltub keskkonnast, keha on selja pealt tavaliselt rohekas-sinakas, mis muutub allapoole"+
                "minnes üha heledamaks, kõhualune on valge.[viide?]\n\nHaugi hambad on suunatud sissepoole, et vältida saagi "+
                "pagemist suust. Alalõua hambad on eri suurusega ja vahetuvad. Alalõua seesmine külg on kaetud pehme koega,"+
                "mille all on asendushammaste kõverad read. Igal kihval on 2–4 asendushammast ja kui kihv välja langeb,"+
                "siis tuleb tema asemele mõni asendushammas. Algul uus hammas logiseb, edaspidi aga kasvab tihedalt alalõua"+
                "külge kinni. Hambad ei vahetu korraga, vaid kogu aasta vältel pidevalt on haugi suus nii noori kui vanu hambaid."+
                "Haugi tavaline suurus on 50–100 cm, aga ta võib olla üle 150 cm pikk ja üle 35 kg raske."+
                "Vangistuses võib haug elada kuni 30 aasta vanuseks.",
                Habitat = "Eestis on haug tavaline ja teda püütakse ka töönduslikult."+
                " Ta esineb enamikus järvedes ja jõgedes, samuti rannikumeres." +
                "Haug on suhteliselt paikne kala, kes eelistab aeglase vooluga jõgesid,"+
                " järvi ja riimveelist rannikumerd, hoidudes enamasti kalda lähedale taimestikku "+
                "või teistesse varju pakkuvatesse paikadesse. On ka hauge, kes elavad avavees ja "+
                "jälitavad pisemaid parvekalu. Ta talub hästi happelist keskkonda ja võib elada veekogudes, "+
                "mille pH on 4,75[1].",
                Diet = "Haug on röövkala, kes toitub teistest kaladest, ka oma liigikaaslastest. "+
                "Suured haugid võivad süüa konni, pardipoegi ja pisiimetajaid. Haugide hulgas on kannibalism"+
                "väga levinud ja eksisteerib järvi, kus peale haugide teisi kalaliike üldse ei ela."+
                "Neis järvedes söövad pisikesed havid vesikirpe, vähikesi ja muud zooplanktonit,"+
                "aga suuremad liigikaaslased söövad neid[1].",
                Season = "Haugi tohib eestis püüda vahemikul Mai kuni märts, kevadel kehtib keeluaeg"+
                "Harrastuspüügil kasutatakse enamasti spinningut ja elussöödaõnge,"+
                "vähemal määral lendõnge ja põhjaõnge. Enamikus veekogudes on edukaim püügiviis elussöödaõng, mõnes spinning.",
                AccentColorStart = Color.FromArgb("#2E8A8F"),
                AccentColorEnd = Color.FromArgb("#d5d5d5"),
                Images = new()
                {
                    "https://i0.wp.com/eestinen.fi/wp-content/uploads/2017/04/haug.jpg?fit=1024%2C628&ssl=1",
                    "https://media.rmk.ee/photos/haug1_block.jpg",
                    "https://kalafoorum.ee/portaal/wp-content/uploads/2023/03/haugi-hooaeg.jpg"
                }

            },
             new()
            {
                Name = "Koha",
                HeroImage = "koha.png",
                Description = "Haug ehk harilik haug ehk havi (Esox lucius) on hauglaste" +
                "sugukonda haugi perekonda kuuluv röövkala." +
                "Haugil on nooljas keha, mis on natuke külgedel lamenenud. Seljauim on keha tagaosas,"+
                "suurendades saba tõukepinda. See võimaldab välkkiireid kohaltsööste saagi haaramiseks."+
                "Suhteliselt suurel peal on pardi nokka meenutav suu, millel on tahapoole kaldu olevad hambad."+
                "Haugi värvus sõltub keskkonnast, keha on selja pealt tavaliselt rohekas-sinakas, mis muutub allapoole"+
                "minnes üha heledamaks, kõhualune on valge.[viide?]\n\nHaugi hambad on suunatud sissepoole, et vältida saagi "+
                "pagemist suust. Alalõua hambad on eri suurusega ja vahetuvad. Alalõua seesmine külg on kaetud pehme koega,"+
                "mille all on asendushammaste kõverad read. Igal kihval on 2–4 asendushammast ja kui kihv välja langeb,"+
                "siis tuleb tema asemele mõni asendushammas. Algul uus hammas logiseb, edaspidi aga kasvab tihedalt alalõua"+
                "külge kinni. Hambad ei vahetu korraga, vaid kogu aasta vältel pidevalt on haugi suus nii noori kui vanu hambaid."+
                "Haugi tavaline suurus on 50–100 cm, aga ta võib olla üle 150 cm pikk ja üle 35 kg raske."+
                "Vangistuses võib haug elada kuni 30 aasta vanuseks.",
                Habitat = "Eestis on haug tavaline ja teda püütakse ka töönduslikult."+
                " Ta esineb enamikus järvedes ja jõgedes, samuti rannikumeres." +
                "Haug on suhteliselt paikne kala, kes eelistab aeglase vooluga jõgesid,"+
                " järvi ja riimveelist rannikumerd, hoidudes enamasti kalda lähedale taimestikku "+
                "või teistesse varju pakkuvatesse paikadesse. On ka hauge, kes elavad avavees ja "+
                "jälitavad pisemaid parvekalu. Ta talub hästi happelist keskkonda ja võib elada veekogudes, "+
                "mille pH on 4,75[1].",
                Diet = "Haug on röövkala, kes toitub teistest kaladest, ka oma liigikaaslastest. "+
                "Suured haugid võivad süüa konni, pardipoegi ja pisiimetajaid. Haugide hulgas on kannibalism"+
                "väga levinud ja eksisteerib järvi, kus peale haugide teisi kalaliike üldse ei ela."+
                "Neis järvedes söövad pisikesed havid vesikirpe, vähikesi ja muud zooplanktonit,"+
                "aga suuremad liigikaaslased söövad neid[1].",
                Season = "Haugi tohib eestis püüda vahemikul Mai kuni märts, kevadel kehtib keeluaeg"+
                "Harrastuspüügil kasutatakse enamasti spinningut ja elussöödaõnge,"+
                "vähemal määral lendõnge ja põhjaõnge. Enamikus veekogudes on edukaim püügiviis elussöödaõng, mõnes spinning.",
                AccentColorStart = Color.FromArgb("#2E8A8F"),
                AccentColorEnd = Color.FromArgb("#d5d5d5"),
                Images = new()
                {
                    "https://i0.wp.com/eestinen.fi/wp-content/uploads/2017/04/haug.jpg?fit=1024%2C628&ssl=1",
                    "https://media.rmk.ee/photos/haug1_block.jpg",
                    "https://kalafoorum.ee/portaal/wp-content/uploads/2023/03/haugi-hooaeg.jpg"
                }

            },
              new()
            {
                Name = "Latikas",
                HeroImage = "Latikas.png",
                Description = "Keha kõrge, tunduvalt lamenenud. Noored isendid suhteliselt madalama kehaga.+" +
                  " Soomused seljauime juures palju väiksemad kui küljejoone lähedal. Silma läbimõõt ninamiku pikkusest väiksem.+" +
                  " Suu poolalaseisune, väljasopistatav, neeluhambad ühes reas.Selg rohekaspruunist mustjassiniseni, küljed noortel +" +
                  "hõbedased, vanemail valkjashallid, kõht valkjas. Kõik uimed hallikad (mitte punakad). Kudemisajal isastel peas, kehal,+" +
                  " vahel ka uimedel üsna tugev helmeskate.Latika värvus muutub sõltuvalt  kala vanusest, põhja ja vee värvusest.+" +
                  " Vanad latikad muutuvad tumedaks ja kullakarvaliseks; turbajärvedes on nad punakaspruunid.",
                Habitat = "Eestis eelistab latikas suuremaid madalavõitu veega eutroofseid kuni hüpertroofseid järvi, väldib düstroofseid+" +
                  " metsa- ja soojärvi. Põlgab tihedat taimestikku. Jõgedest on talle meelepärasemad need, kus veevool aeglane ja põhi mudane.+" +
                  "Latikas on põhja hoiduv parvekala. Noored viibivad rohkem litoraalis, vanemad lähevad ka kaldast kaugemale.Talvitub sügavamates kohtades.",
                Diet = "Zooplankton on põhitoiduks üsna kaua aega, siis see asendub järk-järgult põhjaloomastikuga. Lemmiktoiduks suured surusääskede vastsed, +" +
                  " keda on väljasopistatava suutoru abil mugav põhjamudast välja imeda. Kohati on toiduna tähtsad ka limused (seda eriti suuremail latikail),+'" +
                  " sobival juhul langevad saagiks ka kalade marjaterad, vastsed ja isegi maimud. Kudejad peavad pulmapeo ajal paastu, nooremad mitte. Toitumine on+" +
                  " kõige intensiivsem kesksuvel, talveks see vaibub tugevasti.",
                Season = "\r\nKõige paremini saab latikat kätte kevadel kudemisrände ajal, ent siis on ta püük varude kaitse eesmärgil tugevasti piiratud.+" +
                  "Teine püügihooaeg on sügisel pärast suvist nuumaaega, mil latikas koondub suurtesse parvedesse.+" +
                  "Töönduslik püük toimub põhiliselt mõrdade ja nakkevõrkudega, harrastuspüük õngega ja (peamiselt talvel) kirplandiga.",
                AccentColorStart = Color.FromArgb("#2E8A8F"),
                AccentColorEnd = Color.FromArgb("#d5d5d5"),
                Images = new()
                {
                    "https://i0.wp.com/eestinen.fi/wp-content/uploads/2017/04/haug.jpg?fit=1024%2C628&ssl=1",
                    "https://media.rmk.ee/photos/haug1_block.jpg",
                    "https://kalafoorum.ee/portaal/wp-content/uploads/2023/03/haugi-hooaeg.jpg"
                }

            },
        
            new()
            {
                Name = "Ahven",
                HeroImage = "ahven.png",
                Description ="Ahven on ilus ja ereda värvusega kala. Tema selg on tumeroheline, küljed rohekaskollased,+" +
                    " 5–9 tumeda ristvöödiga. Saba- ja pärakuuim ning kõhuuimed on erepunased, rinnauimed kollased.+" +
                    " Eesmine seljauim on sinakashall, suure musta laiguga tagaosas, tagumine seljauim rohekaskollane.+" +
                    " Silmad on oranžid. Ahvena värvus oleneb ka elukohast, näiteks turbajärvedes on ta täiesti tume." ,
                Habitat = "Ahven on levinud peaaegu kogu Euraasias, Eestis väga laialdase levikuga. Elab enamuses Eesti järvedes,+" +
                    " jõgedes, tiikides, lahtedes ja riimvees. Kuna ahven talub väga hästi happelist vett, siis võib ta elutseda ka+" +
                    " rabajärvedes ja turbaaukudes. ",
                Diet = "Esimesel ja osalt teiselgi eluaastal toiduks zooplankton. Röövtoidule üleminek harilikult teisel-kolmandal eluaastal+" +
                    " (L 10-15 cm). Saakkalu võib püüda nii varitsedes (üksikult tegutsedes) kui jälitades. Sisevetes on peamised saakkalad+" +
                    " väiksemad ahvenad ise, kiisk ja särg, suurjärvedes ka tint, rannikumeres lisaks veel räimemaimud, ogalik, luukarits, mudilad +" +
                    "ja teised arvukamad ning kergemini kättesaadavad kalad. Meie kaladest on ahven kahtlemata suurim kannibal, liigikaaslased on sageli põhitoiduks.+" +
                    " Saakkalad enamasti 5-8 cm pikkused (L). Väiksem ahven (L kuni 13-15 cm) võib olla ka marjasöödik, ehkki hoopis vähemal määral kui kiisk.+" +
                    "Toitub aasta läbi, kõige agaramalt suvel, talvel üsna loiult.",
                Season = "Ahvenat tohib eestis koguaeg püüda, tavaliselt kasutatakse püügivahendiks ujukit või spinningut.",
                AccentColorStart = Color.FromArgb("#2E8A8F"),
                AccentColorEnd = Color.FromArgb("#d5d5d5"),
                Images = new()
                {
                    "https://assets.apu.fi/vqd9tl2q3uk2/33339-ahven/9d302664d9e933281d5584ae33b93912/ahven_1OVi3.jpg?w=2048&q=75&fit=crop-center",
                    "https://upload.wikimedia.org/wikipedia/commons/8/81/Hal_-_Perca_fluviatilis_-_1.jpg",
                    "https://images.ctfassets.net/0yf82hjfqumz/2RO24FqOF3hb15REJfmfLu/cecc568215e6f0b34fbcf59f621f4d39/Ahven_kolumniin_16_9.jpg?fit=thumb&h=1600&q=60&w=1600"
                }
            },

            new()
            {
                Name = "Hõbekoger",
                HeroImage = "h6bekoger.png",
                Description ="Hõbekogre kehakuju varieerub sõltuvalt elupaigast väga suurtes piirides, kuid enamasti on ta madalama kehaga kui koger. " +
                    "Tavaliselt külgedelt tugevalt lamendunud ja näeb seetõttu välja suhteliselt saledana. Neil ei esine kokredele omast „küürakust“ " +
                    "ning keha pikkus-kõrgussuhe jääb enamasti 1/3 ja 1/2 vahele. Värvus varieerub suhteliselt laias ulatuses. Enamasti hõbehallikates " +
                    "toonides kalade seljad võivad olla värvunud kuni rohekashalli toonini. Saba- ja seljauimed on ülejäänud uimedest oluliselt tumedamalt. " +
                    "Selja- ja pärakuuime eesosas 10-16 hambaga pikk ja tugev ogakiir, mille eesmine serv on selgelt jämesaagjas. Seljauime välisserv " +
                    "nõgus või sirge, sabauime väljalõige üsna suur. Soomused suured, karedavõitu. Suu on otseseisune ja poiseid puuduvad. " +
                    "Eristamistunnuseks on ka see, et hõbekogre soomuste tagaserv on kaarjas, mitte sirge nagu harilikul kogrel. " +
                    "Eristada kogrest aitab ka see, et hõbekogrel on tugevalt pigmenteerunud (tume kuni mustjas) kõhukelme. " +
                    "Samuti on hõbekogre sool väga pikk ning see ületab tema keha pikkuse kuni viis korda.",
                Habitat =
                    "Eestisse (Tallinna lähedale tiikidesse, Maardu ja Kahala järvedesse Harjumaal) toodi aastail 1948-1949. Neis järvedes kodunes " +
                    "(hakkas kudema), hiljem tehti palju (valdavalt edutuid) asustamiskatseid mujale. Praegu annab järelkasvu kümmekonnas Eesti mandriosa " +
                    "järves (peale eelmainitute veel Võrtsjärves, Mehikoorma Umbjärves Tartumaal, Ruusmäe järves Võrumaal jm.), neis kõigis elab ka koger. " +
                    "Hõbekokre leidub ka mõnes meie suuremas jões, samuti rannikumeres, eeskätt Liivi lahes. Osades väiksemates merelahtedes (Jausa, " +
                    "Haapsalu-Tagalaht, Saunja laht jt) on muutunud hõbekoger üheks domineerivaks kalaliigiks, kes oma suureneva arvukusega mõjutab oluliselt kohaliku elustikku.",
                Diet ="On kogrest märksa suurem planktonitarbija. Põhitoiduks enamasti siiski põhjaloomastik. Vahel sööb ka taimtoitu ja detriiti.",
                Season ="Piiratud leviku ja väikese arvukuse tõttu Eestis töönduslikult ebaoluline."+
                        "Spordikalana üsna hinnatud.Liha keskmise kvaliteediga, ei jää kogre omale alla."+
                        "Loodusest püütakse hõbekokre maailmas vaid vähesel määral, küll aga viljeldakse teda üsna rohkelt kalakasvatustes, peamiselt Hiinas,+" +
                        "kuid toodetavad kogused on pandud kokku hariliku kogre kasvatamise andmetega." ,
                AccentColorStart = Color.FromArgb("#2E8A8F"),
                AccentColorEnd = Color.FromArgb("#d5d5d5"),
                Images = new()
                {
                    "https://www.naturephoto-cz.com/photos/others/hobekoger-80021.jpg",
                    "https://www.naturephoto-cz.com/photos/others/hobekoger-20522.jpg",
                    "https://www.naturephoto-cz.com/photos/sevcik/hobekoger--96x_karas_stribrity.jpg"
                }
            }
        };

        public static List<Fish> GetFeaturedFishes()
        {
            var random = new Random();
            var randomizedFishes = fishes.OrderBy(item => random.Next());

            return randomizedFishes.Take(2).ToList();
        }

        public static List<Fish> GetAllFishes()
            => fishes;
    }
}
