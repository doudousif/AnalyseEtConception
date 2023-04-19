Application Calendrier

Cette application permet de gérer les événements et les rendez-vous dans un calendrier. Elle a été développée avec WinForms et utilise SQL Server comme base de données. Elle nécessite Visual Studio pour être exécutée et la base de données doit être importée avant de l'utiliser.

Installation:

Clonez le repository sur votre ordinateur
Ouvrez le projet avec Visual Studio
Importez la base de données db_calendar.bacpac dans SQL Server
Compilez et exécutez l'application


Pour importer une base de données dans SQL Server, vous pouvez utiliser l'outil intégré de SQL Server Management Studio (SSMS) ou les commandes T-SQL.

Voici les étapes à suivre pour importer une base de données dans SQL Server à l'aide de SSMS :

Ouvrez SQL Server Management Studio et connectez-vous à l'instance de SQL Server.

Dans l'Explorateur d'objets, sélectionnez la base de données que vous souhaitez importer.

Cliquez avec le bouton droit de la souris sur la base de données et sélectionnez "Tâches" > "Importer des données".

Suivez les étapes de l'Assistant d'importation pour spécifier la source de données et la destination.

Sélectionnez les tables que vous souhaitez importer et définissez les options d'importation.

Exécutez l'importation en cliquant sur le bouton "Terminer".


