using UnityEngine;
using System.Collections;

/**
 * @describe 创建一个窗体
 * @author 康自军
 * @time 2015-02-12 15:21:05
 */
public class MyWindow : MonoBehaviour {
	public Rect rect = new Rect( 200, 200, 400, 300 );

	void OnGUI()
	{
		rect = GUI.Window ( 0, rect, createMyWindow, "Red Window" );
	}

	private void createMyWindow( int windowID )
	{
		if (GUI.Button (new Rect (280, 250, 100, 30), "Sure Button")) 
		{
			print ( "Sure Button has be clicked " );
		}

		GUI.DragWindow ( new Rect( 0, 0, 400, 20 ) );
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
