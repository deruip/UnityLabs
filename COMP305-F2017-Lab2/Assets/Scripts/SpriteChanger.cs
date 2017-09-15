using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    public Sprite GreenButton;
    public Sprite RedButton;
    public Sprite PurpleButton;
    public GameObject Human;
    public Sprite GreenSprite;
    public Sprite RedSprite;
    public Sprite PurpleSprite;

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == GreenButton)
        {
            Human.gameObject.GetComponent<SpriteRenderer>().sprite = GreenSprite;
        }
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == RedButton)
        {
            Human.gameObject.GetComponent<SpriteRenderer>().sprite = RedSprite;
        }
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == PurpleButton)
        {
            Human.gameObject.GetComponent<SpriteRenderer>().sprite = PurpleSprite;
        }
    }
}
