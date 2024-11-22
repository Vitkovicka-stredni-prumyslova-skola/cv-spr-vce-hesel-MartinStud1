namespace SpravceHesel
{
    interface IHeslo
    {
        int DelkaHesla();  
        int MaxDelkaHesla();  
        int MinDelkaHesla();  
    }

    class Heslo : IHeslo
    {
        private string heslo;

        private static int maxDelkaHesla = 20;
        public static int minDelkaHesla = 8;
        
        public int DelkaHesla()
        {
            return heslo.Length; 
        }

        public int MaxDelkaHesla()
        {
            return maxDelkaHesla; 
        }

        public int MinDelkaHesla()
        {
            return minDelkaHesla; 
        }
    }
}