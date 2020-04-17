using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float target_rotate = 100;

    public Camera MainCamera;
    private Vector3 newAngle = new Vector3(0, 0, 0);


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(0.0f, 0.0f, 0.01f);


        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }

        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }

        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }

        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -0.1f);
        }

        // 右に回転
        if (Input.GetKey(KeyCode.Keypad6))
        {
            var target = Quaternion.Euler(new Vector3(target_rotate, 0, 0));
            var now_rot = transform.rotation;
            transform.Rotate(new Vector3(0.0f, 0.1f, 0.0f));
        }

        // 左に回転
        if (Input.GetKey(KeyCode.Keypad4))
        {
            newAngle = MainCamera.transform.localEulerAngles;
            
            var target = Quaternion.Euler(new Vector3(target_rotate, 0, 0));
            var now_rot = transform.rotation;
            transform.Rotate(new Vector3(0.0f, -0.1f, 0.0f));
        }





    }
}
