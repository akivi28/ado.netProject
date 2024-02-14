
INSERT INTO Countries (Name)
VALUES
    ('Germany'),
    ('Spain'),
    ('France'),
    ('Italy'),
    ('Portugal');


INSERT INTO Teams (Name, WinCount, LostCount, DrawCount, City, ScoreGoals, LostGoals)
VALUES
    ('Team Germany', 2, 1, 1, 'Berlin', 5, 3),
    ('Team Spain', 3, 0, 1, 'Madrid', 8, 1),
    ('Team France', 2, 1, 2, 'Paris', 7, 4),
    ('Team Italy', 3, 0, 1, 'Rome', 9, 2),
    ('Team Portugal', 1, 2, 1, 'Lisbon', 4, 5);


INSERT INTO Players (FullName, Number, Position, CountryId, TeamId)
VALUES
    ('Player 1', 10, 'Forward', 1, 1),
    ('Player 2', 7, 'Midfielder', 1, 1),
    ('Player 3', 5, 'Defender', 2, 2),
    ('Player 4', 8, 'Forward', 2, 2),
    ('Player 5', 6, 'Midfielder', 3, 3),
    ('Player 6', 9, 'Defender', 3, 3),
    ('Player 7', 11, 'Forward', 4, 4),
    ('Player 8', 7, 'Midfielder', 4, 4),
    ('Player 9', 5, 'Defender', 5, 5),
    ('Player 10', 8, 'Forward', 5, 5);


INSERT INTO Games (GameDate, HomeTeamId, AwayTeamId, GoalsHomeTeam, GoalsAwayTeam)
VALUES
    ('2023-09-01 18:00:00', 1, 2, 2, 1),
    ('2023-09-01 20:00:00', 3, 4, 1, 2),
    ('2023-09-01 22:00:00', 5, 1, 3, 2),
    ('2023-09-03 15:30:00', 2, 3, 1, 1),
    ('2023-09-03 16:30:00', 4, 5, 0, 1),
    ('2023-09-03 18:30:00', 1, 2, 2, 2),
    ('2023-09-05 19:45:00', 3, 4, 1, 2),
    ('2023-09-05 20:45:00', 5, 1, 2, 2),
    ('2023-09-05 21:45:00', 2, 3, 2, 3),
    ('2023-09-07 20:15:00', 4, 5, 3, 1),
    ('2023-09-07 21:15:00', 1, 2, 1, 1),
    ('2023-09-07 22:15:00', 3, 4, 2, 2);


INSERT INTO Goals (GameId, PlayerId)
VALUES
    (1, 1),
    (1, 2),
    (2, 3),
    (2, 4),
    (3, 5),
    (3, 6),
    (4, 7),
    (4, 8),
    (5, 9),
    (5, 10),
    (6, 1),
    (6, 2),
    (7, 3),
    (7, 4),
    (8, 5),
    (8, 6),
    (9, 7),
    (9, 8),
    (10, 9),
    (10, 10),
    (11, 1),
    (11, 2),
    (12, 3),
    (12, 4);
