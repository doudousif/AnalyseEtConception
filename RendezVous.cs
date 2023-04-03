using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar2
{
    internal class RendezVous
    {
        // Classe RendezVous avec les attributs ID, HeureDebut, HeureFin et Jour

        // Identifiant du rendez-vous
        public int ID { get; set; }
        // Heure de début du rendez-vous
        public DateTime HeureDebut { get; set; }

        // Heure de fin du rendez-vous
        public DateTime HeureFin { get; set; }

        // Jour du rendez-vous
         public DateTime Jour { get; set; }


        // Liste des employés associés au rendez-vous
        public List<Employee> Employees { get; set; } = new List<Employee>();     // Méthode pour ajouter un employé associé au rendez-vous
        public void AjouterEmployee(Employee employee)
        {
            Employees.Add(employee);
        }     // Méthode pour obtenir la liste des employés associés au rendez-vous
        public List<Employee> ListeDesEmployees()
        {
            return Employees;
        }
    }
}

