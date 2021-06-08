using System;
using System.IO;
using System.Windows;
using emp_controller.config;

namespace emp_controller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
             
            string configPath = @"InstallationConfig.json";
            if (File.Exists(configPath))
            {
                string text = File.ReadAllText(configPath);
                InstallationConfig.FromJson(text);
                

            }
            else
            {
                InstallationConfig installationConfig = new InstallationConfig
                {
                    Nginx = new config.config {Date = "", Installed = false, Path = ""},
                    Php = new config.config {Date = "", Installed = false, Path = ""},
                    Phpmyadmin = new config.config {Date = "", Installed = false, Path = ""},
                    Mysql = new config.config {Date = "", Installed = false, Path = ""}
                };


                File.WriteAllText(configPath, installationConfig.ToJson());
                Console.WriteLine("wrote file");
                
            }
            
            // Read the file as one string.
            InitializeComponent();
         
        }
     
    }
 
}
