namespace Onion.Core.Models
{
	/// <summary>
	/// Interface to represent some object that has a deterministic score.
	/// </summary>
	public interface IHasScore
	{
		/// <summary>
		/// Object score.
		/// </summary>
		double Score { get; }
	}
}
