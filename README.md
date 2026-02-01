Computational Interface Engine (C#)
A robust, terminal-based arithmetic utility built with C# and .NET. This project demonstrates foundational software engineering principles, including defensive programming, input sanitization, and precise arithmetic handling.

🚀 Technical Highlights
Defensive Programming: Implements int.TryParse to ensure the application remains stable and "crash-proof" against non-numerical user input.
Mathematical Integrity: Explicitly handles Division by Zero edge cases to prevent runtime exceptions and maintain mathematical logic.
High-Precision Arithmetic: Utilizes the decimal data type for results to ensure accuracy in quotients and remainders, avoiding the rounding errors associated with float or double.
Input Sanitization: Features a validation loop with LINQ set-membership checks to verify operator validity before proceeding with execution.
UX Design: Includes System.Threading for timed delays and Console.Clear to provide a clean, professional "system-like" user interface.

🛠️ Key Skills Demonstrated
Control Flow: Sophisticated use of nested while loops and continue/break statements for smooth program navigation.
Data Validation: Logic-based verification of user inputs to minimize "garbage-in, garbage-out" scenarios.
Type Casting: Strategic explicit casting to preserve data integrity during complex operations.
Clean Code: Adherence to professional naming conventions and namespace management.

💻 Installation
1. Clone the Repository: git clone https://github.com/YourUsername/Calculator-Project.git
2. Open in IDE: Open the solution in Visual Studio
3. Build & Run: Press F5 to compile and run.

📖 Usage Example
--- Computational Interface ---
Input the initial operand: 10

The available set of binary operations is: 
1. Sum (+)
2. Difference (-)
3. Product (*)
4. Quotient (/)
5. Remainder (%)

Designate the operator: /
Input the secondary operand: 3

The resulting value of 10 / 3 is 3.33.
Commence a further iteration? (y/n)

📄 License
This project is open-source and free to use for learning and development purposes.
