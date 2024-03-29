﻿//for working with excel we used information from
//http://csharp.net-informations.com/excel/csharp-create-excel.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
//using Microsoft.Office.Interop.Excel;

namespace TFT
{
    class Program
    {
        #region fields
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //private static ALog aLogger = new ALog();
        static bool excelAvailable = false;
        static Dictionary<IPlayer, int> scores;
        static int[,] results;
        static List<IPlayer> players;
        static List<IPlayer> newPlayers;
        #endregion
        static void Main(string[] args)
        {
            players = new List<IPlayer>();
            newPlayers = new List<IPlayer>();
            RunTFT();
        }

        private static void RunTFT()
        {
            logger.Fatal("S19Fatal test RunTFT started");
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp != null)
            //{
            //    excelAvailable = true;
            //}
            IPlayer geoPHelper = new GeoPHelper();
            IPlayer geoPHelper2 = new GeoPHelper2();
            IPlayer geoege = new GeoPlayer();
            IPlayer random = new RandomPlayer2();
            IPlayer smc = new SmartCostin();
            IPlayer costin = new Costin();
            IPlayer silviu = new Playersilviu();
            IPlayer mar = new MarPlayer();
            IPlayer mar2 = new MarPlayer2();
            IPlayer dp = new DanielPlayer2();
            IPlayer g2 = new GeoPlayer2();
            IPlayer diana = new DianaPlayer();
            IPlayer player2 = new Player2();
            IPlayer profu = new PlayLikeABoss();
            //IPlayer liviu = new LiviuPlayer();
            //var game = new Game(cristi2, boss);
            //var var = boss.GetType().ToString();
            //players.Add(random);
            players.Add(geoPHelper);
            players.Add(smc);
            players.Add(costin);
            players.Add(silviu);
            players.Add(mar);
            players.Add(mar2);
            players.Add(dp);
            players.Add(g2);
            players.Add(diana);
            players.Add(player2);
            players.Add(profu);
            logger.Trace("S19trace line after creating players List");
            //players = new List<IPlayer>() { };
            //newPlayers = new List<IPlayer>();


            var r = new Random();
            while (players.Count > 0)
            {
                var loto = players[r.Next(players.Count)];
                newPlayers.Add(loto);
                players.Remove(loto);
            }
            logger.Error("S19logException test before checking availability of excel");
            if (excelAvailable)
            {
                //_Workbook xlWorkBook = xlApp.Workbooks.Add();
                //_Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "ID";
                //xlWorkSheet.Cells[1, 2] = "Name";
                //xlWorkSheet.Cells[2, 1] = "1";
                //xlWorkSheet.Cells[2, 2] = "One";
                //xlWorkSheet.Cells[3, 1] = "2";
                //xlWorkSheet.Cells[3, 2] = "Two";
                //xlWorkBook.SaveAs("your-file-name.xls");
            }
            scores = new Dictionary<IPlayer, int>();
            results = new int[newPlayers.Count, newPlayers.Count];
            try
            {
                for (int i = 0; i < newPlayers.Count - 1; i++)
                {
                    for (int j = i + 1; j < newPlayers.Count; j++)
                    {
                        var game = new Game(newPlayers[i], newPlayers[j]);
                        game.RunGame();
                        var latestGameResults = game.Scores;
                        if (scores.ContainsKey(newPlayers[i]))
                        {
                            scores[newPlayers[i]] += latestGameResults[0];
                        }
                        else
                        {
                            scores.Add(newPlayers[i], latestGameResults[0]);
                        }
                        if (scores.ContainsKey(newPlayers[j]))
                        {
                            scores[newPlayers[j]] += latestGameResults[1];
                        }
                        else
                        {
                            scores.Add(newPlayers[j], latestGameResults[1]);
                        }
                        results[i, j] = latestGameResults[0];
                        results[j, i] = latestGameResults[1];
                    }
                }
                cwmatrice();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                //aLogger.Log("error message: " + e.Message + ";source: " + e.Source);
                logger.Error("error message: " + e.Message + ";source: " + e.Source);
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }

        private static void cwmatrice()
        {
            Console.Write("  ");
            for (int i = 0; i < newPlayers.Count; i++)
            {
                Console.Write(("P" + i).PadLeft(4, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < newPlayers.Count; i++)
            {
                Console.Write(("P" + i).PadRight(3, ' '));
                for (int j = 0; j < newPlayers.Count; j++)
                {
                    Console.Write(results[i, j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
