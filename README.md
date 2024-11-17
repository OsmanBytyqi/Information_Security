# User Authentication System with PBKDF2-SHA512

## University and Contributors
- **University**: University of Pristina
- **Faculty**: Faculty of Electrical and Computer Engineering
- **Mentor**: Dr. Sc. Mërgim H. HOTI
- **Students**:
  - Fisnik MUSTAFA
  - Osman BYTYQI
  - Urim HOXHA

## Disclaimer

This application is a **demonstration** of how to use **PBKDF2 with SHA-512** for secure password storage. It is **not** a complete authentication system and was not designed to be one. The **goal** of this project was to explore and demonstrate the usage of PBKDF2-SHA512 for securing user passwords in a practical application, demonstrating how cryptographic hashing can be used to build a secure authentication system.

### Key Points:
- The application is purposefully kept **simple** and **minimal** for educational purposes.
- It is not intended for production use or deployment in real-world applications.

## Overview

This project is a simple User Authentication System implemented in .NET/C# that uses PBKDF2 with the SHA-512 algorithm to securely hash and verify passwords. It demonstrates best practices for password security by applying cryptographic hashing with a salt and multiple iterations, which helps mitigate brute-force attacks.

## Description of PBKDF2-SHA512
PBKDF2 (Password-Based Key Derivation Function 2) is a cryptographic algorithm that applies a pseudorandom function (in this case, SHA-512) to the input password along with a salt and repeats the process for a set number of iterations. This makes it computationally expensive for an attacker to brute-force passwords. SHA-512 is a cryptographic hash function from the SHA-2 family, known for producing a 512-bit hash.

## Features

- **User Registration**: Securely hashes and stores passwords with a salt during user registration.
- **User Login**: Authenticates users by comparing input passwords with stored hashed values.
- **Persistent Data Storage**: Saves user data (username, salt, hash) to a users.json file to retain user data across application sessions.
- **Security Practices**: Utilizes PBKDF2 with SHA-512, a high iteration count, and randomly generated salts for enhanced security.

## Technologies Used

- **C# Programming Language**
- **System.Security.Cryptography** for cryptographic operations

## Prerequisites

- .NET 8.0 SDK installed
- Basic knowledge of C#

### Cloning the Repository

Clone this repository to your local machine with the following command:

```bash
git clone https://github.com/yourusername/user-auth-system.git
```

### Building and Running the Project

1. Open the project in Visual Studio or your preferred C# editor.
2. Build the project using the IDE or run this command in your terminal:
   ```bash
   dotnet build
   ```
3. Run the project using:
   ```bash
   dotnet run
   ```

## How to Use

1. When you run the application, you will see the following options:
    ```
    1. Register User
    2. Authenticate User
    3. Exit
    ```
2. To register a new user:
    - Select option `1` to register a new user.
    - Enter a desired username.
    - Enter a password for the user.
    - The user will be stored in memory and saved to the `users.json` file.

3. To authenticate an existing user:
    - Select option `2` to authenticate.
    - Enter the username.
    - Enter the password.
    - If the credentials match a registered user, authentication will be successful.

4. To exit the application:
    - Select option `3` to exit.

## Project Structure 
```
project_root/
├── .gitignore                      # Git ignore rules
├── LICENSE                         # Project license information
├── Program.cs                      # Main application entry point
├── README.md                       # Project documentation
├── UserAuthenticationSystem.cs     # Core user authentication functionality
├── InformationSecurity.csproj      # Project configuration file
│
├── DTO/                            # Data Transfer Objects for data transfer between layers
└──   └── UserKeyDTO.cs               # DTO class for user key data
```
## Results

The project successfully demonstrates how to implement secure password handling using PBKDF2-SHA512. By leveraging this approach, the system ensures that passwords are stored in a cryptographically secure manner, making it resistant to common attacks such as brute-force and rainbow table attacks.

## Future Enhancements

While this application is not intended to be extended further, here are some potential improvements that could be made if one chooses to continue developing it:

- **Better Persistent Data Storage**: Integrate a database (e.g., SQLite, SQL Server) for permanent user data storage.
- **Password Policies**: Enforce password complexity rules to strengthen security.
- **Logging and Monitoring**: Add detailed logging and monitor authentication attempts for security analysis.
- **User Interface**: Develop a web-based or GUI interface to improve user experience.

## License
This project is licensed under the MIT License - see the [LICENSE](https://github.com/OsmanBytyqi/Information_Security/blob/master/LICENSE) file for details.
