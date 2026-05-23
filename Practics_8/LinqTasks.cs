using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_8
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public class LinqTasks
    {
        // Task 1
        public IEnumerable<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0);
        }

        // Task 2
        public int GetSum(List<int> numbers)
        {
            return numbers.Sum();
        }

        // Task 3
        public IEnumerable<string> GetLongStrings(List<string> strings)
        {
            return strings.Where(s => s.Length > 3);
        }

        // Task 4
        public Person FindPersonByName(List<Person> people, string name)
        {
            return people.FirstOrDefault(p => p.Name == name);
        }

        // Task 5
        public IEnumerable<int> SortDescending(List<int> numbers)
        {
            return numbers.OrderByDescending(n => n);
        }

        // Task 6
        public IEnumerable<IGrouping<int, Person>> GroupByAge(List<Person> people)
        {
            return people.GroupBy(p => p.Age);
        }

        // Task 7
        public bool AnyNumberGreaterThanTen(List<int> numbers)
        {
            return numbers.Any(n => n > 10);
        }

        // Task 8
        public IEnumerable<string?> SelectNames(List<Person> people)
        {
            return people.Select(p => p.Name);
        }

        // Task 9
        public bool AllPositive(List<int> numbers)
        {
            return numbers.All(n => n > 0);
        }

        // Task 10
        public IEnumerable<int> ConcatenateLists(List<int> first, List<int> second)
        {
            return first.Concat(second);
        }
    }
}