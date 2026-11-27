using UnityEngine;

public class clue : MonoBehaviour
{
    bool isHovering = false;

    Outline outline;


    private void Awake()
    {
        outline = GetComponent<Outline>();        
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OnHover()
    {
        Debug.Log("I WAS HOVERED");
    }
    public void OnClick()
    {
        Debug.Log("I WAS CLICKED");
    }

    private void OnMouseExit()
    {
        outline.enabled = false;
        outline.OutlineWidth = 0;

        isHovering = false;

    }

    private void OnMouseEnter()
    {
        outline.enabled = true;
        outline.OutlineWidth = 1;

        isHovering = true;

        Debug.Log("I WAS HOVERED");
    }
}
