using System;
using MsgPack.Serialization;
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
        /// <param name="a">The integer a.</param>
        /// <param name="b">The integer b.</param>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Computes the average age given the specified list of Person objects.
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

        // ***
        // REPLACE THE METHODS WITHIN THESE MARKERS WITH THE METHODS DEFINED IN YOUR MANIFEST.
        // ***

        /// <summary>
        /// DO NOT MODIFY THIS MAIN METHOD EXCEPT ON THE LINES MARKED.
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Create App instance.
            App app = new App();

            // Add Serializers (DELETE OR MODIFY THIS LINE)
            app.context.Serializers.RegisterOverride(new PersonSerializer(app.context));

            // Start app.
            app.Start();
        }
    }
}