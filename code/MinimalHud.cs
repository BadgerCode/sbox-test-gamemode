﻿using Sandbox;
using Sandbox.UI;
using TestGamemode.ui;

namespace TestGamemode
{
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
}
