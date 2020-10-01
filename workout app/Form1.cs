using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using WMPLib;
using System.Threading;
using System.Security.Cryptography;
using MediaPlayer;

namespace workout_app
{
    public partial class Form1 : Form
    {
        int timer = 1;
        int timer2 = 0;
        int timer3 = 0;
        int maxcount = 30;
        WMPLib.WindowsMediaPlayer Player;
        Dictionary<string, string> workouts = fnSetDictionary();

        List<workout> mainWOList = new List<workout>();

        //Barrier n = new Barrier(30000);
        private static Dictionary<string, string> fnSetDictionary()
        {
            Dictionary<string, string> workouts = new Dictionary<string, string>();

            string[] workoutNames = Directory.GetFiles(Properties.Settings.Default.XMLLocation);
            foreach (string a in workoutNames)
            {
                workouts.Add(a, a.Split('\\').Last());

            }


            return workouts;
        }

        public Form1()
        {
            InitializeComponent();
            //List<string> arts = new List<string>();
            //arts.Add("Please Choose Artist");
            //Dictionary<string, string> artistes = new Dictionary<string, string>();
            //string[] artists = Directory.GetDirectories(Properties.Settings.Default.MusicFiles);
            //foreach (string a in artists)
            //{
            //    arts.Add(a.Split('\\').Last());
            //    artistes.Add(a.Split('\\').Last(), a);
            //}
            //lbxArtist.DataSource = arts;

            List<string> wn = new List<string>();
            string nameth = Properties.Settings.Default.XMLLocation.ToString();

            string[] workoutNames = Directory.GetFiles(Properties.Settings.Default.XMLLocation);
            foreach (string a in workoutNames)
            {
                wn.Add(a.Split('\\').Last());
                
            }
            lbxWorkOut.DataSource = wn;

            string v = "\\";
            string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + "alternate crunch" + ".jpg";

            pBxExercise.ImageLocation = iFileLoc;

            pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;

        } 

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListBox l =  (ListBox)sender;

        //    if (l.SelectedIndex > 0)
        //    {

        //        KeyValuePair<string, string> res = new KeyValuePair<string, string>();
        //        Dictionary<string, string> artistes = new Dictionary<string, string>();
        //        List<string> arts = new List<string>();
        //        string[] artists = Directory.GetDirectories(Properties.Settings.Default.MusicFiles);
        //        foreach (string a in artists)
        //        {
        //            arts.Add(a.Split('\\').Last());
        //            artistes.Add(a.Split('\\').Last(), a);
        //        }

        //        string Artsy = lbxArtist.SelectedItem.ToString();
        //        var kvpl = artistes.Where(r => r.Key.Equals(Artsy));
        //        foreach (KeyValuePair<string, string> k in kvpl)
        //        {
        //            res = k;
        //            break;
        //        }


        //        List<string> fs = new List<string>();
        //        List<string> musicF = new List<string>();
        //        //System.IO.FileInfo[] files = null;

        //        string[] f = Directory.GetDirectories(res.Value);
        //        fs = f.ToList();
                
        //        List<string> mf = new List<string>();
        //        if (fs.Count == 0)
        //        {
        //            mf.AddRange(Directory.GetFiles(res.Value));
        //        }
        //        else
        //        {
        //            foreach (string s in fs)
        //            {
        //                mf.AddRange(Directory.GetFiles(s));
        //            }
        //        }

        //        foreach (string s in mf)
        //        {
                    
        //                System.IO.FileInfo fi = new System.IO.FileInfo(s);
        //                if (fi.Extension == ".mp3" || fi.Extension == ".wma")
        //                {
        //                    musicF.Add(s);
        //                }
                    
        //        }
        //        var t = new Thread (() => fnsetWorkOutMusic(musicF));
        //        t.Start();
        //    }

        //}

        private void btnRun_Click(object sender, EventArgs e)
        {
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            timer3 = 0;
            
            KeyValuePair<string, string> routine = new KeyValuePair<string, string>();
            
            string workout = lbxWorkOut.SelectedItem.ToString();
            var kvpRtne = workouts.Where(r => r.Value.Equals(workout));

            foreach (KeyValuePair<string, string> k in kvpRtne)
            {
                routine = k;
                break;
            }

            fnSetExercisePattern(routine );

            Exercise(mainWOList[0]);

        }

