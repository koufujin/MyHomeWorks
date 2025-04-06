namespace TMS_HomeWork11;

public class Pair<T1, T2>
{
    private T1 value1;
    private T2 value2;

    public Pair(T1 value1, T2 value2)
    {
        this.value1 = value1;
        this.value2 = value2;
    }

    public T1 FirstValue
    {
        get { return value1; }
    }

    public T2 SecondValue
    {
        get { return value2; }
    }
}

