# Angular Address Book App

A user-friendly Angular application for managing and viewing a list of users. This app features real-time search functionality, allowing users to filter through the list as they type. Each user's details can be viewed by clicking on their profile. The application is built using Angular, TypeScript, HTML, CSS, and C#, providing a responsive design for a seamless user experience across devices.

## Photos

- ![image](https://github.com/AntonioIliev19/AddressBook/assets/114621404/4e7551ca-fcce-4c07-a49f-45a2fa902edc)
- **Filtering**
  ![image](https://github.com/AntonioIliev19/AddressBook/assets/114621404/f4552c13-510d-4017-9890-d63f848334bc)
- **Details**
  ![image](https://github.com/AntonioIliev19/AddressBook/assets/114621404/69e21c4c-360c-4974-8e24-f064a725f9af)
- **Iphone 14 Pro Max View**
  ![image](https://github.com/AntonioIliev19/AddressBook/assets/114621404/73b7d394-54a6-47b9-a18a-42aaf4b2178c)


## Features

- **User List:** Display a list of users with profile pictures and relevant information.
- **Real-Time Search:** Filter users instantly based on input in the search bar.
- **User Details:** View detailed information about each user.
- **Responsive Design:** Ensures a consistent experience on various devices.

## Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/AntonioIliev19/AddressBook.git

2. **Install dependencies:** 

   ```bash
   npm install

In the AddressBook.Server, open the Program.cs file and edit your IP and Port for CORS services. 
Also, in the AddressBook.Client, open the people.service.ts file and change your API URL, to mach with your local URL.

3. **Run the application with the backend, so you can use the API from the Server side.**

Open your browser and navigate to http://yourip:yourport/ to access the application.

## Project Structure for client side
- **src/app/people-list/:** Components for managing the list of users.
- **src/app/navbar/:** Components for the navigation bar and search functionality.
- **src/app/user.model.ts:** Data model definition for users.
- **src/app/people.service.ts:** Service for fetching user data.

## Project Structure for server side
- **controllers/PeopleController.cs/:** API Controller which is responsible to make a HttpGet request
- **PeopleService.cs:** The business logic of getting the random users from randomuser.me
- **modals/Class.cs/:** Models, which we want to receive
- **Program.cs/:**  The whole builder section, also with CORS services
