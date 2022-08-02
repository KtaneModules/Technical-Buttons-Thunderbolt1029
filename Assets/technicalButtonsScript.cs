using System.Runtime.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;
using System.Text.RegularExpressions;

class button {
	public KMSelectable Button;
	public int id;
	public string color;
	public bool twoNoDuplicates;
	public bool solved = false;
	public bool shouldBePressed;

	public button(KMSelectable buttonObject, int buttonId, Material buttonColor) {
		Button = buttonObject;
		id = buttonId;
		Button.GetComponent<Renderer>().material = new Material(buttonColor);
		color = buttonColor.name;
		color = (color=="darkGreen") ? "dark green" : color;
		color = (color=="darkRed") ? "dark red" : color;
		color = (color=="lightBlue") ? "light blue" : color;
	}

	public bool checkShouldBePressed(Dictionary<string, int> buttonColorOccurrence, int table, bool moreOnIndicators, bool oddNoPlates, bool noVowelIndicators, bool moreParallel, bool warm) {
		if (buttonColorOccurrence[color]>=2 ) {
			twoNoDuplicates = true;
			foreach (var kvp in buttonColorOccurrence) {
				if (kvp.Key==color) { continue; }
				else if (kvp.Value>1) { twoNoDuplicates = false; break; }
			}
		}

		if (color=="black") {
			if (table==1 && (oddNoPlates)) 				{ shouldBePressed = true; }
			else if (table==2 && (moreParallel)) 		{ shouldBePressed = true; }
			else if (table==3 && (moreOnIndicators)) 	{ shouldBePressed = true; }
			else if (table==4 && (oddNoPlates)) 		{ shouldBePressed = true; }
		} 
		else if (color=="blue") {
			if (table==1 && (noVowelIndicators)) 		{ shouldBePressed = true; }
			else if (table==2 && (moreParallel)) 		{ shouldBePressed = true; }
			else if (table==3 && (twoNoDuplicates)) 	{ shouldBePressed = true; }
			else if (table==4 && (noVowelIndicators)) 	{ shouldBePressed = true; }
		}
		else if (color=="brown") {
			if (table==1 && (moreParallel)) { shouldBePressed = true; }
			else if (table==2 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==3 && (noVowelIndicators)) { shouldBePressed = true; }
			else if (table==4 && (moreOnIndicators)) { shouldBePressed = true; }
		}
		else if (color=="cream") {
			if (table==1 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==2 && (moreParallel)) { shouldBePressed = true; }
			else if (table==3 && (moreParallel)) { shouldBePressed = true; }
			else if (table==4 && (noVowelIndicators)) { shouldBePressed = true; }
		}
		else if (color=="cyan") {
			if (table==1 && (warm)) { shouldBePressed = true; }
			else if (table==2 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==3 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==4 && (twoNoDuplicates)) { shouldBePressed = true; }
		}
		else if (color=="dark green") {
			if (table==1 && (moreParallel)) { shouldBePressed = true; }
			else if (table==2 && (noVowelIndicators)) { shouldBePressed = true; }
			else if (table==3 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==4 && (noVowelIndicators)) { shouldBePressed = true; }
		}
		else if (color=="dark red") {
			if (table==1 && (warm)) { shouldBePressed = true; }
			else if (table==2 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==3 && (moreParallel)) { shouldBePressed = true; }
			else if (table==4 && (warm)) { shouldBePressed = true; }
		}
		else if (color=="light blue") {
			if (table==1 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==2 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==3 && (noVowelIndicators)) { shouldBePressed = true; }
			else if (table==4 && (moreOnIndicators)) { shouldBePressed = true; }
		}
		else if (color=="lime") {
			if (table==1 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==2 && (moreParallel)) { shouldBePressed = true; }
			else if (table==3 && (warm)) { shouldBePressed = true; }
			else if (table==4 && (oddNoPlates)) { shouldBePressed = true; }
		}
		else if (color=="orange") {
			if (table==1 && (oddNoPlates)) { shouldBePressed = true; }
			else if (table==2 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==3 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==4 && (moreParallel)) { shouldBePressed = true; }
		}
		else if (color=="pink") {
			if (table==1 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==2 && (moreParallel)) { shouldBePressed = true; }
			else if (table==3 && (warm)) { shouldBePressed = true; }
			else if (table==4 && (warm)) { shouldBePressed = true; }
		}
		else if (color=="purple") {
			if (table==1 && (moreParallel)) { shouldBePressed = true; }
			else if (table==2 && (noVowelIndicators)) { shouldBePressed = true; }
			else if (table==3 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==4 && (moreParallel)) { shouldBePressed = true; }
		}
		else if (color=="red") {
			if (table==1 && (oddNoPlates)) { shouldBePressed = true; }
			else if (table==2 && (oddNoPlates)) { shouldBePressed = true; }
			else if (table==3 && (moreParallel)) { shouldBePressed = true; }
			else if (table==4 && (moreOnIndicators)) { shouldBePressed = true; }
		}
		else if (color=="white") {
			if (table==1 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==2 && (noVowelIndicators)) { shouldBePressed = true; }
			else if (table==3 && (moreOnIndicators)) { shouldBePressed = true; }
			else if (table==4 && (twoNoDuplicates)) { shouldBePressed = true; }
		}
		else if (color=="yellow") {
			if (table==1 && (oddNoPlates)) { shouldBePressed = true; }
			else if (table==2 && (warm)) { shouldBePressed = true; }
			else if (table==3 && (twoNoDuplicates)) { shouldBePressed = true; }
			else if (table==4 && (noVowelIndicators)) { shouldBePressed = true; }
		}
		else { shouldBePressed = false; }

		return shouldBePressed;
	}
}
class statusLight {
	public GameObject StatusLight;
	public int id;

