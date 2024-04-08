using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CuoiKy.Program;

namespace winform_test
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());                        
        }       
    }
    internal class GlobalData
    {
        public static BinarySearchTree BinarySearchTree { get; } = new BinarySearchTree();
    }
}
