using Sandbox;
using System;

public sealed class BoxTrigger : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		Log.Info("Trigger");
		var player = other.Components.Get<UnitInfo>();
		player.Health = player.Health - 100;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}