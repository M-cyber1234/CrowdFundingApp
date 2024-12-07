use CrowfundingDB;

INSERT INTO Users VALUES
('Alice', 'alice@example.com', 'hashed_password_1', '2023-01-01', '2024-01-01'),
('Bob', 'bob@example.com', 'hashed_password_2', '2023-02-01', '2024-01-01'),
('Charlie', 'charlie@example.com', 'hashed_password_3', '2023-03-01', '2025-01-01');

INSERT INTO Categories (Name, Description) VALUES
('Technologie', 'Projets liés à la technologie et à l''innovation'),
('Art', 'Projets artistiques et créatifs'),
('Éducation', 'Projets éducatifs et pédagogiques'),
('Santé', 'Projets liés à la santé et au bien-être'),
('Environnement', 'Projets environnementaux et écologiques');


INSERT INTO Projects (Title, Description, GoalAmount, CurrentAmount, StartDate, EndDate, UserId, CategoryId) VALUES
('Projet Tech 1', 'Description du projet tech 1', 10000, 0, '2023-04-01', '2023-05-01', 2, 2),
('Projet Art 1', 'Description du projet art 1', 5000, 0, '2023-04-02', '2023-05-02', 3, 3),
('Projet Éducation 1', 'Description du projet éducation 1', 8000, 0, '2023-04-03', '2023-05-03', 4, 4);

INSERT INTO Rewards (Description, MinimumContribution, ProjectId) VALUES
('Récompense de base', 10, 2),
('Récompense premium', 50, 2),
('Récompense spéciale', 100, 2),
('Récompense de base', 20, 3),
('Récompense premium', 100, 3),
('Récompense de base', 30, 4),
('Récompense premium', 70, 4);

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
('Technologie', 'Projets liés à la technologie et à l''innovation'),
('Art', 'Projets artistiques et créatifs'),
('Éducation', 'Projets éducatifs et pédagogiques'),
('Santé', 'Projets liés à la santé et au bien-être'),
('Environnement', 'Projets environnementaux et écologiques');


SELECT * FROM Users;
SELECT * FROM Categories;
SELECT * FROM Projects;
SELECT * FROM Rewards;
SELECT * FROM Contributions;
SELECT * FROM UserRewards;
