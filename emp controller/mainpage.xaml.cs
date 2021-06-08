using System;
using System.Windows.Controls;
using emp_controller.config;

namespace emp_controller
{
    public partial class mainpage : Page
    {
        public mainpage()
        {
            
            InitializeComponent();
            GUIConsole writer = new GUIConsole(GUIConsoleTextBox);
            Console.SetOut(writer);
        }
    }
}