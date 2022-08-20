Acebook clone
===

Link to the deployed application -->> [Acebook website](https://acebook-clone.azurewebsites.net/)

---


## What is this project about
- This program posts a post to an Acebook
- This program allows to see all posts in reverse chronological order
- This program allows to comment on the post
- This program allows to see all posts and comments with user name
- This program allows to see the time at which it was made
- This program allows user to sign up for Acebook
- This program allows user to log in to Acebook
- This program allows user to log out of Acebook
- This program deployed to Azure
- This program has a database PGSQL connected to Azure


---

## Examples of usage:

![screen1]()  

![screen2]()  

![screen3]()    

![screen4]()  

![screen4]() 

---

## If I have more time
This project was part of Makers Accelerator program.   
I had 3.5 days to work through the tickets.   
The main point of this week was to learn new framework (.Net) and language (C#) using Razor and constantly deploying to Azure.  
If I have more time I would:
- Implement likes for posts and comments
- Create functionality so that user can add photo to a post or a comment
- Implement profile page wit user details
- Implement "friends" - so users can befriend other users
- Style the pages

---

## Trello

![screen](https://i.postimg.cc/K89Qx53Y/Screenshot-2022-08-20-at-12-28-16.png)   

https://trello.com/b/NGuknyDE/acebook-c

---


## How to install the program

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