	public statusLight(GameObject statusLightObject, int statusLightId, Material statusLightColor) {
		StatusLight = statusLightObject;
		id = statusLightId;
		StatusLight.GetComponent<Renderer>().material = new Material(statusLightColor);
	}
}

class LED {
	public GameObject led;
	public int id;
	public string color;

	public LED(GameObject ledObject, int ledId, Material ledColor) {
		led = ledObject;
		id = ledId;
		led.GetComponent<Renderer>().material = new Material(ledColor);
		color = ledColor.name.Substring(0, ledColor.name.IndexOf("L"));
	}
}

public class technicalButtonsScript : MonoBehaviour {

	public KMBombInfo Bomb;
	public KMAudio Audio;


	public Material[] buttonColorChoices;
	public Material[] ledColorChoices; 
	public Material[] statusLightColors;

	public KMSelectable[] _keypadButtons;
	button[] keypadButtons;
	Dictionary<string, int> buttonColorOccurrence = new Dictionary<string, int>();
	public GameObject[] _buttonStatusLights;
	statusLight[] statusLights;
	public float statusLightFlashTime;
	public GameObject[] _LEDs;
	LED[] LEDs;

	List<button> solvedButtons = new List<button>();

	float buttonIndex;

	// Table parameters
	bool oneBlueLED;
	bool oneRedLED;
	bool DBatteries;
	bool serialEven;
	int table;

	// Button parameters
	bool moreOnIndicators;
	bool oddNoPlates;
	bool noVowelIndicators;
	bool containsVowel = false;
	int numVowels;
	bool duplicates;
	bool moreParallel;
	bool warm;


	// Logging
	static int moduleIdCounter = 1;
	int moduleId;
	private bool moduleSolved;

	// Use this for initialization
	void Start () {
		moduleId = moduleIdCounter++;

		// Initialize button status light array 
		List<statusLight> statusLightTemp = new List<statusLight>();
		for (int i = 0; i < _buttonStatusLights.Length; i++) {
			statusLightTemp.Add(new statusLight(_buttonStatusLights[i], i, statusLightColors[0]));
		}
		statusLights = statusLightTemp.ToArray();


		// Initialize button led array 
		List<LED> LEDsTemp = new List<LED>();
		for (int i = 0; i < _LEDs.Length; i++) {
			LEDsTemp.Add(new LED(_LEDs[i], i, ledColorChoices[UnityEngine.Random.Range(0, ledColorChoices.Length)]));
		}
		LEDs = LEDsTemp.ToArray();

		List<button> keypadButtonsTemp = new List<button>();
		int solveableButtons;
		do {
			// Initialize button object array
			keypadButtonsTemp.Clear();
			for (int i = 0; i < _keypadButtons.Length; i++) {
				keypadButtonsTemp.Add(new button(_keypadButtons[i], i, buttonColorChoices[UnityEngine.Random.Range(0, buttonColorChoices.Length)]));
			}
			keypadButtons = keypadButtonsTemp.ToArray();

			setBools();

			solveableButtons = 0;
			foreach (button Button in keypadButtons) {
				if (Button.checkShouldBePressed(buttonColorOccurrence, table, moreOnIndicators, oddNoPlates, noVowelIndicators, moreParallel, warm)) { solveableButtons++; }
			}
		} while (solveableButtons==0);

		// Add the on click function for buttons
		foreach (button Button in keypadButtons) {
			Button.Button.OnInteract += delegate () { keypadPress(Button); return false; };
		}

		foreach (LED led in LEDs) {
			Debug.Log("[Technical Buttons #" + moduleId + "] " + "LED #" + led.id + " is " + led.color);
		}
		foreach (button Button in keypadButtons) {
			Debug.Log("[Technical Buttons #" + moduleId + "] " + "Button #" + Button.id + " is " + Button.color);
		}
		Debug.Log("[Technical Buttons #" + moduleId + "] " + "Table to be used: " + table);

		foreach (button Button in keypadButtons) {
			if (!Button.shouldBePressed) {
				solvedButtons.Add(Button);
			}
			Debug.Log("[Technical Buttons #" + moduleId + "] " + "Button ID: " + Button.id + ", Should be pressed: " + Button.shouldBePressed);
		}
	}

