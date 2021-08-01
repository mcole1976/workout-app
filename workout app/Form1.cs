using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using ExerciseMethodShareDtNt;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using CreateExercises;


namespace workout_app
{
    public partial class Form1 : Form
    {
        int timer = 1;
        int timer2 = 0;
        int timer3 = 0;
        int maxcount = 30;
        Dictionary<string, string> workouts = fnSetDictionary();
        List<ExerciseMethodShareDtNt.WorkOut> wo = new List<ExerciseMethodShareDtNt.WorkOut>();
        List<ExerciseMethodShareDtNt.WorkOut> mainWOList = new List<ExerciseMethodShareDtNt.WorkOut>();

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

            fnSetFilesWkt();
            fnSetFood();
            string v = "\\";
            string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + "alternate crunch" + ".jpg";

            pBxExercise.ImageLocation = iFileLoc;

            pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;

        }
        private void fnSetFood()
        {
            List<string> f = new List<string>();
            f.Add(Properties.Settings.Default.MealTypeA);
            f.Add(Properties.Settings.Default.MealTypeB);
            f.Add(Properties.Settings.Default.MealTypeC);
            f.Add(Properties.Settings.Default.MealTypeD);

            lbxMeal.DataSource = f;
        }
        private void fnSetFilesWkt()
        {
            //List<string> wn = new List<string>();
            //string nameth = Properties.Settings.Default.XMLLocation.ToString();

            Dictionary<int, string> t = new Dictionary<int, string>();
            t = CreateExercises.ExerciseDataFeed.Exercise_Types_List();

            lbxType.DataSource = new BindingSource(t, null);
            lbxType.DisplayMember = "Value";
            lbxType.ValueMember = "Key";


            int key = lbxType.SelectedIndex;
            int res = 0;
            int counter = 0;

            foreach(KeyValuePair<int,string>kvp in t)
            {
                if(counter == key)
                {
                    res = kvp.Key;
                    break;
                }
                counter++;
            }
            Dictionary<int, string> workoutNames = CreateExercises.ExerciseDataFeed.Routine_List(res);

            lbxWorkOut.DataSource = new BindingSource(workoutNames, null);
            lbxWorkOut.DisplayMember = "Value";
            lbxWorkOut.ValueMember = "Key";

                

            
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            //fnBegin();
            //fnSetExGrid();
            tmrMain.Stop();
            timer3 = 0;
            Exercise(mainWOList[0]);
            workouts = null;
            workouts = fnSetDictionary();
        }

        private void fnSaveData()
        {
            
            int save_ID = (int)lbxWorkOut.SelectedValue;
            string timeTotEx = lbRnTime.ToString();
            double time = 0;
            bool timeTrial = double.TryParse(timeTotEx, out time);
            int Type = (int)lbxType.SelectedValue;
            CreateExercises.ExerciseDataFeed.Make_Log_Entry(Type, save_ID, 5);


        }

        private void fnBegin()
        {
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            timer3 = 0;

            KeyValuePair<int, string> routine = new KeyValuePair<int, string>();
            Dictionary<int, string> t = new Dictionary<int, string>();
            t = CreateExercises.ExerciseDataFeed.Exercise_Types_List();
            int key = lbxType.SelectedIndex;
            int res = 0;
            int counter = 0;

            foreach (KeyValuePair<int, string> kvp in t)
            {
                if (counter == key)
                {
                    res = kvp.Key;
                    break;
                }
                counter++;
            }
            Dictionary<int, string> workoutNames = CreateExercises.ExerciseDataFeed.Routine_List(res);

            lbxWorkOut.DataSource = new BindingSource(workoutNames, null);
            lbxWorkOut.DisplayMember = "Value";
            lbxWorkOut.ValueMember = "Key";


            //string workout = lbxWorkOut.SelectedItem.ToString();
            // var kvpRtne = workouts.Where(r => r.Value.Equals(workout));
            res = 0;
            counter = 0;

            key = lbxWorkOut.SelectedIndex;
            foreach (KeyValuePair<int, string> k in workoutNames)
            {

                string loc = "";
                if (counter == key)
                {
                    //loc = Properties.Settings.Default.XMLLibrary + @"\" + k.Value;
                    routine = k;
                    break;
                }
                counter++;
            }

            

            fnSetExercisePattern(routine);

            //
        }

