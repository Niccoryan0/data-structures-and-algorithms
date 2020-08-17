using HashTable;
using System;
using Xunit;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToTable()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("Nicco", 10);
            Assert.NotNull(table);
        }

        [Fact]
        public void CanGetValue()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("Dave", 6);
            table.Add("Kate", 7);
            table.Add("Nicco", 10);

            var result = table.Get("Kate");
            Assert.Equal(7, result);
        }

        [Fact]
        public void CanFindContainedValue()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("Dave", 6);
            table.Add("Kate", 7);
            table.Add("Nicco", 10);

            var result = table.Contains("Kate");
            Assert.True(result);
        }    
        
        [Fact]
        public void CanReturnFalseForUnfoundValues()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("Dave", 6);
            table.Add("Kate", 7);
            table.Add("Nicco", 10);

            var result = table.Contains("Jimmy");
            Assert.False(result);
        }

    }
}