	void Strike(button Button) {
		GetComponent<KMBombModule>().HandleStrike();
		statusLights[Button.id].StatusLight.GetComponent<Renderer>().material = new Material(statusLightColors[1]);
		StartCoroutine(resetStatusLightColor(Button));
	}

	IEnumerator resetStatusLightColor(button Button) {
		yield return new WaitForSeconds(statusLightFlashTime);
		statusLights[Button.id].StatusLight.GetComponent<Renderer>().material = new Material(statusLightColors[0]);
	}

	void moduleSolve() {
		GetComponent<KMBombModule>().HandlePass();
		moduleSolved = true;
		foreach (button Button in keypadButtons) {
			try { Destroy(Button.Button.transform.GetChild(0).gameObject); } catch { }
		}
	}
	void buttonSolve(button Button) {
		Destroy(Button.Button.transform.GetChild(0).gameObject);
		statusLights[Button.id].StatusLight.GetComponent<Renderer>().material = new Material(statusLightColors[2]);
		GetComponent<KMAudio>().HandlePlayGameSoundAtTransformWithRef(KMSoundOverride.SoundEffect.ButtonPress, transform);
		solvedButtons.Add(Button);
		Debug.Log("[Technical Buttons #" + moduleId + "] " + "Passed id: " + Button.id);

		if (keypadButtons.Length==solvedButtons.ToArray().Length) { moduleSolve(); }
	}

