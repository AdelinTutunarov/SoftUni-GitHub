namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TestCase(0)]
        [TestCase(7)]
        [TestCase(16)]
        public void ConstructorAndFetchMethodTests_ValidCases(int n)
        {
            Person[] people = CreatePersonArr(n);
            Database db = new Database(people);

            Assert.AreEqual(people.Length, db.Count);
        }

        [TestCase(17)]
        [TestCase(20)]
        public void ConstructorWithMoreThan16Elements_ShouldThrow(int n)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Person[] people = CreatePersonArr(n);
                Database db = new Database(people);
            });
        }

        [TestCase(0)]
        [TestCase(7)]
        [TestCase(15)]
        public void AddMethod_ValidCases(int n)
        {
            Person[] people = CreatePersonArr(n);
            Database db = new Database(people);
            db.Add(new Person(99,""));
            Assert.AreEqual(people.Length + 1, db.Count);
        }

        [TestCase(16)]
        [TestCase(17)]
        public void AddMethod_InValidCases_ShouldThrow(int n)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Person[] people = CreatePersonArr(n);
                Database db = new Database(people);
                db.Add(new Person(99, ""));
            });
        }

        [TestCase(1)]
        [TestCase(7)]
        [TestCase(16)]
        public void RemoveMethod_ValidCases(int n)
        {
            Person[] people = CreatePersonArr(n);
            Database db = new Database(people);
            db.Remove();

            Assert.AreEqual(people.Length - 1, db.Count);
        }

        [TestCase(0)]
        [TestCase(17)]
        public void RemoveMethod_InValidCases_ShouldThrow(int n)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Person[] people = CreatePersonArr(n);
                Database db = new Database(people);
                db.Remove();
            });
        }

        private Person[] CreatePersonArr(int n)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                people.Add(new Person(i, ""));
            }
            return people.ToArray();
        }
    }
}