        private void fnSetExercisePattern(KeyValuePair<string, string> wo)
        {

            List<workout> wol = new List<workout>();
            XElement xDoc = XElement.Load(wo.Key);
            IEnumerable<XElement> childList =
            from el in xDoc.Elements()
            select el;
            foreach (XElement e in childList)
            {
                workout wOut = new workout();
                wOut.Id = Convert.ToInt32(e.Element("order").Value.ToString());
                wOut.Name = e.Element("name").Value.ToString();
                wOut.Time = Convert.ToInt32(e.Element("time").Value.ToString());
                wol.Add(wOut);
            }

            // int ct = 1;
            //workout wk = new workout();
            //while (ct > 0 )
            //{
            //    ct = (from c in wol where c.Complete == false select c).Count();
            //        if (ct > 0)
            //        {
            //            wk = (from c in wol where c.Complete == false select c).FirstOrDefault();
            //        }
            //fnSetWorkOutExercise( wol);
            mainWOList = wol;
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            grdExercise.Columns.Add("WorkOut", "WorkOut");
            grdExercise.Columns.Add("Time", "Time");
            //grdExercise.DataSource = mainWOList;
            foreach ( workout wk in mainWOList )
            {
                grdExercise.Rows.Add(wk.Name, wk.Time);
            }
            
        }

        
        private void Exercise(workout w)
        {
            tmrWrkOut.Stop();
            lbActivity.Text = w.Name;
            lbTime.Text = w.Time.ToString();
            string v = "\\";
            string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + w.Name + ".jpg";
           pBxExercise.Load( iFileLoc);
            //pBxExercise.im
            pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;
            tmrWrkOut.Interval = (w.Time * 1000);
            maxcount = w.Time;
            w.Complete = true;

            int marker = 0;
            foreach(workout y in mainWOList)
            {
                if( w.Id == y.Id)
                {
                    break;
                }
                marker++;
            }

            workout next = (from n in mainWOList where n.Id == w.Id + 1 select n).FirstOrDefault();

            lbNextName.Text = next.Name;
            // mainWOList.Where(o => o.Id == w.Id).ToList().ForEach(s => s.Complete = true);
            mainWOList.RemoveAt(marker);
            timer2 = w.Time;
            SystemSounds.Beep.Play();
            tmrWrkOut.Start();
            tmrWork2.Start();
            tmrMain.Start();
        }

        //private void fnsetWorkOutMusic( List<string> musicF)
        //{

        //    WindowsMediaPlayer w = new WindowsMediaPlayer();
        //    WMPLib.IWMPPlaylist pl = w.newPlaylist("newL", "");
        //    //throw new NotImplementedException();
        //    foreach (string m in musicF )
        //    {
        //        //playFile(m);
        //        // w.newMedia(m);
        //        pl.appendItem(w.newMedia(m));
        //        //w.controls.stop();
        //    }
        //    w.currentPlaylist = pl;
        //    w.controls.play();
            
            
        //}


        private void tmrWrkOut_Tick(object sender, EventArgs e)
        {
           
            timer++;
            int cnt = (from k in mainWOList where k.Complete == false select k).Count();
            if (cnt > 0)
            {
                workout w = (from k in mainWOList where k.Complete == false select k).FirstOrDefault();
                Exercise(w);
            }
            else
            {
                lbActivity.Text = "Well Done";
                string v = "\\";
                string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + "hold and lift" + ".jpg";
                pBxExercise.Load(iFileLoc);
                tmrMain.Stop();
                return;
            }
           
        }

        private void pBxExercise_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void tmrWork2_Tick(object sender, EventArgs e)
        {
            timer2--;
            lbClicker.Text = timer2.ToString();
            
                
                if (timer2 == 0 )
                {
                    
                    tmrWork2.Stop();
                }
            if (timer2 < 5) 
                {
                    SystemSounds.Beep.Play();
                }

            

             
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            int p60 = 1;
            int trem = 0;
            timer3++;
            if (timer3 > 60)
            {
                p60 = timer3 / 60;
                trem = timer3 - (p60 * 60);
                if (trem < 10)
                {
                    lbRnTime.Text = p60.ToString() + ":0" + trem.ToString();
                }
                else
                {
                    lbRnTime.Text = p60.ToString() + ":" + trem.ToString();
                }
            }
            else
            {
                lbRnTime.Text =  timer3.ToString();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            string message = lbActivity.Text;
            lbActivity.Text = "Paused 5 Seconds";
            Thread.Sleep(5000);
            lbActivity.Text = message;

        }

        private void btnPause60_Click(object sender, EventArgs e)
        {
            string message = lbActivity.Text;
            lbActivity.Text = "Paused 60 Seconds";
            Thread.Sleep(60000);
            lbActivity.Text = message;
        }
    }
}
