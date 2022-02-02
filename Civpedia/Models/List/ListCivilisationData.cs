using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civpedia.Models
{
    public static class ListCivilisationData
    {
        public static List<Dirigeants> ListDirigeants = new List<Dirigeants>
        {
            new Dirigeants()
            {
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
                NomBatimentEmpire = "Aasilikoi Paides",
                BatimentEmpire = "Batiment exclusif à la Macédoine. Expérience au combat +25% pour toutes les unités de combat rapproché, d'attaque à distance terrestres et Hétairoi formés dans cette ville. Bonus de science égal à 25% du coût de l'unité lorsqu'une unité non civile est formée dans une ville. Réserve de ressources stratégiques +10 (en vitesse normale). Construction impossible dans un campement possédant déjà une écurie."
            },
            new Dirigeants()
            {
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
            },
            new Dirigeants()
            {
                Id = 2,
                NomDirigeant = "Aliénor d'Aquitaine",
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
            },
        new Dirigeants()
        {
            Id = 3,
                NomDirigeant = "Aliénor d'Aquitaine",
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
            },
        new Dirigeants()
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
            }


    };
    }
}
