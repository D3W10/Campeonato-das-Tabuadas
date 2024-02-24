using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace Multiplication_Championship.Classes
{
    public class AwardController
    {
        public static List<AwardData> GetAllAwardsData()
        {
            string[] awardIds = { "A1", "A1G", "A1R", "A2", "A2G", "A2R", "A3", "A3G", "A3R", "A4", "A4G", "A4R", "A5", "A5G", "A5R", "A6", "A6G", "A6R", "A7", "A7G", "A7R", "A8", "A8G", "A8R", "A9", "A9G", "A9R", "AX", "AXG", "AXR", "C100", "C300", "C1000", "T30", "T10", "F1", "F2", "F3", "F4" };
            List<AwardData> list = new();
            ResourceManager resources = new("Multiplication_Championship.Properties.Awards", Assembly.GetExecutingAssembly());

            foreach (string id in awardIds)
                list.Add(new(id, resources.GetString(id).Split(';')[0], resources.GetString(id).Split(';')[1]));

            return list;
        }

        public static void CheckForWonAward(ref JSONFormat obj, AwardDiscriminator info, ref ImageList imageList)
        {
            // Classic Awards
            if (info.qtd == info.correct && ((info.qtd == 10 && info.min > 0) || info.qtd > 10) && info.max - info.min >= 9 && info.tab != -1)
            {
                string tabToSearch = info.tab > 9 ? "X" : info.tab.ToString();

                if (info.shuffle && info.comutative)
                {
                    if (info.minutes * 60 + info.seconds <= info.qtd * 2 && !Convert.ToBoolean(obj.Awards.GetType().GetProperty("A" + tabToSearch + "R").GetValue(obj.Awards, null)))
                    {
                        obj.Awards.GetType().GetProperty("A" + tabToSearch + "R").SetValue(obj.Awards, true);
                        ShowAwardAlert("A" + tabToSearch + "R.png", ref imageList);
                    }
                    
                    if (!Convert.ToBoolean(obj.Awards.GetType().GetProperty("A" + tabToSearch + "G").GetValue(obj.Awards, null)))
                    {
                        obj.Awards.GetType().GetProperty("A" + tabToSearch + "G").SetValue(obj.Awards, true);
                        ShowAwardAlert("A" + tabToSearch + "G.png", ref imageList);
                    }
                }
                else
                {
                    obj.Awards.GetType().GetProperty("A" + tabToSearch).SetValue(obj.Awards, true);
                    ShowAwardAlert("A" + tabToSearch + ".png", ref imageList);
                }
            }

            // Correct Count Awards
            if (obj.TotalCorrect + info.correct >= 100 && !Convert.ToBoolean(obj.Awards.C100))
            {
                obj.Awards.C100 = true;
                ShowAwardAlert("C100.png", ref imageList);
            }
            else if (obj.TotalCorrect + info.correct >= 300 && !Convert.ToBoolean(obj.Awards.C300))
            {
                obj.Awards.C300 = true;
                ShowAwardAlert("C300.png", ref imageList);
            }
            else if (obj.TotalCorrect + info.correct >= 1000 && !Convert.ToBoolean(obj.Awards.C1000))
            {
                obj.Awards.C1000 = true;
                ShowAwardAlert("C1000.png", ref imageList);
            }

            // Time Awards
            if (info.qtd == info.correct && ((info.qtd == 10 && info.min > 0) || info.qtd > 10) && info.max - info.min >= 9 && info.shuffle && info.comutative && info.minutes * 60 + info.seconds <= 30 && !Convert.ToBoolean(obj.Awards.T30))
            {
                obj.Awards.T30 = true;
                ShowAwardAlert("T30.png", ref imageList);
            }
            else if (info.qtd == info.correct && ((info.qtd == 10 && info.min > 0) || info.qtd > 10) && info.max - info.min >= 9 && info.shuffle && info.comutative && info.minutes * 60 + info.seconds <= 10 && !Convert.ToBoolean(obj.Awards.T10))
            {
                obj.Awards.T10 = true;
                ShowAwardAlert("T10.png", ref imageList);
            }

            // Final Awards
            if (info.qtd == info.correct && ((info.qtd == 10 && info.min > 0) || info.qtd > 10) && info.max - info.min >= 9 && info.tab == -1 && !Convert.ToBoolean(obj.Awards.F1))
            {
                obj.Awards.F1 = true;
                ShowAwardAlert("F1.png", ref imageList);
            }
            else if (info.qtd == info.correct && ((info.qtd == 10 && info.min > 0) || info.qtd > 10) && info.max - info.min >= 9 && info.tab == -1 && info.minutes * 60 + info.seconds <= 30 && !Convert.ToBoolean(obj.Awards.F2))
            {
                obj.Awards.F2 = true;
                ShowAwardAlert("F2.png", ref imageList);
            }
            else if (info.qtd == info.correct && ((info.qtd == 20 && info.min > 0) || info.qtd > 20) && info.max - info.min >= 9 && info.shuffle && info.comutative && info.tab == -1 && info.minutes * 60 + info.seconds <= 60 && !Convert.ToBoolean(obj.Awards.F3))
            {
                obj.Awards.F3 = true;
                ShowAwardAlert("F3.png", ref imageList);
            }
            else if (info.qtd == info.correct && ((info.qtd == 50 && info.min > 0) || info.qtd > 50) && info.max - info.min >= 9 && info.shuffle && info.comutative && info.tab == -1 && info.minutes * 60 + info.seconds <= 80 && !Convert.ToBoolean(obj.Awards.F4))
            {
                obj.Awards.F4 = true;
                ShowAwardAlert("F4.png", ref imageList);
            }
        }

        private static void ShowAwardAlert(string imageSrc, ref ImageList imageList)
        {
            int imageIndex = 0;

            for (int i = 0; i < imageList.Images.Keys.Count; i++)
            {
                if (imageList.Images.Keys[i] == imageSrc)
                    imageIndex = i;
            }

            new WonAward(imageList.Images[imageIndex]).ShowDialog();
        }
    }

    public struct AwardDiscriminator
    {
        public int correct;

        public int wrong;

        public int tab;

        public decimal qtd;

        public decimal min;

        public decimal max;

        public bool shuffle;

        public bool comutative;

        public int minutes;

        public int seconds;
    }
}