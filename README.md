# Added README file to the project
- Documented the project structure, setup, and usage instructions

# Added 2 Models: User and Ticket
- Created models to represent 'User' and 'Ticket' entities
- Integrated these models into the application context

# Implemented Required Classes and Behaviors
- Designed the necessary properties and behaviors for each model
- Added ApplicationDbContext for handling database interactions

# Implemented Generic Repository for Ticket Entity
- Created a reusable Generic Repository pattern
- Handles CRUD operations for Ticket and potentially other entities

# Added CRUD operations in the TicketsController
- Implemented endpoints for Ticket management:
  - GET: Retrieve a specific ticket
  - POST: Add a new ticket
  - PUT: Update an existing ticket
  - DELETE: Remove a ticket
  - GET: Retrieve a list of all tickets

# Improved Separation of Concerns
- Refactored to use the repository pattern for better code structure and reusability


# using my sql over Docker 
![the](https://github.com/user-attachments/assets/7c9b362a-b13b-4c85-aa87-140c1c17be1d) 
-Configure connection string 
![conf](https://github.com/user-attachments/assets/c44624b9-f4a3-4cf0-b3dd-ff861449e209)
- using this command to create Mysql at docker
  # docker run --name "----" -e MYSQL_ROOT_PASSWORD=Root1234 -d mysql:tag
 