        private void fnSetExercisePattern(KeyValuePair<int, string> wo)
        {

            List<ExerciseMethodShareDtNt.WorkOut> wol = new List<ExerciseMethodShareDtNt.WorkOut>();
            wol = CreateExercises.ExerciseDataFeed.WorkOut_Regiment(wo.Key);


            mainWOList = wol;
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            grdExercise.Columns.Add("WorkOut", "WorkOut");
            grdExercise.Columns.Add("Time", "Time");

            foreach (ExerciseMethodShareDtNt.WorkOut wk in wol)
            {
                grdExercise.Rows.Add(wk.Name, wk.Time);
            }


        }
        //public void Exercise(List<ExerciseMethodShareDtNt.WorkOut> w)
        //{
        //    tmrWrkOut.Stop();
        //    lbActivity.Text = w[0].Name;
        //    lbTime.Text = w[0].Time.ToString();
        //    string v = "\\";
        //    string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + w[0].Name + ".jpg";
        //    try
        //    {
        //        pBxExercise.Load(iFileLoc);
        //    }
        //    catch (Exception Ex)
        //    {
        //        pBxExercise.Load(Properties.Settings.Default.ExercisePics.ToString() + v + "Burpee" + ".jpg");
        //    }

        //    pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;
        //    tmrWrkOut.Interval = (w[0].Time * 1000);
        //    maxcount = w[0].Time;
        //    w[0].Complete = true;


        //    ExerciseMethodShareDtNt.WorkOut next = (from n in mainWOList where n.Id == w[0].Id + 1 select n).FirstOrDefault();

        //    lbNextName.Text = next.Name;
        //    // mainWOList.Where(o => o.Id == w.Id).ToList().ForEach(s => s.Complete = true);
        //   //wo.RemoveAt(0);
        //    timer2 = w[0].Time;
        //    SystemSounds.Beep.Play();
        //    tmrWrkOut.Start();
        //    tmrWork2.Start();
        //    tmrMain.Start();
           
        //}
        
        private void Exercise(ExerciseMethodShareDtNt.WorkOut w)
        {
            tmrWrkOut.Stop();
            lbActivity.Text = w.Name;
            lbTime.Text = w.Time.ToString();
            string v = "\\";
            string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + w.Name + ".jpg";
            try { 
            pBxExercise.Load(iFileLoc);
            }
            catch (Exception Ex)
            {
                pBxExercise.Load(Properties.Settings.Default.ExercisePics.ToString() + v + "Burpee" + ".jpg");
            }

            pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;
            tmrWrkOut.Interval = (w.Time * 1000);
            maxcount = w.Time;
            w.Complete = true;

            int marker = 0;
            foreach(ExerciseMethodShareDtNt.WorkOut y in mainWOList)
            {
                if( w.Id == y.Id)
                {
                    break;
                }
                marker++;
            }
            try
            {
                ExerciseMethodShareDtNt.WorkOut next = (from n in mainWOList where n.Id == w.Id +1 select n).FirstOrDefault();
                lbNextName.Text = next.Name;
                mainWOList.RemoveAt(marker);
            }
            catch(Exception e)
            {
                lbNextName.Text = "Finished";
            }
            
            // mainWOList.Where(o => o.Id == w.Id).ToList().ForEach(s => s.Complete = true);
            
            timer2 = w.Time;
            SystemSounds.Beep.Play();
            tmrWrkOut.Start();
            tmrWork2.Start();
            tmrMain.Start();
        }



