using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Runtime.Serialization;

namespace xml
{
    public partial class Form1 : Form
    {
        int wasClicked = 0;
        public delegate void Operation(int num1, int num2, string op);
        //PerformanceCounter MemCount = new PerformanceCounter("Memory", "Available MBytes");
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string file = textBox1.Text;
            try
            {
                using (StreamReader sr = new StreamReader($@"C:\Users\cben2\Desktop\MongoDB\{file}"))
                {
                    Output.Text += sr.ReadToEnd();
                    Output.Text += Environment.NewLine;
                    Output.Text += sr.CurrentEncoding;
                    Output.Text += Environment.NewLine;
                }
            }
            catch (FileNotFoundException ex)
            {
                Output.Text += ex.Message;
                Output.Text += Environment.NewLine;
                //Output.Text += ex.StackTrace;
                //Output.Text += Environment.NewLine;
                Output.Text += "Please Check Filename";
                Output.Text += Environment.NewLine;


            }
            catch (DirectoryNotFoundException ex)
            {
                Output.Text += ex.Message;
                Output.Text += Environment.NewLine;
                //Output.Text += ex.StackTrace;
                //Output.Text += Environment.NewLine;
                Output.Text += "Please Check Directory";
                Output.Text += Environment.NewLine;
            }
            catch (Exception ex)
            {
                Output.Text += ex.Message;
                Output.Text += Environment.NewLine;
                Output.Text += ex.StackTrace;
                Output.Text += Environment.NewLine;
            }
            finally
            {
                Output.Text += "End";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //StringBuilder sb = new StringBuilder($"{(int)MemCount.NextValue()} MB");
            //textBox2.Text = sb.ToString();
        }



        private void divButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\cben2\Desktop\MongoDB\";
            Output2.Text = "";
            
            try
            {
                try
                {
                    StreamWriter swOk = new StreamWriter($"{filePath}Ok.txt", append: true);
                    int num1 = int.Parse(Num1.Text);
                    int num2 = int.Parse(Num2.Text);
                    Output2.Text += num1 + num2
                    Output2.Text += Environment.NewLine;
                    swOk.WriteLine($"Time: {DateTime.Now} Info: {Output2.Text} \n");
                    swOk.Close();
                    if(wasClicked == 1)
                    {
                        throw new ErrorButtonException("Error button was clicked");
                    }
                }
                catch (DivideByZeroException ex)
                {
                    if (File.Exists($"{filePath}Log.txt"))
                    {
                        StreamWriter swLog = new StreamWriter($"{filePath}Log.txt", append: true);
                        Output2.Text += "Cannot Divide By 0";
                        swLog.WriteLine($"Time: {DateTime.Now} Error: {ex.Message}\n");
                        swLog.WriteLine($"Additional Info:\n {ex.StackTrace}\n");
                        swLog.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException($"{filePath}Log.txt was not found", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                StreamWriter swLog = new StreamWriter($"{filePath}Log.txt", append: true);
                swLog.WriteLine($"Current Exception: {ex}");
                Output.Text += ex.Message;
                if(ex.InnerException != null)
                {
                    swLog.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                swLog.Flush();
                swLog.Close();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Error_Click(object sender, EventArgs e)
        {
            wasClicked = 1;
        }

    }
    [Serializable]
    public class ErrorButtonException  : Exception
    {
        public ErrorButtonException() : base()
        {

        }
        public ErrorButtonException(string message) : base(message)
        {

        }

        public ErrorButtonException(string message, Exception innerException) : base(message, innerException) 
        {

        }

        public ErrorButtonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
