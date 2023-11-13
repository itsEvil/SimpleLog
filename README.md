# SimpleLog

Simple drop in open source library for quick console logging.

### How to setup

1. Simply add SLog.cs into your project. 
2. Call SLog.Terminate() when closing your application to stop worker thread.
3. Done!

### Notes 

Easy and simple configuration.

To modify logger look in 
=> SLogConfig class for configuration 
=> SLogColors class for console colors 
=> SLog.Format() method to change the format used

Termination also happens when Fatal(string message, [bool terminate = true]) is called with terminate set to true.

### How does it work?

When the user calls any of the public methods 'Debug' 'Trace' etc,
it formats the message and adds it to the queue to be processed.

On startup, it creates a new worker thread which runs until termination. 
Each tick of this thread it tries to dequeue all 'ConsoleMessages' from '_messages' queue.
After its done with the queue it sleeps for 'SLogConfig.SleepTime' MS.


