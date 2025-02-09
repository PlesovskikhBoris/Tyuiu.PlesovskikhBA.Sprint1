using System.Text.Json;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            string valuelower;
            valuelower = value.ToLower();
            if (value == valuelower)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