        private void tmrWrkOut_Tick(object sender, EventArgs e)
        {
           
            timer++;

            if (wo.Count >  0 )
            {
                mainWOList = wo;
            }
            int cnt = (from k in mainWOList where k.Complete == false select k).Count();
            if (cnt > 0)
            {
                ExerciseMethodShareDtNt.WorkOut w = new ExerciseMethodShareDtNt.WorkOut();


                try 
                {
                     w = (from k in mainWOList where k.Complete == false select k).FirstOrDefault();
                    Exercise(w); }
                catch (Exception ex)
                {
                     w = (from k in mainWOList where k.Id   == wo.Count - 1 select k).FirstOrDefault();
                    wo = null;
                }
               
            }
            else
            { 
               
                lbActivity.Text = "Well Done";
                string v = "\\";
                string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + "finish" + ".jpg";
                pBxExercise.Load(iFileLoc);
                fnSaveData();
                tmrWrkOut.Stop();
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
            fnSetFilesWkt();
            workouts = null;
            workouts = fnSetDictionary();
            tmrMain.Stop();
            tmrWork2.Stop();
            tmrWrkOut.Stop();
            fnBegin();
            lbRnTime.Text = "";
            lbClicker.Text = "";
            string v = "\\";
            string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + "alternate crunch" + ".jpg";

            pBxExercise.ImageLocation = iFileLoc;

            pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        

        private void lbxWorkOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnSetExGrid();
        }

        private void fnSetExGrid()
        {
            //List<string> wn = new List<string>();
            //string nameth = Properties.Settings.Default.XMLLocation.ToString();

            int res = 0;
            int counter = 0;

            KeyValuePair<int, string> routine = new KeyValuePair<int, string>();
            Dictionary<int, string> t = new Dictionary<int, string>();
            t = CreateExercises.ExerciseDataFeed.Exercise_Types_List();
            int key = lbxType.SelectedIndex;

            foreach (KeyValuePair<int, string> kvp in t)
            {
                if (counter == key)
                {
                    res = kvp.Key;
                    break;
                }
                counter++;
            }
            Dictionary<int, string> workoutNames = CreateExercises.ExerciseDataFeed.Routine_List(res);

            counter = 0;

            key = lbxWorkOut.SelectedIndex;
            foreach (KeyValuePair<int, string> k in workoutNames)
            {

                string loc = "";
                if (counter == key)
                {
                    //loc = Properties.Settings.Default.XMLLibrary + @"\" + k.Value;
                    routine = k;
                    break;
                }
                counter++;
            }



            fnSetExercisePattern(routine);

        }

        private void grdExercise_SelectionChanged(object sender, EventArgs e)
        {
            
            int index = 0;
            string pic = "alternate crunch";

            foreach (DataGridViewRow r in grdExercise.Rows)
            {
                if(grdExercise.Rows[index].Selected == true)
                {
                    try
                    {
                        string v = "\\";
                        pic = r.Cells[0].Value.ToString();

                        string iFileLoc = Properties.Settings.Default.ExercisePics.ToString() + v + pic + ".jpg";

                        pBxExercise.ImageLocation = iFileLoc;

                        pBxExercise.SizeMode = PictureBoxSizeMode.AutoSize;
                    }
                    catch (Exception ex)
                    {

                    }
                    
                }
                index++;
            }


        }

        private void fnchk_Time(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
                
            if(c.Name == "chk10")
            {
                if (c.Checked == true)
                {
                    chk15.Checked = false;
                    chk20.Checked = false;
                    chk30.Checked = false;
                }
            }
            else if(c.Name == "chk15")
            {
                if (c.Checked == true)
                {
                    chk10.Checked = false;
                    chk20.Checked = false;
                    chk30.Checked = false;
                }
            }
            else if (c.Name == "chk20")
            {
                if (c.Checked == true)
                {
                    chk10.Checked = false;
                    chk15.Checked = false;
                    chk30.Checked = false;
                }
            }
            else if (c.Name == "chk30")
            {
                if (c.Checked == true)
                {
                    chk10.Checked = false;
                    chk15.Checked = false;
                    chk20.Checked = false;
                }
            }
        }

        private void fnchk_Exercise(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;

            if (c.Name == "chkUB")
            {
                if(c.Checked == true)
                {
                    chkFB.Checked = false;
                    ChkLG.Checked = false;
                    chKAB.Checked = false;
                    chkNB.Checked = false;
                }
            }
            else if (c.Name == "chKAB")
            {
                if (c.Checked == true)
                {
                    chkUB.Checked = false;
                    ChkLG.Checked = false;
                    chkFB.Checked = false;
                    chkNB.Checked = false;
                }

            }
            else if (c.Name == "ChkLG")
            {
                if (c.Checked == true)
                {
                    chkUB.Checked = false;
                    chKAB.Checked = false;
                    chkFB.Checked = false;
                    chkNB.Checked = false;
                }
            }

            else if (c.Name == "ChkFB")
            {
                if (c.Checked == true)
                {
                    chkUB.Checked = false;
                    chKAB.Checked = false;
                    ChkLG.Checked = false;
                    chkNB.Checked = false;
                }
            }
            else  if (c.Name == "chkNB")
            {
                if (c.Checked == true)
                {
                    chkUB.Checked = false;
                    chKAB.Checked = false;
                    ChkLG.Checked = false;
                    chkFB.Checked = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ExerciseMethodShareDtNt.WorkOut> newWO = new List<ExerciseMethodShareDtNt.WorkOut>();
            wo = newWO;
            bool TenOn, FifteenOn, TwentyOn, ThirtyOn;
            int checkCount = 0;
            int chkCountEx = 0;
            int timetoRun = 0;
            Dictionary<int, string> typesEx =  CreateExercises.ExerciseDataFeed.Exercise_Types_List();
            KeyValuePair<int, string> exChosen = new KeyValuePair<int, string>();

            //Validation Code for entered Text time and exercise type
            
            if (chk10.Checked == true)
            {
                TenOn = true;
                timetoRun = 10;
                checkCount++;
            }

            if (chk15.Checked == true)
            {
                FifteenOn = true;
                timetoRun = 15;
                checkCount++;
            }

            if (chk20.Checked == true)
            {
                TwentyOn = true;
                timetoRun = 20;
                checkCount++;
            }

            if (chk30.Checked == true)
            {
                ThirtyOn = true;
                timetoRun = 30;
                checkCount++;
            }

            if (ChkLG.Checked == true)
            {
                chkCountEx++;
                exChosen = (from t in typesEx where ChkLG.Text == t.Value select t).FirstOrDefault();
            }

            if (chkUB.Checked == true)
            {
                chkCountEx++;
                exChosen = (from t in typesEx where chkUB.Text == t.Value select t).FirstOrDefault();
            }

            if (chKAB.Checked == true)
            {
                chkCountEx++;
                exChosen = (from t in typesEx where chKAB.Text == t.Value select t).FirstOrDefault();
            }

            if (chkFB.Checked)
            {
                chkCountEx++;
                exChosen = (from t in typesEx where chkFB.Text == t.Value select t).FirstOrDefault();
            }

            if (chkNB.Checked)
            {
                chkCountEx++;
                exChosen = (from t in typesEx where "Full Body" == t.Value select t).FirstOrDefault();
            }
            if(txtExName.Text.Length == 0 || string.IsNullOrEmpty(txtExName.Text) )
            {
                lbErr.Text = lbErr.Text = "You need toEnter a Name for the Exercise";
                return;
            }

            if (checkCount < 1)
            {
                lbErr.Text = lbErr.Text = "You need to Check a time frame";
                return;
            }
            else if (checkCount > 1)
            {
                lbErr.Text = lbErr.Text = "You need to Check only one time frame";
                return;
            }

            if (chkCountEx < 1)
            {
                lbErr.Text = lbErr.Text = "You need to Check an Exercise Type";
                return;
            }

            if (chkCountEx > 1)
            {
                lbErr.Text = lbErr.Text = "You need to Check only one Exercise Type";
                return;
            }

            List<int> intervals = new List<int>();

            //List<string> exercises = ExercisePatterns.exerciseStringList();

            //no break and Full Body are the same exercise patterns but have different break structures

            List<int> breakInterval = new List<int>();
            if (exChosen.Value == "Full Body")
            {
                if (!chkNB.Checked)
                {
                    fnSetTimeforFullBody(ref breakInterval, timetoRun);
                }


            }
            else
            {

                fnSetBreak(ref breakInterval, timetoRun);

            }
            // creatine the exercise routine 
            fnCreateRoutine(timetoRun, breakInterval, ref newWO, exChosen);
           
        }

        private void fnCreateRoutine(int timetoRun, List<int> breakInterval, ref List<ExerciseMethodShareDtNt.WorkOut> wo, KeyValuePair<int,string> exType)
        {
            List<string> currExs = new List<string>();
            List<string> aiEx = new List<string>();
            //int listCount = 0;
            //int compiledTime = 0;
            //bool breakfound = false;

            // choose all available exercise
            List<ExerciseMethodShareDtNt.ResultBase> rb = CreateExercises.ExerciseDataFeed.ResultList();

            //rb = (from r in rb where r.Exercise_Type == exType select r).ToList();

            Dictionary<int, string> exNamesA = CreateExercises.ExerciseDataFeed.Routine_List(exType.Key);
            //List<string> exercises = new List<string>();
            //exercises = (from rs in rb select rs.Exercise_Name).Distinct().ToList();

            //List<string> exNames = new List<string>();

            //exNames = (from rEx in rb select rEx.Searched_exercise).Distinct().ToList();
            // divide exercises up

            // get a list of Exercises that match Chosen Exercise Type

            // get list of exercise routines to pick off exercises
            //string ExLoc = Properties.Settings.Default.XMLLibrary.ToString();
            //ExLoc = ExLoc + @"\";
            List<WorkOut> workOutsMain = new List<WorkOut>();
            //List<WorkOut> workOutsB = new List<WorkOut>();
            // loop over each exercise routine 
            foreach (KeyValuePair<int,string> s in exNamesA)
            {
                List<WorkOut> wOUT = new List<WorkOut>();

                wOUT = CreateExercises.ExerciseDataFeed.WorkOut_Regiment(s.Key);
                //List<string> exercisess = new List<string>();
                //exercisess = (from r in wOutArr select r.Name).ToList();

                //List<string> ExTypes = new List<string>();

                // breakdown each routine
                foreach (WorkOut wCheck in wOUT)
                {
                    if (exType.Value != "Full Body")
                    {
                        string wNm = wCheck.Name;
                        int wCnt = 0;
                        wCnt = (from r in rb where r.Exercise_Name == wNm && r.Exercise_Type == exType.Value select r).Count();
                        if (wNm == "Rest" || wNm == "rest" || wNm == "Complete" || wNm == "complete" || wNm == "Break" || wNm == "cobra" || wNm == "Cobra" || wNm == "cobra" || wNm == "child pose" || wNm == "Child Pose")
                        {

                        }
                        else if (wNm.Contains("stretch") || wNm.Contains("Child Pose"))
                        {

                        }
                        else if (wCnt < 1)
                        {
                            wCheck.Id = 0;
                            //workOutsMain.Add(wCheck);
                            aiEx.Add(wCheck.Name);
                        }
                        else if (wCnt > 1)
                        {
                            currExs.Add(wCheck.Name);
                        }
                    }
                    else if (exType.Value == "Full Body" )
                    {
                        string wNm = wCheck.Name;
                        int wCnt = 0;
                        wCnt = (from r in rb

                                where r.Exercise_Name == wNm 
                                select r).Count();
                        if (wNm == "Rest" || wNm == "rest" || wNm == "Complete" || wNm == "complete")
                        {

                        }
                        else if (wNm.Contains("stretch") || wNm.Contains("Child Pose"))
                        {

                        }
                        else if (wCnt < 1)
                        {
                            wCheck.Id = 0;
                            //workOutsMain.Add(wCheck);
                            aiEx.Add(wCheck.Name);
                        }
                        else if (wCnt > 1)
                        {
                            currExs.Add(wCheck.Name);
                        }

                    }

                }
                //workOutsMain.AddRange(wOUT);
            }


            currExs = currExs.Distinct().ToList();
            aiEx = aiEx.Distinct().ToList();

            // set exercises according to time
            if (timetoRun == 30)
            {
                if (chkNB.Checked)
                {
                    int r = (timetoRun * 60) / 45;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
                else
                {
                    int r = timetoRun * 2;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
            }
            else if (timetoRun == 20)
            {
                if (chkNB.Checked)
                {
                    int r = (timetoRun * 60) / 40;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
                else
                {
                    int r = timetoRun * 2;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
            }
            else if (timetoRun == 15)
            {
                if (chkNB.Checked)
                {
                    int r = (timetoRun * 60) / 45;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
                else
                {
                    int r = timetoRun * 2;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
            }
            else if (timetoRun == 10)
            {
                if (chkNB.Checked)
                {
                    int r = (timetoRun * 60) / 40;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
                else
                {
                    int r = timetoRun * 2;
                    fnSetExerciseDetails(r, breakInterval, exType, aiEx, currExs);
                }
            }



            //string fileloc = @"C:\Users\marcu\Documents\Code\ExerciseXML\" +  + ".xml";
            //int f = wo.Count;
            //fnwriteXML(exType.Key,txtExName.Text);
            fnBeginAuto(wo);
            Exercise(wo[0]);
           // workouts = null;
          //workouts = fnSetDictionary();
        }

        private void fnBeginAuto(List<WorkOut> wo)
        {
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            timer3 = 0;

            mainWOList = wo;
            grdExercise.Rows.Clear();
            grdExercise.Columns.Clear();
            grdExercise.Columns.Add("WorkOut", "WorkOut");
            grdExercise.Columns.Add("Time", "Time");

            foreach (ExerciseMethodShareDtNt.WorkOut wk in wo)
            {
                grdExercise.Rows.Add(wk.Name, wk.Time);
            }

            tbMain.SelectedIndex = 0;


        }

        private void fnwriteXML(int ExID, string fileloc)
        {
            lbErr.Text = "";

            CreateExercises.ExerciseDataFeed.Make_Exercise_Regiment(ExID, fileloc);


            foreach (ExerciseMethodShareDtNt.WorkOut w in wo)
            {
                CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w);
                CreateExercises.ExerciseDataFeed.Make_Result_Base(w, ExID , fileloc);
            }
            //wo.Clear();
            //counter = 0;
            lbErr.Text = "Current Routine Completed and Made";
            
        }

        private void fnSetExerciseDetails(int r, List<int> bi, KeyValuePair<int,string> exType, List<string> aiEx, List<string> curr)
        {
            List<string> currExs = curr;
            int totalTime = r;
            bool newOld = true;
            bool breakfound = false;
            int c = 0;
            if (exType.Value == "Full Body" )
            {
                currExs.AddRange(aiEx);
                currExs.Distinct().ToList();
            }

            CreateExercises.ExerciseDataFeed.Make_Exercise_Regiment(exType.Key, txtExName.Text);
            while (r > 0)
            {
                ExerciseMethodShareDtNt.WorkOut w = new ExerciseMethodShareDtNt.WorkOut();

                if (exType.Value == "Full Body" )
                {
                    newOld = false;
                }
                else
                {
                    if (r % 2 == 0 && r != 0)
                    {
                        newOld = true;
                    }
                    else
                    {
                        newOld = false;
                    }
                }

                foreach (int t in bi)
                {
                    if (t == c)
                    {
                        breakfound = true;
                        w.Name = "Rest";
                        w.Id = totalTime - r;
                        if (exType.Value == "Full Body")
                        {
                            w.Time = 20;
                        }
                        else
                        {
                            w.Time = 30;
                        }
                    }
                }

                bool directionFound = false;
                string directionName = "";
                ExerciseMethodShareDtNt.WorkOut w2 = new ExerciseMethodShareDtNt.WorkOut();


                if (breakfound == false)
                {
                    w.Name = fnSetWorkout(currExs, aiEx, newOld);
                    if (w.Name.Contains(" Right") || w.Name.Contains("Left") || w.Name.Contains(" right") || w.Name.Contains("left"))
                    {
                        directionFound = true;
                        if (w.Name.Contains(" Right") || w.Name.Contains(" right"))
                        {
                            directionName = "Left".ToUpper();
                        }
                        else
                        {
                            directionName = "Right".ToUpper();
                        }
                        List<string> exB = aiEx;
                        if (newOld)
                        {
                            exB = currExs;
                        }
                        w2.Name = fnGetRIGHTLEFT(w.Name, directionName, exB);
                        w2.Id = (totalTime - r);

                    }
                    w.Id = totalTime - r;
                    if (exType.Value == "Full Body")
                    {
                        if ((chk15.Checked || chk30.Checked) && chkNB.Checked)
                        {
                            w.Time = 45;
                            w2.Time = 45;
                        }
                        else
                        {
                            w.Time = 40;
                            w2.Time = 40;
                        }
                    }
                    else
                    {
                        w.Time = 30;
                        w2.Time = 30;
                    }

                }

                if (exType.Value == "Full Body")
                {
                    if (breakfound)
                    {
                        c = c + 20;
                    }
                    else
                    {
                        if ((chk15.Checked || chk30.Checked) && chkNB.Checked)
                        {
                            c = c + 45;
                        }
                        else
                        {
                            c = c + 40;
                        }
                    }
                }
                else
                {
                    if (!directionFound)
                    {
                        c = c + 30;
                    }

                }


                breakfound = false;


                if (directionFound)
                {
                    wo.Add(w);
                    CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w);
                    if (exType.Value == "Full Body")
                    {
                        WorkOut w3 = new WorkOut();
                        if (chkNB.Checked)
                        {
                            w2.Id = (totalTime - r) + 1;
                            r = r - 2;
                            c = c + (w2.Time);
                            wo.Add(w2);
                            CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w2);
                        }
                        else
                        {
                            w3.Name = "Rest";
                            w3.Id = (totalTime - r) + 1;
                            w2.Id = w3.Id + 1;
                            w3.Time = 20;
                            wo.Add(w3);
                            CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w3);
                            r = r - 3;
                            c = c + (w3.Time + w2.Time);
                            wo.Add(w2);
                            CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w2);

                            //c = c + (w3.Time + w2.Time);
                        }
                    }
                    else
                    {
                        w2.Id = (totalTime - r) + 1;

                        r = r - 2;
                        c = c + (w.Time);

                        foreach (int t in bi)
                        {
                            if (c == t)
                            {
                                r = r - 1;
                                WorkOut wRest = new WorkOut();
                                wRest.Name = "Rest";
                                wRest.Id = w2.Id;
                                w2.Id = w2.Id + 1;
                                if (exType.Value == "Full Body")
                                {
                                    wRest.Time = 20;
                                    c = c + 20;
                                }
                                else
                                {
                                    wRest.Time = 30;
                                    c = c + 30;
                                }
                                wo.Add(wRest);
                                CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, wRest);

                            }
                        }

                        c = c + w2.Time;

                        wo.Add(w2);
                        CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w2);
                    }
                }
                else
                {
                    r--;
                    if (r == 0 && (w.Name == "Rest" || w.Name == "break"))
                    {
                        WorkOut ext = new WorkOut();
                        ext.Name = fnSetWorkout(currExs, aiEx, newOld);
                        ext.Id = w.Id + 1;
                        bool rl = false;
                        while (rl == false)
                        {
                            if (ext.Name.Contains("right") || ext.Name.Contains("left") || ext.Name.Contains("Right") || ext.Name.Contains("Left"))
                            {
                                rl = false;
                                w.Name = fnSetWorkout(currExs, aiEx, newOld);
                                if (exType.Value == "Full Body")
                                {
                                    ext.Time = 40;
                                }
                                else
                                {
                                    ext.Time = 30;
                                }
                            }
                            else
                            {
                                rl = true;
                                if (exType.Value == "Full Body")
                                {
                                    ext.Time = 40;
                                }
                                else
                                {
                                    ext.Time = 30;
                                }
                            }
                        }
                        wo.Add(w);
                        CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w);
                        wo.Add(ext);
                        CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0,ext);
                    }
                    else
                    {
                        wo.Add(w);
                        CreateExercises.ExerciseDataFeed.Make_Regiment_Record(0, w);
                    }
                }
            }
        }

        private string fnGetRIGHTLEFT(string name, string directionName, List<string> exB)
        {
            string directionToLookFor = "";
            string stringPart = "";
            int at = 0;
            string resPortion = "";
            string returnResult = "";

            if (directionName == "RIGHT")
            {
                directionToLookFor = "LEFT";
                name = name.ToUpper();
                at = name.IndexOf(directionToLookFor);
                resPortion = name.Substring(0, at).ToUpper();


                returnResult = (from r in exB where r.ToUpper() == resPortion + directionName select r).FirstOrDefault();
                if (string.IsNullOrEmpty(returnResult))
                {
                    //returnResult = (from r in exs where r.ToUpper().Contains(resPortion) && r.ToUpper().Contains(directionName) select r).FirstOrDefault();
                    returnResult = resPortion + directionName;

                }
            }
            else if (directionName == "LEFT")
            {
                directionToLookFor = "RIGHT";
                name = name.ToUpper();
                at = name.IndexOf(directionToLookFor);
                resPortion = name.Substring(0, at).ToUpper();
                returnResult = (from r in exB where r.ToUpper() == resPortion + directionName select r).FirstOrDefault();

                if (string.IsNullOrEmpty(returnResult))
                {

                    //returnResult = (from r in exs where r.ToUpper().Contains(resPortion) && r.ToUpper().Contains(directionName) select r).FirstOrDefault();
                    returnResult = resPortion + directionName;
                }
            }

            return returnResult;
        }

        private string fnSetWorkout(List<string> currExs, List<string> aiEx, bool newOld)
        {
            Random r = new Random();
            //workout res = new workout();
            int counter = 0;
            string resName = "";
            if (newOld)
            {
                counter = r.Next(0, currExs.Count);
                resName = currExs[counter];
            }
            else
            {
                counter = r.Next(0, aiEx.Count);
                resName = aiEx[counter];
            }

            if (resName == "Rest" || resName.Contains("Stretch") || resName == " Child Pose")
            {
                resName = fnSetWorkout(currExs, aiEx, true);
            }

            return resName;
        }

        private void fnSetBreak(ref List<int> breakInterval, int TotalTime)
        {
            if (TotalTime == 30)
            {
                breakInterval.Add(450);
                breakInterval.Add(900);
                breakInterval.Add(1350);
            }
            else if (TotalTime == 20)
            {
                breakInterval.Add(420);
                breakInterval.Add(810);
            }
            else if (TotalTime == 15)
            {
                breakInterval.Add(300);
                breakInterval.Add(600);
            }
            else if (TotalTime == 10)
            {
                breakInterval.Add(300);

            }
        }

        private void fnSetTimeforFullBody(ref List<int> breakInterval, int timetoRun)
        {
            int controlledRuntime = 0;
            int loopTime = 0;
            if (timetoRun == 30)
            {
                controlledRuntime = (timetoRun * 60) - 20;

                while (loopTime < controlledRuntime)
                {
                    loopTime = loopTime + 40;
                    breakInterval.Add(loopTime);
                    loopTime = loopTime + 20;

                }
            }
            else if (timetoRun == 20)
            {
                controlledRuntime = (timetoRun * 60) - 20;

                while (loopTime < controlledRuntime)
                {
                    loopTime = loopTime + 40;
                    breakInterval.Add(loopTime);
                    loopTime = loopTime + 20;

                }
            }
            else if (timetoRun == 15)
            {
                controlledRuntime = (timetoRun * 60) - 20;

                while (loopTime < controlledRuntime)
                {
                    loopTime = loopTime + 40;
                    breakInterval.Add(loopTime);
                    loopTime = loopTime + 20;

                }
            }
            else if (timetoRun == 10)
            {
                controlledRuntime = (timetoRun * 60) - 20;

                while (loopTime < controlledRuntime)
                {
                    loopTime = loopTime + 40;
                    breakInterval.Add(loopTime);
                    loopTime = loopTime + 20;

                }

            }
        }

        private void lbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnBegin();
        }

        private void tbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbMain.SelectedIndex == 1)
            {
                txtExName.Focus();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int del_ID = (int)lbxWorkOut.SelectedValue;
            CreateExercises.ExerciseDataFeed.Delete_Exercise(del_ID);

            fnSetFilesWkt();
           
            fnBegin();
            

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ExerciseMethodShareDtNt.Food_Log f = new Food_Log();

            if (txtFoodDesc.Text == "" || String.IsNullOrEmpty(txtFoodDesc.Text))
            {
                lbErrFd.Text = "Please Enter a Food Description";
                return;
            }
            if (txtCalCnt.Text.Length <1)
            {
                lbErrFd.Text = "Please Enter a Food Description";
                return;
                
            }

            f.Meal_Description = txtFoodDesc.Text;
            f.Meal = lbxMeal.SelectedValue.ToString();
            int fRes = 1;
            bool fBool;

            fBool = int.TryParse(txtCalCnt.Text, out fRes);
            f.Calorie_Count = fRes;

            CreateExercises.ExerciseDataFeed.Make_Food_Entry(f);

        }

        private void txtCalCnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

        }
    }
}
