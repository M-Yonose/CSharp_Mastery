class WaterBottle
{
    private readonly int _capacity;
    public int _waterAmount;
    private readonly string _color = "white";
    public string Label { get; set; } = string.Empty;


    public int Capacity
    {
        get
        {
            return _capacity;
        }
    }
    public string Color
    {
        get
        {
            return _color;
        }
    }



    public WaterBottle() : this(300)
    {

    }

    public WaterBottle(int capacity) : this(capacity, "green")
    {
        Label = string.Empty;
    }

    public WaterBottle(int capacity, string color)
    {
        if (capacity < 0)
            _capacity = 0;
        else
            _capacity = capacity;

        _color = Color;
    }

    public void fill(int amount)
    {
        _waterAmount += amount;
        if (_waterAmount > _capacity)
        {
            _waterAmount = _capacity;
        }

    }
}
//public string GetColor()
//{
//    return _color;

//}
//public int GetWataerAmount()
//{
//    return waterAmount;
//}
//public int GetCapacity()
//{
//    return _capacity;
//}

//    public WaterBottle()
//    {
//        _capacity = 300;
//        _color = "black";
//    }


//    public WaterBottle(int capacity, string color)
//    {
//        _capacity = capacity;
//        _color = color;
//    }
//    void fill(int amount)
//    {
//        waterAmount += amount;
//        if(waterAmount > _capacity)
//        {
//            waterAmount = _capacity;
//        }
//    }
//}
