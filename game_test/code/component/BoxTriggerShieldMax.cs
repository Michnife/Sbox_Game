using Sandbox;

public sealed class BoxTriggerShieldMax : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		var player = other.Components.Get<UnitInfo>();
		player.Armor = player.MaxArmor;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}