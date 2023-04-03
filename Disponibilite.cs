using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar2
{
    internal class Disponibilite
    {    /// <summary>
        /// Classe Disponibilite avec les attributs HeureDebut, HeureFin et Jour
        /// </summary>

        

        // Heure de début de la disponibilité
        public DateTime HeureDebut { get; set; }

        // Heure de fin de la disponibilité
        public DateTime HeureFin { get; set; }

        // Jour de la disponibilité
        public DateTime Jour { get; set; }

        // Liste des employés disponibles
        public List<Employee> Employees { get; set; } = new List<Employee>();     // Méthode pour obtenir la liste des employés disponibles
                                                                                  // Méthode pour obtenir la liste des employés disponibles
        public List<Employee> ListeDesEmployeesDisponibles()
        {
            // Liste des employés disponibles
            List<Employee> employesDisponibles = new List<Employee>();

            // Parcours de la liste de tous les employés
            foreach (Employee employee in Employees)
            {
                // Vérification de la disponibilité de l'employé pour la date et l'heure demandées
                bool disponible = true;
                foreach (RendezVous rdv in employee.RendezVous)
                {
                    if (rdv.Jour.Date == Jour.Date)
                    {
                        if (HeureDebut >= rdv.HeureDebut && HeureDebut < rdv.HeureFin ||
                            HeureFin > rdv.HeureDebut && HeureFin <= rdv.HeureFin ||
                            HeureDebut <= rdv.HeureDebut && HeureFin >= rdv.HeureFin)
                        {
                            // L'employé n'est pas disponible pour la plage horaire demandée
                            disponible = false;
                            break;
                        }
                    }
                }
                if (disponible)
                {
                    // Ajout de l'employé à la liste des employés disponibles
                    employesDisponibles.Add(employee);
                }
            }

            // Retour de la liste des employés disponibles
            return employesDisponibles;
        }

    }
}
