using Sandbox;

public sealed class BlockTest : Component
{
	[Property]
	public GameObject test_ { get; set;}

	protected override void OnUpdate()
	{

	}

	protected override void OnFixedUpdate()
	{
		if (Input.Pressed("Run"))
        {
        }
	}

}
