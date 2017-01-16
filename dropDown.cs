using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class xxx:MonoBehavior(){

	void Start(){

		myDropDown.onValueChanged.AddListener(delegate {myDropDownValueChangedHandler(myDropDown)});

	}
	private void myDropDownValueChangedHandler(DropDown Target){
		if(target.value==1){
			ChangeEnglish();
		}else if(target.value==0){
			ChangeChinese;
		}
	}
}