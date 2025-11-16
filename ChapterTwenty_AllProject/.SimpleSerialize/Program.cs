using SimpleSerialize;

Console.WriteLine("Fun With Object Serialization");
JamesBondCar jms = new()
{
    CanFly = true,
    CanSubmerge = false,
    TheRadio = new()
    {
        StationPresets = new() {89.3, 105.1, 97.1},
        HasTweeters = true
    }
};
Person p = new()
{
    FirstName = "James",
    IsAlive = true,
};