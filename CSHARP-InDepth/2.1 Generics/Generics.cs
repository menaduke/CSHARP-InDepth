using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CSHARP_InDepth._2._1
{
    class Generics
    {
        public void MainInitializerAsync()
        {
            string[] stringArray = GenerateArrayStringNames();
            Console.WriteLine($"String Array: {JsonConvert.DeserializeObject(JsonConvert.SerializeObject(stringArray))}, size: {stringArray.Length}");
            ArrayList stringArrayList = GenerateArrayListStringNames();
            Console.WriteLine($"String ArrayList: {JsonConvert.DeserializeObject(JsonConvert.SerializeObject(stringArrayList))}, size: {stringArrayList.Count}");
            List<string> stringList = GenerateListStringNames<string>();
            // using generics for this add function to use the typing of the list and the typing of added value
            addToList(stringList, "Theo");
            addToList(stringList, "Markus");
            addToList(stringList, "Clara");
            addToList(stringList, "Alexis");
            Console.WriteLine($"String List<string>: {JsonConvert.DeserializeObject(JsonConvert.SerializeObject(stringList))}, size: {stringList.Count}");
            Console.WriteLine($"check out this list i created by passing a type to its type parameter now it can create a list with those types (int)s");
            List<int> listOfInts = CreateGenericListBasedOnTypeParameter<int>();
            listOfInts.Add(3);
            listOfInts.Add(5);
            Console.WriteLine($"List<int>: {JsonConvert.DeserializeObject(JsonConvert.SerializeObject(listOfInts))}, size: {listOfInts.Count}");
            Dictionary<string, int> aDictionary = CreateGenericDictionaryBasedOnTypeParameter<string, int>();
            Console.WriteLine($"check out this dictionary i created by passing a type to its type parameter now it can create a list with those types (string, int)s");
            aDictionary.Add("key1", 1);
            aDictionary.Add("key2", 3);
            Console.WriteLine($"dictionary<string,int>: {JsonConvert.DeserializeObject(JsonConvert.SerializeObject(aDictionary))}, size: {aDictionary.Count}");
        }
        public string[] GenerateArrayStringNames()
        {
            // using array syntax, remember arrays are fixed sized and need to increased manually to make larger
            string[] names = new string[3];
            names[0] = "Carl";
            names[1] = "Tina";
            names[2] = "Michael";
            return names;
        }
        public ArrayList GenerateArrayListStringNames()
        {
            // using arraylist syntax we can have variable sizes
            ArrayList names = new ArrayList();
            names.Add("Eddie");
            names.Add("Laura");
            names.Add("Donald");
            names.Add("Elizabeth");
            return names;
        }

        public List<T> GenerateListStringNames<T>()
        {
            List<T> names = new List<T>();
            return names;
        }

        public void addToList<T>(List<T> list, T value) {
            list.Add(value);
        }

        public List<T> CreateGenericListBasedOnTypeParameter<T> ()
        {
            List<T> genericTypeList = new List<T>();
            return genericTypeList;
        }

        public Dictionary<Key, Value> CreateGenericDictionaryBasedOnTypeParameter<Key, Value>()
        {
            Dictionary<Key, Value> genericTypeDictionary = new Dictionary<Key, Value>();
            return genericTypeDictionary;
        }
    }
}
