using System;
using System.Runtime.CompilerServices;

namespace shazebalopolis.console.GCU
{
    public class Internships
    {
        public static Dictionary<string, string> internships = new Dictionary<string, string>
        {
            { "Dropbox: $8,500 per month, Remote, iOS/Android", "NOT APPLIED" },
            { "Viasat: Remote, Carlsbad California, up to $74.1k/year, VICE Team ", "APPLIED" },
            { "Sony Playstation: ", "NOT APPLIED" },
            { "Instagram: ", "NOT APPLIED" },
            { "Snapchat: ", "NOT APPLIED" },
            { "SpaceX: Spring 2023 Software Engineering Intern", "APPLIED" },
            { "SpaceX: Summer 2023 Software Engineering Intern", "APPLIED" },
            { "NASA: ", "NOT APPLIED" },
            { "Twitch: ", "APPLIED" },
            { "TikTok: (Creative Tools) Team", "APPLIED" },
            { "TikTok: (Ads Platform & Interface) Team", "APPLIED" },
            { "Intel: ", "REJECTED" },
            { "Netflix: ", "APPLIED" },
            { "Activision: Game Development", "APPLIED" },
            { "Tencent: Tools Programmer Intern, $111,878 salary", "APPLIED" },
            { "Gamestop: Mechanical/Electrical Engineer Internship, $57,416 salary", "APPLIED" },
            { "HP: $80,605 salary", "APPLIED" },
            { "Meta: Software Engineer Intern/Co-Op, Java/JavaScript/C++, $89.3k-$113k", "NOT APPLIED" },
            { "US Tech: Software Engineer Summer, C#/JavaScript/Angular/Azure, $67.6k-$85.7k", "APPLIED--1/22/2022" },
            { "Paylocity: up to $30/hr, C#", "APPLIED--1/22/2022" },
            { "Keysight Technologies: R&D Software Engineer Internship $29.30-$38.32, C#", "APPLIED--1/22/2022" },
            { "W. L. Gore & Associates: 2023 IT Architect Summer Internship, $72 .8k-$92.2k, C#", "APPLIED--1/22/2022" },
            { "Oracle: Software Engineer Intern - UNCF, $66.9k-$84.7k, C#", "NOT APPLIED--1/22/2022" },
            { "Affinitive: Quality Assurance (QA) Engineer Intern, C#", "APPLIED--1/22/2022" },
            { "PWC (Price Waterhouse Coopers): $56k-$71k, C#", "APPLIED--1/22/2022" },
            { "ECS: $67.7k-$85.7k, C#", "APPLIED--1/22/2022" },
            { "UKG (Ultimate Kronos Group): $65k-$82.3k, C#", "NOT APPLIED--1/22/2022" },
            { "Medidata Solutions: Rave Platform Technology Summer Intern, New York, $34-$37, C#", "APPLIED--1/22/2022" },
            { "Auctane Careers: Software Engineering Intern, Austin Texas, $59.1k-$74.9k, C#", "APPLIED--1/22/2022" },
            { "Intuitive: Manufacturing Software Engineer Intern, Sunnyvale California, $34-$59, C#", "APPLIED--1/22/2022" },
            { "PACCAR: Software Engineer - Test Engineering, Mount Vernon Washington, $30, C#", "APPLIED--1/22/2022" },
            { "Cvent: Application Security Intern, Tysons Corner Virginia, $65.1k-$82.4k, C#", "APPLIED--1/22/2022" },
            { "Tesla: Software Engineering Intern - Vehicle Engineering, Austin Texas, $75.5k-$95.6k, C#", "APPLIED--1/22/2022" },
            { "UWM (United Wholesale Mortgage): Application Development, Pontiac Michigan, $56.2k-$71.2k, C#", "APPLIED--1/22/2022" },
            { "TikTok: Software Engineer Intern (Cross Platform), Mountain View California, $45/hr, C#", "NOT APPLIED--1/22/2022" },
            { "Nintendo of America Inc.: CPU Debugger Software Engineer (NTD), Redmond Washington, $40/hr, C#", "APPLIED--1/22/2022" },
            { "Nintendo of America Inc.: GPU Tools Software Engineer (NTD), Redmond Washington, $40/hr, C#", "APPLIED--1/22/2022" },
            { "ByteDance: Software Engineer Intern (XR Engine adn Runtime), Mountain View California, $75.7k-$95.9k, C#", "NOT APPLIED--1/22/2022" },
            { "UiPath: Software Engineer Intern, Bellevue Washington, $68.7k-$86.9k, C#", "APPLIED--1/22/2022" },
            { "Fastly: Software Engineer Intern, San Francisco California, $30-$35, JavaScript", "APPLIED--1/22/2022" },
            { "Meta: Front End Engineer Intern, New York NY, $82k-$104k, JavaScript", "APPLIED--1/22/2022" },
            { "Spotify: Back End Engineer Intern, New York NY, $33, JavaScript", "APPLIED--1/22/2022" },
            { "Discord: Back End Engineer Intern - Native Framework & Tools, Remote San Francisco California, $67, JavaScript", "APPLIED--1/22/2022" },
            { "CLEAR: Software Engineer Intern (Intern Cohort), Austin Texas, $55.7k-$70.5k, JavaScript", "APPLIED--1/22/2022" },
            { "General Motors: Software Engineer Intern, Warren Michigan, $54.2k-$68.7k, JavaScript", "APPLIED--1/22/2022" },
            { "FanDuel: Software Engineer Intern, Atlanta Georgia, $104k-$132k, JavaScript", "APPLIED--1/22/2022" },
            { "West Monroe: Software Engineer Intern - Product Experience & Engineering Lab, Remote United States, $39, JavaScript", "NOT APPLIED--1/22/2022" },
            { "Zoox: Frontend Software Engineer Intern - Driving Tools, Foster City California, $6,500-$9,500, JavaScript", "NOT APPLIED--1/22/2022" },
        }; 
        
