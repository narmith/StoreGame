public struct Menu
{
    //static int id0 = 0;
    static string id0desc = "null";
    //static int id1 = 0;
    static string id1desc = "glass of water";
    /*
    static int id2 = 0;
    static string id2desc = "black coffe";
    static int id3 = 0;
    static string id3desc = "coffe with suga";
    static int id4 = 0;
    static string id4desc = "coffe with milk";
    static int id5 = 0;
    static string id5desc = "beer";
    static int id6 = 0;
    static string id6desc = "wine";
    static int id7 = 0;
    static string id7desc = "whisky";
    static int id8 = 0;
    static string id8desc = "glass of water";
    static int id9 = 0;
    static string id9desc = "glass of water";
    static int id10 = 0;
    static string id10desc = "glass of water";
    static int id11 = 0;
    static string id11desc = "glass of water";
    static int id12 = 0;
    static string id12desc = "glass of water";
    */

    static public string getItem(int _id)
    {
        string some = "id" + _id + "desc";
        if (some == "id1desc")
        {
            return id1desc;
        }
        else return id0desc;
    }

}
