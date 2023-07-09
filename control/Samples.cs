using System;

namespace CsharpExample.Control
{
    class ControlSamples
    {
        public void Exec()
        {
            LoopSample loopSample = new LoopSample();
            loopSample.ExecForLoop();
            loopSample.ExecForLoopWithBreak();
            loopSample.ExecForLoopWithContinue();
            loopSample.ExecForEachLoop();
            loopSample.ExecWhileLoop();
            loopSample.ExecDoWhileLoop();

            TryCatchSample tryCatchSample = new TryCatchSample();
            tryCatchSample.ExecTryCatch();

            SwitchSample switchSample = new SwitchSample();
            switchSample.ExecSwitch();
            Console.WriteLine(switchSample.ExecSwitchExpression(1));
            Console.WriteLine(switchSample.ExecSwitchExpression(10));

            Console.WriteLine(switchSample.ExecSwitchExpressionWithCompare(10));
            Console.WriteLine(switchSample.ExecSwitchExpressionWithCompare(5));
            Console.WriteLine(switchSample.ExecSwitchExpressionWithCompare(3));
            Console.WriteLine(switchSample.ExecSwitchExpressionWithCompare(0));

            Console.WriteLine(switchSample.ExecPatternMatchingWithType(100));
            Console.WriteLine(switchSample.ExecPatternMatchingWithType("文字"));
            Console.WriteLine(switchSample.ExecPatternMatchingWithType(true));

            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare(10));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare(-1));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare(""));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare("あいうえお"));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare(true));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare(false));
            Console.WriteLine(switchSample.ExecPatternMatchingWithTypeAndComare((1, 2, 3)));
        }
    }
}
