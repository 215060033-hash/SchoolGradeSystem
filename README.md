# School Grade Management System

This console application is developed as a term project for the SWE203 course. It simulates a basic school grading system where students, courses, and grade entries are managed using object-oriented principles.

## Class Design Principles

Following the guidelines provided for the term project, I have designed the classes based on real-life object properties and separated the "identity" of objects from their "state".

### 1. Identity vs. State (Usage of `init`)
In real-world scenarios, certain attributes of an object act as identifiers and do not change after creation.
- In the `Student` class, I defined `StudentNo` with the `init` keyword. A student number is an identity assigned upon registration; it should not be mutable.
- Similarly, `CourseCode` in the `Course` class is defined as `init` for the same reason.

### 2. Encapsulation and Data Integrity
The project strictly enforces data validation within the class definitions, rather than relying on external checks.
- **Grade Validation:** In the `GradeEntry` class, the `Grade` property implements a `set` block. It checks if the input value is between 0 and 100. If an invalid value is entered, the system catches it and assigns a default value (0) to maintain data integrity.

### 3. Relational Logic (ID References)
Following the "RentalVehicle" sample project's logic, I avoided storing whole object references inside the `GradeEntry` class.
- Instead of storing `Student` and `Course` objects directly, the `GradeEntry` class stores `StudentNo` and `CourseCode`.
- This mimics **Relational Database** design. The system uses these IDs to look up details only when needed (e.g., during report generation).

### 4. Manager Class Pattern
To ensure the `Program` class remains clean and the code is portable, I implemented a `SchoolManager` class. All operations are handled by this manager class, preventing code clutter in the main program.
