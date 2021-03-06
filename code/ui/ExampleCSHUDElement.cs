using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TestGamemode.ui
{
	public class ExampleCSHUDElement : Panel
	{
		// If you add a property, you will need to reload the level- type restart in console
		public Label Label { get; set; }

		public ExampleCSHUDElement()
		{
			StyleSheet.Load($"/ui/{nameof(ExampleCSHUDElement)}.scss"); // Don't forget to update the class name in this file if you rename this class
			Label = Add.Label("100", "value");
		}

		public override void Tick()
		{
			Label.Text = (Local.Pawn?.Health.CeilToInt() ?? 100).ToString();
		}
	}
}
