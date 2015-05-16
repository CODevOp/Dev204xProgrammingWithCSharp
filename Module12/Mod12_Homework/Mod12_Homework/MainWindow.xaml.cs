using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Mod12_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {
            ///////////////// OPTION 1 /////////////////////////////////
            //accordint to classmate this should be changed to a sync method but that is not possible.
            //events do not return data to their callers.
            // DOES NOT WORK: await WriteFileAsync();

            ///////////////// OPTION 2 /////////////////////////////////
            // modify this to use a task. To that the text field must be sent to metod
            // WORKS: 
            string text = txtContents.Text;
            Task writeFileTask = new Task<Task>(() => WriteFileAsync(text));
            writeFileTask.Start();

            ///////////////// OPTION 3 /////////////////////////////////
            // modify this to use a task. To that the text field must be sent to metod
            // DOES not work WORKS: needs to be new Task<t> 
            //string text = txtContents.Text;
            //Task writeFileTask = new Task(() => WriteFileAsync(text));
            //writeFileTask.Start();

            ///////////////// OPTION 4 /////////////////////////////////
            // modify this to use a task. To that the text field must be sent to metod
            // This simply runs a new task.
            // WORKS: 
            //string text = txtContents.Text;
            //Task.Run(() => WriteFileAsync(text));           


            
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            ReadFileAsync();
        }

        async public Task WriteFileAsync(string text )
        {
            string filePath = @"SampleFile.txt";           

            await WriteTextAsync(filePath, text);
        }
        //include Async in its name
        //Return a Task
        //Make the method asynchronous with the correct method modifer
        async private Task WriteTextAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                //changed from Write to WriteAync
                await sourceStream.WriteAsync (encodedText, 0, encodedText.Length);
            };

            Thread.Sleep(5000);
            Console.Beep(2000, 500);
        }

        async public void ReadFileAsync()
        {
            string filePath = @"SampleFile.txt";

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(filePath + " not found", "File Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    string text = await ReadTextAsync(filePath);
                    txtContents.Text = text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        async private Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The write button is full asynchronous. The read button will still lock up if the task run is too long.");
        }

    }
}
