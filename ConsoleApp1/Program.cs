namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                {0, 1, 1, 1, 0, 1, 1, 1}, //0
                {0, 1, 1, 1, 0, 1, 1, 1},//1
                {0, 0, 1, 0, 1, 0, 0, 1},//2
                {0, 0, 1, 0, 1, 1, 0, 1},//3
                {0, 1, 1, 1, 0, 1, 0, 0},//4
                {0, 1, 0, 0, 0, 1, 0, 0},//5
                {0, 1, 1, 1, 0, 1, 1, 1},//6
                {0, 0, 0, 1, 1, 1, 0, 1},//7
                
            };
            RatInMaze rmz = new RatInMaze(arr);
            rmz.Run(1, 1);
        }
    }
}