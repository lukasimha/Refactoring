using System;
using NUnit.Framework;

namespace Refactoring
{
    [TestFixture] 
    public class DateParserTest
    {
    
        [Test]
        public void shouldThrowExceptionIfYearStringCannotBeParsed()
        {
            try {
                new DateParser("111").parse();
                Assert.Fail("Should have failed since the year string is less than 4 characters");
            } catch (Exception e) {
                Assert.AreEqual("Year string is less than 4 characters", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfYearIsNotInteger()
        {
            try {
                new DateParser("abcd").parse();
                Assert.Fail("Should have failed since the year string is not an integer");
            } catch (Exception e) {
                Assert.AreEqual("Year is not an integer", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfYearIsLessThan2000()
        {
            try {
                new DateParser("1999").parse();
                Assert.Fail("Should have failed since the year is less than 2000");
            } catch (Exception e) {
                Assert.AreEqual("Year cannot be less than 2000 or more than 2012", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMonthStringCannotBeParsed()
        {
            try {
                new DateParser("2012-1").parse();
                Assert.Fail("Should have failed since the month string is less than 2 characters");
            } catch (Exception e) {
                Assert.AreEqual("Month string is less than 2 characters", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMonthIsNotInteger()
        {
            try {
                new DateParser("2012-ab").parse();
                Assert.Fail("Should have failed since the month string is not an integer");
            } catch (Exception e) {
                Assert.AreEqual("Month is not an integer", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMonthIsMoreThan12()
        {
            try {
                new DateParser("2012-13").parse();
                Assert.Fail("Should have failed since the month is more than 12");
            } catch (Exception e) {
                Assert.AreEqual("Month cannot be less than 1 or more than 12", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfDateStringCannotBeParsed()
        {
            try {
                new DateParser("2012-12-1").parse();
                Assert.Fail("Should have failed since the date string is less than 2 characters");
            } catch (Exception e) {
                Assert.AreEqual("Date string is less than 2 characters", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfDateIsNotInteger()
        {
            try {
                new DateParser("2012-12-ab").parse();
                Assert.Fail("Should have failed since the date string is not an integer");
            } catch (Exception e) {
                Assert.AreEqual("Date is not an integer", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfDateIsMoreThan31()
        {
            try {
                new DateParser("2012-12-32").parse();
                Assert.Fail("Should have failed since the date is more than 31");
            } catch (Exception e) {
                Assert.AreEqual("Date cannot be less than 1 or more than 31", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfHourStringCannotBeParsed()
        {
            try {
                new DateParser("2012-12-11T0").parse();
                Assert.Fail("Should have failed since the hour string is less than 2 characters");
            } catch (Exception e) {
                Assert.AreEqual("Hour string is less than 2 characters", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfHourIsNotInteger()
        {
            try {
                new DateParser("2012-12-30Tab").parse();
                Assert.Fail("Should have failed since the hour string is not an integer");
            } catch (Exception e) {
                Assert.AreEqual("Hour is not an integer", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfHourIsMoreThan23()
        {
            try {
                new DateParser("2012-12-31T24").parse();
                Assert.Fail("Should have failed since the hour is more than 23");
            } catch (Exception e) {
                Assert.AreEqual("Hour cannot be less than 0 or more than 23", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMinuteStringCannotBeParsed()
        {
            try {
                new DateParser("2012-12-11T01:1").parse();
                Assert.Fail("Should have failed since the minute string is less than 2 characters");
            } catch (Exception e) {
                Assert.AreEqual("Minute string is less than 2 characters", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMinuteIsNotInteger()
        {
            try {
                new DateParser("2012-12-30T01:ab").parse();
                Assert.Fail("Should have failed since the minute string is not an integer");
            } catch (Exception e) {
                Assert.AreEqual("Minute is not an integer", e.Message);
            }
        }
    
        [Test]
        public void shouldThrowExceptionIfMinuteIsMoreThan59()
        {
            try {
                new DateParser("2012-12-31T23:60").parse();
                Assert.Fail("Should have failed since the minute is more than 59");
            } catch (Exception e) {
                Assert.AreEqual("Minute cannot be less than 0 or more than 59", e.Message);
            }
        }
    
        [Test]
        public void shouldParseDateForValidInput()
        {
            DateTime result = new DateParser("2012-12-31T23:59Z").parse();
    
            Assert.AreEqual(2012, result.Year);
            Assert.AreEqual(12, result.Month);
            Assert.AreEqual(31, result.Day);
        }
    }
}