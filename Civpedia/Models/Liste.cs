using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civpedia.Models
{
    public class Liste
    {
        static void methode()
        {
            List<Dirigeants> civilisations = new List<Dirigeants>();
            civilisations.Add(new Dirigeants() { 
                Id = 1, 
                NomDirigeant = "Alexandre", 
                TitrePassifDirigeant = "Jusqu'au Bout Du Monde", 
                PassifDirigeant = "Les victoires militaires génèrent une quantité de Science égale à 25% de la Puissance de combat de l'unité vaincue (en vitesse en ligne). Les villes ne génèrent pas d'usure de guerre. Toutes les unités militaires sont entièrement soignées si le joueur capture une ville dotée d'une merveille mondiale.", 
                NomEmpire = "Macédoine", 
                TitrePassifEmpire = "Fusion Helléniste", 
                PassifEmpire = "Vous recevez une amélioration pour chaque ville capturée : Production + 20% dans toutes vos villes pendant 10 tours, un Euréka ! pour chaque campement ou campus de la ville conquise, et une Inspiration pour chaque lieu saint ou place du théâtre.", 
                UnitesEmpire = new List<UniteEmpire>() { 
                    new UniteEmpire() {
                        Id=1, 
                        NomUnite="Hypaspiste", 
                        AtkUnite=38, 
                        TexteUnite="Exclusive à la Macédoine, cette unité de combat rapproché remplace le spadassin. Puissance de combat +10 en cas de siège d'un quartier. Bonus de soutien +50 %." 
                    } ,
                    new UniteEmpire() {
                        Id=2,
                        NomUnite="Hétairoi",
                        AtkUnite=36,
                        TexteUnite="Unité de cavalerie lourde exclusive à la Macédoine. Puissance de combat +5 si adjacent à un général illustre. Points de général illustre +5 pour chaque ennemi tué, et commence avec une promotion gratuite." 
                    }
                },
                NomBatimentEmpire = "Basilikoi Paides",
                BatimentEmpire = "Batiment exclusif à la Macédoine. Expérience au combat +25% pour toutes les unités de combat rapproché, d'attaque à distance terrestres et Hétairoi formés dans cette ville. Bonus de science égal à 25% du coût de l'unité lorsqu'une unité non civile est formée dans une ville. Réserve de ressources stratégiques +10 (en vitesse normale). Construction impossible dans un campement possédant déjà une écurie."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 2,
                NomDirigeant = "Aliénor d'Aquitaine (Angleterre)",
                TitrePassifDirigeant = "Cour d'Amour",
                PassifDirigeant = "Production +100% pour les bâtiments de la Place du Théâtre. Loyauté -1 par tour dans les villes étrangères pour chaque chef-d'oeuvre présent dans l'une des villes d'Aliénor, dans un rayon de 9 cases. Une ville qui quitte une autre civilisation suite à une perte de loyauté et dont la majeure partie de la loyauté provient de la civilisation d'Aliénor rejoint directement celle-ci sans passer par le statut de ville libre.",
                NomEmpire = "Angleterre",
                TitrePassifEmpire = "Atelier Mondial",
                PassifEmpire = "Ressources des mines de charbon et de fer +2 par tour. Production +100% pour les ingénieurs militaires. Charges +2 pour les ingénieurs militaires. Rendement +4 pour les bâtiments qui octroient des ressources supplémentaires lorsqu'ils sont alimentés en électricité. Production +20% pour les bâtiments des zones industrielles. Stocks de ressources stratégiques +10 en vitesse normale grâce aux bâtiments des ports.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Chien De Mer",
                        AtkUnite=55,
                        TexteUnite="Exclusive à l'Angleterre et remplaçant le corsaire, cette unité navale de la Renaissance peut capturer les navires ennemis. Ne peut être vu que par d'autres unités navales de combat rapproché à moins de lui être adjacent. Dévoile les unités d'assaut en mer dans le champ de vision."
                    }
                },
                NomQuartierEmpire = "Port Militaire De La Royal Navy",
                QuartierEmpire = "Quartier exclusif à l'Angleterre remplaçant le port, destiné à accueillir les activités navales de votre ville. Annule la pénalité de mouvement cas d'embarquement ou de débarquement depuis cette case. Doit être construit sur une côté ou un lac adjacent à la terre ferme. PM +1 pour toutes les unités navales issues du port militaire. Or +2 et loyauté +4 par tour en cas de construction sur un continent étranger. Ne peut pas être construit sur un récif. +1 point d'Amiral illustre par tour pour les Phares."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 3,
                NomDirigeant = "Aliénor d'Aquitaine (France)",
                TitrePassifDirigeant = "Cour d'Amour",
                PassifDirigeant = "Production +100% pour les bâtiments de la Place du Théâtre. Loyauté -1 par tour dans les villes étrangères pour chaque chef-d'oeuvre présent dans l'une des villes d'Aliénor, dans un rayon de 9 cases. Une ville qui quitte une autre civilisation suite à une perte de loyauté et dont la majeure partie de la loyauté provient de la civilisation d'Aliénor rejoint directement celle-ci sans passer par le statut de ville libre.",
                NomEmpire = "France",
                TitrePassifEmpire = "Grande Tournée",
                PassifEmpire = "Reçoit un espion gratuit (et la possibilité d'en accueillir plus) quand les Châteaux sont découverts. Tous les espions commencent agents, avec une promotion gratuite. Production +20% pour la construction de merveilles du Moyen-âge, de la Renaissance et de l'ère industrielle. Tourisme +50% pour toutes les merveilles, quelle que soit l'ère.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Garde Impérial",
                        AtkUnite=70,
                        TexteUnite="Exclusive à la France, cette unité de combat rapproché de l'ère industrielle remplaçant l'infanterie de ligne voit sa puissance de combat augmenter de 5 points sur le continent de sa capitale et génère des points de général illustre à chaque ennemi tué."
                    }
                },
                NomAmenagementEmpire = "Castel",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un castel, exclusif à la France. Habitations +1. Attrait +1. Culture +2 et Or +1. Culture +1 pour chaque Merveille adjacnete, porté à +2 à Aviation. Nourriture +1 pour chaque ressource de luxe adjacente. Doit être placé sur une case adjacente à une ressource bonus ou une ressource de luxe. Construction impossible sur une case adjacente à un autre castel. Octroie du tourisme une fois l'aviation recherchée."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 4,
                NomDirigeant = "Amanitoré",
                TitrePassifDirigeant = "Candace De Méroé",
                PassifDirigeant = "Production +20% pour tous les quartiers, +40% si une pyramide nubienne est adjacente au centre-ville.",
                NomEmpire = "Nubie",
                TitrePassifEmpire = "Ta-seti",
                PassifEmpire = "Expérience +30% pour les unités d'attaque à distance. Les mines construites sur des ressources stratégiques fournissent +1 unité de production, et celles sur des ressources bonus et de luxe +2 unités d'or.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Archer Pitati",
                        AtkUnite=30,
                        TexteUnite="Exclusive à la Nubie et plus puissante que l'archer, qu'elle remplace, cette unité de l'Antiquité profite d'un déplacement supplémentaire. Amélioration: arbalétrier."
                    }
                },
                NomAmenagementEmpire = "Pyramide Nubienne",
                AmenagementEmpire = "Aménagement antique constructible dans une plaine plate, une prairie plate, une plaine inondable ou un désert. Nourriture +1 et Foi +2. Les quartiers adjacents octroient des rendements bonus: Nourriture +2 si adjacente à un centre-ville. Science +2 par Campus adjacent. Production +2 par Zone industrielle adjacente. Culture +2 par Place du Théâtre adjacente. Foi +2 par Lieu Saint adjacent. Or +2 par Plateforme Commerciale ou Port adjacent. Deux pyramides ne peuvent pas être adjacentes."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 5,
                NomDirigeant = "Ambiorix",
                TitrePassifDirigeant = "Roi Des Eburons",
                PassifDirigeant = "Puissance de combat +1 pour les unités de combat rapproché et anti-cavalerie pour chaque unité adjacente.",
                NomEmpire = "Gaule",
                TitrePassifEmpire = "Culture De Hallstatt",
                PassifEmpire = "Culture +1 pour les mines une fois le Travail du Bronze découvert, qui offrent un bonus de proximité mineur à tous les quartiers et une bombe culturelle sur les territoires non possédés. Les quartiers spécialisés ne reçoivent pas de bonus de proximité mineur à côté d'un autre quartier et ces quartiers ne peuvent pas être adjacents au centre-ville.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Gésates",
                        AtkUnite=20,
                        TexteUnite="Unité gauloise de l'Antiquité qui remplace le guerrier, pour un coût plus élevé. Puissance de combat +10 contre les unités ayant une puissance de combat de base plus élevée. Puissance de combat +5 contre les défenses de quartier."
                    }
                },
                NomQuartierEmpire = "Oppidum",
                QuartierEmpire = "Quartier exclusif aux Gaulois remplaçant la zone industrielle à moindre coût et plus tôt dans la partie. Le quartier de l'oppidum peut être défendu par des attaques à distance. Bonus de proximité: production +2 s'il est adjacent à une carrière ou une ressource stratégique."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 6,
                NomDirigeant = "Ba Trieu",
                TitrePassifDirigeant = "Expulsion Des Agresseurs",
                PassifDirigeant = "Puissance de combat +2 pour les unités combattant dans les forêts tropicales, les marais et les bois. +1PM si elles commencent le tour dans une forêt tropicale, des marais ou des bois. Ces bonus sont doublés si la case se trouve dans votre territoire.",
                NomEmpire = "Vietnam",
                TitrePassifEmpire = "Delta Du Fleuve Des Neuf Dragons",
                PassifEmpire = "Tous les quartiers spécialisés terrestres ne peuvent être construits que dans les forêts tropicales, les marais ou les bois. Bonus pour chaque bâtiment construit sur ces terrains: Culture +1 dans les bois, science +1 dans les forêts tropicales et production +1 dans les marais. Le dogme des foires médiévales permet de planter des bois.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Voi Chien",
                        AtkUnite=35,
                        TexteUnite="Unité d'attaque à distance du Moyen-âge exclusive au Vietnam qui remplace l'arbalétrier. Elle peut se déplacer après avoir attaqué et dispose de PM supplémentaires. Elle est également plus puissante en défense et possède un meilleure champ de vision, mais elle est plus coûteuse."
                    }
                },
                NomQuartierEmpire = "Thành",
                QuartierEmpire = "Quartier exclusif au Vietnam remplaçant le campement à moindre coût. Culture +2 pour chaque quartier adjacent. Une fois l'aviation découverte, fournit autant de tourisme que de culture. Ce quartier n'est pas spécialisé, ne nécessite pas d'habitations, ne peut pas être construit sur une case adjacente au centre-ville, et ne génère pas de points de personnages illustres. Déclenche une bombe culturelle, capturant les cases neutres adjacentes."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 7,
                NomDirigeant = "Basile II",
                TitrePassifDirigeant = "Porphyrogénnêtos",
                PassifDirigeant = "Les unités de cavalerie lourdes et légères font 100% de dégâts aux villes pratiquant la même religion que Byzance. Le tagma, unité exclusive, est débloqué à la découverte du droit divin.",
                NomEmpire = "Byzance",
                TitrePassifEmpire = "Taxis",
                PassifEmpire = "Puissance de combat ou puissance religieuse +2 pour les unités pour chaque ville sainte convertie à la religion byzantine (y compris la ville sainte de Byzance). La religion de Byzance se propage aux villes voisines lorsque l'unité d'une civilisation ou d'une cité-état ennemie est vaincue. Points de prophète illustre +1 pour les villes possédant un lieu saint.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Dromon",
                        AtkUnite=20,
                        TexteUnite="Unité de l'ère classique exclusive aux Byzantins qui remplace la quadrirème et a une plus grande portée. Puissance de combat +10 contre les unités."
                    },
                    new UniteEmpire() {
                        Id=2,
                        NomUnite="Tagma",
                        AtkUnite=50,
                        TexteUnite="Unité du Moyen-âge exclusive à Basile II qui remplace le chevalier. Puissance de combat ou religieuse +2 pour les unités terrestres dans un rayon d'une case."
                    }
                },
                NomQuartierEmpire = "Hippodrome",
                QuartierEmpire = "Quartier exclusif à Byzance, remplaçant le complexe de loisirs à moindre coût. Activités +3. Octroie une unité de cavalerie lourde pour sa construction et celle de ses bâtiments. L'entretien des unités gagnées grâce à ce quartier est gratuit. La ville ne doit pas posséder de parc aquatique."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 8,
                NomDirigeant = "Catherine de Médicis (Reine Noire)",
                TitrePassifDirigeant = "Escadron Volant De Catherine",
                PassifDirigeant = "Une fois la Philosophie politique atteinte, dispose d'un niveau de visibilité diplomatique de plus que la normale avec chaque civilisation rencontrée.",
                NomEmpire = "France",
                TitrePassifEmpire = "Grande Tournée",
                PassifEmpire = "Reçoit un espion gratuit (et la possibilité d'en accueillir plus) quand les Châteaux sont découverts. Tous les espions commencent agents, avec une promotion gratuite. Production +20% pour la construction de merveilles du Moyen-âge, de la Renaissance et de l'ère industrielle. Tourisme +50% pour toutes les merveilles, quelle que soit l'ère.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Garde Impérial",
                        AtkUnite=70,
                        TexteUnite="Exclusive à la France, cette unité de combat rapproché de l'ère industrielle remplaçant l'infanterie de ligne voit sa puissance de combat augmenter de 5 points sur le continent de sa capitale et génère des points de général illustre à chaque ennemi tué."
                    }
                },
                NomAmenagementEmpire = "Castel",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un castel, exclusif à la France. Habitations +1. Attrait +1. Culture +2 et Or +1. Culture +1 pour chaque Merveille adjacnete, porté à +2 à Aviation. Nourriture +1 pour chaque ressource de luxe adjacente. Doit être placé sur une case adjacente à une ressource bonus ou une ressource de luxe. Construction impossible sur une case adjacente à un autre castel. Octroie du tourisme une fois l'aviation recherchée."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 9,
                NomDirigeant = "Catherine de Médicis (Splendeur)",
                TitrePassifDirigeant = "Magnificences De Catherine",
                PassifDirigeant = "Culture +2 pour les ressources de luxe aménagées adjacentes à une place du théâtre ou un castel. Peut lancer le projet \"fête de la cour\" dans une ville dotée d'une place du théâtre.",
                NomEmpire = "France",
                TitrePassifEmpire = "Grande Tournée",
                PassifEmpire = "Reçoit un espion gratuit (et la possibilité d'en accueillir plus) quand les Châteaux sont découverts. Tous les espions commencent agents, avec une promotion gratuite. Production +20% pour la construction de merveilles du Moyen-âge, de la Renaissance et de l'ère industrielle. Tourisme +50% pour toutes les merveilles, quelle que soit l'ère.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Garde Impérial",
                        AtkUnite=70,
                        TexteUnite="Exclusive à la France, cette unité de combat rapproché de l'ère industrielle remplaçant l'infanterie de ligne voit sa puissance de combat augmenter de 5 points sur le continent de sa capitale et génère des points de général illustre à chaque ennemi tué."
                    }
                },
                NomAmenagementEmpire = "Castel",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un castel, exclusif à la France. Habitations +1. Attrait +1. Culture +2 et Or +1. Culture +1 pour chaque Merveille adjacnete, porté à +2 à Aviation. Nourriture +1 pour chaque ressource de luxe adjacente. Doit être placé sur une case adjacente à une ressource bonus ou une ressource de luxe. Construction impossible sur une case adjacente à un autre castel. Octroie du tourisme une fois l'aviation recherchée."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 10,
                NomDirigeant = "Chaka",
                TitrePassifDirigeant = "Amabutho",
                PassifDirigeant = "Peut former des régiments à Mercenaires et des armées à Nationalisme. Puissance de combat de base +3 pour les régiments et les armées à Nationalisme, porté à +5 à Mobilisation.",
                NomEmpire = "Zoulous",
                TitrePassifEmpire = "Isibongo",
                PassifEmpire = "Les villes possédant une unité en garnison reçoivent 3 points de loyauté par tour, ou 5 points en cas de régiment ou d'armée. Pour transformer une unité en régiment ou en armée, envoyez-la conquérir une ville après avoir débloqué le dogme correspondant.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Impi",
                        AtkUnite=45,
                        TexteUnite="Exclusive au peuple zoulou, cette unité de l'ère médiévale remplace le piquier. Augmente le bonus de contournement. Unité peu coûteuse à produire et à entretenir. Gagne rapidement de l'EXP."
                    }
                },
                NomQuartierEmpire = "Ikanda",
                QuartierEmpire = "Quartier exclusif aux Zoulous remplaçant le campement. Habitations +1. Les bâtiments de l'Ikanda reçoivent Or +2 et Culture +1. Une fois les prérequis dogmatiques et technologiques atteints, les régiments et les armées peuvent être créés. Création plus rapide de régiments et d'armées."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 11,
                NomDirigeant = "Chandragupta",
                TitrePassifDirigeant = "Arthashâstra",
                PassifDirigeant = "Toutes les unités militaies terrestres et toutes les unités religieuses reçoivent +1 Mouvement.",
                NomEmpire = "Inde",
                TitrePassifEmpire = "Dharma",
                PassifEmpire = "Reçoit les bonus de croyance des fidèles de chaque religion dans la ville possédant au moins un fidèle. Les villes gagnent une activité pour chaque religion possédant au moins un fidèle. Charges de propagation +2 pour les missionnaires. Pression religieuse +100% sur vos routes commerciales.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Varu",
                        AtkUnite=40,
                        TexteUnite="Unité de cavalerie lourde de l'ère classique exclusive à l'Inde. Les unités ennemies adjacentes subissent -5 de puissance de combat."
                    }
                },
                NomAmenagementEmpire = "Puits à Degrés",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un puits à degrés, exclusif à l'Inde. Nourriture +1, foi +1 et habitations +1. Foi +1 si adjacent à un lieu saint. Nourriture +1 pour chaque ferme adjacente. Construction impossible sur une colline ou adjacent à un autre puits à degrés."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 12,
                NomDirigeant = "Christine de Suède",
                TitrePassifDirigeant = "Minerve Du Nord",
                PassifDirigeant = "Les bâtiments avec au moins trois emplacements de chef-d'oeuvre et les merveilles en disposant d'au moins deux ont automatiquement un thème lorsque tous leurs emplacements sont remplis. Peut construire la Bibliothèque de la reine sur la place de la gouvernance.",
                NomEmpire = "Suède",
                TitrePassifEmpire = "Prix Nobel",
                PassifEmpire = "La Suède gagne 25 faveurs diplomatiques lorsqu'elle obtient un personnage illustre (en vitesse en ligne). Les usines génèrent un point d'ingénieur illustre supplémentaire et les universités 1 point de savant illustre supplémentaire. Production +50% pour la construction des ateliers, usines, bibliothèques et universités. La présence de la Suède dans une partie ajoute trois compétitions exclusives au Congrès mondial à partir de l'ère industrielle. Production +50% pour les bâtiments de la place de la gouvernance.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Caroléen",
                        AtkUnite=55,
                        TexteUnite="Exclusive à la Suède, cette unité de la Renaissance est plus rapide que l'unité \"Pique et tir\", qu'elle remplace. Puissance de combat +3 pour chaque PM inutilisé."
                    }
                },
                NomAmenagementEmpire = "Musée En Plein Air",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un musée en plein air, exclusif à la Suède. Loyauté +2 par tour dans la ville. Culture et tourisme +2 pour chaque type de terrain (neige, toundra, désert, plaine ou prairie) sur lequel au moins une ville suédoise est construite. Limité à un par ville. Les cases contenant un musée en plein air ne peuvent pas être attribuées à une autre ville.",
                NomBatimentEmpire = "Bibliothèque De La Reine",
                BatimentEmpire = "Bâtiment exclusif à la Suède. Octroie 2 emplacements de chef-d'oeuvre littéraire, musical et artistique. Titres de gouverneur +1."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 13,
                NomDirigeant = "Cléopâtre",
                TitrePassifDirigeant = "Epouse De La Méditerranée",
                PassifDirigeant = "Les routes commerciales avec d'autres civilisations fournissent 4 Or à l'Egypte. Les routes commerciales d'autres civilisations avec l'Egypte fournissent 2 nourriture à celles-ci et 2 or à l'Egypte. Echanger avec des alliés génère deux fois plus de points d'alliance.",
                NomEmpire = "Egypte",
                TitrePassifEmpire = "Iteru",
                PassifEmpire = "Production +25% pour la construction de quartiers et de merveilles adjacents à une rivière. Ne subit aucun dégât d'inondation.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Archer Sur Char Maryannu",
                        AtkUnite=35,
                        TexteUnite="Exclusive à l'Egypte, cette unité d'attaque à distance de l'Antiquité dispose de 4 PM quand elle commence son tour en terrain dégagé."
                    }
                },
                NomAmenagementEmpire = "Sphinx",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un Sphinx, exclusif à l'Egypte. Foi +2, Culture +1 et Attrait +2. Foi +1 et Culture +1 si adjacent à une merveille. Nourriture +1 et Production +1 si construit sur un désert ou +1 Culture si construit sur des plaines inondables. Bonus de culture lorsque Service Diplomatique est découvert. Génère du tourisme après avoir recherché l'Aviation. Ne peut pas être construit à côté d'un autre Sphinx ou sur la Neige ou sur une colline enneigée."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 14,
                NomDirigeant = "Cyrus",
                TitrePassifDirigeant = "Chute De Babylone",
                PassifDirigeant = "+3 Puissance de combat en attaque pour toutes les unités militaires Perses. Loyauté +5 par tour dans les villes occupées possédant une unité en garnison. Déclarer une Guerre Surprise compte comme pour une Guerre Formelle dans le calcul des Griefs et du Bellicisme.",
                NomEmpire = "Perse",
                TitrePassifEmpire = "Satrapies",
                PassifEmpire = "Routes commerciales +1 avec la philosophie politique. Or +2 et culture +1 pour vos routes commerciales internes. Or +2 à Banque. Or +2 à Sciences économiques. Culture +2 à Foires Médiévales. Culture +2 à l'Urbanisation. Les routes construites sur votre territoire sont d'un niveau supérieur.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Immortel",
                        AtkUnite=35,
                        TexteUnite="Exclusive à la Perse, cette unité de combat rapproché remplace le spadassin. Pouvant également attaquer à distance, sa portée est de deux cases et elle possède une défense puissante."
                    }
                },
                NomAmenagementEmpire = "Pairidaeza",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un pairidaeza, exclusif à la Perse. Culture +1 et or +2. Attrait +1. Culture +1 pour chaque Lieu Saint, Campus et Place du Théâtre adjacent. Or +1 pour chaque Plateforme Commerciale, Port, Zone Industrielle et Centre-Ville adjacent. Culture et tourisme additionnels à mesure que vous progressez dans l'arbre des technologies et celui des dogmes. Construction impossible sur une case de neige, de toundra, de colline enneigée, ou de colline de toundra, ou adjacent à un autre pairidaeza."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 15,
                NomDirigeant = "Dame Six Cieux",
                TitrePassifDirigeant = "Ix Mutal Ahaw",
                PassifDirigeant = "Tous les rendements sont augmentés de 10% dans les villes situées dans un rayon de 6 cases autour de votre Capitale. Les autres villes voient tous leurs rendements diminués de 15%. Puissance de combat +3 pour les unités dans un rayon de 6 cases autour de la capitale.",
                NomEmpire = "Maya",
                TitrePassifEmpire = "Mayab",
                PassifEmpire = "L'installation à côté des cases d'eau douce et côtières n'octroie pas d'habitations supplémentaires, mais chaque ferme octroie habitations +1, production +1 pour chaque observatoire adjacent, et or +1. Activités +1 pour chaque ressource de luxe adjacente au centre-ville.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Hul-che",
                        AtkUnite=28,
                        TexteUnite="Unité de l'Antiquité exclusive aux Mayas remplaçant l'archer et dotée d'une puissante attaque à distance. Puissance de combat +5 contre les unités blessées."
                    }
                },
                NomQuartierEmpire = "Observatoire",
                QuartierEmpire = "Quartier exclusif aux Mayas pour leurs recherches scientifiques. Remplace le campus à moindre coût. Science +2 pour chaque plantation adjacente. Science +1 pour toutes les deux cases de fermes ou de quartiers adjacentes."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 16,
                NomDirigeant = "Didon",
                TitrePassifDirigeant = "Fondatrice De Carthage",
                PassifDirigeant = "Peut déplacer sa capitale d'origine vers une ville fondée par ses soins et disposant d'un cothon en menant à terme un projet exclusif de cette ville. Capacité des routes commerciales +1 pour la place de la gouvernance et chacun de ses bâtiments. Production +50% pour les quartiers de la ville disposant de la place de la gouvernance.",
                NomEmpire = "Phénicie",
                TitrePassifEmpire = "Colonies Méditerranéennes",
                PassifEmpire = "Commencez la partie avec un Eurêka pour l'écriture. Les villes cotières fondées par la Phénicie et situées sur le même continent que la capitale phénicienne sont loyales à 100%. PM +1 et champ de vision +2 pour les colons embarqués. Pas de coût de PM supplémentaire pour l'embarquement et le débarquement des colons.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Birème",
                        AtkUnite=35,
                        TexteUnite="Exclusive à la Phénicie, cette unité de l'Antiquité remplace la galère. Puissance de combat et PM augmentés. Les unités marchandes ne peuvent pas être pillées si elles se trouvent dans un rayon de 4 cases d'eau autour d'une birème."
                    }
                },
                NomQuartierEmpire = "Cothon",
                QuartierEmpire = "Exclusive à la Phénicie remplaçant le port à moindres coûts, destiné à accueillir les activités navales de votre ville. Doit être construit sur une case de côte ou de lac adjacente à une case terrestre. Production +25% pour chaque unité navale et colon dans cette ville."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 17,
                NomDirigeant = "Dyah Gitarja",
                TitrePassifDirigeant = "Déesse Exaltée Des Trois Mondes",
                PassifDirigeant = "Les unités navales peuvent être achetées contre de la foi. Les unités religieuses ne consomment pas de PM pour embarquer ou débarquer. Foi +2 pour les centres-villes adjacents à une côte ou un lac.",
                NomEmpire = "Indonésie",
                TitrePassifEmpire = "Grand Nusantara",
                PassifEmpire = "Les cases de côte et de lac octroient un petit bonus de proximité pour le lieu saint, le campus, la zone industrielle et la place du théâtre. Activités de loisirs +1 pour chaque complexe de loisirs adjacent à une côte ou un lac.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Jonque",
                        AtkUnite=45,
                        TexteUnite="Exclusive à l'Indonésie, cette unité navale médiévale remplace la frégate. Puissance de combat +5 pour les unités en formation, qui profitent de la vitesse de déplacement de leur escorte."
                    }
                },
                NomAmenagementEmpire = "Kampung",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un kampung, exclusif à l'Indonésie. Production +1 et habitations +1. Nourriture et Foi +1 pour chaque bateau de pêche adjacent. Production, habitations et tourisme bonus à mesure que vous progressez dans les arbres des technologies et des dogmes. Doit être placé sur une case de côte ou de lac adjacente à une ressource maritime."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 18,
                NomDirigeant = "Frédéric Barberousse",
                TitrePassifDirigeant = "Empereur Du Saint-empire",
                PassifDirigeant = "Emplacement de doctrine militaire supplémentaire. Puissance de combat +7 en cas d'attaque d'une cité-état.",
                NomEmpire = "Allemagne",
                TitrePassifEmpire = "Villes Libres De L'Empire",
                PassifEmpire = "Après le dogme des Guildes, chaque ville peut construire un quartier de plus, au-delà du seuil imposé par la population.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="U-Boot",
                        AtkUnite=65,
                        TexteUnite="Exclusive à l'Allemagne et remplaçant le sous-marin, cette unité navale de l'ère moderne est produite à moindre coût. Champ de vision +1 et puissance de combat +10 sur les cases d'océan. Peut révéler les autres unités furtives."
                    }
                },
                NomQuartierEmpire = "Hanse",
                QuartierEmpire = "Quartier exclusif à l'Allemagne remplaçant la zone industrielle à moindres coûts, destiné à accueillir les activités industrielles. Production +2 si adjacente à une plateforme commerciale, un aqueduc, un canal ou un barrage. Production +1 pour chaque ressource adjacente. Production +1 pour toutes les 2 cases de quartier adjacentes."
            });
            civilisations.Add(new Dirigeants()
            {
                Id = 19,
                NomDirigeant = "Gandhi",
                TitrePassifDirigeant = "Satyagraha",
                PassifDirigeant = "Octroit une croyance supplémentaire à la fondation d'une Religion. PM +1 pour les bâtisseurs et les colons. Foi +5 pour chaque civilisation rencontrée (y compris l'Inde) ayant fondé une religion et n'étant pas en guerre. L'usure de la guerre est doublée pour les civilisations qui combattent Gandhi.",
                NomEmpire = "Inde",
                TitrePassifEmpire = "Dharma",
                PassifEmpire = "Reçoit les bonus de croyance des fidèles de chaque religion dans la ville possédant au moins un fidèle. Les villes gagnent une activité pour chaque religion possédant au moins un fidèle. Charges de propagation +2 pour les missionnaires. Pression religieuse +100% sur vos routes commerciales.",
                UnitesEmpire = new List<UniteEmpire>() {
                    new UniteEmpire() {
                        Id=1,
                        NomUnite="Varu",
                        AtkUnite=40,
                        TexteUnite="Unité de cavalerie lourde de l'ère classique exclusive à l'Inde. Les unités ennemies adjacentes subissent -5 de puissance de combat."
                    }
                },
                NomAmenagementEmpire = "Puits à Degrés",
                AmenagementEmpire = "Débloque la compétence de bâtisseur permettant de construire un puits à degrés, exclusif à l'Inde. Nourriture +1, foi +1 et habitations +1. Foi +1 si adjacent à un lieu saint. Nourriture +1 pour chaque ferme adjacente. Construction impossible sur une colline ou adjacent à un autre puits à degrés."
            });
        }
        
    }
}
