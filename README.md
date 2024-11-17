# User Authentication System with PBKDF2-SHA512

## University and Contributors
- **University**: University of Pristina
- **Faculty**: Faculty of Electrical and Computer Engineering
- **Mentor**: Dr. Sc. Mërgim H. HOTI
- **Students**:
  - Fisnik MUSTAFA
  - Osman BYTYQI
  - Urim HOXHA 

## Overview

This project is a User Authentication System implemented in .NET/C# that uses PBKDF2 with the SHA-512 algorithm to securely hash and verify passwords. It demonstrates best practices for password security by applying cryptographic hashing with a salt and multiple iterations, which helps mitigate brute-force attacks.

## Goal
The goal of this project was to explore and demonstrate the usage of PBKDF2-SHA512 for securing user passwords in a practical application, demonstrating how cryptographic hashing can be used to build a secure authentication system.

## Description of PBKDF2-SHA512
PBKDF2 (Password-Based Key Derivation Function 2) is a cryptographic algorithm that applies a pseudorandom function (in this case, SHA-512) to the input password along with a salt and repeats the process for a set number of iterations. This makes it computationally expensive for an attacker to brute-force passwords. SHA-512 is a cryptographic hash function from the SHA-2 family, known for producing a 512-bit hash.

## Features

- **User Registration**: Securely hashes and stores passwords with a salt during user registration.
- **User Login**: Authenticates users by comparing input passwords with stored hashed values.
- **In-Memory Data Storage**: Stores user data (username, salt, hash) in an in-memory dictionary for simplicity.
- **Security Practices**: Utilizes PBKDF2 with SHA-512, a high iteration count, and randomly generated salts for enhanced security.

## Technologies Used

- **C# Programming Language**
- **System.Security.Cryptography** for cryptographic operations

## Prerequisites

- .NET SDK installed
- Basic knowledge of C#

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

## License
This project is licensed under the MIT License - see the [LICENSE](https://github.com/OsmanBytyqi/Information_Security/blob/master/LICENSE) file for details.
