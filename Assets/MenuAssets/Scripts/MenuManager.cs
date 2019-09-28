using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public Menus currentMenu;

	void Start () {
		ShowMenu (currentMenu);

	}

	public void ShowMenu(Menus menu){
		if (currentMenu != null) {
			currentMenu.IsOpen = false;
		}

		currentMenu = menu;
		currentMenu.IsOpen = true;
	}

	public void PauseMenu(Menus menu){
		
		if (currentMenu != null) {
			currentMenu.IsOpen = false;
		}

		currentMenu = menu;
		currentMenu.IsOpen = true;
		Time.timeScale = 0;
	}

	public void PlayMenu(Menus menu){

		if (currentMenu != null) {
			currentMenu.IsOpen = false;
		}

		currentMenu = menu;
		currentMenu.IsOpen = true;
		Time.timeScale = 1;
	}
}
