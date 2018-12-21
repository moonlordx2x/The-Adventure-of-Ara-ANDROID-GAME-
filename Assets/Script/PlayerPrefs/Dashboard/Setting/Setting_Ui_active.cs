using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_Ui_active : MonoBehaviour {

	
	public void cplus_active_ui()
    {
        PlayerPrefs.SetString("cplus_ui", "active");
        PlayerPrefs.SetString("java_ui", "deactive");
        PlayerPrefs.SetString("php_ui", "deactive");
    }

    public void java_active_ui()
    {
        PlayerPrefs.SetString("cplus_ui", "deactive");
        PlayerPrefs.SetString("java_ui", "active");
        PlayerPrefs.SetString("php_ui", "deactive");
    }

    public void php_active_ui()
    {
        PlayerPrefs.SetString("cplus_ui", "deactive");
        PlayerPrefs.SetString("java_ui", "deactive");
        PlayerPrefs.SetString("php_ui", "active");
    }
}
