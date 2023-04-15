namespace shazebalopolis.console.GCU
{
    public class HashTable
    {
        Dictionary<string, HashNode> hashPosts = new Dictionary<string, HashNode>()
        {
            { "AAA", new HashNode("", "Shazeb", "Suhail", "Shazebs") },
        };
        List<string> hashKeys;


        public static string HashCode()
        {
            return "";
        }
    }

    public class HashNode
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public List<HashNode> SiblingNodes { get; set; }

        public HashNode(string id, string firstName, string lastName, string userName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
        }
    }
}

/*
 
// FirstName and LastName

 [1] a, b, c, d, e, f, g, h, i

 [2] j, k, l, m, n, o, p, q, r

 [3] s, t, u, v, w, x, y, z

 
 // UserName

 [1] a, b, c

 [2] d, e, f

 [3] g, h, i

 [4] j, k, l

 [5] m, n, o

 [6] p, q, r 

 [7] s, t, u

 [8] v, w, x

 [9] y, z

 [0] 

 */
