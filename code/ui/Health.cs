using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

//[UseTemplate]
//public class Health : Panel
//{
//	public string MyVariable { get; set; }
//	public Label Element { get; set; }

//	public Health()
//	{
//		MyVariable = "Hello world";
//	}

//	public override void Tick()
//	{
//		var player = Local.Pawn;
//		if ( player == null ) return;

//		Element.Text = $"{player.Health.CeilToInt()}";
//	}
//}

public class Health : Panel
{
	public Label Label;

	public Health()
	{
		Label = Add.Label( "100", "value" );
	}

	public override void Tick()
	{
		var player = Local.Pawn;
		if ( player == null ) return;

		Label.Text = $"{player.Health.CeilToInt()}";
	}
}
