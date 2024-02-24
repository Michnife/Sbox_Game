using Sandbox;
using Sandbox.Citizen;

public sealed class SnotPlayer : Component
{

	[Property]
	[Category( "Components")]
	public GameObject Camera { get; set;}

	[Property]
	[Category( "Components")]
	public CharacterController Controller { get; set;}

	[Property]
	[Category( "Components")]
	public CitizenAnimationHelper Animator { get; set;}

	[Property]
	[Category( "Stats")]
	[Range( 0f, 400f, 1f)]
	public float WalkSpeed  { get; set;} = 120f;

	[Property]
	[Category( "Stats")]
	[Range( 0f, 800f, 1f)]
	public float RunSpeed { get; set;} = 250f;

	[Property]
	[Category( "Stats")]
	[Range( 0f, 1000f, 10f)]
	public float JumpStrength { get; set;} = 400f;

	public Angles EyeAngles { get; set; }

	protected override void OnUpdate()
	{
		EyeAngles += Input.AnalogLook;
		Transform.Rotation = Rotation.FromYaw( EyeAngles.yaw );
	}

	protected override void OnFixedUpdate()
	{
		if( Controller == null) return;

		var wishVelocity = Input.AnalogMove * WalkSpeed * Transform.Rotation;

		Controller.Accelerate( wishVelocity);

		if( Controller.IsOnGround)
			Controller.ApplyFriction( 5f);
		else
			Controller.Velocity += Scene.PhysicsWorld.Gravity * Time.Delta;

		Controller.Move();
	}
}