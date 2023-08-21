using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchControl : Singleton
{
    public GameObject PlayerController;
    public GameObject PlayerCharacter;
    public float CharacterSpeed = 1;
    public float speedOnLevel;
    public bool canRun;
    public Vector2 pastPosition;
    public GameObject endScreen;
    public AnimationManager animationManager;
    public ScaleAnimation scaleAnimation;
    public ParticleSystem deadParticle;
    private bool died;
    public override void Awake()
    {
        base.Awake();
        transform.localScale = new Vector3(0, 0, 0);
    }
    void Start()
    {
        animationManager.Play(AnimationManager.AnimationTypes.IDLE);
        scaleAnimation.Animations[0].Tween();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canRun) { return; }
        if(Input.GetMouseButton(0))
        {
            Move(Input.mousePosition.x - pastPosition.x);
        }
        pastPosition = Input.mousePosition;
        Lerp();
    }
    public void Move(float speed)
    {
        PlayerController.transform.position += Vector3.right * Time.deltaTime * speed;
    }
    public void Lerp()
    {
        PlayerCharacter.transform.position = Vector3.Lerp(PlayerCharacter.transform.position, PlayerController.transform.position, CharacterSpeed * Time.deltaTime);
        PlayerController.transform.Translate(PlayerController.transform.forward * speedOnLevel * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            if(!died)
            {
                EndGame();
                scaleAnimation.Animations[2].Tween();
                died = true;
            }
                
                
        }
    }
    public void StartGame()
    {
        canRun = true;
        animationManager.Play(AnimationManager.AnimationTypes.RUN);
    }
    public void EndGame()
    {
        canRun = false;
        endScreen.SetActive(true);
        animationManager.Play(AnimationManager.AnimationTypes.DEAD);
        deadParticle.Play();


    }
    #region POWERUPS
    #region Jump
    public void JumpPowerStart(float s)
    {
        PlayerController.transform.position = new Vector3(PlayerController.transform.position.x, PlayerController.transform.position.y + 4, PlayerController.transform.position.z);
        speedOnLevel += s;
    }
    public void JumpPowerEnd(float s)
    {
        PlayerController.transform.position = new Vector3(PlayerController.transform.position.x, PlayerController.transform.position.y - 4, PlayerController.transform.position.z);
        speedOnLevel -= s;
    }
    #endregion
    public void SpeedUpPowerStart(float f)
    {
        speedOnLevel += f;
    }
    public void SpeedUpPowerEnd(float f)
    {
        speedOnLevel -= f;
    }
    #endregion
}
