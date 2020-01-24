using UnityEngine;

public class GetScript : MonoBehaviour
{
    public bool redGemA;
    public GameObject redGem;
    private bool entered;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && entered == true)
        {
            Debug.Log("EEEE");
            redGemA = true;
            redGem.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Red Gem"))
        {
            entered = true;
          
        }
    }
}
