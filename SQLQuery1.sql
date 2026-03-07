CREATE TABLE [dbo].[Workouts] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [UserId] NVARCHAR (450) NOT NULL,
    [ActivityType] NVARCHAR (MAX) NOT NULL,
    [ExerciseName] NVARCHAR (MAX) NOT NULL,
    [Weight] FLOAT (53) NULL,
    [Sets] INT NULL,
    [Reps] INT NULL,
    [Distance] FLOAT (53) NULL,
    [DurationMinutes] INT NULL,
    [DateLogged] DATETIME2 (7) NOT NULL DEFAULT (getdate()),
    CONSTRAINT [PK_Workouts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[UserGoals] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [UserId] NVARCHAR (450) NOT NULL,
    [GoalName] NVARCHAR (MAX) NOT NULL,
    [TargetValue] FLOAT (53) NOT NULL,
    [TargetDate] DATETIME2 (7) NOT NULL,
    [IsCompleted] BIT NOT NULL DEFAULT (0),
    CONSTRAINT [PK_UserGoals] PRIMARY KEY CLUSTERED ([Id] ASC)
);