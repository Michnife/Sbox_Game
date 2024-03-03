using Sandbox;

public sealed class BoxTriggerShield : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		Log.Info("Trigger Hp !!");
		var player = other.Components.Get<UnitInfo>();
		player.Armor = player.Armor - 5;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}