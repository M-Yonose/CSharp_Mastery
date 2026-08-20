class Car
{
    int capacity;
    int fuel;
    
    void fill(int amount)
    {
        fuel += amount;
        if(fuel > capacity)
        {
            fuel = capacity;
        }
    }
}