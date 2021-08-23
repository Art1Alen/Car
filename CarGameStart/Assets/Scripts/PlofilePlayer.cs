public class PlofilePlayer 
{
   public PlofilePlayer(float speed)
    {
        CurrentState = new SubscribeProperty<GameState>();
        CurrentCur = new Car(speed);
    }  
    public SubscribeProperty<GameState> CurrentState { get; }
    public Car CurrentCur { get; }
    
}
