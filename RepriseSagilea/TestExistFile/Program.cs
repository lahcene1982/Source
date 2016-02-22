﻿using System;
using log4net;
using log4net.Config;
using System.Diagnostics;
using System.Configuration;

namespace TestExistFile
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger("logging");

        static void Main(string[] args)
        {
            //configuration de log4net
            XmlConfigurator.Configure();

            bool isStopWatch = bool.Parse(ConfigurationManager.AppSettings["watch"]);
            Log.Info("Début du traitement ...");

            //chrono temps d'execution
            Stopwatch watch = new Stopwatch();
            if(isStopWatch)  
                watch = Stopwatch.StartNew();

            //execution de la tâche
            Tasks.ExecuteMainTask(args);

            if (isStopWatch)
            {
                //arrêt chrono
                watch.Stop();

                Log.Info(string.Format("Temps d'execution total : {0} ms (soit {1})"
                    , watch.ElapsedMilliseconds.ToString()
                    , Tasks.GetTimeFromMilliseconds(watch.ElapsedMilliseconds)));
            }
        }

    }
}
