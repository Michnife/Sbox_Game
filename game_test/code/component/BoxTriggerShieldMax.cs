using Sandbox;

public sealed class BoxTriggerShieldMax : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		Log.Info("Trigger Hp !!");
		var player = other.Components.Get<UnitInfo>();
		player.Armor = player.MaxArmor;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}