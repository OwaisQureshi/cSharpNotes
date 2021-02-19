using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// https://csharp-video-tutorials.blogspot.com/2016/10/async-and-await-in-c-example.html
/// https://www.youtube.com/watch?v=C5VhaxQWcpE
/// </summary>


namespace WinFormsAsync
{
    public partial class Form1 : Form
    {
        private const string str_FileProcessingMessage = "Processing file. Please wait";
        private const string str_CharsInFile = " characters in file";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Synch_Click(object sender, EventArgs e)
        {
            lbl_btn_Synch.Text = str_FileProcessingMessage;
            lbl_btn_Synch.Refresh();
            int count = CountFileChars();
            lbl_btn_Synch.Text = $"{count} {str_CharsInFile}";
        }

        //Make the method aync by using the keyword
        private async void btn_Asynch_Click(object sender, EventArgs e)
        {
            //create a task to execute CountFileChars() function
            //CountFileChars returns int, so we created Task<int>
            Task<int> task = new Task<int>(CountFileChars);
            task.Start();

            lbl_btn_Asynch.Text = str_FileProcessingMessage;
            //wait until the long running task completed
            int count = await task;
            lbl_btn_Asynch.Text = $"{count} {str_CharsInFile}";
        }

        private int CountFileChars() {
            int count = 0;
            // This will get the current PROJECT directory
            //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName
            var filePath = @"D:\OwaisWorkx\#Code\cSharpNotes2\cSharpNotes\WinFormsAsync\Data\AsyncDummyData.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                count = content.Length;                
                Thread.Sleep(5000);//add 5 sec delay
            }
            return count;
        }
    }
}
