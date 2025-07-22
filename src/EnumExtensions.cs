using System.ComponentModel.DataAnnotations;

namespace KebabGGbab.Extensions.Primitives
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
				?.GetCustomAttributes(false)
				.OfType<DisplayAttribute>()
				.FirstOrDefault()
				?.Name;
		}
	}
}
