namespace SpravceHesel
{
interface IHeslo{
        int DelkaHesla();  
        int MaxDelkaHesla();  
        int MinDelkaHesla();  
    }

    class Heslo : IHeslo
    {
        private string heslo;
        public static int maxDelkaHesla = 20;
        public static int minDelkaHesla = 8;
        
        private string [] maleZnaky = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

        private string [] velkeZnaky = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];

        private int [] cislice = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        private string [] specialniZnaky = ["!", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "\\", "]", "^", "_", "{", "|", "}", "~"];
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
        public static string GeneratorHesla(int pocetZnakuHesla){
        
    }
        //concat - spojí všechna pole
    

    }
}