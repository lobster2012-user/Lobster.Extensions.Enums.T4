# Lobster.Extensions.Enums.T4
Lobster.Extensions.Enums.T4

Sample of auto-generated code
```
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
