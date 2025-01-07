# Directly Modifying Backing Field Instead of Using Property

This repository demonstrates a common error in C# where a backing field is directly modified instead of using its associated property.  This can lead to unexpected behavior and inconsistencies.

## Bug Description
The `bug.cs` file contains a class `ExampleClass` with a private field `_myField` and a public property `MyProperty` that provides access to the field. However, the `MyMethod` function directly modifies `_myField` without using the property's setter.  This bypasses any logic within the property, potentially leading to bugs.

## Solution
The `bugSolution.cs` file demonstrates the correct way to modify the field: by using the property's setter (`MyProperty = 10`). This ensures that any logic within the property is properly executed.