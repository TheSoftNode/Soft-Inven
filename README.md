# SoftInven - Inventory Management System

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction
The SoftInven is designed for a production firm that supplies products to shops. This system streamlines inventory tracking, order processing, and sales management, ensuring efficient operations and accurate stock control. It aims to enhance the productivity and operational efficiency of the firm by providing a user-friendly interface and powerful backend features.

## Features
- **Real-time Inventory Tracking:** Monitor stock levels, track inventory in and out, and set reorder points.
- **Order Management:** Process orders from shops, manage invoices, and track order status.
- **Sales Management:** Record sales transactions, generate sales reports, and analyze sales trends.
- **Supplier Management:** Manage supplier information, track purchase orders, and handle supplier payments.
- **User Authentication and Role Management:** Secure login system with different access levels for admins, managers, and staff.
- **Notifications:** Get notified for low stock levels, new orders, and other important events.
- **Reporting:** Generate detailed reports on inventory status, sales performance, and order history.

## Technologies Used
- **Frontend:**
  - Blazor Server
  - Bootstrap
- **Backend:**
  - C#
  - .NET Core
- **Database:**
  - SQL Server
- **Real-time Communication:**
  - SignalR
- **Containerization:**
  - Docker
- **Cloud Services:**
  - AWS

## Installation
To set up the Inventory Management System locally, follow these steps:

1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/inventory-management-system.git
   cd inventory-management-system
   ```

2. **Set up the database:**
   - Ensure SQL Server is installed and running.
   - Update the connection string in `appsettings.json` with your SQL Server details.

3. **Run the backend:**
   ```sh
   dotnet restore
   dotnet build
   dotnet run
   ```

4. **Docker setup (Optional):**
   - Build the Docker image:
     ```sh
     docker build -t inventory-management-system .
     ```
   - Run the Docker container:
     ```sh
     docker run -d -p 8080:80 inventory-management-system
     ```

## Usage
1. **Access the application:**
   - Open a web browser and navigate to `http://localhost:5000` (or the appropriate Docker port).

2. **Login:**
   - Use the provided admin credentials to log in and explore the features.

3. **Manage Inventory:**
   - Navigate to the inventory section to add, edit, or remove products.

4. **Process Orders:**
   - Use the order management section to process new orders from shops.

5. **Generate Reports:**
   - Access the reports section to generate and view detailed inventory and sales reports.

## Contributing
We welcome contributions to enhance the Inventory Management System. To contribute, follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a pull request.

Please ensure your code adheres to the project's coding standards and includes relevant tests.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact
For any inquiries or feedback, please contact:
- **Theophilus Uchechukwu** - Project Lead
- **Email:** thesoftnode@gmail.com
- **GitHub:** [TheSoftNode](https://github.com/TheSoftNode)

Thank you for using the SoftInven


