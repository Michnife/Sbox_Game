using Sandbox;

public sealed class BoxTriggerInfo : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		var player = other.Components.Get<UnitInfo>();
		Log.Info(player.Health);
		Log.Info(player.Armor);

	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}