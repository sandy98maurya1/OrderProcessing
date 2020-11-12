using OrderProcessing.src.order.processing.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OrderProcessing.src.order.processing.exception
{
    /// <summary>
    /// created class for common exception Log
    /// </summary>
    public sealed class Logexception
    {
        private static Object thread = new object();
        private static Logexception exception;
        private Logexception() { }

        public static Logexception obj
        {
            get
            {

                if (exception == null)
                {
                    lock (thread)
                    {
                        if (exception == null)
                            exception = new Logexception();
                    }
                }
                return exception;
            }
        }

        public void Log(string exception)
        {
            if (File.Exists(OrderConfig.LOG_Folder_PATH))
            {
                using (var tw = new StreamWriter(OrderConfig.LOG_Folder_PATH, true))
                {
                    tw.WriteLine(" * " + exception);
                }
            }

        }

    }
}
