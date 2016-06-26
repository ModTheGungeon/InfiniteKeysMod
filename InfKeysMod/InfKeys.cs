using System;

// This class is the "main" mod class. ETGMod will run the methods inside it as required.
// The name and version is in the metadata.txt in the .zip, not here just as with the backends.
public class InfKeysMod : ETGModule {

	public InfKeysMod() {
		/* Initialization happens in Start! */
	}

	public override void Start() {
	}

	public override void Update() {
		// Update code goes in here.
		ETGMod.Player.InfiniteKeys = true;
		Console.WriteLine (ETGMod.Player.InfiniteKeys.ToString ());
	}

	public override void Exit() {
		// Disposal code goes in here.
	}
}