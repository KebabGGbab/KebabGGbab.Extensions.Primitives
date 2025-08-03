using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KebabGGbab.Primitives.Extensions
{
	public static class EnumExtensions
	{
		/// <summary>
		/// Возвращает значение свойства <see cref="DisplayAttribute.Name"/>, указанного для поля перечисления.
		/// </summary>
		/// <param name="field">Поле перечисления, у которого нужно получить значение свойства <see cref="DisplayAttribute.Name"/>.</param>
		/// <returns>
		/// Значение свойства <see cref="DisplayAttribute.Name"/>, если атрибут присутствует; иначе — null.
		/// </returns>
		public static string? GetDisplayNameField(this Enum field)
		{
			return field
				.GetType()
				.GetField(field.ToString())
				?.GetCustomAttribute<DisplayAttribute>()
				?.Name;
		}
	}
}
