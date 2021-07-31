using Sandbox;
using Sandbox.UI;
using TestGamemode.ui;

namespace TestGamemode
{
	[Library]
	public partial class Hud : HudEntity<RootPanel>
	{
		public Hud()
		{
			if (!IsClient)
				return;

			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<CrosshairCanvas>();
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<VoiceList>();
			RootPanel.AddChild<KillFeed>();
			RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
			RootPanel.AddChild<ExampleCSHUDElement>();
			RootPanel.AddChild<ExampleHTMLHUDElement>();
		}
	}
}