	void setBools() {
		// Check for one blue LED
		foreach (LED led in LEDs) {
			if (led.color=="blue") {
				if (oneBlueLED) {
					oneBlueLED = false;
					break;
				}
				oneBlueLED = true;
			}
		}

		// Check for one red LED
		foreach (LED led in LEDs) {
			if (led.color=="red") {
				if (oneRedLED) {
					oneRedLED = false;
					break;
				}
				oneRedLED = true;
			}
		}

		// Check for 1 or more D-type batteries
		DBatteries = (Bomb.GetBatteryCount(Battery.D)>=1);

		// Check for serial number total is even
		int total = 0;
		foreach (int num in Bomb.GetSerialNumberNumbers()) { total+=num; }
		serialEven = (total%2==0);


		// Check for no unlit indicators
		moreOnIndicators = (Bomb.GetOffIndicators().Count()<Bomb.GetOnIndicators().Count());

		// Check for odd number of port plates
		oddNoPlates = (Bomb.GetPortPlateCount()%2==1);

		// Check for lit indicators not including any vowels
		if (Bomb.GetOnIndicators().Count()!=0) {
			foreach (string indicator in Bomb.GetOnIndicators()) {
				foreach (char letter in indicator) {
					if (letter=='A' || letter=='E' || letter=='I' || letter=='O' || letter=='U') {
						containsVowel = true;
						break;
					}
				}
				if (containsVowel) { break; }
			}
		}
		noVowelIndicators = (!containsVowel);

		// Check for 2 or more of the same colour including the pressed button and no other duplicates
		string[] buttonColors = new string[keypadButtons.Length];
		for (int i = 0; i < keypadButtons.Length; i++) {
			buttonColors[i] = keypadButtons[i].color;
		}

        foreach(string color in buttonColors) {
        	if (buttonColorOccurrence.ContainsKey(color)) {
        		buttonColorOccurrence[color]++;
			}
        	else {
        		buttonColorOccurrence[color] = 1;
			}
        }
		// Rest will be checked on button press

		// Check for more parallel ports than serial ports
		moreParallel = (Bomb.GetPortCount(Port.Parallel)>Bomb.GetPortCount(Port.Serial));

		// Check for warm colours
		warm = false;
		foreach (button Button in keypadButtons) {
			if (Button.color=="dark red" || Button.color=="red" || Button.color=="orange" || Button.color=="yellow") {
				warm = true;
				break;
			}
		}

		// Sets the table to be used
		if (!oneBlueLED && !oneRedLED && !DBatteries && !serialEven) 		{ table = 3; }		// 0000
		else if (!oneBlueLED && !oneRedLED && !DBatteries && serialEven) 	{ table = 3; }		// 0001
		else if (!oneBlueLED && !oneRedLED && DBatteries && !serialEven) 	{ table = 4; }		// 0010
		else if (!oneBlueLED && !oneRedLED && DBatteries && serialEven) 	{ table = 1; }		// 0011
		else if (!oneBlueLED && oneRedLED && !DBatteries && !serialEven) 	{ table = 2; }		// 0100
		else if (!oneBlueLED && oneRedLED && !DBatteries && serialEven) 	{ table = 3; }		// 0101
		else if (!oneBlueLED && oneRedLED && DBatteries && !serialEven) 	{ table = 2; }		// 0110
		else if (!oneBlueLED && oneRedLED && DBatteries && serialEven) 		{ table = 1; }		// 0111
		else if (oneBlueLED && !oneRedLED && !DBatteries && !serialEven) 	{ table = 1; }		// 1000
		else if (oneBlueLED && !oneRedLED && !DBatteries && serialEven) 	{ table = 4; }		// 1001
		else if (oneBlueLED && !oneRedLED && DBatteries && !serialEven) 	{ table = 2; }		// 1010
		else if (oneBlueLED && !oneRedLED && DBatteries && serialEven) 		{ table = 4; }		// 1011
		else if (oneBlueLED && oneRedLED && !DBatteries && !serialEven) 	{ table = 4; }		// 1100
		else if (oneBlueLED && oneRedLED && !DBatteries && serialEven) 		{ table = 3; }		// 1101
		else if (oneBlueLED && oneRedLED && DBatteries && !serialEven) 		{ table = 1; }		// 1110
		else if (oneBlueLED && oneRedLED && DBatteries && serialEven) 		{ table = 2; }		// 1111

		foreach (button Button in keypadButtons) {
			Button.checkShouldBePressed(buttonColorOccurrence, table, moreOnIndicators, oddNoPlates, noVowelIndicators, moreParallel, warm);
		}
	}

