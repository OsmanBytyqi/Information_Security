# Information Security

## University and Contributors
- **University**: University of Pristina
- **Faculty**: Faculty of Electrical and Computer Engineering
- **Mentor**: Dr. Sc. Mërgim H. HOTI
- **Students**:
  - Fisnik MUSTAFA
  - Osman BYTYQI
  - Urim HOXHA 

## Goal
The goal of this project was to explore and implement PBKDF2-SHA512 for securing user passwords in a practical application, demonstrating how cryptographic hashing can be used to build a secure authentication system.

## Description of PBKDF2-SHA512
PBKDF2 (Password-Based Key Derivation Function 2) is a cryptographic algorithm that applies a pseudorandom function (in this case, SHA-512) to the input password along with a salt and repeats the process for a set number of iterations. This makes it computationally expensive for an attacker to brute-force passwords. SHA-512 is a cryptographic hash function from the SHA-2 family, known for producing a 512-bit hash.

## Project Structure 
```
project_root/
├── .gitignore                # Git ignore rules
├── LICENSE                   # Project license information
├── Program.cs                # Main application entry point
├── README.md                 # Project documentation
├── UserAuthenticationSystem.cs # Core user authentication functionality
└── UserAuthenticationSystem.csproj # Project configuration file
```

## License
This project is licensed under the MIT License - see the [LICENSE](https://github.com/OsmanBytyqi/Information_Security/blob/master/LICENSE) file for details.
