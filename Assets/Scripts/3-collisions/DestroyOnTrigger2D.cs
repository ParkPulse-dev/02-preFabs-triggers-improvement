using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField liveText;
    [SerializeField] GameObject spaceship;
    public int hitPoints;// = 3;

    private void Start() {
        hitPoints = 3;
        liveText = GameObject.FindGameObjectWithTag("LiveTag").GetComponent<NumberField>();
        spaceship = GameObject.FindGameObjectWithTag("Player");
        if (this.gameObject.name == "PlayerSpaceship") {
            liveText.SetNumber(hitPoints);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);

            if (this.gameObject.name == "PlayerSpaceship") {
                hitPoints--;
                liveText.SetNumber(hitPoints);
            

                if (hitPoints == 0) {
                    Debug.Log("Game over!");
                    Destroy(this.gameObject);
                    Application.Quit();
                    
                }
            } else {
                spaceship.transform.localScale += new Vector3(0.05f, 0.05f, 0);
                Destroy(this.gameObject);
            }
        }
    }


    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
