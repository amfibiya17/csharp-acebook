Acebook clone
===

[![build](https://github.com/amfibiya17/csharp-acebook/actions/workflows/main_acebook-clone.yml/badge.svg)](https://github.com/amfibiya17/csharp-acebook/actions/workflows/main_acebook-clone.yml)

Link to the deployed application -->> [Acebook website](https://acebook-clone.azurewebsites.net/)

--- 


## What this project is about

The program:

- posts a post to Acebook
- shows all posts in reverse chronological order
- allows users to comment on the post
- shows all posts and comments with the author's name
- shows the time at which it was made
- allows users to sign up for Acebook
- allows users to log in to Acebook
- allows users to log out of Acebook
- deployed to Azure
- has a PGSQL database connected to Azure


---

## Examples of usage:

![screen1](https://i.postimg.cc/hP83Gbbq/Screenshot-2022-08-20-at-13-38-47.png)   

![screen2](https://i.postimg.cc/htpyLD5y/Screenshot-2022-08-20-at-13-38-54.png)  

![screen3](https://i.postimg.cc/dQbz3VbG/Screenshot-2022-08-20-at-13-36-08.png)    

![screen4](https://i.postimg.cc/q7DFTJch/Screenshot-2022-08-20-at-13-36-27.png)  

---

## If I'd had more time

This project was part of Makers' Accelerator program.   
I had 3 and a half days to work through the tickets.   
The main point of this week was to learn a new framework (.Net) and language (C#) using Razor and constantly deploying to Azure. 

If I'd had more time I would:

- Find out why nav bar doesn't change behavior dynamically as expected
- Implement likes for posts and comments
- Create functionality so that user can add photo to a post or a comment
- Implement profile page with user details
- Implement "friends" - so users can "friend" other users
- Style the pages

---

## Trello

![screen](https://i.postimg.cc/K89Qx53Y/Screenshot-2022-08-20-at-12-28-16.png)   

https://trello.com/b/NGuknyDE/acebook-c

---


## How to install the Program

- Clone this repository 

```
git clone https://github.com/amfibiya17/csharp-acebook.git
```

---


## How to run the program    

- Install the .NET Entity Framework CLI
```
dotnet tool install --global dotnet-ef
```
- Create the database/s in `psql`
```
CREATE DATABASE acebook
```
- Run the migration to create the tables
```
cd Acebook
dotnet ef database update
DATABASE_NAME=acebook dotnet ef database update
```
- Start the application, with the development database
```
DATABASE_NAME=acebook dotnet watch run
```
- Go to `http://localhost:5287/`  

---


## How to run the Tests

- Install Chromedriver
```
brew install chromedriver
```
- Start the application, with the default (test) database
```
dotnet watch run
```
- Open a second terminal session and run the tests
```
dotnet test
```
---