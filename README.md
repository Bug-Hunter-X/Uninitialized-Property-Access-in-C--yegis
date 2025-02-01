# Uninitialized Property Access in C#

This repository demonstrates a common C# error: accessing a property before it's been assigned a value. This can lead to unexpected behavior, exceptions, or incorrect results.  The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a corrected version.

**Problem:**
In the `bug.cs` example, the `MyProperty` is accessed in the `MyMethod` before any value is assigned to it.  This can result in unpredictable behavior depending on the property type and context.

**Solution:**
The `bugSolution.cs` file corrects the issue by initializing `MyProperty` with a default value in the constructor or before accessing it in the method.  Always initialize properties to avoid such runtime issues.
