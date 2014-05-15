using UnityEngine;
using System.Collections;

public class Tentacle : Stage {
	public override void OnAwake()
	{
		CreateBackground();
		CinchOptions.DefaultPixelsPerMeter = 180;
		
		//make a container clip at the lower left corner
		Sprite lastParent = Library.New<Sprite>("root");
		AddChild(lastParent);
		lastParent.Rotation = 0f;
		
		for (var i=0; i<20; i++)
		{
			var newSprite = Sprite.NewFromImage ("Cinch2D/Strawberry");
			lastParent.AddChild(newSprite);
			newSprite.X = .6f;
			newSprite.Rotation = 12f;
			newSprite.ScaleX = newSprite.ScaleY = .95f;
			
			lastParent = newSprite;
		}
	}
	
	private void CreateBackground()
	{
		Sprite background = Sprite.NewFromImage("Cinch2D/Background", 100f, RegistrationPoint.BottomLeft);
		background.Width = ViewportWidth;
		background.Height = ViewportHeight;
		AddChild(background);
	}
}
