using System.Buffers;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BoxinAndUnboxin;

public unsafe struct Any : IDisposable
{
	private void* Pointer;

	public void Put<T>(T value)
	{
		fixed (void* ptr = &Pointer)
		{
			*(T*)ptr = value;
		}
	}

	public T? Get<T>()
	{
		T? result = default;
		fixed (void* ptr = &Pointer)
		{
			var valuePtr = (T*)ptr;
			result = *( valuePtr );
		}

		return result;
	}

	public readonly void Dispose() => GC.SuppressFinalize(this);
}
