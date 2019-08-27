# Pachi Maze API

WIP API for planned PachiMari maze game. Initially just a leaderboard (no sign in to play. Think arcade machines.)

DB Setup:
- in psql:
```
CREATE ROLE pachimaze WITH LOGIN;
CREATE DATABASE pachimaze WITH OWNER = pachimaze;
```
- in PMC:
```
Update-Database
```