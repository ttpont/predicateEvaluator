using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PredicateEvaluatorNamespace;

namespace PredicateEvaluatorTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestIncreasingPredicateWithValidInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 0, 2, 4, 5 }, PredicateEvaluator.IncreasingPredicate);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIncreasingPredicateWithDecreasingInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 5, 2, 4, 1 }, PredicateEvaluator.IncreasingPredicate);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestDecreasingPredicateWithValidInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 5, 4, 3, 1 }, PredicateEvaluator.DecreasingPredicate);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestStrictlyIncreasingPredicateWithValidInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 0, 2, 4, 5 }, PredicateEvaluator.StrictlyIncreasingPredicate);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestStrictlyIncreasingPredicateWithOnlyIncreasingInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 0, 2, 4, 4 }, PredicateEvaluator.StrictlyIncreasingPredicate);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestStrictlyDecreasingPredicateWithValidInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 6, 5, 4, 1 }, PredicateEvaluator.StrictlyDecreasingPredicate);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestStrictlyDecreasingPredicateWithOnlyDecreasingInput()
        {
            var result = PredicateEvaluator.EvaluateSetAgainstPredicate(new List<int>() { 9, 8, 8, 4 }, PredicateEvaluator.StrictlyDecreasingPredicate);
            Assert.AreEqual(false, result);
        }
    }
}
