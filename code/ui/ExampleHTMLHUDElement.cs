using Sandbox;
using Sandbox.UI;

namespace TestGamemode.ui
{
	// Look for a html template with the same name (in the same folder?)- TestElement.html
	[UseTemplate]
	public class ExampleHTMLHUDElement : Panel
	{
		// If you add a property, you will need to reload the level- type restart in console
		public string MyProperty { get; set; }
		public Label Element { get; set; }
		public string Name { get; set; }
		public string Health { get; set; }

		public ExampleHTMLHUDElement()
		{
			StyleSheet.Load($"/ui/{nameof(ExampleHTMLHUDElement)}.scss");
			MyProperty = "This property is set via CS code!"; // This will only run once- on gamemode load. Use restart in console to reload
		}

		public override void Tick()
		{
			// Modify our properties which are used in the HTML
			Name = Local.DisplayName;
			Health = (Local.Pawn?.Health.CeilToInt() ?? 100).ToString();

			// Access an element directly
			Element.Text = "This element's text has been directly altered via CS code!";
			base.Tick();
		}
	}
}
