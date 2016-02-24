using System;
using System.Threading;
using Thinknode;

namespace App
{

    class App : Provider
    {
        // ***
        // REPLACE THE METHODS WITHIN THESE MARKERS WITH THE METHODS DEFINED IN YOUR MANIFEST.
        // ***

        /// <summary>
        /// Add the specified integers a and b.
        /// </summary>
        /// <returns>The result of adding a and b.</returns>
        /// <param name="a">The integer a.</param>
        /// <param name="b">The integer b.</param>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Adds the specified integers while reporting progress.
        /// </summary>
        /// <returns>The result of adding a and b.</returns>
        /// <param name="a">The integer a.</param>
        /// <param name="b">The integer b.</param>
        /// <param name="progress">The progress callback.</param>
        public static int AddWithProgress(int a, int b, ProgressDelegate progress)
        {
            progress(0.25f, "25%");
            Thread.Sleep(1000);
            progress(0.5f, "50%");
            Thread.Sleep(1000);
            progress(0.75f, "75%");
            Thread.Sleep(1000);
            return a + b;
        }

        /// <summary>
        /// Reports a failure before adding the integers.
        /// </summary>
        /// <returns>The result of adding a and b.</returns>
        /// <param name="a">The integer a.</param>
        /// <param name="b">The integer b.</param>
        /// <param name="fail">The failure callback.</param>
        public static int AddWithFailure(int a, int b, FailureDelegate fail)
        {
            fail("my_error", "This is a test of the error functionality");
            return a + b;
        }

        /// <summary>
        /// Computes the average age given the specified list of Person objects.
        /// Note: This function's purpose is to demonstrate the MessagePack Serialization
        /// and Deserialization of the Person class.
        /// </summary>
        /// <returns>The average age</returns>
        /// <param name="list">A list of Person objects.</param>
        public static double AverageAge(Person[] list)
        {
            double running_avg = 0;
            int count = 0;
            for (var i = 0; i < list.Length; ++i)
            {
                running_avg = ((running_avg * count) + list[i].age) / (count + 1);
                count++;
            }
            return running_avg;
        }

        /// <summary>
        /// Gets the length of the byte array.
        /// </summary>
        /// <returns>The byte array length.</returns>
        /// <param name="arr">The byte array.</param>
        public static int GetByteArrayLength(byte[] arr)
        {
            return arr.Length;
        }

        /// <summary>
        /// Gets the year component of the given datetime value.
        /// </summary>
        /// <returns>The year.</returns>
        /// <param name="val">The datetime value.</param>
        public static uint GetYear(DateTime val)
        {
            return Convert.ToUInt32(val.Year);
        }

        // ***
        // REPLACE THE METHODS WITHIN THESE MARKERS WITH THE METHODS DEFINED IN YOUR MANIFEST.
        // ***

        /// <summary>
        /// MODIFY THIS MAIN METHOD WITH CARE.
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Create App instance.
            App app = new App();

            // Start app.
            app.Start();
        }
    }
}