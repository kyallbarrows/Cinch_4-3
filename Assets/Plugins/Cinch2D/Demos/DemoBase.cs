using UnityEngine;
using System.Collections;

public class DemoBase : Stage {
	
	protected void CreateBackground()
	{
		CinchSprite background = CinchSprite.NewFromImage("Cinch2D/Background", 100f);
		background.Width = ViewportWidth;
		background.Height = ViewportHeight;
		AddChild(background);
	}
}
