using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzDrink
{
    public class EzDrinkModelToolBox
    {
        private const int NAME_INDEX = 0;
        private const int PRICE_INDEX = 1;
        private const int ROW_SIZE = 2;

        //Get Addition List String
        public List<List<string>> GetListString<T>(List<T> list)
        {
            List<List<string>> result = new List<List<String>>();
            foreach (T eachItem in list)
            {
                if (eachItem is Drink)
                    result.Add((eachItem as Drink).GetDataList());
                else if (eachItem is DrinkAddition)
                    result.Add((eachItem as DrinkAddition).GetDataList());
                else
                    result.Add((eachItem as Order).GetDataList());
            }
            return result;
        }

        //Is Success Load List
        public bool IsSuccessLoadList<T>(ref List<T> list, string filePath)
        {
            string typeParameterType = typeof(T).ToString();
            try
            {
                System.IO.StreamReader drinkMenuFile = new System.IO.StreamReader(filePath, Encoding.Default);
                List<List<string>> data = ReadFileLine(drinkMenuFile);
                if (data.Count == 0)
                    return false;
                list.Clear();
                foreach (List<string> eachRow in data)
                    list.Add((T)Activator.CreateInstance(Type.GetType(typeParameterType),eachRow[NAME_INDEX], int.Parse(eachRow[PRICE_INDEX])));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Read File Line
        private List<List<string>> ReadFileLine(System.IO.StreamReader file)
        {
            string line;
            List<List<string>> data = new List<List<string>>();
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                const char SPACE = ' ';
                List<string> tempList = line.Split(SPACE).ToList();
                if (IsFitFormat(tempList))
                    data.Add(tempList);
                else
                    return new List<List<string>>();
            }
            return data;
        }

        //Is Fit Format
        private bool IsFitFormat(List<string> list)
        {
            if (list.Count == ROW_SIZE)
            {
                int temp = 0;
                int tempPrice = 0;
                if (!int.TryParse(list[0], out temp) && int.TryParse(list[1], out tempPrice) && !string.IsNullOrEmpty(list[0]) && !string.IsNullOrEmpty(list[1]) && !string.IsNullOrWhiteSpace(list[0]) && !string.IsNullOrWhiteSpace(list[1]))
                {
                    if (tempPrice >= 0)
                        return true;
                }
            }
            return false;
        }
    }
}
