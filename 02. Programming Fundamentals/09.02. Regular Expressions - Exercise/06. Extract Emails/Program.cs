using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            MatchCollection collection = Regex.Matches(input, pattern);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
// 1 . (^|(?<=\s)) - Искаме да проверим дали има начало на стринг ИЛИ ( " | ") дали има празно място (това прави първа група) => positive lookahead

//2.   ([a-zA-Z0-9]+)([\.\-_]?) ([A-Za-z0-9]+)(@) - търсим :
//(дума, която съдържа букви и цифри)
//(после търсим някой от разрешените символи АКО има някое от тях, затова използваме "?")
//(после пак дума, която съдържа букви и цифри)
//тука броя на думите може да бъде 1

//3. (слагаме @)

//4. ([a-zA-Z]+([\.\-_][A-Za-z]+)+) - започваме с търсенето на дума , но задължително след първата дума трябва да има някой от разрешените символи "." ,  "-" или "_" , 
//иначе ще има грешката да има само една дума, а по условие се искат поне 2 думи и между тях да има един от разрешените символи и накрая domain - a(.bg , .net и т.н).
//например: @mail.uu.net
//([a - zA - Z]+([\.\-_][A - Za - z]+)+) - плюсът е важен за група 8 , тъй като търси още съвпадения ... това ти позволява да имаш маркираш още думи, 
//но задължително да започват със един от разрешените символи

//5. (\b|(?=\s))  Същото като 1. - търси за boundery \b Или positive lookahead(или погледни на дясно за да видиш дали има white space)

//ако не ти е ясно какво правят 1. и 5. Прочети за positive lookahead и negative lookahead