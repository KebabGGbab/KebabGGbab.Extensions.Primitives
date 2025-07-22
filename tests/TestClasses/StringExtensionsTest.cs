namespace KebabGGbab.Extensions.Primitives.Tests.TestClasses
{
	[TestClass]
	public sealed class StringExtensionsTest
	{
		[TestMethod]
		public void ToStream_ReadStream_String()
		{
			string str = "Привет мир!";

			Stream stream = str.ToStream();
			using StreamReader sr = new(stream);
			string valueStream = sr.ReadToEnd();

			Assert.AreEqual(str, valueStream);
		}
	}
}
