using UnityEngine;
using System.Collections;

public class TextButtonThing : CinchSprite {
	
	private SimpleTextField _tf;
	
	public override void OnAwake () {
		InitFromImage("Table", 100f);
	
		_tf = SimpleTextField.NewFromString("Green", "Cinch2D/FjallaOne-Regular", 1f, TextAnchor.MiddleCenter);
		AddChild(_tf);
	}
	
	public void SetColor(Color color)
	{
		_tf.TextColor = color;
	}
}
