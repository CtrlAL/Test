namespace Api.Helpers
{
	public class KebabCaseControllerNameConvention : IOutboundParameterTransformer
	{
		public string TransformOutbound(object value)
		{
			if (value == null) return null;

			return System.Text.RegularExpressions.Regex.Replace(
				value.ToString(),
				"([a-z])([A-Z])",
				"$1-$2"
			).ToLower();
		}
	}
}
