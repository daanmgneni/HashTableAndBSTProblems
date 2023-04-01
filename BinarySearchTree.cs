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

        int leftcount = 0;
        int rightcount = 0;

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
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Data.ToString());
            if (this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }
    }

}
