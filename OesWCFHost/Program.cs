﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using OesWCFContract;
using OesWCFImpl;

namespace OesWCFHost
{
    class Program
    {
        public static void Main(string[] args)
        {
            using(ServiceHost examHost = new ServiceHost(typeof(ExamService)))
            using (ServiceHost questionHost = new ServiceHost(typeof(QuestionService)))
            using (ServiceHost userHost = new ServiceHost(typeof(UserService)))
            {
                userHost.Open();
                examHost.Open();
                questionHost.Open();

                Console.WriteLine("Service started, Press ENTER to stop and exit.");
                Console.ReadLine();
            }
        }
    }
}
