namespace Regexes_1._5
{
    internal class Program
    {

        public static bool IsSpecial(char c) => "^%$@#&*!?".Contains(c);

        public static bool IsLetter(char c) => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');

        public static bool IsNumber(char c) => char.IsDigit(c);

        public static bool IsAcceptable(char c) => IsSpecial(c) || IsLetter(c) || IsNumber(c);

        static bool IsCorrect(string input)
        {
            if (input.Length < 8) return false; // Если длина меньше 8, сразу нет
            ReadOnlySpan<char> span = input.AsSpan();
            HashSet<char> specials = new HashSet<char>();
            char previous = '_';
            bool LatinInUp = false;
            bool LatinInLow = false;
            bool HasNumber = false;

            foreach (char c in span)
            {
                if (!IsAcceptable(c)) return false;//Если не число, не буква и не спецсимвол - сразу нет
                if (c == previous) return false; //Если повтор с предыдущим - сразу нет
                LatinInUp |= IsLetter(c) && char.IsUpper(c);//LatinInUp будет true, если встретится буква в верхнем регистре
                LatinInLow |= IsLetter(c) && char.IsLower(c);//Аналогично
                HasNumber |= IsNumber(c);//Аналогично
                if (IsSpecial(c))
                    specials.Add(c);//Добавляем специальный символ в кучу

                previous = c;//Меняем предыдущий
            }

            return specials.Count >= 2 && HasNumber && LatinInLow && LatinInUp; //True при соблюдении всех условий выше
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите пароль> ");
                string pass = Console.ReadLine();
                Console.WriteLine(IsCorrect(pass) ? "Пароль верный" : "Пароль не верный");
            }
        }
    }
}