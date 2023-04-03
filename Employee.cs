using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar2
{
    // Classe Employee avec les attributs ID et nom
    internal class Employee
    {
        // Identifiant de l'employé
        public int ID { get; set; }
        
        // Nom de l'employé
        public string Nom { get; set; }

        // Liste de rendez-vous de l'employé
        public List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();    
        
        // Méthode pour ajouter un rendez-vous
        public void AjouterRendezVous(RendezVous rendezVous)
        {
            RendezVous.Add(rendezVous);
        }

        // Méthode pour modifier un rendez-vous
        // Méthode pour modifier un rendez-vous
        // Méthode pour modifier un rendez-vous
        public void ModifierRendezVous(RendezVous rendezVous)
        {
            // Recherche du rendez-vous à modifier dans la liste des rendez-vous de l'employé
            foreach (RendezVous rv in RendezVous)
            {
                if (rv.ID == rendezVous.ID)
                {
                    // Mise à jour des informations du rendez-vous
                    rv.HeureDebut = rendezVous.HeureDebut;
                    rv.HeureFin = rendezVous.HeureFin;
                    rv.Jour = rendezVous.Jour;
                    break;
                }
            }
        }


        // Méthode pour supprimer un rendez-vous

        // Méthode pour supprimer un rendez-vous
        public void SupprimerRendezVous(int id)
        {
            // Recherche du rendez-vous à supprimer dans la liste des rendez-vous de l'employé
            for (int i = 0; i < RendezVous.Count; i++)
            {
                if (RendezVous[i].ID == id)
                {
                    // Suppression du rendez-vous de la liste
                    RendezVous.RemoveAt(i);
                    break;
                }
            }
        }


    }
}
