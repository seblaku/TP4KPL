public class DoorMachine
{
    private enum State { Terkunci, Terbuka }

    private State currentState = State.Terkunci;

    private void SetState(State newState)
    {
        currentState = newState;

        // Pesan muncul saat STATE MASUK
        if (currentState == State.Terkunci)
            Console.WriteLine("Pintu terkunci");
        else if (currentState == State.Terbuka)
            Console.WriteLine("Pintu tidak terkunci");
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
            SetState(State.Terbuka);
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
            SetState(State.Terkunci);
    }
}