namespace BinarySearchTreeProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Hash Table and Bst problem*****");
            BinarySearchTree<int> obj = new BinarySearchTree<int>(56);
            obj.Add(30);
            obj.Add(70);
            obj.Add(22);
            obj.Add(40);
            obj.Add(60);
            obj.Add(95);
            obj.Add(11);
            obj.Add(65);
            obj.Add(3);
            obj.Add(16);
            obj.Add(63);
            obj.Add(67);
            obj.Display();
            obj.Size();
            bool result = obj.IfExists(63, obj);
            Console.WriteLine(result);

        }
    }
}