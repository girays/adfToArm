﻿using AdfToArm.Core.Logs;
using System;

namespace AdfToArm
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public ConsoleLogger(bool verbose)
        {
            _verbose = verbose;
        }

        private bool _verbose;

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.UtcNow}]: ERROR! {message}");
            Console.WriteLine();
            Console.ResetColor();
        }

        public void Info(string message)
        {
            if (!_verbose)
                return;

            Console.WriteLine($"[{DateTime.UtcNow}]: {message}");
        }

        public void SetLoggingLevel(bool verbose)
        {
            _verbose = verbose;
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.UtcNow}]: {message}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}