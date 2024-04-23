using System.ComponentModel;

namespace ConceptionBar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Liquide[] liquide1 = new Liquide[10];
            liquide1[0] = new Liquide("coca", "soft");
            liquide1[1] = new Liquide("pepsi", "soft");
            liquide1[2] = new Liquide("fanta", "soft");
            liquide1[3] = new Liquide("sprite", "soft");
            liquide1[4] = new Liquide("cola", "soft");

            liquide1[5] = new Liquide("tequila", "alcool");
            liquide1[6] = new Liquide("gin", "alcool");
            liquide1[7] = new Liquide("liqueur", "alcool");
            liquide1[8] = new Liquide("absinthe", "alcool");
            liquide1[9] = new Liquide("saké", "alcool");

            List<Portion> portion1 = new List<Portion>();
            portion1[0] = new Portion(liquide1[0], 1);
            portion1[1] = new Portion(liquide1[1], 2);
            portion1[2] = new Portion(liquide1[2], 1);
            portion1[3] = new Portion(liquide1[3], 1);
            portion1[4] = new Portion(liquide1[4], 1);
            portion1[5] = new Portion(liquide1[5], 2);
            portion1[6] = new Portion(liquide1[6], 1);
            portion1[7] = new Portion(liquide1[7], 1);
            portion1[8] = new Portion(liquide1[8], 2);
            portion1[9] = new Portion(liquide1[9], 1);

            List<Cocktail> cocktails1 = new List<Cocktail>();

            List < Portion > Cocktail1 = new List<Portion>
            {
                new Portion(liquide1[9], 1),
                new Portion (liquide1[4], 2),
            };

            new Cocktail("Cocktail", Cocktail1);

            Recette recette1 = new Recette(Cocktail1);
            Cocktail[] cocktails = new Cocktail[5];
            cocktails[0] = new Cocktail("Jack", Recette.Ingredient[i].Contenu.Nom);
            cocktails[1] = new Cocktail("Gin + Fanta");
            cocktails[2] = new Cocktail("Liqueur + Pepsi");
            cocktails[3] = new Cocktail("Absinthe + Sprite");
            cocktails[4] = new Cocktail("Saké + Cola");
            Recette recette1 = new Recette(portion1);
            Shaker shaker1 = new Shaker(recette1);
            Cocktail cocktail1 = new Cocktail("Mojito", recette1, 1);
            string reset = "";
            Barman barman1 = new Barman("Theo");

            // Générer un index aléatoire
            Random rnd = new Random();
            int randomIndex = rnd.Next(liquide1.Length);

            // Récupérer le liquide aléatoire
            Liquide liquideAleatoire = liquide1[randomIndex];

            // Afficher le liquide aléatoire
            
            Console.WriteLine(barman1.commander());
                Console.WriteLine("Tapez : ");
                Console.WriteLine("1 : pour afficher les recettes des shakers");
                Console.WriteLine("2 : pour afficher les shakers");
                Console.WriteLine("3 : pour voir les quantités");
                Console.WriteLine("4 : Commander un cocktail");
                string reponse = Console.ReadLine();
            do
            {


                switch (reponse)
                {
                    case "1":
                        Console.WriteLine(recette1.AfficheRecetteDispo());
                        break;
                    case "2":
                       Console.WriteLine(shaker1.Melanger());
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        Console.WriteLine("Cocktails :");
                        foreach (Cocktail cocktail in cocktails)
                        {
                            Console.WriteLine(cocktail.DonnerLeCocktail());
                        }
                        break;
                }


            } while (reset == " ") ;
            }
        }
    }