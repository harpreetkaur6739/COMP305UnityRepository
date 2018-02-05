using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public GameObject character;
    private Rigidbody2D rBody;
    public Sprite pinkSprite;
    public Sprite greenSprite;
    public Sprite blueSprite;
    private SpriteRenderer sRenderer;

	// Use this for initialization
	void Start () {
        Debug.Log("Entered");
        rBody = character.GetComponent<Rigidbody2D>();
        sRenderer = rBody.GetComponent<SpriteRenderer>();

    }
	
	
	void OnMouseDown () {
        Debug.Log("Clicked");
        Debug.Log(this.name);
        if (this.name == "Btn_Blue") {
            sRenderer.sprite = blueSprite;
        } else if (this.name == "Btn_Green") {
            sRenderer.sprite = greenSprite;
        } else if (this.name == "Btn_Pink") {
            sRenderer.sprite = pinkSprite;
        }
    }
}
