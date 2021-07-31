using Sandbox;
using Sandbox.UI;

// Look for a html template with the same name (in the same folder?)- TestElement.html
[UseTemplate]
public class TestElement : Panel
{
	public string MyProperty { get; set; }
	public Label Element { get; set; }
	public string Name { get; set; }
	public string Health { get; set; }

	public TestElement()
	{
		MyProperty = "Some property"; // This will only run once- on gamemode load. Use restart in console to reload
	}

	public override void Tick()
	{
		// Modify our properties which are used in the HTML
		Name = Local.DisplayName;
		Health = (Local.Pawn?.Health.CeilToInt() ?? 100).ToString();

		// Access an element directly
		Element.Text = "Nice";
		base.Tick();
	}
}
