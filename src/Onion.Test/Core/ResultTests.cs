using NUnit.Framework;
using Onion.Core.Results;

namespace Onion.Test.Core
{
	/// <summary>
	/// Tests for the <see cref="Onion.Core.Result"/>
	/// </summary>
	[TestFixture]
	public class ResultsTests
	{
		private const string TestValue = "Hello World!";

		[Test]
		public void HitResultExists_WhenInterface_ReturnsTrue()
		{
			IResult<string> result = new HitResult<string>(TestValue);

			Assert.IsTrue(result.Exists, "((IResult) HitResult).Exists returned false.");
		}

		[Test]
		public void MissResultExists_WhenInterface_ReturnsFalse()
		{
			IResult<string> result = new MissResult<string>();

			Assert.IsFalse(result.Exists, "((IResult) MissResult).Exists returned true.");
		}

		[Test]
		public void HitResultValue_WhenInterface_ReturnsValue()
		{
			IResult<string> result = new HitResult<string>(TestValue);

			Assert.AreEqual(TestValue, result.Value, "((IResult) HitResult).Value returned different value.");
		}

		[Test]
		public void MissResult_WhenInterface_ReturnsDefault()
		{
			IResult<string> result = new MissResult<string>();

			Assert.AreEqual(default(string), result.Value, "((IResult) MissResult).Value returned non-default value.");
		}
	}
}