	bool checkForSolve(button Button){
		bool solved = false;

		if (Button.color=="black") {
			if (table==1 && (oddNoPlates)) 					{ solved = true; }
			else if (table==2 && (moreParallel)) 			{ solved = true; }
			else if (table==3 && (moreOnIndicators)) 		{ solved = true; }
			else if (table==4 && (oddNoPlates)) 			{ solved = true; }
		} 
		else if (Button.color=="blue") {
			if (table==1 && (noVowelIndicators)) 			{ solved = true; }
			else if (table==2 && (moreParallel)) 			{ solved = true; }
			else if (table==3 && (Button.twoNoDuplicates)) 	{ solved = true; }
			else if (table==4 && (noVowelIndicators)) 		{ solved = true; }
		}
		else if (Button.color=="brown") {
			if (table==1 && (moreParallel)) 				{ solved = true; }
			else if (table==2 && (moreOnIndicators)) 		{ solved = true; }
			else if (table==3 && (noVowelIndicators)) 		{ solved = true; }
			else if (table==4 && (moreOnIndicators)) 		{ solved = true; }
		}
		else if (Button.color=="cream") {
			if (table==1 && (Button.twoNoDuplicates)) 		{ solved = true; }
			else if (table==2 && (moreParallel)) { solved = true; }
			else if (table==3 && (moreParallel)) { solved = true; }
			else if (table==4 && (noVowelIndicators)) { solved = true; }
		}
		else if (Button.color=="cyan") {
			if (table==1 && (warm)) { solved = true; }
			else if (table==2 && (moreOnIndicators)) { solved = true; }
			else if (table==3 && (moreOnIndicators)) { solved = true; }
			else if (table==4 && (Button.twoNoDuplicates)) { solved = true; }
		}
		else if (Button.color=="dark green") {
			if (table==1 && (moreParallel)) { solved = true; }
			else if (table==2 && (noVowelIndicators)) { solved = true; }
			else if (table==3 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==4 && (noVowelIndicators)) { solved = true; }
		}
		else if (Button.color=="dark red") {
			if (table==1 && (warm)) { solved = true; }
			else if (table==2 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==3 && (moreParallel)) { solved = true; }
			else if (table==4 && (warm)) { solved = true; }
		}
		else if (Button.color=="light blue") {
			if (table==1 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==2 && (moreOnIndicators)) { solved = true; }
			else if (table==3 && (noVowelIndicators)) { solved = true; }
			else if (table==4 && (moreOnIndicators)) { solved = true; }
		}
		else if (Button.color=="lime") {
			if (table==1 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==2 && (moreParallel)) { solved = true; }
			else if (table==3 && (warm)) { solved = true; }
			else if (table==4 && (oddNoPlates)) { solved = true; }
		}
		else if (Button.color=="orange") {
			if (table==1 && (oddNoPlates)) { solved = true; }
			else if (table==2 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==3 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==4 && (moreParallel)) { solved = true; }
		}
		else if (Button.color=="pink") {
			if (table==1 && (moreOnIndicators)) { solved = true; }
			else if (table==2 && (moreParallel)) { solved = true; }
			else if (table==3 && (warm)) { solved = true; }
			else if (table==4 && (warm)) { solved = true; }
		}
		else if (Button.color=="purple") {
			if (table==1 && (moreParallel)) { solved = true; }
			else if (table==2 && (noVowelIndicators)) { solved = true; }
			else if (table==3 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==4 && (moreParallel)) { solved = true; }
		}
		else if (Button.color=="red") {
			if (table==1 && (oddNoPlates)) { solved = true; }
			else if (table==2 && (oddNoPlates)) { solved = true; }
			else if (table==3 && (moreParallel)) { solved = true; }
			else if (table==4 && (moreOnIndicators)) { solved = true; }
		}
		else if (Button.color=="white") {
			if (table==1 && (moreOnIndicators)) { solved = true; }
			else if (table==2 && (noVowelIndicators)) { solved = true; }
			else if (table==3 && (moreOnIndicators)) { solved = true; }
			else if (table==4 && (Button.twoNoDuplicates)) { solved = true; }
		}
		else if (Button.color=="yellow") {
			if (table==1 && (oddNoPlates)) { solved = true; }
			else if (table==2 && (warm)) { solved = true; }
			else if (table==3 && (Button.twoNoDuplicates)) { solved = true; }
			else if (table==4 && (noVowelIndicators)) { solved = true; }
		}
		
		return solved;
	}
	
	void keypadPress(button Button) {
		if (moduleSolved || Button.solved) { return; }
		Button.Button.AddInteractionPunch();

		Debug.Log("[Technical Buttons #" + moduleId + "] " + "Button ID: " + Button.id + ", Button colour: " + Button.color + ", Color occurrences: " + buttonColorOccurrence[Button.color]);

		Button.solved = Button.checkShouldBePressed(buttonColorOccurrence, table, moreOnIndicators, oddNoPlates, noVowelIndicators, moreParallel, warm);
		if (Button.solved) { buttonSolve(Button); }
		else { Strike(Button); }
	}
	
	//twitch plays
    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"To press a button on the module, use the command !{0} press [N/NE/E/SE/S/SW/W/NW]";
    #pragma warning restore 414
	
	List<string> PressedButtons = new List<string>();
	string[] ValidButtons = {"N", "NE", "E", "SE", "S", "SW", "W", "NW"};
	
	IEnumerator ProcessTwitchCommand(string command)
    {
		string[] parameters = command.Split(' ');
		if (Regex.IsMatch(parameters[0], @"^\s*press\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			yield return null;
			if (parameters.Length != 2)
			{
				yield return "sendtochaterror Parameter length invalid. Command ignored.";
				yield break;
			}
			
			if (!ValidButtons.Contains(parameters[1].ToUpper()))
			{
				yield return "sendtochaterror Button position is invalid. Command ignored.";
				yield break;
			}
			
			if (PressedButtons.Contains(parameters[1].ToUpper()))
			{
				yield return "sendtochaterror This button position has been pressed. Command ignored.";
				yield break;
			}
			
			_keypadButtons[Array.IndexOf(ValidButtons, parameters[1].ToUpper())].OnInteract();
			PressedButtons.Add(parameters[1].ToUpper());
		}
	}
}
