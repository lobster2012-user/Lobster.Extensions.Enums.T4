# Lobster.Extensions.Enums.T4
Lobster.Extensions.Enums.T4

[![NuGet](https://img.shields.io/nuget/v/Lobster.Extensions.Enums.T4.svg)](https://www.nuget.org/packages/Lobster.Extensions.Enums.T4)
[![NuGet](https://img.shields.io/nuget/dt/Lobster.Extensions.Enums.T4.svg)](https://www.nuget.org/packages/Lobster.Extensions.Enums.T4)
[![Build status](https://ci.appveyor.com/api/projects/status/4kj0q18frf3me7h7?svg=true)](https://ci.appveyor.com/project/lobster2012-user/Lobster.Extensions.Enums.T4)


Example of auto-generated code

```csharp
namespace Lobster.Extensions.Enums
{
   public static class Extensions_Enum_Ops
   {
      public static bool IsAnySet(this System.IO.FileAccess value, System.IO.FileAccess flags) => (value & flags) != 0;
      public static bool AreAllSet(this System.IO.FileAccess value, System.IO.FileAccess flags) => (value & flags) == flags;
      public static System.IO.FileAccess Set(this System.IO.FileAccess value, System.IO.FileAccess flags) => value | flags;
      public static System.IO.FileAccess Reset(this System.IO.FileAccess value, System.IO.FileAccess flags) => value & ~flags;
   }
}
```

Example of use

```csharp
using Lobster.Extensions.Enums;

bool SomeFunc(SomeEnumType type)
{
    return type.IsAnySet(SomeEnumType.SomeFlag0|SomeEnumType.SomeFlag1);
}
```
