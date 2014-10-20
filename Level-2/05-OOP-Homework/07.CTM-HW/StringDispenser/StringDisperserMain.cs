namespace StringDisperser
{
    using System;
    public class StringDisperserMain
    {
        static void Main()
        {
            StringDisperser text = new StringDisperser("run", "fast");
            StringDisperser newText = (StringDisperser)text.Clone();
            text.TextBuilder.Append("rain is comming");
            newText.TextBuilder.Append("love");
            newText.TextBuilder.Append("is");
            newText.TextBuilder.Append("everywhere");

            foreach (var item in text)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            foreach (var item in newText)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}