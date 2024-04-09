using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransfusionScript : MonoBehaviour
{
    public static GameObject onButton;

    private bool isPressed = false;
    private float pressedTimer = 0f;
    public float TimeForLongPress = 4f;

    public GameObject up;
    public GameObject up1;
    public GameObject down;
    public GameObject down1;

    public GameObject origbag;
    public GameObject destbag;

    public float maxPanel = -70.51499f;
    public float minPanel = 402.98f;

    public bool hasWinded;

    private void OnMouseDown()
    {
        Debug.Log("did thing");
        isPressed = true;
        up.GetComponent<ParticleSystem>().Play();
        up1.GetComponent<ParticleSystem>().Play();
        down.GetComponent<ParticleSystem>().Play();
        down1.GetComponent<ParticleSystem>().Play();

    }

    private void OnMouseUpAsButton()
    {
        if (pressedTimer >= TimeForLongPress)
        {
            resetall();
            GameObject.Find("SceneManager").GetComponent<CharacterScrip>().skin.SetActive(true);
            GameObject.Find("SceneManager").GetComponent<CharacterScrip>().organControllerObject.GetComponent<OrganController>().minigameComplete = true;
            Destroy(gameObject.transform.parent.transform.parent.transform.parent.gameObject);
            hasWinded = true;
        }
        else
        {
            Debug.Log("Mouse button released early!");
            resetall();
        }
    }

    public void resetall()
    {
        isPressed = false;
        pressedTimer = 0f;
        up.GetComponent<ParticleSystem>().Stop();
        up1.GetComponent<ParticleSystem>().Stop();
        down.GetComponent<ParticleSystem>().Stop();
        down1.GetComponent<ParticleSystem>().Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (isPressed)
        {
            pressedTimer += Time.deltaTime;
            Debug.Log("Timer: " + pressedTimer);
        }
    }

    public void FixedUpdate()
    {
        //this will make the top of destbag go up to maxPanel as the origbag goes down to minPanel and will reset if win condition isnt met but remain if it is
        if (!hasWinded)
        {
            if (isPressed)
            {
                //origbag.GetComponent<RectTransform>().
                origbag.GetComponent<RectTransform>().localScale = new Vector3(
                    origbag.GetComponent<RectTransform>().localScale.x,
                    Mathf.Clamp(origbag.GetComponent<RectTransform>().localScale.y - 0.01f, 0.1f, 1f),
                    origbag.GetComponent<RectTransform>().localScale.z);
                destbag.GetComponent<RectTransform>().localScale = new Vector3(
                    destbag.GetComponent<RectTransform>().localScale.x,
                    Mathf.Clamp(destbag.GetComponent<RectTransform>().localScale.y + 0.01f, 0.1f, 1f),
                    destbag.GetComponent<RectTransform>().localScale.z);
            }
            else
            {
                origbag.GetComponent<RectTransform>().localScale = new Vector3(
                    origbag.GetComponent<RectTransform>().localScale.x,
                    Mathf.Clamp(origbag.GetComponent<RectTransform>().localScale.y + 0.01f, 0.1f, 1f),
                    origbag.GetComponent<RectTransform>().localScale.z);
                destbag.GetComponent<RectTransform>().localScale = new Vector3(
                    destbag.GetComponent<RectTransform>().localScale.x,
                    Mathf.Clamp(destbag.GetComponent<RectTransform>().localScale.y - 0.01f, 0.1f, 1f),
                    destbag.GetComponent<RectTransform>().localScale.z);
                //the current code doesnt account for the scale making the bottom of the panel lift up so here is the fix
                if (origbag.GetComponent<RectTransform>().localScale.y >= 1f)
                {
                    origbag.GetComponent<RectTransform>().localScale = new Vector3(
                        origbag.GetComponent<RectTransform>().localScale.x, 1f,
                        origbag.GetComponent<RectTransform>().localScale.z);
                }

                if (destbag.GetComponent<RectTransform>().localScale.y <= 0.1f)
                {
                    destbag.GetComponent<RectTransform>().localScale = new Vector3(
                        destbag.GetComponent<RectTransform>().localScale.x, 0.1f,
                        destbag.GetComponent<RectTransform>().localScale.z);
                }
            }
        }
    }

}
