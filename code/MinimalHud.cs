//using Sandbox;
//using Sandbox.UI;

///// <summary>
///// This is the HUD entity. It creates a RootPanel clientside, which can be accessed
///// via RootPanel on this entity, or Local.Hud.
///// </summary>
//[Library]
//public partial class MinimalHudEntity : HudEntity<RootPanel>
//{
//	public MinimalHudEntity()
//	{
//		if (!IsClient)
//			return;

//		RootPanel.AddChild<Health>();
//	}
//}



using Sandbox;
using Sandbox.UI;

[Library]
public partial class SandboxHud : HudEntity<RootPanel>
{
	public SandboxHud()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "/ui/SandboxHud.scss" );

		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<CrosshairCanvas>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<KillFeed>();
		RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
		RootPanel.AddChild<Health>();
		RootPanel.AddChild<TestElement>();
	}
}
