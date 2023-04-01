namespace BinarySearchTreeProgram
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T Data)
        {
            this.Data = Data;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;

        public void Add(T item)
        {
            T currentValue = this.Data;
            if (currentValue.CompareTo(item) > 0)
            {
                if (LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else { this.LeftTree.Add(item); }
            }

            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Add(item);
            }
        }


        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Data.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        //SIZE
        public void Size()
        {
            Console.WriteLine("Size" + " " + (7 * (this.leftCount + this.rightCount) - 1));
        }
    }

}
