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

        [Fact]
        public void CanGetValueWithCollision()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("eatk", 6);
            table.Add("kaet", 7);
            table.Add("atke", 10);
            table.Add("kate", 15);
            table.Add("aket", 22);

            var result = table.Get("kate");
            Assert.Equal(15, result);
        }

        [Fact]
        public void CanGetHashIndex()
        {
            HashTable<int> table = new HashTable<int>(16);
            int hash1 = table.GetHash("Dave");
            int hash2 = table.GetHash("Kate");
            int hash3 = table.GetHash("Nicco");
            int hash4 = table.GetHash("Leon");

            Assert.True(hash1 <= 16 && hash1 >= 0);
            Assert.NotEqual(hash1, hash2);
            Assert.True(hash2 <= 16 && hash2 >= 0);
            Assert.NotEqual(hash2, hash3);
            Assert.True(hash3 <= 16 && hash3 >= 0);
            Assert.NotEqual(hash3, hash4);
            Assert.True(hash4 <= 16 && hash4 >= 0);
        }




    }
}
