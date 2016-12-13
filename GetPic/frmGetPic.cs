using Gif.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPic
{
    public partial class frmGetPic : Form
    {
        private DateTime currentDate;
        private DateTime endDate;
        private string path=Application.StartupPath;
        private List<string> imgFiles=new List<string>();
        private int interval;
        private int mapType;

        public frmGetPic()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (bgdWorker.IsBusy)
            {
                MessageBox.Show("Process is working.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (chkGif.Checked)
            {
                //is interval <0?
                Int32.TryParse(txtGifInterval.Text,out interval);
                if (interval <= 0)
                {
                    MessageBox.Show("Interval should large than 0. Auto set to default value 500.","Alert",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    interval=500;
                }
            }
            currentDate = dtpStart.Value;
            endDate = dtpEnd.Value;
            //map type
            if (radPointMap.Checked)
                mapType = 0;
            else if (radContourMap.Checked)
                mapType = 1;
            if (endDate < currentDate)
                MessageBox.Show("End time should late than start time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bgdWorker.RunWorkerAsync(new string[4]{cboPollutants.Text,chkGif.Checked.ToString(),chkGifLoop.Checked.ToString(),chkDelJpg.Checked.ToString()});
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;
                tsslblStatus.Text = "Processing, please wait...";
            }
        }

        private void btnDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(path))
                fbd.SelectedPath = System.IO.Path.GetDirectoryName(path);
            try
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    path = fbd.SelectedPath;
                    txtDst.Text = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgdWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //get pollutant type
            int type=1;
            switch ((e.Argument as string[])[0])
            {
                case "SO2":
                    type = 1;
                    break;
                case "CO":
                    type = 2;
                    break;
                case "O3":
                    type = 3;
                    break;
                case "PM10":
                    type = 4;
                    break;
                case "NO2":
                    type = 7;
                    break;
                case "PM2.5":
                    type = 33;
                    break;
            }
            //count process
            TimeSpan ts = new TimeSpan();
            ts = endDate - currentDate;
            int totalPic = (int)(ts.TotalHours + 0.5);
            if (bool.Parse((e.Argument as string[])[1]))
                totalPic = (int)(totalPic * 1.5);
            float counter = 0;
            try
            {
                do
                {
                    string url="";
                    switch (mapType)
                    {
                        case 0:
                            url = "http://taqm.epa.gov.tw/taqm/chart/Pollutant/map.aspx?param=" + type + "&dt=" + currentDate.ToString("yyyy/MM/dd HH:00");
                            if (type==4)
                                url = "http://taqm.epa.gov.tw/taqm/chart/MainParams24H/map.aspx?param=" + type + "&dt=" + currentDate.ToString("yyyy/MM/dd HH:00");
                            break;
                        case 1:
                            url = "http://taqm.epa.gov.tw/taqm/map_Contour/" + currentDate.ToString("yyyyMMdd-HH") + "-0-"+type+".jpg";
                            break;
                    }
                    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                    {
                        using (Stream stream = httpWebReponse.GetResponseStream())
                        {
                            Image img = Image.FromStream(stream);
                            string filename = path + @"\" + (e.Argument as string[])[0] + "-" + currentDate.AddHours(1).ToString("yyyy-MM-dd HH00") + ".jpg";
                            imgFiles.Add(filename);
                            img.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                    counter += 1;
                    bgdWorker.ReportProgress((int)(counter / totalPic * 100), (e.Argument as string[])[0] + "-" + currentDate.AddHours(1).ToString("yyyy-MM-dd HH00") + ".jpg");
                    currentDate = currentDate.AddHours(1);
                    if (bgdWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                } while (currentDate <= endDate);
                //create gif
                if (bool.Parse((e.Argument as string[])[1]))
                {
                    bgdWorker.ReportProgress((int)(counter / totalPic * 100), "Generating Gif file...");
                    AnimatedGifEncoder aniGif = new AnimatedGifEncoder();
                    string gifName = path + @"\" + (e.Argument as string[])[0] + "-" + dtpStart.Value.ToString("yyyyMMdd HHmm") + "-" + dtpEnd.Value.ToString("yyyyMMdd HHmm") + ".gif";
                    if (File.Exists(gifName))
                    {
                        if (MessageBox.Show("File \"" + gifName + "\" already exist, do you want to replace?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                            return;
                        else
                            File.Delete(gifName);
                    }
                    aniGif.Start(gifName);
                    aniGif.SetDelay(interval);
                    if (bool.Parse((e.Argument as string[])[2]))
                        aniGif.SetRepeat(0);
                    else
                        aniGif.SetRepeat(-1);
                    int frameCount = 0;
                    foreach (string imgFile in imgFiles)
                    {
                        if (bgdWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                        aniGif.AddFrame(Image.FromFile(imgFile));
                        counter += 0.5F;
                        frameCount += 1;
                        bgdWorker.ReportProgress((int)(counter / totalPic * 100), "Generating Gif file("+frameCount+"/"+imgFiles.Count+")...");
                    }
                    aniGif.Finish();
                    //del jpg
                    if (bool.Parse((e.Argument as string[])[3]))
                    {
                        bgdWorker.ReportProgress(99, "Deleting Jpg files...");
                        try
                        {
                            foreach (string imgFile in imgFiles)
                            {
                                if (File.Exists(imgFile))
                                    File.Delete(imgFile);
                            }
                        }
                        catch (Exception ex2) { }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgdWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Visible = false;
            tsslblStatus.Text = "Idle";
            if (e.Cancelled)
                MessageBox.Show("User interrupt program.", "Interrupt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (e.Error !=null)
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Image catching successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmGetPic_Load(object sender, EventArgs e)
        {
            txtDst.Text = path;
            txtGifInterval.Text = "500";
            cboPollutants.SelectedIndex = 0;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            radPointMap.Checked = true;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutMsg = new frmAbout();
            aboutMsg.ShowDialog(this);
        }

        private void txtGifInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //handled = true means not to handle this event
            //ASCII 8 = backspace
            //only allow integer (no decimal point)
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void bgdWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < 100)
                toolStripProgressBar1.Value = e.ProgressPercentage;
            else
                toolStripProgressBar1.Value = 99;
            tsslblStatus.Text = e.UserState.ToString();
        }

        private void chkGif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGif.Checked)
            {
                txtGifInterval.Enabled = true;
                chkGifLoop.Enabled = true;
                chkDelJpg.Enabled = true;
            }
            else
            {
                txtGifInterval.Enabled = false;
                chkGifLoop.Enabled = false;
                chkDelJpg.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bgdWorker.IsBusy)
                bgdWorker.CancelAsync();
            else
                MessageBox.Show("No catching process is running", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
