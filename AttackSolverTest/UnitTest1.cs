using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using AttackSolver;
using Xunit;
using Xunit.Abstractions;

namespace AttackSolverTest
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            var insts = FindImplementations();
            if (insts.Count == 0)
                throw new Exception(
                    "No implementation of IAttackCounter was found, make sure you add a reference to your project to AttackSolverTest");

            foreach (var inst in insts)
            {
                output.WriteLine("Testing " + inst.GetType().FullName);
                /*
                // Rook - ladja
                    .o.
                    Ro.
                 */
                var res = inst.CountUnderAttack(ChessmanType.Rook, new Size(3, 2), new Point(1, 1),
                    new[] { new Point(2, 2), new Point(2, 1) });
                Assert.Equal(1, res);

                /*
                // Bishop - slon
                    ....
                    ....
                    o.o.
                    .B..
                    ....
                 */
                res = inst.CountUnderAttack(ChessmanType.Bishop, new Size(4, 5), new Point(2, 2),
                    new[] { new Point(1, 3), new Point(3, 3)});
                Assert.Equal(2, res);
            }
        }

        IList<IAttackCounter> FindImplementations()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IAttackCounter)))
                .Select(type => (IAttackCounter)Activator.CreateInstance(type)).ToList();
        }
    }
}