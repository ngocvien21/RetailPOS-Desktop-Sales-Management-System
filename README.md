# RetailPOS – Desktop Sales Management System

## Overview

**RetailPOS** is a desktop application designed to streamline sales management in retail clothing stores. Developed using C# and Microsoft SQL Server, it offers a comprehensive solution for handling various aspects of store operations, including inventory management, customer relations, billing, and staff oversight.
![image](https://github.com/user-attachments/assets/7f97adcc-0814-4a02-8702-18dd87ac9c39)


## Features

- **Entity Relationship Diagram (ERD) Design**: Captures and models the software's requirements to ensure a robust database structure.
- **Automated Financial Calculations**: Utilizes SQL Server triggers to compute transaction totals in real-time.
- **Comprehensive CRUD Operations**: Implements stored procedures for efficient data management, including search, add, edit, and delete functionalities.
- **User-Friendly Interface**: Provides intuitive forms for managing:
  - **Login**: Secure access control for users.
  - **Menu**: Central navigation hub for all functionalities.
  - **Account Management**: Administration of user accounts and permissions.
  - **Customer Management**: Tracking customer information and purchase history.
  - **Billing**: Processing sales transactions and generating invoices.
  - **Product Management**: Overseeing inventory, including product details and stock levels.
  - **Staff Management**: Handling employee records and roles.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/ngocvien21/RetailPOS-Desktop-Sales-Management-System.git
   ```
2. **Set Up the Database**:
   - Restore the `databaseforSW.sql` file in Microsoft SQL Server to create the necessary database and tables.
3. **Configure the Application**:
   - Update the database connection string in the application's configuration file to match your SQL Server setup.
4. **Build and Run**:
   - Open the solution in Visual Studio.
   - Build the project to resolve dependencies.
   - Run the application.

## Usage

- **Login**: Access the system using your credentials.
- **Navigate**: Use the main menu to access different modules.
- **Manage Records**: Add, edit, or delete information in modules like Customers, Products, and Staff.
- **Process Sales**: Utilize the Billing module to handle transactions and print receipts.

## Screenshots

*Include relevant screenshots here to showcase the application's interface and functionalities.*

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your proposed changes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For questions or suggestions, please contact [Truong Thi Ngoc Vien] at [ngocvien2052001@gmail.com].
