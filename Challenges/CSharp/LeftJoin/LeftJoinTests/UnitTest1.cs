using System;
using System.Collections.Generic;
using Xunit;
using static LeftJoin.LeftJoin;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanLeftJoinTwoHashMapsAllSameKeys()
        {
            var map1 = new Dictionary<string, string>() 
            {
                { "Happy", "Sad" },
                { "Great", "Terrible" },
                { "Cold", "Hot" },
                { "Arrive", "Depart" },
                { "Sharp", "Blunt" },
            };    
            var map2 = new Dictionary<string, string>() 
            {
                { "Happy", "Depressed" },
                { "Great", "Bad" },
                { "Cold", "Warm" },
                { "Arrive", "Leave" },
                { "Sharp", "Dull" },
            };

            string[,] expected = new string[,]
            {
                { "Happy", "Sad", "Depressed" },
                { "Great", "Terrible", "Bad" },
                { "Cold", "Hot", "Warm" },
                { "Arrive", "Depart", "Leave" },
                { "Sharp", "Blunt", "Dull" }
            };

            var result = (Join(map1, map2));

            Assert.Equal(expected, result);

        }      
        
        [Fact]
        public void CanLeftJoinTwoHashMapsNoSameKeys()
        {
            var map1 = new Dictionary<string, string>() 
            {
                { "Happy", "Sad" },
                { "Great", "Terrible" },
                { "Cold", "Hot" },
                { "Arrive", "Depart" },
                { "Sharp", "Blunt" },
            };    
            var map2 = new Dictionary<string, string>() 
            {
                { "Strong", "Weak" },
                { "Good", "Bad" },
                { "Shaven", "Hairy" },
                { "Stay", "Leave" },
                { "Difficult", "Easy" },
            };

            string[,] expected = new string[,]
            {
                { "Happy", "Sad", null },
                { "Great", "Terrible", null },
                { "Cold", "Hot", null },
                { "Arrive", "Depart", null },
                { "Sharp", "Blunt", null }
            };

            var result = (Join(map1, map2));

            Assert.Equal(expected, result);
        }       
        
        [Fact]
        public void CanLeftJoinTwoHashMapsSomeSameKeys()
        {
            var map1 = new Dictionary<string, string>() 
            {
                { "Happy", "Sad" },
                { "Great", "Terrible" },
                { "Cold", "Hot" },
                { "Arrive", "Depart" },
                { "Sharp", "Blunt" },
            };    
            var map2 = new Dictionary<string, string>() 
            {
                { "Great", "Awful" },
                { "Good", "Bad" },
                { "Shaven", "Hairy" },
                { "Happy", "Depressed" },
                { "Cold", "Warm" },
            };

            string[,] expected = new string[,]
            {
                { "Happy", "Sad", "Depressed" },
                { "Great", "Terrible", "Awful" },
                { "Cold", "Hot", "Warm" },
                { "Arrive", "Depart", null },
                { "Sharp", "Blunt", null }
            };

            var result = (Join(map1, map2));

            Assert.Equal(expected, result);
        }
    }
}
