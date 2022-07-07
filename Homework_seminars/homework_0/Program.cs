internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0, distance = 10000, FirstFriendSpeed = 1, SecondFriendSpeed = 2, DogSpeed = 5, Friend = 2, time;


        while (distance > 10)
        {
            if (Friend == 1)
            {
                time = distance / (FirstFriendSpeed + DogSpeed);
                Friend = 2;
            }
            else
            {
                time = distance / (SecondFriendSpeed + DogSpeed);
                Friend = 1;
            }
            distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
            count++;
        }
        Console.WriteLine(count);
    }
}