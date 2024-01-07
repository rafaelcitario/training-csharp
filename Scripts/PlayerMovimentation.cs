using System.Collections;
using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{
    float speedMoviment;
    bool playerCanDash = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DashPlayer();
    }

    void FixedUpdate()
    {

        MovimentationPlayer();
    }

    public void MovimentationPlayer()
    {
        float horizontalMovimentationPlayer = Input.GetAxisRaw("Horizontal");
        float verticalMovimentationPlayer = Input.GetAxisRaw("Vertical");
        bool isHorizontalMovimentationPlayerAble = horizontalMovimentationPlayer > 0;
        bool isVerticalMovimentationPlayerAble = verticalMovimentationPlayer > 0;
        bool isDiagonalMovimentationPlayerAble = isHorizontalMovimentationPlayerAble && isVerticalMovimentationPlayerAble;
        speedMoviment = this.GetComponent<EntityStats>().basicSpeedMoviment;

        switch (isHorizontalMovimentationPlayerAble)
        {
            case true:
                gameObject.transform.Translate(new Vector3(horizontalMovimentationPlayer * speedMoviment * Time.deltaTime, 0));
                break;
            case false:
                gameObject.transform.Translate(new Vector3(horizontalMovimentationPlayer * speedMoviment * Time.deltaTime, 0));
                break;
        }
        switch (isVerticalMovimentationPlayerAble)
        {
            case true:
                gameObject.transform.Translate(new Vector3(0, verticalMovimentationPlayer * speedMoviment * Time.deltaTime));
                break;
            case false:
                gameObject.transform.Translate(new Vector3(0, verticalMovimentationPlayer * speedMoviment * Time.deltaTime));
                break;
        }
        switch (isDiagonalMovimentationPlayerAble)
        {
            case true:
                gameObject.transform.Translate(new Vector3(horizontalMovimentationPlayer * speedMoviment / 2 * Time.deltaTime, verticalMovimentationPlayer * speedMoviment / 2 * Time.deltaTime));
                break;
            case false:
                gameObject.transform.Translate(new Vector3(horizontalMovimentationPlayer * speedMoviment / 2 * Time.deltaTime, verticalMovimentationPlayer * speedMoviment / 2 * Time.deltaTime));
                break;
        }

    }

    public void DashPlayer()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && playerCanDash)
        {
            playerCanDash = false;
            GetComponent<EntityStats>().basicSpeedMoviment += 10;
            StartCoroutine(waiter());

        }
    }

    IEnumerator waiter()
    {

        yield return new WaitForSeconds(0.1f);
        GetComponent<EntityStats>().basicSpeedMoviment -= 10;
        yield return new WaitForSeconds(1f);
        playerCanDash = true;

    }

}
