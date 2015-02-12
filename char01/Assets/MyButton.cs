using UnityEngine;
using System.Collections;

/**
 * @describe 创建按钮
 * @author 康自军
 * @time 
 */
public class MyButton : MonoBehaviour {
	public Texture2D bg;
	public float left;
	public float top;
	void OnGUI()
	{
		if ( bg == null) 
		{
			Debug.LogError("Please assign a texture on the inspector");
			print ( "enter the params" );
			return;
		}

		GUI.Button ( new Rect( left, top, bg.width, bg.height ), bg );
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
