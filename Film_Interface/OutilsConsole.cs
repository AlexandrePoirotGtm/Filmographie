using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Film_métier;
namespace Film_Interface
{
    public static class OutilsConsole
    {
        public static string PosezQuestion(string question)
        {
            Console.WriteLine(question);
            return (Console.ReadLine());
        }
        public static string PosezQuestionObligatoire(string question)
        {
            string laQuestion = PosezQuestion(question);
            while (string.IsNullOrWhiteSpace(laQuestion))
            {
                laQuestion = PosezQuestion(question);
            }
            return laQuestion;
        }
        public static int SaisirInt(string entier)
        {
            return int.Parse(PosezQuestion(entier));
        }
        public static double SaisirDouble(string dooble)
        {
            return double.Parse(PosezQuestion(dooble));
        }
        static bool Saisirbool(string bobol)
        {
            return bool.Parse(PosezQuestion(bobol));
        }
        public static DateTime SaisirDate(string date)
        {
            bool trying;
            DateTime datee = DateTime.Parse("25/04/1995");
            trying = DateTime.TryParse(PosezQuestion(date), out datee);
            return datee;
        }
        public static DateTime SaisirDateObligatoire(string date)
        {
            bool trying;
            DateTime datee = DateTime.Parse("25/04/1995");
            do
            {
                trying = DateTime.TryParse(PosezQuestion(date), out datee);
                Console.ForegroundColor = ConsoleColor.Red;
            } while (!trying);
            Console.ForegroundColor = ConsoleColor.Green;
            return datee;
        }
        static decimal SaisirDécimal(string entier)
        {
            return decimal.Parse(PosezQuestion("Veuillez saisir un décimal : "));
        }
        public static void Connexion(List<Client> lesClients)
        {
            string nom;
            string mdp;
            nom = PosezQuestionObligatoire("Nom : ");
            mdp = PosezQuestionObligatoire("Mot De Passe : ");
            
            foreach (Client client in lesClients)
            {
                if((client.Nom.ToLower() == nom.ToLower())&& (client.Mdp.ToLower() == mdp.ToLower()))
                {
                    Console.Clear();
                    AfficherMessage("Bienvenue " + client.Prenom, ConsoleColor.Magenta);
                    
                }
                else
                {
                    Console.Clear();
                    string choix;
                    AfficherMessage("Compte Inconnue\n\n1-Réessayer\n2-Inscription\n3-Quitter",ConsoleColor.DarkRed);
                    choix = Console.ReadLine();
                    switch (choix)
                    {
                        case "1":
                            
                            break;

                        case "2":
                            Inscription(lesClients);
                            return;
                            
                        default:

                            break;
                    }
                }
            }
        }
        public static void Inscription(List<Client> lesClients)
        {
            string nom;
            string prenom;
            string mdp;
            nom = PosezQuestionObligatoire("Nom : ");
            prenom = PosezQuestionObligatoire("Prenom : ");
            mdp = PosezQuestionObligatoire("Mot De Passe : ");
            Client leClient = new Client(prenom,nom,mdp);
            lesClients.Add(leClient);
        }
      
        public static void AfficherMenu()
        {

        }

        public static void AfficherLogger(List<Client> lesClients)
        {
            string choix;
            choix = PosezQuestionObligatoire("1-Connexion\n\n2-Inscription");
            Console.Clear();
            if(choix == "1")
            {
                Connexion(lesClients);
            }
            else if(choix == "2")
            {
                Inscription(lesClients);
            }
            else {}
        }
        public static void AfficherMessage(string message,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

