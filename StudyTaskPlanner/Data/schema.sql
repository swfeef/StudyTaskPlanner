CREATE TABLE IF NOT EXISTS tasks (
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    description TEXT,
    due_date TEXT,
    is_completed INTEGER NOT NULL DEFAULT 0
);
