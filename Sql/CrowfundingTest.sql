use CrowfundingDB;

INSERT INTO Users VALUES
('Alice', 'alice@example.com', 'hashed_password_1', '2023-01-01', '2024-01-01'),
('Bob', 'bob@example.com', 'hashed_password_2', '2023-02-01', '2024-01-01'),
('Charlie', 'charlie@example.com', 'hashed_password_3', '2023-03-01', '2025-01-01');

INSERT INTO Categories (Name, Description) VALUES
('Technologie', 'Projets li�s � la technologie et � l''innovation'),
('Art', 'Projets artistiques et cr�atifs'),
('�ducation', 'Projets �ducatifs et p�dagogiques'),
('Sant�', 'Projets li�s � la sant� et au bien-�tre'),
('Environnement', 'Projets environnementaux et �cologiques');


INSERT INTO Projects (Title, Description, GoalAmount, CurrentAmount, StartDate, EndDate, UserId, CategoryId) VALUES
('Projet Tech 1', 'Description du projet tech 1', 10000, 0, '2023-04-01', '2023-05-01', 2, 2),
('Projet Art 1', 'Description du projet art 1', 5000, 0, '2023-04-02', '2023-05-02', 3, 3),
('Projet �ducation 1', 'Description du projet �ducation 1', 8000, 0, '2023-04-03', '2023-05-03', 4, 4);

INSERT INTO Rewards (Description, MinimumContribution, ProjectId) VALUES
('R�compense de base', 10, 2),
('R�compense premium', 50, 2),
('R�compense sp�ciale', 100, 2),
('R�compense de base', 20, 3),
('R�compense premium', 100, 3),
('R�compense de base', 30, 4),
('R�compense premium', 70, 4);

INSERT INTO Contributions (Amount, ContributionDate, UserId, ProjectId) VALUES
(50, '2023-04-05', 2, 4),
(100, '2023-04-06', 3, 4),
(20, '2023-04-07', 4, 2),
(70, '2023-04-08', 2, 3);

INSERT INTO UserRewards (UserId, RewardId, DateAwarded) VALUES
(2, 1, '2023-04-05'),
(3, 2, '2023-04-06'),
(4, 4, '2023-04-07'),
(2, 6, '2023-04-08');

INSERT INTO Categories (Name, Description) VALUES
('Technologie', 'Projets li�s � la technologie et � l''innovation'),
('Art', 'Projets artistiques et cr�atifs'),
('�ducation', 'Projets �ducatifs et p�dagogiques'),
('Sant�', 'Projets li�s � la sant� et au bien-�tre'),
('Environnement', 'Projets environnementaux et �cologiques');


SELECT * FROM Users;
SELECT * FROM Categories;
SELECT * FROM Projects;
SELECT * FROM Rewards;
SELECT * FROM Contributions;
SELECT * FROM UserRewards;
