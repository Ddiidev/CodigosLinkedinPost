using System.Buffers;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BoxinAndUnboxin;

public unsafe struct Any : IDisposable
{
	private void* Pointer;
	private Int128 value;

	public Any(string value) => Put(value);
	
	public Any(int value) => Put(value);

	public Any(decimal value) => Put(value);

	public Any(bool value) => Put(value);


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

	public static implicit operator Any(string value) => new(value);

	public static implicit operator Any(int value) => new(value);

	public static implicit operator Any(decimal value) => new(value);

	public static implicit operator Any(bool value) => new(value);
}