        /// <summary>
        /// Main Driver method for executing console output.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (true)
            {
                GetApplied();
                GetNotApplied();
                GetRejectedApps();
            }
            else GetAllAppStatus(); 
        }

        public static void GetAllAppStatus()
        {
            var count = 1;
            foreach (var internship in internships)
            {
                DisplayCompanyName(internship, count++);
                switch (GetAppType(internship.Value)) 
                {
                    case "APPLIED":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case "NOT APPLIED":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;

                    case "REJECTED":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    default:break;
                }
                Console.Write(internship.Value.Split("--")[0]);
                Console.ResetColor();
                DisplayDate(internship.Value);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Get "APPLIED" items.
        /// </summary>
        /// <param name="internships"></param>
        public static void GetApplied(string category = "APPLIED")
        {
            Console.WriteLine($"// {category}"); 
            var pending = internships.Where(x => x.Value.StartsWith(category)); 
            var count = 1; 
            foreach (var x in pending)
            {
                DisplayCompanyName(x, count++);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(category);
                Console.ResetColor();
                DisplayDate(x.Value); 
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Get "NOT APPLIED" items.
        /// </summary>
        /// <param name="internships"></param>
        public static void GetNotApplied(string category = "NOT APPLIED")
        {
            Console.WriteLine($"// {category}");
            var options = internships.Where(x => x.Value.StartsWith(category));
            var count = 1;
            foreach (var x in options)
            {
                DisplayCompanyName(x, count++);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(category);
                Console.ResetColor();
                DisplayDate(x.Value);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Get "REJECTED" items.
        /// </summary>
        /// <param name="internships"></param>
        public static void GetRejectedApps(string category = "REJECTED")
        {
            Console.WriteLine($"// {category}");
            var rejections = internships.Where(x => x.Value.StartsWith(category));
            var count = 1;
            foreach (var x in rejections)
            {
                DisplayCompanyName(x, count++);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(category);
                Console.ResetColor();
                DisplayDate(x.Value);
            }
            Console.WriteLine();
        }

        public static void DisplayDate(string value)
        {
            var values = value.Split("--");
            if (values.Length > 1)
            {
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(values[1]);
                Console.ResetColor();
            }
            else
                Console.WriteLine();
        }

        public static void DisplayCompanyName(KeyValuePair<string, string> internship, int count)
        {
            var details = internship.Key.Split(':');
            Console.Write($"{count}. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{details[0]}");
            Console.ResetColor();
            Console.Write($" -{details[1]} - ");
        }

        public static string GetAppType(string value)
        {
            if (value.StartsWith("APPLIED")) return "APPLIED";
            if (value.StartsWith("NOT APPLIED")) return "NOT APPLIED";
            if (value.StartsWith("REJECTED")) return "REJECTED";
            return "";
        }
    }
}
