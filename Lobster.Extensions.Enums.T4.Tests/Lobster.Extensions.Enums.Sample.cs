

  


namespace Lobster.Extensions.Enums
{
	public static class Extensions_Enum_Ops
	{

		public static bool IsAnySet(this System.IO.FileAccess value, System.IO.FileAccess flags) => (value & flags) != 0;
		public static bool AreAllSet(this System.IO.FileAccess value, System.IO.FileAccess flags) => (value & flags) == flags;
		public static System.IO.FileAccess Set(this System.IO.FileAccess value, System.IO.FileAccess flags) => value | flags;
		public static System.IO.FileAccess Reset(this System.IO.FileAccess value, System.IO.FileAccess flags) => value & ~flags;
		public static bool ContainsOnlyAnyOf(this System.IO.FileAccess value, System.IO.FileAccess flags) => (value & ~flags) == 0;
		public static bool IsAnySet(this System.IO.FileShare value, System.IO.FileShare flags) => (value & flags) != 0;
		public static bool AreAllSet(this System.IO.FileShare value, System.IO.FileShare flags) => (value & flags) == flags;
		public static System.IO.FileShare Set(this System.IO.FileShare value, System.IO.FileShare flags) => value | flags;
		public static System.IO.FileShare Reset(this System.IO.FileShare value, System.IO.FileShare flags) => value & ~flags;
		public static bool ContainsOnlyAnyOf(this System.IO.FileShare value, System.IO.FileShare flags) => (value & ~flags) == 0;
}
	}
