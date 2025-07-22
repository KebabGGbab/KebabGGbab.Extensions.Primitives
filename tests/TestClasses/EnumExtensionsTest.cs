using System.ComponentModel.DataAnnotations;

namespace KebabGGbab.Extensions.Primitives.Tests.TestClasses
{
	[TestClass]
	public sealed class EnumExtensionsTest
	{
		[TestMethod]
		[DataRow(Grades.Bad)]
		[DataRow(Grades.Great)]
		public void GetDisplayNameField_AttributeDefined_NamePropertyValue(Grades grade)
		{
			string? name = grade.GetDisplayNameField();

			Assert.IsNotNull(name);
		}

		[TestMethod]
		public void GetDisplayNameField_AttributeNotFound_Null()
		{
			Grades grade = Grades.None;

			string? name = grade.GetDisplayNameField();

			Assert.IsNull(name);
		}

		public enum Grades
		{
			None = 0,
			[Display(Name = "Ужасно")]
			Terrible = 1,
			[Display(Name = "Плохо")]
			Bad = 2,
			[Display(Name = "Удовлетворительно")]
			Satisfactory = 3,
			[Display(Name = "Хорошо")]
			Good = 4,
			[Display(Name = "Отлично", Description = "Наилучшая оценка", ShortName = "5")]
			Great = 5
		}
	}
}
