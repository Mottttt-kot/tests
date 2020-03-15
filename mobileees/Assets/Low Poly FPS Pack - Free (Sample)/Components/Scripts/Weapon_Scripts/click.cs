using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class click : MonoBehaviour {
	
	public Button yourButton;
	public Camera gunCamera;
	[Header("Gun Camera Options")]
	public float aimFov = 15.0f;
	public float fovSpeed = 15.0f;
	private bool isAiming;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}


	void TaskOnClick(){
					gunCamera.fieldOfView = Mathf.Lerp (gunCamera.fieldOfView,
				aimFov, fovSpeed * Time.deltaTime);
			
			isAiming = true;

	}
}