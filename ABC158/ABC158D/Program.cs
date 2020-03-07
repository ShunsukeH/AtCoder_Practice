using System;
using System.Text;

namespace ABC158D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            StringBuilder sbRev = new StringBuilder();
            sb.Append(s);
            sbRev.Append(s);
            int q = int.Parse(Console.ReadLine());
            bool isOrdered = true;
            for (int i = 0; i < q; i++)
            {
                string[] query = Console.ReadLine().Split();
                if (query[0] == "1")
                {
                    isOrdered = !isOrdered;
                }
                else
                {
                    if (query[1] == "1")
                    {
                        if (isOrdered)
                        {
                            // prefix
                            sb.Insert(0, query[2]);
                            sbRev.Append(query[2]);
                        }
                        else
                        {
                            //suffix
                            sb.Append(query[2]);
                            sbRev.Insert(0, query[2]);
                        }
                    }
                    else
                    {
                        if (isOrdered)
                        {
                            //suffix
                            sb.Append(query[2]);
                            sbRev.Insert(0, query[2]);
                        }
                        else
                        {
                            // prefix
                            sb.Insert(0, query[2]);
                            sbRev.Append(query[2]);
                        }
                    }
                }
            }

            Console.WriteLine(isOrdered ? sb.ToString() : sbRev.ToString());
        }
    }
}
