using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;


namespace Threader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Methods.RunDownloadSync();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            textBox2.Text += $"Total execution time: { elapsedMs }";


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await Methods.RunDownloadParallelAsync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            textBox2.Text += $"Total execution time: { elapsedMs }";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Progress<Report> progress = new Progress<Report>();
            progress.ProgressChanged += ReportProgress;


            var results = await Methods.RunDownloadAsync(progress);
            ReportWebsiteInfo(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            textBox2.Text += $"Total execution time: { elapsedMs }";
        }

        private void ReportProgress(object sender, Report e)
        {
            progressBar1.Value = e.CompPercent;
            ReportWebsiteInfo(e.SitesDownloaded);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ReportWebsiteInfo(List<WebsiteDataModel> results)
        { 
            textBox2.Text = "";

            foreach(var i in results)
            {
                textBox2.Text += $"{ i.WebsiteUrl } downloaded: { i.WebsiteData.Length } chracters long.{Environment.NewLine }";
            }



        }

    }
}
