using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
/*there is something called autos , debug-windows-autos , it automatically show us the variables which are arround the current breakpoints* ,u
                         * should use it in the debugging mood*/

/* the other thing is the watch , debug-windows-watch-watch , should use it in the debugging mood , in watch u can add items like variables ,
             and check what is their value while you debug */

/*another thing is locals, locals shows you the variables that are available in the local context(in the scope we are currently looking at)
 * ,should use it in the debugging mood*/
 



            var friends = new List<string> {"frank","joe","michelle", "andy","maria" , "carlos" , "angelia" };
            var partyfriends = getpartyfriends(friends, 3);

            foreach(var name in partyfriends)
            {
                Console.WriteLine(name);
            }
        }

        public static List<string> getpartyfriends(List<string> list , int count)
        {
            var partyfriends = new List<string>();

            var buffer = new List<string>(list);

            while(partyfriends.Count< count)
            {
                var currentfriends = getpartyfriends(buffer);

                partyfriends.Add(currentfriends);

                //list.Remove(currentfriends);
                //here we are removing from the list itself , so you are deleting the element from the memory , so if 
                //you tried to access the list , u will find that it will have no value

            //solution here is  to make a copy from the list and delete from that copy
            buffer.Remove(currentfriends);
            
            }
            return partyfriends;
        }

        public static string getpartyfriends(List<string> list)
        {
            string shortestname = list[0];
            for(var i = 0; i<list.Count; i++)
            {
                if (list[i].Length > shortestname.Length)
                {
                    shortestname = list[i];
                }
            }
            return shortestname;
        }
    }
}
