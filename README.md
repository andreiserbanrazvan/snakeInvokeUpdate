# snakeInvokeUpdate
 prototype snakelike
 
 
 cool way alternative To Using Update is using Invoke inside Start and another method . without having to use delta time that is probably bad since other more slower or more performant cpu might run different. 
 
public class Snake : MonoBehaviour
{
    public GameObject snakeBit;
    public float spawnTime=0.5f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("MoveSnake",spawnTime);
    }

    void MoveSnake()
    {
        Instantiate(snakeBit, transform.position, transform.rotation);
       int turnDirection = Random.Range(0, 3);
        if (turnDirection == 1)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        else if(turnDirection == 2)
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
      
        transform.position += transform.forward;
        Invoke("MoveSnake", spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 from the Y view without deleting the snakes body , this procedure could make a fine animation for procedural generation , in a simple game
![alt-text](https://github.com/andreiserbanrazvan/snakeInvokeUpdate/blob/main/snake.PNG)
