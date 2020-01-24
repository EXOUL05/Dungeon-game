using UnityEngine;

public class StatueScript : MonoBehaviour
{
    public GetScript getScript;
    public GameObject redGemStatue;
    private bool statueEntered;

    private void Update()
    {

        if (getScript.redGemA == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && statueEntered == true)
            {
                redGemStatue.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            statueEntered = true;
        }
    }
}
