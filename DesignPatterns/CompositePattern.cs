using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Let's say you're building a file system where both files and directories can be treated as individual 
     * entities. A directory can contain both files and other directories. The Composite pattern allows you 
     * to treat both files and directories uniformly.
    */

    /*Explanation:
     * Component (FileSystemItem):
     * This is the abstract base class for both files and directories.
     * It defines the Display() method that will be implemented by the concrete classes.
     * 
     * Leaf (File):
     * This class represents the leaf nodes in the tree structure, which are files.
     * It implements the Display() method to show the file name.
     * 
     * Composite (Directory):
     * This class represents the composite nodes in the tree structure, which are directories.
     * It contains a list of FileSystemItem objects (both files and directories).
     * The Display() method is implemented to recursively show the directory and its contents.
     * 
     * Client (Program):
     * The client creates a file system structure by adding files and directories.
     * It uses the Display() method to print the structure.
    */

    // Component
    public abstract class FileSystemItem
    {
        protected string name;

        public FileSystemItem(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }

    // Leaf
    public class File : FileSystemItem
    {
        public File(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " File: " + name);
        }
    }

    // Composite
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> items = new List<FileSystemItem>();

        public Directory(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            items.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            items.Remove(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Directory: " + name);

            foreach (FileSystemItem item in items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
