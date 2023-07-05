using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas.Classes
{
    public class AwardController
    {
        public static List<AwardData> GetAllAwardsData()
        {
            return new List<AwardData>()
            {
                new AwardData("A1", "Tabuada do 1 Concluída", "Terminar a tabuada do 1 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A1G", "Tabuada do 1 Conquistada", "Terminar a tabuada do 1 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A1R", "Tabuada do 1 Dominada", "Terminar a tabuada do 1 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A2", "Tabuada do 2 Concluída", "Terminar a tabuada do 2 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A2G", "Tabuada do 2 Conquistada", "Terminar a tabuada do 2 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A2R", "Tabuada do 2 Dominada", "Terminar a tabuada do 2 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A3", "Tabuada do 3 Concluída", "Terminar a tabuada do 3 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A3G", "Tabuada do 3 Conquistada", "Terminar a tabuada do 3 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A3R", "Tabuada do 3 Dominada", "Terminar a tabuada do 3 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A4", "Tabuada do 4 Concluída", "Terminar a tabuada do 4 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A4G", "Tabuada do 4 Conquistada", "Terminar a tabuada do 4 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A4R", "Tabuada do 4 Dominada", "Terminar a tabuada do 4 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A5", "Tabuada do 5 Concluída", "Terminar a tabuada do 5 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A5G", "Tabuada do 5 Conquistada", "Terminar a tabuada do 5 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A5R", "Tabuada do 5 Dominada", "Terminar a tabuada do 5 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A6", "Tabuada do 6 Concluída", "Terminar a tabuada do 6 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A6G", "Tabuada do 6 Conquistada", "Terminar a tabuada do 6 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A6R", "Tabuada do 6 Dominada", "Terminar a tabuada do 6 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A7", "Tabuada do 7 Concluída", "Terminar a tabuada do 7 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A7G", "Tabuada do 7 Conquistada", "Terminar a tabuada do 7 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A7R", "Tabuada do 7 Dominada", "Terminar a tabuada do 7 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A8", "Tabuada do 8 Concluída", "Terminar a tabuada do 8 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A8G", "Tabuada do 8 Conquistada", "Terminar a tabuada do 8 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A8R", "Tabuada do 8 Dominada", "Terminar a tabuada do 8 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A9", "Tabuada do 9 Concluída", "Terminar a tabuada do 9 com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A9G", "Tabuada do 9 Conquistada", "Terminar a tabuada do 9 com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("A9R", "Tabuada do 9 Dominada", "Terminar a tabuada do 9 com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("AX", "Outra Tabuada Concluída", "Terminar qualquer outra tabuada com todas as respostas certas e sem usar o aleatório nem o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("AXG", "Outra Tabuada Conquistada", "Terminar qualquer outra tabuada com todas as respostas certas usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("AXR", "Outra Tabuada Dominada", "Terminar qualquer outra tabuada com todas as respostas certas usando o aleatório e o comutativo. O tempo em segundos não pode ultrapassar o dobro das perguntas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("C100", "100 Respostas Certas", "Acertar 100 vezes no total na resposta às tabuadas.\n\nA contagem de respostas certas prevalece entre jogos."),
                new AwardData("C300", "300 Respostas Certas", "Acertar 300 vezes no total na resposta às tabuadas.\n\nA contagem de respostas certas prevalece entre jogos."),
                new AwardData("C1000", "1000 Respostas Certas", "Acertar 1000 vezes no total na resposta às tabuadas.\n\nA contagem de respostas certas prevalece entre jogos."),
                new AwardData("T30", "Tempo 30 segundos", "Terminar qualquer tabuada em 30 segundos ou menos com todas as respostas certas e usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("T10", "Tempo 10 segundos", "Terminar qualquer tabuada em 10 segundos ou menos com todas as respostas certas e usando o aleatório e o comutativo.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("F1", "Desafio Final Magnífico", "Terminar uma ronda no modo \"Todas\" com todas as respostas certas.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("F2", "Desafio Final Majestoso", "Terminar uma ronda no modo \"Todas\" com todas as respostas certas e em menos de 30 segundos.\n\nDevem ser feitas pelo menos 10 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 10 questões."),
                new AwardData("F3", "Desafio Final Imponente", "Terminar uma ronda no modo \"Todas\" com todas as respostas certas, usando o aleatório e o comutativo e em menos de 1 minuto.\n\nDevem ser feitas pelo menos 20 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 20 questões."),
                new AwardData("F4", "Desafio Final Deslumbrante", "Terminar uma ronda no modo \"Todas\" com todas as respostas certas, usando o aleatório e o comutativo e em menos de 1 minuto e 20 segundos.\n\nDevem ser feitas pelo menos 50 questões e o valor mínimo deve ser maior que 0 se forem selecionadas 50 questões.")
            };
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